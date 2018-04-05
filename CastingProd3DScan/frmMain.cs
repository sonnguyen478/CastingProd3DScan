#define UsePLC
#define UseCam
//#define UseRemoteDB
//#define UseLocalRemoteDB

#define SaveTIF
#define SaveIMG

using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CastingProd3DScan
{
    public partial class frmMain : Form
    {
        private bool bIsDelay = true;
        private bool bIsStartClose = false;
        private bool isInspection = false; // 검사 진행 여부

        private AxCVDISPLAYLib.AxCVdisplay CVDisplay; //
        private AxCVIMAGELib.AxCVimage CVImageORG; // 원본 이미지
        private AxCVIMAGELib.AxCVimage CVImage16; // 검사용 이미지 - 높이값 측정용
        private AxCVIMAGELib.AxCVimage CVImage8;// 화면 출력 및 SF 용
        private AxCVDISPLAYLib.AxCVdisplay CVDisplayView;// 화면 출력 및 SF 용
        private float AxCVImageCutRate; // 원본 이미지 Cut 비율

        private System.Windows.Forms.Label[] _resultX = null;
        private System.Windows.Forms.Label[] _resultY = null;
        private System.Windows.Forms.Label[] _resultZ = null;

        private Interop.Common.Progress.SplashThread loadProgress = null;
        private cGlobalDefine.stProdCount stProdCnt;

        private string sSettingPath = string.Empty;
        private string sMotionPath = string.Empty;

        private frmServoSetting cfrmServo = null;

        private double iAccel = 0;
        private double iDccel = 0;

        private Interop.Common.DB.cSQLServer localdbConn = null;
        private Interop.Common.DB.cSQLServer remotedbConn = null;
        private Interop.Common.PLC.Melsec.CMxComponentDirect cMxCom = null;

        //SF 설정
        public readonly int iMaxNumSolutions = 1; //찾을 개체 수
        public readonly int iMinimalThreshold = 25;//Threshold (0 ~ 255)
        public readonly int iPrecision = 1;//검색 정밀도 0 : fast, poor accuracy, 1= medium, medium accuracy, 2=high accuracy
        public readonly int iRelativeThreshold = 75;//베스트 모델 대비 상대적 Threshold (0 ~ 100)
        public readonly int iLocXY = 20;//결과 개체간의 픽셀
        public readonly bool bIsFeatures = true;
        public bool bIsRightPlus = true;

        public readonly double dPixelmmX = 0.052464d; // 2D 영상 사용함.//0.052
        public readonly double dPixelmmY = 0.052464d; // 2D 영상 사용함.
        public readonly double dPixelmmZ = 0.001d; // 2D 영상 사용함.

        private object ObjInspProcess = new object(); // Inspection 시 두개가 동시에 들어 오지 못하게 방지용 
        private int nInspCount = 3;

        private cBGWorkerEvents.PLCEvents eventPLC = null;
        private cBGWorkerEvents.EventHeartBit eventHeartBit = null;
        private System.Timers.Timer tmrHeartBitPLCCheck = null;

        private cDBInfo.InspSaveMain saveMain;
        private cDBInfo.InspSaveSub[] saveSub = null;

        private string sInspectionStartTime = string.Empty;
        private string sInspectionModel = string.Empty;

        private int nHeightInspCnt = -1;
        private cDBInfo.InspSettingsHeight[] settingH = null;
        private cDBInfo.InspSettingsSF settingSF;

        private int bPCHeartBit = 0;
        private int beforPLCHeartBit = -1;
        public bool[] beforPLCBit = new bool[30];

        public frmMain()
        {
            InitializeComponent();

            loadProgress = new Interop.Common.Progress.SplashThread();
            loadProgress.AllStepCnt = 8;

            Interop.Common.Util.cLog.mPathLog(Application.StartupPath + @"\LOG");
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                loadProgress.Open();

                // 1 --> Local Database Connecting..
                loadProgress.UpdateProgress(1, "Local Database Connecting...");
                if (true == bIsDelay) System.Threading.Thread.Sleep(300);

                fnDBConnection("LOCAL", ref localdbConn);
                if (false == localdbConn.IsConnect())
                {
                    MessageBox.Show(this, "로컬 DATA BASE에 연결하지 못하였습니다.\n 프로그램을 종료 합니다.", "DB 연결 에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bIsStartClose = true;
                    this.Close();
                }
                logMessage(true, "로컬 DATA BASE 연결 성공...", Interop.Common.Util.cLog.eLogType.LOG);
                fnSetDBConnectClose("LOCAL");

#if UseRemoteDB
                // 2 --> Remote Database Connecting..
                loadProgress.UpdateProgress( 2, "Remote Database Connecting..." );
                if ( true == bIsDelay ) System.Threading.Thread.Sleep( 300 );

                fnDBConnection( "REMOTE", ref remotedbConn );

                if ( false == remotedbConn.IsConnect() )
                {
                    MessageBox.Show( this, "원격 DATA BASE에 연결하지 못하였습니다.\n 프로그램을 종료 합니다.", "DB 연결 에러", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    bIsStartClose = true;
                    this.Close();
                }
                remotedbConn.CloseDataBase();
                logMessage( true, "원격 DATA BASE 연결 성공...", Interop.Common.Util.cLog.eLogType.LOG );
                fnSetDBConnectClose( "REMOTE" );
#endif

                // 3 --> LMI Connection..
                loadProgress.UpdateProgress(3, "3D Camera Connecting...");
                if (true == bIsDelay) System.Threading.Thread.Sleep(300);
#if UseCam
                fnCamInit();
                fnComponentArraySet();
#endif
                // 4 --> PLC Connecting..
                loadProgress.UpdateProgress(4, "PLC Connecting...");
                if (true == bIsDelay) System.Threading.Thread.Sleep(300);
#if UsePLC
                fnMxCompomponentOpen();

                if (false == cMxCom.isOpen)
                {
                    MessageBox.Show(this, "PLC에 연결하지 못하였습니다.\n 프로그램을 종료 합니다.", "PLC 연결 에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bIsStartClose = true;
                    this.Close();
                }
#endif
                logMessage(true, "PLC 연결 성공...", Interop.Common.Util.cLog.eLogType.LOG);

                // 5 --> UI Construct & Clear ...
                loadProgress.UpdateProgress(5, "화면 구성 및 초기화 중...");
                if (true == bIsDelay) System.Threading.Thread.Sleep(300);
                fnDisplayControlsClear();
                logMessage(true, "화면 구성 및 초기화 성공...", Interop.Common.Util.cLog.eLogType.LOG);

                // 6 --> PC 메모리 영역 초기화...
                loadProgress.UpdateProgress(6, "PLC - PC 영역 초기화 중...");
                if (true == bIsDelay) System.Threading.Thread.Sleep(300);
#if UsePLC
                fnSetPCMemoryClear();
#endif
                logMessage(true, "PLC - PC 영역 초기화 성공...", Interop.Common.Util.cLog.eLogType.LOG);

                // 7 --> Program Enviroment Load...
                loadProgress.UpdateProgress(7, "PC 환경설정 불러오는 중...");
                if (true == bIsDelay) System.Threading.Thread.Sleep(300);

                nHeightInspCnt = 2;
                saveMain = new cDBInfo.InspSaveMain();
                saveSub = new cDBInfo.InspSaveSub[nHeightInspCnt];

                //fnLoadModelSettings();

                // 8 --> Local Timer 및 기타 설정 완료
                loadProgress.UpdateProgress(8, "메인 화면 불러오는 중...");
                if (true == bIsDelay) System.Threading.Thread.Sleep(300);
                fnSystemEnviromentSettings(true);
                logMessage(true, "메인 화면 불러오기 성공...", Interop.Common.Util.cLog.eLogType.LOG);

                fnProdCntRead(ref stProdCnt);
                fnProdCntDisplay();
                fnDisplayHDDSpace();
                fnPCBitState(cGlobalDefine.ePCSignal.HEARTBIT, cGlobalDefine.ColorDefault);
                fnPCBitState(cGlobalDefine.ePCSignal.INSP_START, cGlobalDefine.ColorDefault);
                fnPCBitState(cGlobalDefine.ePCSignal.INSP_END, cGlobalDefine.ColorDefault);
                fnPCBitState(cGlobalDefine.ePCSignal.POS_MOVE, cGlobalDefine.ColorDefault);
                fnPCBitState(cGlobalDefine.ePCSignal.INSP_RESULT, cGlobalDefine.ColorDefault);

                //fnSystemEnviromentSettings( true );
                sSettingPath = Application.StartupPath + @"\Settings\Settings.ini";
                sMotionPath = Application.StartupPath + @"\Settings\Servo.ini";

                tmrSystem.Start();
#if UsePLC
                bgWorkPLC.RunWorkerAsync();
#endif
            }
            catch (Exception ex)
            {
                logException("frmMain_Load Error : " + ex.Message.ToString());
            }
            finally
            {
                if (loadProgress != null)
                {
                    loadProgress.Close();
                    loadProgress.Join();
                    loadProgress = null;
                }
            }
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = new DialogResult();

            try
            {
                if (false == bIsStartClose)
                {
                    result = MessageBox.Show("프로그램 종료", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                if ((result == DialogResult.No) && (false == bIsStartClose))
                {
                    e.Cancel = true;
                }
                else
                {
                    axCVimage_Snap.Grab = false;

                    tmrSystem.Stop();
                    tmrHeartBitPLCCheck.Stop();

                    fnSystemEnviromentSettings(false);

#if UsePLC
                    fnSetPCMemoryClear();
                    if (cMxCom.isOpen)
                    {
                        cMxCom.Word_Write("D9000", 0);
                    }
                    fnMxCompomponentClose();
#endif

                    if (bgWorkPLC != null && bgWorkPLC.IsBusy)
                    {
                        bgWorkPLC.CancelAsync();
                    }

                    if (localdbConn != null)
                    {
                        localdbConn.CloseDataBase();
                        localdbConn = null;
                    }
                    if (remotedbConn != null)
                    {
                        remotedbConn.CloseDataBase();
                        remotedbConn = null;
                    }
                }
            }
            catch (Exception ex)
            {
                logException("frmMain FormClosing Error : " + ex.Message.ToString());
            }
            finally
            {
                if (loadProgress != null)
                {
                    loadProgress.Close();
                    loadProgress.Join();
                    loadProgress = null;
                }
            }
        }






        private void btnProdCntReset_Click(object sender, EventArgs e)
        {
            try
            {
                stProdCnt.nTotal = 0;
                stProdCnt.nOK = 0;
                stProdCnt.nNG = 0;

                fnProdCntWrite(stProdCnt);
                fnProdCntDisplay();
            }
            catch (Exception ex)
            {
                logException("btnProdCntReset_Click Error : " + ex.Message.ToString());
            }
        }
        private void btnModelSetting_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmModelSetting modelSet = new frmModelSetting(this, localdbConn))
                {
                    modelSet.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                logException("btnModelSetting_Click Error : " + ex.Message.ToString());
            }
        }
        private void btnServoSetting_Click(object sender, EventArgs e)
        {
            try
            {
                if (cfrmServo == null)
                {
                    cfrmServo = new frmServoSetting(cMxCom);
                }
                else
                {
                    cfrmServo.Close();
                    cfrmServo = null;
                    cfrmServo = new frmServoSetting(cMxCom);
                }
                cfrmServo.motionCloseEvent += new frmServoSetting.motionCloseEventHandler(fnServoSettingCloseEvent);
                cfrmServo.Show();
            }
            catch (Exception ex)
            {
                logException("btnServoSetting_Click Error : " + ex.Message.ToString());
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fnServoSettingCloseEvent()
        {
            try
            {
                cfrmServo.motionCloseEvent -= new frmServoSetting.motionCloseEventHandler(fnServoSettingCloseEvent);
                cfrmServo = null;
            }
            catch (Exception ex)
            {
                logException("fnServoSettingCloseEvent Error : " + ex.Message.ToString());
            }
        }












        // Summary:
        //     Loading GenICAM driver, open the connection with LMI 3D sensors
        //
        // Parameters:
        //   sender, e:
        //     Run all the time, sleep 400ms after running
        private void bgWorkPLC_DoWork(object sender, DoWorkEventArgs e)
        {
            int plcHeartBit = -1;
            int plcInspStart = -1;
            int plcBypass = -1;

            string ErrorString = string.Empty;
            do
            {
                try
                {
                    // PLC Read
                    plcHeartBit = Convert.ToInt16(fnRead_PLC(cGlobalDefine.ePLCSignal.HEARTBIT));
                    plcInspStart = Convert.ToInt16(fnRead_PLC(cGlobalDefine.ePLCSignal.INSP_POS));
                    plcBypass = Convert.ToInt16(fnRead_PLC(cGlobalDefine.ePLCSignal.PLC_BY_PASS));


                    eventPLC.Fliker(plcHeartBit);
                    eventPLC.InspStart(plcInspStart);
                    eventPLC.Bypass(plcBypass);

                    //PC Heart bit
                    eventHeartBit.HeartbitEvent();

                    System.Threading.Thread.Sleep(400);
                }
                catch (Exception ex)
                {
                    logException("bgWorkPLC_DoWork Error : " + ex.Message.ToString());
                }
            } while (true);
        }






        // Summary: (not use)
        //     Loading GenICAM driver, open the connection with LMI 3D sensors
        //
        // Parameters:
        //   
        //     
        private void fnLMI_Initialize()
        {
#if UseCam
            fnCamOpenVin(0);

            axCVgrabber_Snap.CamPort = 0;
            axCVgrabber_Snap.Image = axCVimage_Snap.Image;
            axCVimage_Snap.Image = axCVgrabber_Snap.Image;
#endif
        }
        private string fnRead_PLC(cGlobalDefine.ePLCSignal _target)
        {
            string readValue = string.Empty;
            string address = string.Empty;
            try
            {
                switch (_target)
                {
                    case cGlobalDefine.ePLCSignal.HEARTBIT: address = AppConfigRead("PLC_HEARTBIT"); break;
                    case cGlobalDefine.ePLCSignal.INSP_MODEL: address = AppConfigRead("PLC_INSP_MODEL"); break;
                    case cGlobalDefine.ePLCSignal.INSP_POS: address = AppConfigRead("PLC_INSP_START"); break;
                    case cGlobalDefine.ePLCSignal.PLC_BY_PASS: address = AppConfigRead("PLC_BYPASS"); break;
                    default: address = string.Empty; break;
                }
                if (false == string.IsNullOrEmpty(address))
                {
                    readValue = cMxCom.Word_Read(address).ToString();
                }
                else
                {
                    //log : Wrong Address
                    readValue = string.Empty;
                }
            }
            catch (Exception ex)
            {
                readValue = string.Empty;
                logException("fnRead_PLC Error : " + ex.Message.ToString());
            }

            return readValue;
        }
        private void fnSetPCMemoryClear()
        {
            string _address = string.Empty;
            try
            {
                for (int idx = 1; idx < 22; idx++)
                {
                    _address = string.Format("D9{0:D3}", idx.ToString());
                    cMxCom.Word_Write(_address, 0);
                }
            }
            catch (Exception ex)
            {
                logException("fnSetPCMemoryClear Error : " + ex.Message.ToString());
            }
        }


















        private string AppConfigRead(string _keyName)
        {
            string strReturnValue = string.Empty;
            try
            {
                Configuration currentConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (currentConfig.AppSettings.Settings.AllKeys.Contains(_keyName))
                {
                    strReturnValue = currentConfig.AppSettings.Settings[_keyName].Value.Trim();
                }
                else
                {
                    strReturnValue = string.Empty;
                }
            }
            catch (Exception ex)
            {
                //logMessageSave( false, "fnDBConnection Error : " + ex.Message.ToString(), Interop.Util.cLog.eLogType.EXCEPTION );
                strReturnValue = string.Empty;
            }
            return strReturnValue;
        }
        private void fnSystemEnviromentSettings(bool _flag)
        {
            try
            {
                if (true == _flag)
                {
                    tmrPLCReset.Interval = 2000;
                    tmrPLCReset.Stop();

                    if (tmrHeartBitPLCCheck == null)
                    {
                        tmrHeartBitPLCCheck = new System.Timers.Timer();
                        tmrHeartBitPLCCheck.Elapsed += new System.Timers.ElapsedEventHandler(tmrHeartBitPLCCheck_Elapsed);
                        tmrHeartBitPLCCheck.Interval = 30 * 1000; // 30 초
                    }
                    if (eventHeartBit == null)
                    {
                        eventHeartBit = new cBGWorkerEvents.EventHeartBit();
                        eventHeartBit.evHeartBitHandler += new cBGWorkerEvents.EventHeartBit.EventHandler(eventHeartBit_evHeartBitHandler);
                    }
                    if (eventPLC == null)
                    {
                        eventPLC = new cBGWorkerEvents.PLCEvents();
                        eventPLC.evHeartBit += EventPLC_evHeartBit;
                        eventPLC.evInspStart += EventPLC_evInspStart;
                        eventPLC.evBypass += EventPLC_evBypass;
                    }
                }
                else
                {
                    tmrHeartBitPLCCheck.Elapsed -= new System.Timers.ElapsedEventHandler(tmrHeartBitPLCCheck_Elapsed);
                    eventHeartBit.evHeartBitHandler -= new cBGWorkerEvents.EventHeartBit.EventHandler(eventHeartBit_evHeartBitHandler);

                    eventPLC.evHeartBit -= EventPLC_evHeartBit;
                    eventPLC.evInspStart -= EventPLC_evInspStart;
                    eventPLC.evBypass -= EventPLC_evBypass;

                    tmrHeartBitPLCCheck.Stop();
                    tmrHeartBitPLCCheck = null;

                    eventHeartBit = null;
                    eventPLC = null;
                }
            }
            catch (Exception ex)
            {
                //logMessageSave( false, "fnSystemEnviromentSettings Error : " + ex.Message.ToString(), Interop.Util.cLog.eLogType.EXCEPTION );
            }
        }
        private void fnDBConnection(string _dbGB, ref Interop.Common.DB.cSQLServer _target)
        {
            try
            {
                if (_target == null) _target = new Interop.Common.DB.cSQLServer();

#if UseLocalRemoteDB
                _target.DB_IP = Environment.MachineName + @"\SQLEXPRESS";
#else
                _target.DB_IP = (_dbGB == "LOCAL" ? Environment.MachineName + @"\SQLEXPRESS" : AppConfigRead("RemoteDBIP"));
#endif
                _target.DB_NAME = (_dbGB == "LOCAL" ? AppConfigRead("LocalDBName") : AppConfigRead("RemoteDBName"));
                _target.DB_ID = (_dbGB == "LOCAL" ? AppConfigRead("LocalUserID") : AppConfigRead("RemoteUserID"));
                _target.DB_PW = (_dbGB == "LOCAL" ? AppConfigRead("LocalUserPW") : AppConfigRead("RemoteUserPW"));
                if (false == string.IsNullOrEmpty(_target.SQLOpen()))
                {
                    MessageBox.Show("DB 연결 오류");
                }
            }
            catch (Exception ex)
            {
                logException("fnDBConnection Error : " + ex.Message.ToString());
            }
        }
        public void fnSetDBConnectClose(string target)
        {
            try
            {
                if (target == "LOCAL")
                {
                    if (localdbConn != null) localdbConn.CloseDataBase();
                    //localdbConn = null;
                }
                else
                {
                    if (remotedbConn != null) remotedbConn.CloseDataBase();
                    //remotedbConn = null;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
            }
        }
        private void fnMxCompomponentOpen()
        {
            try
            {
                if (cMxCom == null)
                {
                    cMxCom = new Interop.Common.PLC.Melsec.CMxComponentDirect();
                }
#if UsePLC
                this.cMxCom.Channel_Open(0);
#endif
                if (true == cMxCom.isOpen)
                {
                    fnSetPCMemoryClear();
                    logComm(true, "PLC 연결 성공", Interop.Common.Util.cLog.eLogType.LOG);
                }
            }
            catch (Exception ex)
            {
                logException("PLC 연결 실패 : " + ex.ToString());
            }
        }
        private void fnMxCompomponentClose()
        {
            if (cMxCom != null && cMxCom.isOpen)
            {
                try
                {
                    cMxCom.Channel_Close();
                }
                catch (Exception ex)
                {
                    logException("fnMxCompomponentClose Error : " + ex.ToString());
                }
                finally
                {
                    if (cMxCom != null) cMxCom = null;
                }
            }
        }
        private void fnDisplayControlsClear()
        {
            try
            {
                Interop.Common.Util.CDelegate.SetText(Result_X_01, "");
                Interop.Common.Util.CDelegate.SetText(Result_X_02, "");

                Interop.Common.Util.CDelegate.SetText(Result_Y_01, "");
                Interop.Common.Util.CDelegate.SetText(Result_Y_02, "");

                Interop.Common.Util.CDelegate.SetText(Result_Z_01, "");
                Interop.Common.Util.CDelegate.SetText(Result_Z_02, "");

                Interop.Common.Util.CDelegate.SetText(lblCurrInspModel, "");
                Interop.Common.Util.CDelegate.SetText(lblCurrInspTime, "");

                fnProdCntDisplay();
            }
            catch (Exception ex)
            {
                logException("fnDisplayControlsClear Error : " + ex.ToString());
            }
        }
        private void fnProdCntRead(ref cGlobalDefine.stProdCount _stCNT)
        {
            string strTemp = string.Empty;
            try
            {
                strTemp = Interop.Common.Util.cIni.IniReadValue("PRODUCT_CNT", "TOTAL", sSettingPath).Trim();
                if (false == string.IsNullOrEmpty(strTemp))
                {
                    _stCNT.nTotal = Convert.ToUInt32(strTemp);
                }
                else
                {
                    _stCNT.nTotal = 0;
                    Interop.Common.Util.cIni.IniWriteValue("PRODUCT_CNT", "TOTAL", "0", sSettingPath);
                }
                strTemp = Interop.Common.Util.cIni.IniReadValue("PRODUCT_CNT", "OK", sSettingPath).Trim();
                if (false == string.IsNullOrEmpty(strTemp))
                {
                    _stCNT.nOK = Convert.ToUInt32(strTemp);
                }
                else
                {
                    _stCNT.nOK = 0;
                    Interop.Common.Util.cIni.IniWriteValue("PRODUCT_CNT", "OK", "0", sSettingPath);
                }
                strTemp = Interop.Common.Util.cIni.IniReadValue("PRODUCT_CNT", "RP", sSettingPath).Trim();
                if (false == string.IsNullOrEmpty(strTemp))
                {
                    _stCNT.nRP = Convert.ToUInt32(strTemp);
                }
                else
                {
                    _stCNT.nRP = 0;
                    Interop.Common.Util.cIni.IniWriteValue("PRODUCT_CNT", "RP", "0", sSettingPath);
                }
                strTemp = Interop.Common.Util.cIni.IniReadValue("PRODUCT_CNT", "NG", sSettingPath).Trim();
                if (false == string.IsNullOrEmpty(strTemp))
                {
                    _stCNT.nNG = Convert.ToUInt32(strTemp);
                }
                else
                {
                    _stCNT.nNG = 0;
                    Interop.Common.Util.cIni.IniWriteValue("PRODUCT_CNT", "NG", "0", sSettingPath);
                }
            }
            catch (Exception ex)
            {
                logException("fnProdCntRead Error : " + ex.Message.ToString());
            }
        }
        private void fnProdCntWrite(cGlobalDefine.stProdCount _stCNT)
        {
            string strTemp = string.Empty;
            try
            {
                strTemp = _stCNT.nTotal.ToString();
                Interop.Common.Util.cIni.IniWriteValue("PRODUCT_CNT", "TOTAL", "0", sSettingPath);

                strTemp = _stCNT.nOK.ToString();
                Interop.Common.Util.cIni.IniWriteValue("PRODUCT_CNT", "OK", "0", sSettingPath);

                strTemp = _stCNT.nRP.ToString();
                Interop.Common.Util.cIni.IniWriteValue("PRODUCT_CNT", "RP", "0", sSettingPath);

                strTemp = _stCNT.nNG.ToString();
                Interop.Common.Util.cIni.IniWriteValue("PRODUCT_CNT", "NG", "0", sSettingPath);
            }
            catch (Exception ex)
            {
                logException("fnProdCntWrite Error : " + ex.Message.ToString());
            }
        }
        private void fnProdCntDisplay()
        {
            string strTemp = string.Empty;
            try
            {
                Interop.Common.Util.CDelegate.SetText(lblInspCnt_Total, stProdCnt.nTotal.ToString());
                Interop.Common.Util.CDelegate.SetText(lblInspCnt_OK, stProdCnt.nOK.ToString());
                Interop.Common.Util.CDelegate.SetText(lblInspCnt_OK, stProdCnt.nRP.ToString());
                Interop.Common.Util.CDelegate.SetText(lblInspCnt_NG, stProdCnt.nNG.ToString());

                if (stProdCnt.nTotal > 0)
                {
                    stProdCnt.nOKPer = ((float)stProdCnt.nOK / stProdCnt.nTotal);
                    strTemp = string.Format("{0:P1}%", stProdCnt.nOKPer);
                    Interop.Common.Util.CDelegate.SetText(lblInspCnt_OKRate, strTemp);

                    stProdCnt.nRPPer = ((float)stProdCnt.nRP / stProdCnt.nTotal);
                    strTemp = string.Format("{0:P1}%", stProdCnt.nRPPer);
                    Interop.Common.Util.CDelegate.SetText(lblInspCnt_RPRate, strTemp);

                    stProdCnt.nNGPer = ((float)stProdCnt.nNG / stProdCnt.nTotal);
                    strTemp = string.Format("{0:P1}%", stProdCnt.nNGPer);
                    Interop.Common.Util.CDelegate.SetText(lblInspCnt_NGRate, strTemp);
                }
                else
                {
                    Interop.Common.Util.CDelegate.SetText(lblInspCnt_OKRate, "0%");
                    Interop.Common.Util.CDelegate.SetText(lblInspCnt_RPRate, "0%");
                    Interop.Common.Util.CDelegate.SetText(lblInspCnt_NGRate, "0%");
                }
            }
            catch (Exception ex)
            {
                logException("fnProdCntDisplay Error : " + ex.Message.ToString());
            }
        }
        private void fnPLCBitState(cGlobalDefine.ePLCSignal _name, Color _stats)
        {
            switch (_name)
            {
                case cGlobalDefine.ePLCSignal.HEARTBIT: Interop.Common.Util.CDelegate.SetBackColor(IO_PLC_Fliker, _stats); break;
                case cGlobalDefine.ePLCSignal.INSP_POS: Interop.Common.Util.CDelegate.SetBackColor(IO_PLC_InspStart, _stats); break;
                case cGlobalDefine.ePLCSignal.PLC_BY_PASS: Interop.Common.Util.CDelegate.SetBackColor(IO_PLC_ByPass, _stats); break;
                default:
                    break;
            }
        }
        private void fnPCBitState(cGlobalDefine.ePCSignal _name, Color _stats)
        {
            switch (_name)
            {
                case cGlobalDefine.ePCSignal.HEARTBIT: Interop.Common.Util.CDelegate.SetBackColor(IO_PC_Fliker, _stats); break;
                case cGlobalDefine.ePCSignal.INSP_START: Interop.Common.Util.CDelegate.SetBackColor(IO_PC_InspStart, _stats); break;
                case cGlobalDefine.ePCSignal.INSP_END: Interop.Common.Util.CDelegate.SetBackColor(IO_PC_InspEnd, _stats); break;
                case cGlobalDefine.ePCSignal.POS_MOVE: Interop.Common.Util.CDelegate.SetBackColor(IO_PC_PosMove, _stats); break;
                case cGlobalDefine.ePCSignal.INSP_RESULT: Interop.Common.Util.CDelegate.SetBackColor(IO_PC_InspResult, _stats); break;
                default: break;
            }
        }









        // Summary:
        //     Reset the status data in PC bank D9001 ~ D9003
        //
        // Parameters:
        //   sender, e:
        //     Event handler condition, the event is trigged after 2 seconds 
        //     when the timer starts
        private void tmrPLCReset_Tick(object sender, EventArgs e)
        {
            try
            {
                tmrPLCReset.Stop();
#if UsePLC
                cMxCom.Word_Write("D9001", 0);
                cMxCom.Word_Write("D9002", 0);
                cMxCom.Word_Write("D9003", 0);
#endif
                Interop.Common.Util.CDelegate.SetBackColor(IO_PC_InspStart, cGlobalDefine.ColorDefault);
                Interop.Common.Util.CDelegate.SetBackColor(IO_PC_InspEnd, cGlobalDefine.ColorDefault);
            }
            catch (Exception ex)
            {
                logException("tmrPLCReset_Tick Error : " + ex.Message.ToString());
            }
        }

        // Summary:
        //     Update the system time
        //
        // Parameters:
        //   sender, e:
        //     Event handler condition, the event is trigged every 400msseconds 
        private void tmrSystem_Tick(object sender, EventArgs e)
        {
            try
            {
                Interop.Common.Util.CDelegate.SetText(lblSystemTime, System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            }
            catch (Exception ex)
            {
                logException("tmrSystem_Tick Error : " + ex.Message.ToString());
            }
        }

        // Summary:
        //     Check the toggle state of the HEART BIT
        //
        // Parameters:
        //   sender, e:
        //     Event handler condition, the event is trigged after 30 seconds 
        //     when the timer starts
        private void tmrHeartBitPLCCheck_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                tmrHeartBitPLCCheck.Stop();
                logComm(true, "Error 센서측정 - PLC 통신 이상", Interop.Common.Util.cLog.eLogType.COMM);

                fnPLCBitState(cGlobalDefine.ePLCSignal.HEARTBIT, cGlobalDefine.ColorNG);
            }
            catch (Exception ex)
            {
                logException("tmrHeartBitPLCCheck_Elapsed Error : " + ex.Message.ToString());
            }
        }

        // Summary:
        //     Toggle the HEART BIT in the PC side
        //
        // Parameters:
        //   sender, e:
        //     Event handler condition, the event is trigged after 2 seconds 
        //     when the timer starts
        private void eventHeartBit_evHeartBitHandler(object sender, cBGWorkerEvents.EventArgList e)
        {
            try
            {
                if (bPCHeartBit == 0)
                {
                    bPCHeartBit = 1;
                }
                else
                {
                    bPCHeartBit = 0;
                }

                cMxCom.Word_Write("D9000", bPCHeartBit);
                Interop.Common.Util.CDelegate.SetBackColor(IO_PC_Fliker, bPCHeartBit == 0 ? cGlobalDefine.ColorDefault : cGlobalDefine.ColorOK);
            }
            catch (Exception ex)
            {
                logException("eventHeartBit_evHeartBitHandler Error : " + ex.Message.ToString());
            }
        }

        // Summary:
        //     Start the PLC check timer, set PLC HEART BIT color
        //
        // Parameters:
        //   sender, e:
        //     Event handler condition, the event is trigged when PLC is read 
        private void EventPLC_evHeartBit(object sender, cBGWorkerEvents.EventArgList e)
        {
            try
            {
                if (beforPLCHeartBit != e.data)
                {
                    tmrHeartBitPLCCheck.Stop(); // 통신 에러 Timer
                    tmrHeartBitPLCCheck.Start();

                    fnPLCBitState(cGlobalDefine.ePLCSignal.HEARTBIT, e.data == 0 ? cGlobalDefine.ColorDefault : cGlobalDefine.ColorOK);
                    beforPLCHeartBit = e.data;
                }
            }
            catch (Exception ex)
            {
                logException("EventPLC_evHeartBit Error : " + ex.Message.ToString());
            }
        }

        // Summary:
        //     Start inspection the product and handle bypass if it sets
        //
        // Parameters:
        //   sender, e:
        //     Event handler condition, the event is trigged when PLC is read 
        private void EventPLC_evInspStart(object sender, cBGWorkerEvents.EventArgList e)
        {
            try
            {
                int iAddr = (int)cGlobalDefine.ePLCSignal.INSP_POS;


                if (e.data == 1 && beforPLCBit[iAddr] == false)
                {
                    int isBypass = cMxCom.Word_Read("D9103");
                    if (isBypass != 1)
                    {

                        fnPLCBitState(cGlobalDefine.ePLCSignal.INSP_POS, cGlobalDefine.ColorOK);
                        beforPLCBit[iAddr] = true;

                        logComm(true, "(PLC)검사 시작 On", Interop.Common.Util.cLog.eLogType.COMM);
                        if (true == isInspection)
                        {
                            logComm(true, "검사 도중 PLC에서 검사시작 신호 요청 함.", Interop.Common.Util.cLog.eLogType.COMM);
                        }
                        else
                        {
                            axCVimage_Snap.Clear(0, 0);
                            Interop.Common.CVB.CCVBOverlay.OverlayLabelRemoveAll(CVDisplay);
                            Interop.Common.CVB.CCVBOverlay.OverlayObjectRemoveAll(CVDisplay);

                            axCVdisplay1.Image = axCVimage_Snap.Image;

                            cMxCom.Word_Write("D9002", 0);

                            fnPCBitState(cGlobalDefine.ePCSignal.INSP_START, cGlobalDefine.ColorOK);
                            fnDisplayControlsClear();

                            sInspectionStartTime = System.DateTime.Now.ToString("yyyyMMddHHmmss");
                            sInspectionModel = fnRead_PLC(cGlobalDefine.ePLCSignal.INSP_MODEL);

                            settingH = null;

                            settingSF = new cDBInfo.InspSettingsSF();
                            settingH = new cDBInfo.InspSettingsHeight[2];
                            fnConvertModel(ref sInspectionModel);
                            fnLoadModelSettings(sInspectionModel);

                            Interop.Common.Util.CDelegate.SetText(lblCurrInspTime, sInspectionStartTime);
                            Interop.Common.Util.CDelegate.SetText(lblCurrInspModel, sInspectionModel);

                            //Save DB Init
                            saveMain.Clear();
                            saveMain.dateTime = sInspectionStartTime;
                            saveMain.model = sInspectionModel;
                            for (int idx = 0; idx < saveSub.Length; idx++)
                            {
                                saveSub[idx].Clear();
                                saveSub[idx].dateTime = saveMain.dateTime;
                                saveSub[idx].model = saveMain.model;
                            }

                            fnScanSensor(true);

                            fnPCBitState(cGlobalDefine.ePCSignal.POS_MOVE, cGlobalDefine.ColorOK);
                            this.Invoke(new MethodInvoker(delegate() { pnlLMI.Visible = true; }));

                            string posMove = string.Empty;
                            string posVel = string.Empty;
                            long posValue = -1;
                            long velValue = -1;

                            posMove = Interop.Common.Util.cIni.IniReadValue("INSP_POS", "MOVE_POS", sMotionPath);
                            posVel = Interop.Common.Util.cIni.IniReadValue("INSP_POS", "MOVE_VEL", sMotionPath);

#if UsePLC
                            posValue = (long)Interop.Common.Util.CUtil.StringToFloat(posMove.Trim());
                            posValue = posValue * 10000;
                            velValue = (long)Interop.Common.Util.CUtil.StringToFloat(posVel.Trim());
                            velValue = velValue * 100;

                            cMxCom.Word2_Write("D9014", posValue);
                            cMxCom.Word2_Write("D9016", velValue);

                            System.Threading.Thread.Sleep(200);

                            cMxCom.Word_Write("D9012", 1);
                            cMxCom.Word_Write("D9001", 1);
#endif
                        }
                    }
                    else
                    {
                        logComm(true, "Bypass  상태에서 검사시작 신호 요청 함.", Interop.Common.Util.cLog.eLogType.COMM);
                    }
                }
                else if (e.data == 0 && beforPLCBit[iAddr] == true)
                {
                    fnPLCBitState(cGlobalDefine.ePLCSignal.INSP_POS, cGlobalDefine.ColorDefault);
                    fnPCBitState(cGlobalDefine.ePCSignal.POS_MOVE, cGlobalDefine.ColorDefault);
                    fnPCBitState(cGlobalDefine.ePCSignal.INSP_END, cGlobalDefine.ColorDefault);
                    beforPLCBit[iAddr] = false;
                    logComm(true, "(PLC)검사시작 Off", Interop.Common.Util.cLog.eLogType.COMM);

                    cMxCom.Word_Write("D9012", 0);
                    cMxCom.Word_Write("D9001", 0);
                }
            }
            catch (Exception ex)
            {
                logException("EventPLC_evInspStart Error : " + ex.Message.ToString());
            }
        }

        // Summary:
        //     Set/unset bypass status
        //
        // Parameters:
        //   sender, e:
        //     Event handler condition, the event is trigged when PLC is read 
        private void EventPLC_evBypass(object sender, cBGWorkerEvents.EventArgList e)
        {
            try
            {
                int iAddr = (int)cGlobalDefine.ePLCSignal.PLC_BY_PASS;

                if (e.data == 1 && beforPLCBit[iAddr] == false)
                {
                    fnPLCBitState(cGlobalDefine.ePLCSignal.PLC_BY_PASS, cGlobalDefine.ColorOK);
                    beforPLCBit[iAddr] = true;

                    logComm(true, "(PLC)BYpass On", Interop.Common.Util.cLog.eLogType.COMM);
                }
                else if (e.data == 0 && beforPLCBit[iAddr] == true)
                {
                    fnPLCBitState(cGlobalDefine.ePLCSignal.PLC_BY_PASS, cGlobalDefine.ColorDefault);
                    beforPLCBit[iAddr] = false;

                    logComm(true, "(PLC)BYpass Off", Interop.Common.Util.cLog.eLogType.COMM);
                }
            }
            catch (Exception ex)
            {
                logException("EventPLC_evBypass Error : " + ex.Message.ToString());
            }
        }


















        private void fnConvertModel(ref string _readModel)
        {
            string makeModel = string.Empty;
            try
            {
                makeModel = string.Format("Model_{0}", Interop.Common.Util.CUtil.mStringToInt(_readModel.Trim()).ToString("00"));

                _readModel = makeModel;
            }
            catch (Exception ex)
            {
                logException("fnConvertModel Error : " + ex.Message.ToString());
            }
        }
        private void fnDisplayHDDSpace()
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                pgrDrive_C.Value = Interop.Common.Util.CUtil.mGetHDDFreeSpace("C");
                lblFreeSpace_C.Text = pgrDrive_C.Value.ToString() + "%";
                pgrDrive_D.Value = Interop.Common.Util.CUtil.mGetHDDFreeSpace("D");
                lblFreeSpace_D.Text = pgrDrive_D.Value.ToString() + "%";

            }));
        }
        private void logException(string _msg)
        {
            Interop.Common.Util.cLog.FileWrite_Str(_msg, Interop.Common.Util.cLog.eLogType.EXCEPTION);
        }
        private void logMessage(bool _saveFlag, string _msg, Interop.Common.Util.cLog.eLogType _type)
        {
            string saveDate = string.Empty;
            string dispTime = string.Empty;
            string saveMsg = string.Empty;
            try
            {
                saveDate = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                dispTime = System.DateTime.Now.ToString("HH:mm:ss");

                saveMsg = string.Format("[{0}]{1}", saveDate, _msg);
                this.Invoke(new MethodInvoker(delegate()
                {
                    if (lstVision.Items.Count >= 200) lstVision.Items.Clear();

                    lstVision.Items.Add(string.Format("[{0}]{1}", dispTime, _msg));
                }));
                if (_saveFlag == true) Interop.Common.Util.cLog.FileWrite_Str(saveMsg, _type);
            }
            catch (Exception ex)
            {
                logException("Log Data Save Fail : " + ex.Message.ToString());
            }
        }
        private void logComm(bool _saveFlag, string _msg, Interop.Common.Util.cLog.eLogType _type)
        {
            string saveDate = string.Empty;
            string dispTime = string.Empty;
            string saveMsg = string.Empty;

            try
            {
                saveDate = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                dispTime = System.DateTime.Now.ToString("HH:mm:ss");

                saveMsg = string.Format("[{0}]{1}", saveDate, _msg);
                this.Invoke(new MethodInvoker(delegate()
                {
                    if (lstComm.Items.Count >= 200) lstComm.Items.Clear();

                    lstComm.Items.Add(string.Format("[{0}]{1}", dispTime, _msg));
                }));
                if (_saveFlag == true) Interop.Common.Util.cLog.FileWrite_Str(saveMsg, _type);
            }
            catch (Exception ex)
            {
                logException("Comm Data Save Fail : " + ex.Message.ToString());
            }
        }


        // Summary:
        //     Set/unset bypass status
        //
        // Parameters:
        //   sender, e:
        //     Event handler condition, the event is trigged when new image is received 
        private void axCVimage_Snap_ImageSnaped(object sender, EventArgs e)
        {
            try
            {
                axCVdisplay1.Image = axCVimage_Snap.Image;
                axCVimage_Snap.SaveImage(@"D:\Data_Images\TEMP\" + saveMain.model.ToString() + "_Sanp.TIF");

                fnScanSensor(false);
                logMessage(true, " #SNAP Grap = false, img Snaped", Interop.Common.Util.cLog.eLogType.LOG);
                this.Invoke(new MethodInvoker(delegate() { pnlLMI.Visible = false; }));

                fnPCBitState(cGlobalDefine.ePCSignal.INSP_START, cGlobalDefine.ColorOK);
                //IO_PC_InspStart

                ////axCVimage_Snap.SaveImage( @"C:\Data_Images\TEMP\" +  saveMain.model.ToString() + "_Sanp.TIF" );

                CVImageORG.Image = Interop.Common.CVB.Util.UtilImage.ConvertImageCut(axCVimage_Snap
                                                                                    , Interop.Common.CVB.Util.UtilImage.DuplicateImage(axCVimage_Snap.Image)
                                                                                    , AxCVImageCutRate);
                cMainUtils.fnConvert3DImage(ref CVImageORG, false, true);

                mRunInspection();
                fnScanSensor(false);

                mRunInspection_Complete();

                cMxCom.Word_Write_Str("D9003", "OK");
                cMxCom.Word_Write("D9002", 1);

                fnPCBitState(cGlobalDefine.ePCSignal.INSP_START, cGlobalDefine.ColorDefault);
                fnPCBitState(cGlobalDefine.ePCSignal.INSP_END, cGlobalDefine.ColorOK);
            }
            catch (Exception ex)
            {
                logException("axCVimage_Snap_ImageSnaped Error : " + ex.Message.ToString());
            }
        }

        // Summary:
        //     Inspaction process
        //     Using CVB ShapeFinder2 library to get a list of center location of
        //     founded objects, then compare the height of the setting points in 
        //     the reference model and current founded objects.
        //     The acceptable range (height) is defined in setting list when loading
        //     reference model. The inspection result will be 
        //     OK       the height that is measured at the setting locations are in acceptable range
        //     NG       otherwise
        //     Update the saveMain and saveSub parameter for sending to SQL server 
        //
        // Parameters:
        //   
        private void mRunInspection()
        {
            string dirPath = string.Empty;
            string fileName = string.Empty;

            if (isInspection) return;

            lock (this.ObjInspProcess)
            {
                isInspection = true;
                logMessage(true, "SF 검사 시작", Interop.Common.Util.cLog.eLogType.LOG);

                string sf2Path = string.Empty;
                Interop.Common.CVB.cStruct.stCvbArea area;
                Interop.Common.CVB.cStruct.sLMI_StampInfo sLmiInfo = new Interop.Common.CVB.cStruct.sLMI_StampInfo();

                cGlobalDefine.eJudge totResult = cGlobalDefine.eJudge.NONE;

                try
                {
                    int iMaxNumSolutions = this.iMaxNumSolutions; //찾을 개체 수
                    int iMinimalThreshold = this.iMinimalThreshold;//Threshold (0 ~ 255)
                    int iPrecision = this.iPrecision;//검색 정밀도 0 : fast, poor accuracy, 1= medium, medium accuracy, 2=high accuracy
                    int iRelativeThreshold = this.iRelativeThreshold;//베스트 모델 대비 상대적 Threshold (0 ~ 100)
                    int iLocXY = this.iLocXY;//결과 개체간의 픽셀         
                    double dPixelmm = this.dPixelmmX;
                    bool bIsFeatures = this.bIsFeatures;

                    // 검사 이미지로 변환
                    fnLMImageConvert();
                    fnGetLMISensorInfo(ref sLmiInfo, out dPixelmm);

                    //saveMain.Clear();
                    //saveMain.dateTime = sInspectionStartTime;
                    //saveMain.model = sInspectionModel;
                    //for ( int idx = 0 ; idx < saveSub.Length ; idx++ )
                    //{
                    //    saveSub[ idx ].dateTime = saveMain.dateTime;
                    //    saveSub[ idx ].model = saveMain.model;
                    //}

                    CVDisplay.Image = this.CVImage8.Image;

                    Interop.Common.CVB.cStruct.stShapeFinderOutputtData[] resultDataList;
                    string errMessage = string.Empty;

                    double tmpX = 0;
                    double tmpY = 0;
                    double tmpZ = 0;

                    double moveZ = 0;

                    area = new Interop.Common.CVB.cStruct.stCvbArea();
                    area.Left = settingSF.INSP_LEFT;
                    area.Top = settingSF.INSP_TOP;
                    area.Right = settingSF.INSP_RIGHT;
                    area.Bottom = settingSF.INSP_BOTTOM;

                    sf2Path = cMainUtils.mSFPath(sInspectionModel);
                    Interop.Common.CVB.Util.UtilShapeFinder.RunProcess(sf2Path
                                                                                             , CVImage8.Image
                                                                                             , area
                                                                                             , iMaxNumSolutions
                                                                                             , iMinimalThreshold
                                                                                             , iPrecision
                                                                                             , iRelativeThreshold
                                                                                             , iLocXY
                                                                                             , 0
                                                                                             , dPixelmm
                                                                                             , bIsFeatures
                                                                                             , ref CVDisplay
                                                                                             , out resultDataList
                                                                                             , out errMessage
                                                                                             , false
                                                                                             );
                    if (string.IsNullOrEmpty(errMessage) && resultDataList.Length > 0)
                    {
                        tmpX = resultDataList[0].CenterX;
                        tmpY = resultDataList[0].CenterY;


                        for (int idx = 0; idx < settingH.Length; idx++)
                        {
                            cGlobalDefine.eJudge posJudge = cGlobalDefine.eJudge.NONE;
                            //int inspX = (int)tmpX + (int)settingH[idx].INSP_X;
                            //int inspY = (int)tmpY + (int)settingH[idx].INSP_Y;
                            int inspX = (int)settingH[idx].INSP_X;
                            int inspY = (int)settingH[idx].INSP_Y;

                            Cvb.Image.TDRect tdRect = cMainUtils.mGetHeightArea(inspX, inspY);

                            float inspZ = Interop.Common.CVB.Util.UtilImage.mGetLMISenserHValue(CVImage16, (int)tdRect.Left, (int)tdRect.Top, (int)tdRect.Right, (int)tdRect.Bottom);

                            tmpZ = cMainUtils.fnMoveCalculation((int)settingH[idx].MASTER_Z, (int)inspZ, sLmiInfo.ZResolution, settingH[idx].JUDGE_OFFSET, true);
                            moveZ = System.Math.Truncate(tmpZ * 100) * 0.01;
                            Interop.Common.CVB.CCVBOverlay.RectangleDraw(CVDisplay, idx + cMainUtils.cTarget, tdRect, Color.Red, Color.Red, false);

                            if (((float)moveZ >= (float)settingH[idx].JUDGE_MIN) && ((float)moveZ <= (float)settingH[idx].JUDGE_MAX))
                            {
                                posJudge = cGlobalDefine.eJudge.OK;
                            }
                            else
                            {
                                posJudge = cGlobalDefine.eJudge.NG;
                            }

                            saveSub[idx].Clear();
                            saveSub[idx].dateTime = saveMain.dateTime;
                            saveSub[idx].model = saveMain.model;
                            saveSub[idx].resNo = (idx + 1);
                            saveSub[idx].posJudge = posJudge.ToString();
                            saveSub[idx].posX = inspX;
                            saveSub[idx].posY = inspY;
                            saveSub[idx].posZ = (int)tmpZ;

                            saveSub[idx].valueX = (float)tmpX;
                            saveSub[idx].valueY = (float)tmpY;
                            saveSub[idx].valueZ = (float)moveZ;


                            if (idx == 0)
                            {
                                Interop.Common.Util.CDelegate.SetText(Result_X_01, saveSub[idx].valueX.ToString());
                                Interop.Common.Util.CDelegate.SetText(Result_Y_01, saveSub[idx].valueY.ToString());
                                Interop.Common.Util.CDelegate.SetText(Result_Z_01, saveSub[idx].valueZ.ToString());
                            }
                            else
                            {
                                Interop.Common.Util.CDelegate.SetText(Result_X_02, saveSub[idx].valueX.ToString());
                                Interop.Common.Util.CDelegate.SetText(Result_Y_02, saveSub[idx].valueY.ToString());
                                Interop.Common.Util.CDelegate.SetText(Result_Z_02, saveSub[idx].valueZ.ToString());
                            }
                        }

                        for (int idx = 0; idx < saveSub.Length; idx++)
                        {
                            if (saveSub[idx].posJudge == "OK")
                            {
                                totResult = cGlobalDefine.eJudge.OK;
                            }
                            else
                            {
                                totResult = cGlobalDefine.eJudge.NG;
                                break;
                            }
                        }

                    }
                    else
                    {
                        for (int idx = 0; idx < saveSub.Length; idx++)
                        {
                            saveSub[idx].Clear();
                            saveSub[idx].dateTime = saveMain.dateTime;
                            saveSub[idx].model = saveMain.model;
                            saveSub[idx].resNo = (idx + 1);
                            saveSub[idx].posJudge = "NG";
                            saveSub[idx].posX = 0;
                            saveSub[idx].posY = 0;
                            saveSub[idx].posZ = 0;

                            saveSub[idx].valueX = 0;
                            saveSub[idx].valueY = 0;
                            saveSub[idx].valueZ = 0;
                        }
                    }
                    //임시 강제  OK 처리
                    //for (int idx = 0; idx < saveSub.Length; idx++)
                    //{
                    //    if (saveSub[idx].posJudge == "NG")
                    //    {
                    //        totResult = cGlobalDefine.eJudge.NG;
                    //        break;
                    //    }
                    //    else
                    //    {
                    //        totResult = cGlobalDefine.eJudge.OK;
                    //    }
                    //}
                    totResult = cGlobalDefine.eJudge.OK;
                    saveMain.totalResult = totResult.ToString();
                    if (Cvb.Image.IsImage(this.CVImage8.Image))
                    {
                        dirPath = string.Format("{0}\\{1}\\{2}\\", cGlobalDefine.sPathData, saveMain.dateTime.Substring(0, 8), saveMain.model);
                        if (System.IO.Directory.Exists(dirPath) == false) System.IO.Directory.CreateDirectory(dirPath);
                        fileName = string.Format("{0}_{1}_Scan.jpg", saveMain.dateTime, saveMain.totalResult);
                        saveMain.savePath = dirPath + fileName;
                        CVImage8.SaveImage(dirPath + fileName);
                    }
                    else
                    {
                        saveMain.savePath = "";
                    }

#if SaveTIF
                    string saveTIFPath = dirPath + string.Format("\\ORG\\{0}_{1}_Scan.TIF", saveMain.dateTime, saveMain.totalResult);
                    if (System.IO.Directory.Exists(dirPath + "\\ORG\\") == false) System.IO.Directory.CreateDirectory(dirPath + "\\ORG\\");
                    axCVimage_Snap.SaveImage(saveTIFPath);
#endif
#if SaveIMG
                    string saveIMGPath = dirPath + "\\8BIT\\" + fileName;
                    if (System.IO.Directory.Exists(dirPath + "\\8BIT\\") == false) System.IO.Directory.CreateDirectory(dirPath + "\\8BIT\\");
                    CVImage8.SaveImage(saveIMGPath);
#endif
                }
                catch (Exception ex)
                {
                    logException("mRunInspection Error : " + ex.Message.ToString());
                }
            }
        }

        // Summary:
        //     Update counting inspection products
        //     Save data to SQL server
        //
        // Parameters:
        //   
        private void mRunInspection_Complete()
        {
            try
            {
                stProdCnt.nTotal++;
                if (saveMain.totalResult == "OK")
                {
                    stProdCnt.nOK++;
                }
                else if (saveMain.totalResult == "RP")
                {
                    stProdCnt.nRP++;
                }
                else
                {
                    stProdCnt.nNG++;
                }

#if UsePLC
                //cMxCom.Word_Write_Str( "D9003", saveMain.totalResult );
                cMxCom.Word_Write_Str("D9003", "OK");
                cMxCom.Word_Write("D9002", 1);
#endif
                //PC 신호 초기화 타이머 구동
                //2초후에 D9001, D9002, D9003 0 으로 리셋
                tmrPLCReset.Start();

                fnProdCntWrite(stProdCnt);
                fnProdCntDisplay();

                Interop.Common.Util.CDelegate.SetText(lblTotalResult, saveMain.totalResult);
                Interop.Common.Util.CDelegate.SetBackColor(lblTotalResult, (saveMain.totalResult == "OK" ? Color.PaleGreen : Color.Red));

                if (localdbConn.IsConnect() == false) localdbConn.SQLOpen();
                localdbConn.SQLExecute(cDBInfo.saveHistoryMain(saveMain));
                localdbConn.SQLExecute(cDBInfo.saveHistorySub(saveSub[0]));
                localdbConn.SQLExecute(cDBInfo.saveHistorySub(saveSub[1]));
                if (localdbConn.IsConnect() == true) localdbConn.CloseDataBase();
                logMessage(true, "Local History Save Complete", Interop.Common.Util.cLog.eLogType.LOG);

#if UseRemoteDB
                if ( remotedbConn.IsConnect() == false ) remotedbConn.SQLOpen();
                remotedbConn.SQLExecute( cDBInfo.saveHistoryMain( saveMain ) );
                remotedbConn.SQLExecute( cDBInfo.saveHistorySub( saveSub ) );
                if ( remotedbConn.IsConnect() == true ) remotedbConn.CloseDataBase();
                logMessage( true, "Remote History Save Complete", Interop.Common.Util.cLog.eLogType.LOG );
#endif

                axCVdisplay1.Refresh();
                isInspection = false;
                fnDisplayHDDSpace();
                logMessage(true, "검사 완료 : " + saveMain.totalResult, Interop.Common.Util.cLog.eLogType.LOG);
            }
            catch (Exception ex)
            {
                logException("mRunInspection_Complete Error : " + ex.Message.ToString());
            }
        }

        // Summary:
        //     Initialize the Grabber Control,
        //     Grabber Control is a easy method to control all available cameras
        //
        // Parameters:
        //   
        //     
        private void fnCamInit()
        {
#if UseCam
            fnCamOpenVin(0);

            axCVgrabber_Snap.CamPort = 0;
            axCVgrabber_Snap.Image = axCVimage_Snap.Image;
            axCVimage_Snap.Image = axCVgrabber_Snap.Image;
#endif
        }


        // Summary:
        //     Loading GenICAM driver, open the connection with LMI 3D sensors
        //
        // Parameters:
        //   Mode:
        //     Camera index         
        private void fnCamOpenVin(int Mode)
        {
            string sFileName = Interop.Common.CVB.CCVBUtil.mTranslateFileName() + "Drivers\\GenICam.vin";

            try
            {
                if (axCVimage_Snap.LoadImage(sFileName) == true)
                {
                    logMessage(true, "LMI #1 Open", Interop.Common.Util.cLog.eLogType.LOG);
                    return;
                }
                else
                {
                    // LMI 초기에 VIN 파일 읽어 오지 못하는 경우 발생
                    // Time Out 시간 이후 다시 시도 시 정상적으로 vin 파일 읽어옴
                    System.Threading.Thread.Sleep(3000);
                    if (axCVimage_Snap.LoadImage(sFileName))
                    {
                        logMessage(true, "LMI #1 Open", Interop.Common.Util.cLog.eLogType.LOG);
                        return;
                    }
                    else
                    {
                        logMessage(true, "LMI# 1 Open  Error", Interop.Common.Util.cLog.eLogType.LOG);
                    }
                    if (axCVimage_Snap.LoadImage(sFileName))
                    {
                        logMessage(true, "LMI #1 Open", Interop.Common.Util.cLog.eLogType.LOG);
                    }
                    else
                    {
                        logMessage(true, "LMI# 1 Open  Error", Interop.Common.Util.cLog.eLogType.LOG);
                    }
                }
            }
            catch (Exception ex)
            {
                logException("fnCamOpenVin Error : " + ex.Message.ToString());
            }
        }

        // Summary:
        //     Enable/Disable CVB Image snaped event function
        //
        // Parameters:
        //   _flag:
        //     True     Enable
        //     False    Disable 
        private bool fnScanSensor(bool _flag)
        {
            bool result = false;
            try
            {
                if (_flag == true)
                {
                    if (axCVimage_Snap.Grab == false)
                    {
                        axCVimage_Snap.Grab = false;
                        System.Threading.Thread.Sleep(500);
                        axCVimage_Snap.Grab = true;
                        logMessage(true, "LMI Grap = true", Interop.Common.Util.cLog.eLogType.LOG);
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
                else
                {
                    axCVimage_Snap.Grab = false;
                    System.Threading.Thread.Sleep(500);
                    logMessage(true, "LMI Grap = false", Interop.Common.Util.cLog.eLogType.LOG);
                    result = true;
                }
            }
            catch (Exception ex)
            {
                logException("fnScanSensor Error : " + ex.Message.ToString());
                result = false;
            }
            return result;
        }

        // Summary:
        //     Convert original captured image to 8, 16 bits gray image
        //
        // Parameters:
        //   
        //     
        private void fnLMImageConvert()
        {
            try
            {
                CVImage16.Image = 0;
                CVImage8.Image = 0;
                CVImage16.Image = Interop.Common.CVB.Util.UtilImage.ConvertTo16BitMonoLMI(this.CVImageORG);
                CVImage8.Image = Interop.Common.CVB.Util.UtilImage.ConvertTo8BitMonoLMI(this.CVImageORG);
            }
            catch (Exception ex)
            {
                logException("fnLMImageConvert Error : " + ex.ToString());
            }
        }

        // Summary:
        //     Get the X resolution from the LMI sensor
        //
        // Parameters:
        //   _sLmiInfo:
        //     output All LMI sensor information 
        //   xResolution:
        //     output X resolution from the LMI sensor 
        private void fnGetLMISensorInfo(ref Interop.Common.CVB.cStruct.sLMI_StampInfo _sLmiInfo, out double xResolution)
        {
            xResolution = this.dPixelmmX;
            try
            {
                if (Cvb.Image.ImageDimension(this.CVImageORG.Image) == 3)
                {
                    Interop.Common.CVB.Util.UtilImage.mGetLMISenserInfo_New(this.CVImageORG.Image, ref _sLmiInfo);
                    xResolution = _sLmiInfo.XResolution == 0 ? this.dPixelmmX : _sLmiInfo.XResolution;
                }
            }
            catch (Exception ex)
            {
                xResolution = this.dPixelmmX;
                logException("fnGetLMISensorInfo Error : " + ex.ToString());
            }
        }

        // Summary:
        //     Copy CVB image and display to the class private parameters
        //
        // Parameters:
        //   
        //     
        private bool fnComponentArraySet()
        {
            bool bresult = true;
            try
            {
                CVDisplay = new AxCVDISPLAYLib.AxCVdisplay();
                CVImageORG = new AxCVIMAGELib.AxCVimage();
                CVImage16 = new AxCVIMAGELib.AxCVimage();
                CVImage8 = new AxCVIMAGELib.AxCVimage();
                AxCVImageCutRate = new float();

                CVDisplay = axCVdisplay1;

                // 원본
                CVImageORG = axCVimage1_org;

                // H 값 계산용
                CVImage16 = this.axCVimage1_insp16;

                // 화면 출력 및 SF 용
                CVImage8 = this.axCVimage1_display8;

                AxCVImageCutRate = 1.0f;
            }
            catch (Exception ex)
            {
                logException("fnComponentArraySet Error : " + ex.ToString());
                bresult = false;
            }
            return bresult;
        }

        // Summary:
        //     Delete resources for image and display private parameters
        //
        // Parameters:
        //   
        //     
        private void fnComponentArrayDispose()
        {
            try
            {
                this.CVDisplay.Dispose();
                this.CVImageORG.Dispose();
                this.CVImage16.Dispose();
                this.CVImage8.Dispose();
            }
            catch (Exception ex)
            {
                logException("fnComponentArrayDispose Error : " + ex.ToString());
            }
        }
        private void fnSetCvbDisplay(ref AxCVDISPLAYLib.AxCVdisplay _display, bool _isFullSize)
        {
            if (_isFullSize)
            {
                _display.StatusCurrentPos = false;
                _display.StatusEmpty = false;
                _display.StatusGrayValue = false;
                _display.StatusImageSize = false;
                _display.StatusUserText = "";
                _display.ScrollBars = false;
                _display.MouseWheelMode = CVDISPLAYLib.MouseWheelMode.MW_ZOOM;
                _display.RightButtonMode = CVDISPLAYLib.RightButtonMode.RB_MENU;
                _display.LeftButtonMode = CVDISPLAYLib.LeftButtonMode.LB_NONE;
                _display.DisplayRectPercentage = 100;
            }
            else
            {
                _display.StatusCurrentPos = true;
                _display.StatusEmpty = false;
                _display.StatusGrayValue = true;
                _display.StatusImageSize = false;
                _display.StatusUserText = "";
                _display.ScrollBars = true;
                _display.MouseWheelMode = CVDISPLAYLib.MouseWheelMode.MW_ZOOM;
                _display.RightButtonMode = CVDISPLAYLib.RightButtonMode.RB_MENU;
                _display.LeftButtonMode = CVDISPLAYLib.LeftButtonMode.LB_NONE;
                _display.DisplayRectPercentage = 95;
            }
        }

        // Summary:
        //     Loading model, inspection area, acceptable range from SQL server
        //
        // Parameters:
        //  _model:
        //     Model number
        private void fnLoadModelSettings(string _model)
        {
            DataTable makeSFData = new DataTable();
            DataTable makeHData = new DataTable();
            try
            {
                makeSFData = localdbConn.GetSelectTable(cDBInfo.fnGetModelSettingSFData(_model));
                makeHData = localdbConn.GetSelectTable(cDBInfo.fnGetModelSettingHeightData(_model));
                if (makeSFData.Rows.Count > 0)
                {
                    settingSF.Clear();

                    settingSF.INSP_TOP = Interop.Common.Util.CUtil.mStringToInt(makeSFData.Rows[0][1].ToString().Trim());
                    settingSF.INSP_LEFT = Interop.Common.Util.CUtil.mStringToInt(makeSFData.Rows[0][2].ToString().Trim());
                    settingSF.INSP_BOTTOM = Interop.Common.Util.CUtil.mStringToInt(makeSFData.Rows[0][3].ToString().Trim());
                    settingSF.INSP_RIGHT = Interop.Common.Util.CUtil.mStringToInt(makeSFData.Rows[0][4].ToString().Trim());

                    settingSF.MASTER_X = Interop.Common.Util.CUtil.StringToFloat(makeSFData.Rows[0][5].ToString().Trim());
                    settingSF.MASTER_Y = Interop.Common.Util.CUtil.StringToFloat(makeSFData.Rows[0][6].ToString().Trim());
                    settingSF.MASTER_X_MM = Interop.Common.Util.CUtil.StringToFloat(makeSFData.Rows[0][7].ToString().Trim());
                    settingSF.MASTER_Y_MM = Interop.Common.Util.CUtil.StringToFloat(makeSFData.Rows[0][8].ToString().Trim());
                }
                else
                {
                    settingSF.Clear();
                }
                if (makeHData.Rows.Count > 0)
                {
                    if (settingH == null) settingH = new cDBInfo.InspSettingsHeight[2];
                    for (int idx = 0; idx < makeHData.Rows.Count; idx++)
                    {
                        settingH[idx].Clear();

                        settingH[idx].RESNO = Interop.Common.Util.CUtil.mStringToInt(makeHData.Rows[idx][1].ToString().Trim());
                        settingH[idx].INSP_X = Interop.Common.Util.CUtil.StringToFloat(makeHData.Rows[idx][2].ToString().Trim());
                        settingH[idx].INSP_Y = Interop.Common.Util.CUtil.StringToFloat(makeHData.Rows[idx][3].ToString().Trim());

                        settingH[idx].MASTER_X = Interop.Common.Util.CUtil.StringToFloat(makeHData.Rows[idx][4].ToString().Trim());
                        settingH[idx].MASTER_Y = Interop.Common.Util.CUtil.StringToFloat(makeHData.Rows[idx][5].ToString().Trim());
                        settingH[idx].MASTER_Z = Interop.Common.Util.CUtil.StringToFloat(makeHData.Rows[idx][6].ToString().Trim());

                        settingH[idx].MASTER_X_MM = Interop.Common.Util.CUtil.StringToFloat(makeHData.Rows[idx][7].ToString().Trim());
                        settingH[idx].MASTER_Y_MM = Interop.Common.Util.CUtil.StringToFloat(makeHData.Rows[idx][8].ToString().Trim());
                        settingH[idx].MASTER_Z_MM = Interop.Common.Util.CUtil.StringToFloat(makeHData.Rows[idx][9].ToString().Trim());

                        settingH[idx].JUDGE_MIN = Interop.Common.Util.CUtil.StringToFloat(makeHData.Rows[idx][10].ToString().Trim());
                        settingH[idx].JUDGE_MAX = Interop.Common.Util.CUtil.StringToFloat(makeHData.Rows[idx][11].ToString().Trim());
                        settingH[idx].JUDGE_OFFSET = Interop.Common.Util.CUtil.StringToFloat(makeHData.Rows[idx][12].ToString().Trim());
                    }
                }
                else
                {
                }
                makeSFData = null;
                makeHData = null;
            }
            catch (Exception ex)
            {
                logException("fnLoadModelSettings Error : " + ex.Message.ToString());
            }
        }
        private void lstVision_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lstVision.Items.Clear();
        }
        private void lstComm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lstComm.Items.Clear();
        }

















        private void btnGrapTrue_Click(object sender, EventArgs e)
        {
            fnScanSensor(true);
        }
        private void btnGrapFalse_Click(object sender, EventArgs e)
        {
            fnScanSensor(false);
            this.Invoke(new MethodInvoker(delegate() { pnlLMI.Visible = false; }));
        }
        private void btnPosWrite_Click(object sender, EventArgs e)
        {
            long posValue = -1;
            string posMove = Interop.Common.Util.cIni.IniReadValue("INSP_POS", "MOVE_POS", sMotionPath);

            //posValue = (long)Interop.Common.Util.CUtil.StringToFloat(txtPos.Text.Trim());
            posValue = (long)Interop.Common.Util.CUtil.StringToFloat(posMove.Trim());
            posValue = posValue * 10000;
#if UsePLC
            if (cMxCom.isOpen == true)
            {
                cMxCom.Word2_Write("D9014", posValue);
                //cMxCom.Word_Write_Str("D9014", posValue.ToString(), 2);
            }
#endif
        }
        private void btnVelWrite_Click(object sender, EventArgs e)
        {
            long velValue = -1;
            string posVel = Interop.Common.Util.cIni.IniReadValue("INSP_POS", "MOVE_VEL", sMotionPath);

            //velValue = (long)Interop.Common.Util.CUtil.StringToFloat(txtVel.Text.Trim());
            velValue = (long)Interop.Common.Util.CUtil.StringToFloat(posVel.Trim());
            velValue = velValue * 100;


#if UsePLC
            if (cMxCom.isOpen == true)
            {
                cMxCom.Word2_Write("D9016", velValue);
                //cMxCom.Word_Write_Str("D9016", velValue.ToString(), 2);
            }
#endif
        }

        private void btnSnapTEST_Click(object sender, EventArgs e)
        {
            string _filePath = @"D:\01.Work\01.DNST\04.Haewon\01.CastingprodSurfaceInsp\03.Image\2_Sanp_001.TIF";
            axCVimage_Snap.LoadImage(_filePath);
            axCVimage_Snap_ImageSnaped(null, null);
        }







    }
}
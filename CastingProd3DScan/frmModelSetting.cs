#define Debug
#define CutTest
#define ImageMirrorTest

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CastingProd3DScan
{
    public partial class frmModelSetting : Form
    {
        private frmMain mainForm = null;

        private const int _inspCount = 3;

        private Interop.Common.DB.cSQLServer localdbConn = null;
        private string sSettingPath = string.Empty;

        private cDBInfo.InspSettingsSF _settingSFList;
        private cDBInfo.InspSettingsSF _settingSFListTemp;
        private cDBInfo.InspSettingsHeight _settingHList;
        private cDBInfo.InspSettingsHeight _settingHListTemp;

        private int _currentInspNo;

        private int iDebugCnt = 0;

        private Interop.Common.Util.cOpen cof_Image = new Interop.Common.Util.cOpen();

        double dPixelmmX = 0.0d;
        double dPixelmmY = 0.0d;
        double dPixelmmZ = 0.0d;

        public frmModelSetting()
        {
            InitializeComponent();

            mainForm = new frmMain();
            localdbConn = new Interop.Common.DB.cSQLServer();
        }
        public frmModelSetting(frmMain _frm, Interop.Common.DB.cSQLServer _db)
        {
            InitializeComponent();

            if ( _frm != null )
            {
                mainForm = _frm;
            }
            else
            {
                mainForm = new frmMain();
            }
            if ( _db != null )
            {
                localdbConn = _db;
            }
            else
            {
                localdbConn = new Interop.Common.DB.cSQLServer();
            }
        }
        private void frmModelSetting_Load(object sender, EventArgs e)
        {
            try
            {
                fnDBConnect();

                fnSetDisplayClear();


#if Debug
                axCVdisplay2.Visible = true;
                axCVdisplay3.Visible = true;
#endif
                Interop.Common.Util.CDelegate.SetText( lblOpenFilePath, "" );
                Interop.Common.Util.CDelegate.SetText( lblCurrentCount, "/" );

                axCVdisplay1.OverlayObjectDraged += new AxCVDISPLAYLib._DCVdisplayEvents_OverlayObjectDragedEventHandler( axCVdisplay1_OverlayObjectDraged );
            }
            catch ( Exception ex )
            {
                logException( "frmModelSetting_Load Error : " + ex.Message.ToString() );
            }
        }
        private void frmModelSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                axCVdisplay1.OverlayObjectDraged -= new AxCVDISPLAYLib._DCVdisplayEvents_OverlayObjectDragedEventHandler( axCVdisplay1_OverlayObjectDraged );
                if ( !axCVdisplay1.IsDisposed ) axCVdisplay1.Dispose();
                if ( !axCVimageLoad.IsDisposed ) axCVimageLoad.Dispose();

                fnDBConnectClose();
            }
            catch ( Exception ex )
            {
                logException( "frmModelSetting_FormClosing Error : " + ex.Message.ToString() );
            }
        }











        private void cboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            fnLoadModelInfomation();
        }
        private void cboInspNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            fnLoadModelInfomation();
        }
        private void btnImageLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if ( fnOpenFile() == true )
                {
                    fnCVBImageDisplay( cof_Image.CurrFileName() );
                    fnDisplayFileInfo();
                }
            }
            catch ( Exception ex )
            {
                logException( "btnImageLoad_Click Error : " + ex.Message.ToString() );
            }
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            try
            {
                if ( System.IO.File.Exists( cof_Image.Prev() ) )
                {
                    fnDisplayFileInfo();
                    fnCVBImageDisplay( cof_Image.CurrFileName() );

                    if ( chkAuto.Checked ) btnRunInspection_Click( null, null );
                }
            }
            catch ( Exception ex )
            {
                logException( "btnPrev_Click Error : " + ex.Message.ToString() );
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if ( System.IO.File.Exists( cof_Image.Next() ) )
                {
                    fnCVBImageDisplay( cof_Image.CurrFileName() );
                    fnDisplayFileInfo();
                    if ( chkAuto.Checked ) btnRunInspection_Click( null, null );
                }
            }
            catch ( Exception ex )
            {
                logException( "btnNext_Click Error : " + ex.Message.ToString() );
            }
        }
        private void chkAuto_CheckedChanged(object sender, EventArgs e)
        {
            Interop.Common.Util.CDelegate.SetBackColor( chkAuto, ( chkAuto.Checked == true ? cGlobalDefine.ColorOK : cGlobalDefine.ColorDefault ) );
        }
        private void btnRunInspection_Click(object sender, EventArgs e)
        {
            fnRunInspectionSF();
        }
        private void btnInspAreaDisplay_Click(object sender, EventArgs e)
        {
            Interop.Common.CVB.CCVBOverlay.OverlayObjectRemoveAll( axCVdisplay1 );
            fnShowSmartRectangle( true, 0 );
        }
        private void btnInspAreaDisplayHeight_Click(object sender, EventArgs e)
        {
            fnShowHValueTarget( true, 0 );
        }
        private void btnMasterFind_Click(object sender, EventArgs e)
        {
            fnGetMasterFind();
            fnGetMasterFindHeight();
        }
        private void btnMasterLoad_Click(object sender, EventArgs e)
        {
            try
            {
                Interop.Common.Util.CDelegate.SetText(lblMaster_X, _settingSFListTemp.MASTER_X.ToString("0"));
                Interop.Common.Util.CDelegate.SetText(lblMaster_Y, _settingSFListTemp.MASTER_Y.ToString("0"));
                Interop.Common.Util.CDelegate.SetText( lblMaster_Z, _settingHListTemp.MASTER_Z.ToString( "0" ) );


                //string section = string.Format("{0}_HVALUE_POS", cboModel.Text.Trim());
                //int nHposX = 0;
                //int nHposY = 0;
                ////int nHposY = Interop.Common.Util.CUtil.mStringToInt(Interop.Common.Util.cIni.IniReadValue(section, key + "_Y"));

                //nHposX = (int)_settingSFListTemp.MASTER_X + nHposX;
                //nHposY = (int)_settingSFListTemp.MASTER_Y + nHposY;

            }
            catch ( Exception ex )
            {
                logException( "btnMasterLoad_Click Error : " + ex.Message.ToString() );
            }
        }
        private void btnResetAreaPTN_Click(object sender, EventArgs e)
        {
            if ( axCVimageLoad.Image > 0 )
            {
                lbl_InspArea_Left.Text = ( axCVimageLoad.ImageWidth / 2 - 100 ).ToString();
                lbl_InspArea_Top.Text = ( axCVimageLoad.ImageHeight / 2 - 100 ).ToString();
                lbl_InspArea_Right.Text = ( axCVimageLoad.ImageWidth / 2 + 100 ).ToString();
                lbl_InspArea_Bottom.Text = ( axCVimageLoad.ImageHeight / 2 + 100 ).ToString();

                axCVdisplay1.Image = axCVimageMono8.Image;
                axCVdisplay1.Refresh();
                btnInspAreaDisplay_Click( null, null );
            }
        }
        private void btnResetAreaHeight_Click(object sender, EventArgs e)
        {
            if ( axCVimageLoad.Image > 0 )
            {
                lbl_InspArea_Z_X.Text = ( axCVimageLoad.ImageWidth / 2 - 100 ).ToString();
                lbl_InspArea_Z_Y.Text = ( axCVimageLoad.ImageHeight / 2 - 100 ).ToString();

                axCVdisplay1.Image = axCVimageMono8.Image;
                axCVdisplay1.Refresh();
                btnInspAreaDisplayHeight_Click( null, null );
            }
        }
        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            DataTable makeData = new DataTable();
            Interop.Common.CVB.cStruct.sLMI_StampInfo sLmiInfo = new Interop.Common.CVB.cStruct.sLMI_StampInfo();
            try
            {
                _settingSFList = new cDBInfo.InspSettingsSF();
                _settingHList = new cDBInfo.InspSettingsHeight();

                if (Cvb.Image.ImageDimension(axCVimageLoad.Image) == 3)
                {
                    Interop.Common.CVB.Util.UtilImage.mGetLMISenserInfo_New(axCVimageLoad.Image, ref sLmiInfo);
                }

                _settingSFList.MODEL = cboModel.Text.Trim();
                _settingSFList.INSP_TOP = Interop.Common.Util.CUtil.mStringToInt(lbl_InspArea_Top.Text.Trim());
                _settingSFList.INSP_LEFT = Interop.Common.Util.CUtil.mStringToInt(lbl_InspArea_Left.Text.Trim());
                _settingSFList.INSP_BOTTOM = Interop.Common.Util.CUtil.mStringToInt(lbl_InspArea_Bottom.Text.Trim());
                _settingSFList.INSP_RIGHT = Interop.Common.Util.CUtil.mStringToInt(lbl_InspArea_Right.Text.Trim());

                _settingSFList.MASTER_X = Interop.Common.Util.CUtil.mStringToInt(lblMaster_X.Text.Trim());
                _settingSFList.MASTER_Y = Interop.Common.Util.CUtil.mStringToInt(lblMaster_Y.Text.Trim());
                float tempValX = _settingSFList.MASTER_X * Interop.Common.Util.CUtil.StringToFloat( dPixelmmX.ToString() );
                float tempValY = _settingSFList.MASTER_Y * Interop.Common.Util.CUtil.StringToFloat( dPixelmmY.ToString() );
                _settingSFList.MASTER_X_MM = tempValX;
                _settingSFList.MASTER_Y_MM = tempValY;

                _settingHList.MODEL = _settingSFList.MODEL;
                _settingHList.RESNO = Interop.Common.Util.CUtil.mStringToInt(cboInspNo.Text.Trim());

                _settingHList.INSP_X = Interop.Common.Util.CUtil.StringToFloat(lbl_InspArea_Z_X.Text.Trim());
                _settingHList.INSP_Y = Interop.Common.Util.CUtil.StringToFloat(lbl_InspArea_Z_Y.Text.Trim());

                _settingHList.MASTER_X = _settingSFList.MASTER_X;
                _settingHList.MASTER_Y = _settingSFList.MASTER_Y;

                _settingHList.MASTER_X_MM = tempValX;
                _settingHList.MASTER_Y_MM = tempValY;

                _settingHList.MASTER_Z = Interop.Common.Util.CUtil.StringToFloat(lblMaster_Z.Text.Trim());
                float tempValZ = _settingHList.MASTER_Z * Interop.Common.Util.CUtil.StringToFloat( dPixelmmZ.ToString() );
                _settingHList.MASTER_Z_MM = tempValZ;

                _settingHList.JUDGE_MIN = Interop.Common.Util.CUtil.StringToFloat(txtSpec_MIN.Text.Trim());
                _settingHList.JUDGE_MAX = Interop.Common.Util.CUtil.StringToFloat(txtSpec_MAX.Text.Trim());
                _settingHList.JUDGE_OFFSET = Interop.Common.Util.CUtil.StringToFloat(txtSpec_OFFSET.Text.Trim());

                makeData = localdbConn.GetSelectTable(cDBInfo.fnGetModelSettingSFData(_settingSFList.MODEL));
                if (makeData.Rows.Count > 0)
                {
                    localdbConn.SQLExecute(cDBInfo.fnUpdateSettingSF(_settingSFList));
                }
                else
                {
                    localdbConn.SQLExecute(cDBInfo.fnInsertSettingSF(_settingSFList)); 
                }
                makeData = null;
                makeData = localdbConn.GetSelectTable(cDBInfo.fnGetModelSettingHeightData(_settingHList.MODEL, _settingHList.RESNO.ToString()));
                if (makeData.Rows.Count > 0)
                {
                    localdbConn.SQLExecute(cDBInfo.fnUpdateSettingHeight(_settingHList));
                }
                else
                {
                    localdbConn.SQLExecute(cDBInfo.fnInsertSettingHeight(_settingHList));
                }
                
            }
            catch (Exception ex)
            {
                logException("btnSaveSettings_Click Error : " + ex.Message.ToString());
            }
            finally
            {
                makeData = null;
            }
        }
        private void axCVdisplay1_OverlayObjectDraged(object sender, AxCVDISPLAYLib._DCVdisplayEvents_OverlayObjectDragedEvent e)
        {
            if ( e.iD < cMainUtils.cTarget )
            {
                // Area 표시
                fnInspTArea( Interop.Common.CVB.CCVBOverlay.SmartRectangleGetPosition( axCVdisplay1, e.iD ), e.iD );
                // 다시 표시
                fnShowSmartRectangle( true, e.iD );
            }
            else
            {
                // Target
                fnInspTTarget( Interop.Common.CVB.CCVBOverlay.SmartRectangleGetPosition( axCVdisplay1, e.iD ), e.iD );
                fnShowHValueTarget( true, e.iD - cMainUtils.cTarget );
            }
        }
        private void fnRunInspectionSF()
        {
            Interop.Common.CVB.CCVBOverlay.mOverlayDisplayAllClear( ref this.axCVdisplay1 );

            string sf2Path = string.Empty;
            Interop.Common.CVB.cStruct.stCvbArea area;
            Interop.Common.CVB.cStruct.sLMI_StampInfo sLmiInfo = new Interop.Common.CVB.cStruct.sLMI_StampInfo();
            string sindex = ( (int)_currentInspNo ).ToString();
            // 측정 좌표를 저장 하기 위해 변수 생성
            try
            {
                sf2Path = string.Empty;
                area = new Interop.Common.CVB.cStruct.stCvbArea();
                double moveX = 0;
                double moveY = 0;
                double moveZ = 0;

                int iMaxNumSolutions = mainForm.iMaxNumSolutions; //찾을 개체 수
                int iMinimalThreshold = mainForm.iMinimalThreshold;//Threshold (0 ~ 255)
                int iPrecision = mainForm.iPrecision;//검색 정밀도 0 : fast, poor accuracy, 1= medium, medium accuracy, 2=high accuracy
                int iRelativeThreshold = mainForm.iRelativeThreshold;//베스트 모델 대비 상대적 Threshold (0 ~ 100)
                int iLocXY = mainForm.iLocXY;//결과 개체간의 픽셀         
                double dPixelmm = mainForm.dPixelmmX;
                bool bIsFeatures = mainForm.bIsFeatures;
#if Debug
                bIsFeatures = true;
#endif

                if ( Cvb.Image.ImageDimension( this.axCVimageLoad.Image ) == 3 )
                {
                    Interop.Common.CVB.Util.UtilImage.mGetLMISenserInfo_New( this.axCVimageLoad.Image, ref sLmiInfo );
                    //dPixelmm = sLmiInfo.XResolution;
                }

                Interop.Common.CVB.cStruct.stShapeFinderOutputtData[] resultDataList;

                string errMessage = string.Empty;
                cGlobalDefine.eJudge bResult = cGlobalDefine.eJudge.OK;
                Color tmpJudgeColor = new Color();

                area.Left = _settingSFList.INSP_LEFT;
                area.Top = _settingSFList.INSP_TOP;
                area.Right = _settingSFList.INSP_RIGHT;
                area.Bottom = _settingSFList.INSP_BOTTOM;

                string sfPath = string.Format( @"{0}\SF\{1}.sf2", Application.StartupPath + @"\Settings", cboModel.Text.Trim() );
                Interop.Common.CVB.Util.UtilShapeFinder.RunProcess( sfPath
                                                                                          , this.axCVimageMono8.Image
                                                                                          , area
                                                                                          , iMaxNumSolutions
                                                                                          , iMinimalThreshold
                                                                                          , iPrecision
                                                                                          , iRelativeThreshold
                                                                                          , iLocXY
                                                                                          , 0 //qty
                                                                                          , dPixelmm
                                                                                          , bIsFeatures
                                                                                          , ref this.axCVdisplay1
                                                                                          , out resultDataList
                                                                                          , out errMessage
                                                                                          , false
                                                                                         );

                if ( string.IsNullOrEmpty( errMessage ) && resultDataList.Length > 0 )
                {
                    double tmpX = 0, tmpY = 0, tmpZ = 0;
                    float tmpV = 0;

                    dPixelmmX = sLmiInfo.XResolution;
                    tmpX = cMainUtils.fnMoveCalculation_New( _settingSFList.MASTER_X_MM, (int)resultDataList[0].CenterX, dPixelmm, 0.0f, mainForm.bIsRightPlus, sLmiInfo.XOffset);
                    dPixelmmY = sLmiInfo.YResolution;
                    tmpY = cMainUtils.fnMoveCalculation_New( _settingSFList.MASTER_Y_MM, (int)resultDataList[0].CenterY, dPixelmm, 0.0f, mainForm.bIsRightPlus, sLmiInfo.YOffset);

                    if ( Cvb.Image.ImageDimension( this.axCVimageLoad.Image ) == 3 )
                    {
                        //2017.07.12 검사시 좌표 동적 추출
                        int nPosX = Interop.Common.Util.CUtil.StringToInt( lbl_InspArea_Z_X.Text.Trim() );
                        int nPosY = Interop.Common.Util.CUtil.StringToInt( lbl_InspArea_Z_Y.Text.Trim() );
                        Cvb.Image.TDRect tdRect = cMainUtils.mGetHeightArea( nPosX, nPosY );
                        //Cvb.Image.TDRect tdRect2 = cMainUtils.mGetHeightArea( (int)_settingHList.MASTER_X, (int)_settingSFList.MASTER_Y );

                        tmpV = Interop.Common.CVB.Util.UtilImage.mGetLMISenserHValue( this.axCVimageLoad, (int)tdRect.Left, (int)tdRect.Top, (int)tdRect.Right, (int)tdRect.Bottom );
                        tmpZ = cMainUtils.fnMoveCalculation_New( _settingHList.MASTER_Z_MM, (int)tmpV, sLmiInfo.ZResolution, _settingHList.JUDGE_OFFSET, true, sLmiInfo.ZOffset );
#if Debug
                        Interop.Common.CVB.CCVBOverlay.RectangleDraw( this.axCVdisplay1, 10000, tdRect, Color.Red, Color.Red, false );
#endif
                    }
                    else
                    {
                        tmpZ = 0;
                    }
                    //-------------------------------------------------------------------------------
                    moveX = tmpX;
                    moveY = tmpY;
                    moveZ = tmpZ;
                    //-------------------------------------------------------------------------------

                    moveX = System.Math.Truncate( moveX * 100 ) * 0.01;
                    moveY = System.Math.Truncate( moveY * 100 ) * 0.01;
                    moveZ = System.Math.Truncate( moveZ * 100 ) * 0.01;

                    // 판정
                    if ( (float)moveZ >= _settingHList.JUDGE_MIN && (float)moveZ <= _settingHList.JUDGE_MAX )
                    {
                        bResult = cGlobalDefine.eJudge.OK;
                        tmpJudgeColor = cGlobalDefine.ColorOK;

                    }
                    else
                    {
                        bResult = cGlobalDefine.eJudge.NG;
                        tmpJudgeColor = cGlobalDefine.ColorNG;
                    }
                    Interop.Common.Util.CDelegate.SetText( lbl_InspResult_X, moveX.ToString( "0.00" ) );
                    Interop.Common.Util.CDelegate.SetText( lbl_InspResult_Y, moveY.ToString( "0.00" ) );
                    Interop.Common.Util.CDelegate.SetText( lbl_InspResult_Z, moveZ.ToString( "0.00" ) );

                    Interop.Common.Util.CDelegate.SetText( lbl_INSPResult_Total, bResult.ToString() );
                    Interop.Common.Util.CDelegate.SetBackColor( lbl_INSPResult_Total, tmpJudgeColor );
                }
                else
                {
                    bResult = cGlobalDefine.eJudge.NONE;
                    tmpJudgeColor = cGlobalDefine.ColorNG;

                    Interop.Common.Util.CDelegate.SetText( lbl_InspResult_X, moveX.ToString( "0.00" ) );
                    Interop.Common.Util.CDelegate.SetText( lbl_InspResult_Y, moveY.ToString( "0.00" ) );
                    Interop.Common.Util.CDelegate.SetText( lbl_InspResult_Z, moveZ.ToString( "0.00" ) );
                    Interop.Common.Util.CDelegate.SetText( lbl_INSPResult_Total, bResult.ToString() );
                    Interop.Common.Util.CDelegate.SetBackColor( lbl_INSPResult_Total, tmpJudgeColor );
                }

                Interop.Common.CVB.CCVBOverlay.CrosshairDraw( this.axCVdisplay1, 1000, (int)_settingSFList.MASTER_X, (int)_settingSFList.MASTER_Y, 50, 50, Color.Yellow, Color.Yellow, false );
                Interop.Common.CVB.CCVBOverlay.CrosshairDraw( this.axCVdisplay1, (1000 + 100), (int)(int)resultDataList[ 0 ].CenterX, (int)(int)resultDataList[ 0 ].CenterY, 50, 50, Color.Red, Color.Red, false );
            }
            catch ( Exception ex )
            {
                logException( "fnRunInspectionSF Error : " + ex.Message.ToString() );
            }
            finally
            {
                axCVdisplay1.Refresh();
            }
        }




































        private void logException(string _msg)
        {
            Interop.Common.Util.cLog.FileWrite_Str( _msg, Interop.Common.Util.cLog.eLogType.EXCEPTION );
        }
        private void logMessage(bool _saveFlag, string _msg, Interop.Common.Util.cLog.eLogType _type)
        {
            string saveDate = string.Empty;
            try
            {
                saveDate = System.DateTime.Now.ToString( "yyyy-MM-dd HH:mm:ss" );
                if ( _saveFlag == true ) Interop.Common.Util.cLog.FileWrite_Str( string.Format( "[{0}]{1}", saveDate, _msg ), _type );
            }
            catch ( Exception ex )
            {
                logException( "Log Data Save Fail : " + ex.Message.ToString() );
            }
        }












        private void fnSetDisplayClear()
        {
            DataTable getModel = new DataTable();
            try
            {
                Interop.Common.Util.CDelegate.SetText( lblOpenFilePath, "" );
                Interop.Common.Util.CDelegate.SetText( lblCurrentCount, "" );
                Interop.Common.Util.CDelegate.SetText( lbl_INSPResult_Total, "" );
                Interop.Common.Util.CDelegate.SetBackColor( lbl_INSPResult_Total, cGlobalDefine.ColorDefault );


                Interop.Common.Util.CDelegate.SetText( lbl_InspResult_X, "" );
                Interop.Common.Util.CDelegate.SetText( lbl_InspResult_Y, "" );
                Interop.Common.Util.CDelegate.SetText( lbl_InspResult_Z, "" );

                Interop.Common.Util.CDelegate.SetText( txtSpec_MIN, "" );
                Interop.Common.Util.CDelegate.SetText( txtSpec_MAX, "" );

                Interop.Common.Util.CDelegate.SetText( lbl_InspArea_Left, "" );
                Interop.Common.Util.CDelegate.SetText( lbl_InspArea_Top, "" );
                Interop.Common.Util.CDelegate.SetText( lbl_InspArea_Right, "" );
                Interop.Common.Util.CDelegate.SetText( lbl_InspArea_Bottom, "" );

                Interop.Common.Util.CDelegate.SetText( lbl_InspArea_Z_X, "" );
                Interop.Common.Util.CDelegate.SetText( lbl_InspArea_Z_Y, "" );

                Interop.Common.Util.CDelegate.SetText( lblMaster_X, "" );
                Interop.Common.Util.CDelegate.SetText( lblMaster_Y, "" );
                Interop.Common.Util.CDelegate.SetText( lblMaster_Z, "" );

                Interop.Common.CVB.CCVBOverlay.OverlayObjectRemoveAll( axCVdisplay1 );

                getModel = localdbConn.GetSelectTable( cDBInfo.fnGetModelList() );

                cboModel.Items.Clear();
                if ( getModel.Rows.Count > 0 )
                {
                    for ( int idx = 0 ; idx < getModel.Rows.Count ; idx++ )
                    {
                        cboModel.Items.Add( getModel.Rows[ idx ][ 0 ].ToString().Trim() );
                    }
                }
                else
                {
                    for ( int idx = 1 ; idx < 21 ; idx++ )
                    {
                        cboModel.Items.Add( idx.ToString( "000" ) );
                    }
                }

                cboInspNo.Items.Clear();
                for ( int idx = 0 ; idx < 2 ; idx++ )
                {
                    cboInspNo.Items.Add( ( idx + 1 ).ToString( "00" ) );
                }
                cboModel.SelectedIndex = 0;
                cboInspNo.SelectedIndex = 0;
                chkAuto.Checked = false;

                
            }
            catch ( Exception ex )
            {
                logException( "fnSetDisplayClear Error : " + ex.Message.ToString() );
            }
        }
        private bool fnOpenFile()
        {
            bool bResult = true;
            try
            {
                if ( cof_Image.OpenFile( Interop.Common.Util.cOpen.eFileType.ALL, true ) )
                {
                    axCVimageLoad.LoadImage( cof_Image.CurrFileName() );
                    Interop.Common.CVB.CCVBOverlay.OverlayLabelRemoveAll( axCVdisplay1 );
                    Interop.Common.CVB.CCVBOverlay.OverlayObjectRemoveAll( axCVdisplay1 );

                    fnDisplayFileInfo();

                    //화면에 SmartRectangle 을 표시 
                    fnShowSmartRectangle( false, 0 );
                }
            }
            catch ( Exception ex )
            {
                logException( "OpenFile : " + ex.ToString() );
                bResult = false;
            }
            return bResult;
        }
        private void fnCVBImageDisplay(string _file)
        {
            try
            {
                Interop.Common.CVB.CCVBOverlay.mOverlayDisplayAllClear( ref axCVdisplay1 );
                if ( System.IO.File.Exists( _file ) )
                {
                    axCVimageLoad.LoadImage( _file );

                    if (  Cvb.Image.IsImage( axCVimageLoad.Image ) )
                    {
#if ImageMirrorTest
                        if ( Cvb.Image.ImageDimension( axCVimageLoad.Image ) == 3 )
                        {
                            //cMainUtils.fnConvert3DImage( ref axCVimageLoad,  Interop.Common.CVB.cEnum.eMirror.LeftRight, Interop.Common.CVB.cEnum.eMirror.TopBottom );
                            cMainUtils.fnConvert3DImage( ref axCVimageLoad, false, true );
                        }
#endif
                        if ( Cvb.Image.ImageDimension( axCVimageLoad.Image ) == 1 )
                        {
                            axCVimageMono8.Image = Interop.Common.CVB.Util.UtilImage.DuplicateImage( this.axCVimageLoad.Image );
                            this.axCVimageMono16.Image = 0;
                        }
                        else
                        {
                            this.axCVimageMono8.Image = Interop.Common.CVB.Util.UtilImage.ConvertTo8BitMonoLMI( axCVimageLoad ); // 검사용
                            this.axCVimageMono16.Image = Interop.Common.CVB.Util.UtilImage.ConvertTo16BitMonoLMI( axCVimageLoad ); // 디스플레이용 
                        }
#if Debug
                        this.axCVdisplay2.Image = axCVimageLoad.Image;
                        this.axCVdisplay3.Image = axCVimageMono16.Image;

                        this.axCVdisplay2.Refresh();
                        this.axCVdisplay3.Refresh();
#endif
                        this.axCVdisplay1.Image = this.axCVimageMono8.Image;
                        this.axCVdisplay1.Refresh();
                    }
                }

            }
            catch ( Exception ex )
            {
            }
        }
        private void fnDisplayFileInfo()
        {
            Interop.Common.Util.CDelegate.SetText( lblCurrentCount, cof_Image.CurrentCntDisplay() );
            Interop.Common.Util.CDelegate.SetText( lblOpenFilePath, cof_Image.CurrFileName() );
        }
        private void fnDBConnect()
        {
            if ( localdbConn == null )
            {
                localdbConn = new Interop.Common.DB.cSQLServer();
            }
            localdbConn.DB_IP = Environment.MachineName + @"\SQLEXPRESS";
            localdbConn.DB_NAME = "HW_3DScan_001";
            localdbConn.DB_ID = "dsnt";
            localdbConn.DB_PW = "dsntadmin";
            if ( false == string.IsNullOrEmpty( localdbConn.SQLOpen() ) )
            {
                MessageBox.Show( "Local DB 연결 오류" );
                this.Close();
            }
        }
        private void fnDBConnectClose()
        {
            if ( localdbConn != null )
            {
                localdbConn.CloseDataBase();
                //localdbConn = null;
            }
        }








        private void fnInspTArea(Cvb.Image.TArea _ta, int _selRet)
        {
            try
            {
                Cvb.Image.TDRect t = Interop.Common.CVB.Util.UtilComm.ConvertToRect( _ta );

                Interop.Common.Util.CDelegate.SetText( lbl_InspArea_Top, t.Top.ToString() );
                Interop.Common.Util.CDelegate.SetText( lbl_InspArea_Left, t.Left.ToString() );
                Interop.Common.Util.CDelegate.SetText( lbl_InspArea_Right, t.Right.ToString() );
                Interop.Common.Util.CDelegate.SetText( lbl_InspArea_Bottom, t.Bottom.ToString() );
            }
            catch ( Exception ex )
            {
                logException( "fnInspTArea Error : " + ex.Message.ToString() );
            }
        }
        private void fnInspTTarget(Cvb.Image.TArea _ta, int _selRet)
        {
            Cvb.Image.TDRect t = Interop.Common.CVB.Util.UtilComm.ConvertToRect( _ta );
            int centerX = 0;
            int centerY = 0;

            try
            {
                Cvb.Image.TArea Area = new Cvb.Image.TArea();
                Area = Interop.Common.CVB.CCVBOverlay.SmartRectangleGetPosition( axCVdisplay1, _selRet );

                centerX = (int)Area.X0;
                centerY = (int)Area.Y0;

                Interop.Common.Util.CDelegate.SetText( lbl_InspArea_Z_X, centerX.ToString() );
                Interop.Common.Util.CDelegate.SetText( lbl_InspArea_Z_Y, centerY.ToString() );
            }
            catch ( Exception ex )
            {
                logException( "fnInspTTarget Error : " + ex.Message.ToString() );
            }
        }
        private void fnShowSmartRectangle(bool _isDrag, int _seq)
        {
            if ( this.axCVdisplay1.Image == 0 )
                return;

            Cvb.Image.TDRect curRect = new Cvb.Image.TDRect();

            try
            {
                curRect = Interop.Common.CVB.CCVBOverlay.TDRectToInt( Interop.Common.Util.CUtil.mStringToInt( lbl_InspArea_Left.Text.Trim() )
                                                                                               , Interop.Common.Util.CUtil.mStringToInt( lbl_InspArea_Top.Text.Trim() )
                                                                                               , Interop.Common.Util.CUtil.mStringToInt( lbl_InspArea_Right.Text.Trim() )
                                                                                               , Interop.Common.Util.CUtil.mStringToInt( lbl_InspArea_Bottom.Text.Trim() ) );
                if ( _isDrag )
                {
                    Interop.Common.CVB.CCVBOverlay.mSmartRectangleCheckPos( ref curRect );
                }
                // 초기에 값이 없거나 뒤집혀서 저장 된 경우
                if ( curRect.Bottom <= curRect.Top && curRect.Right <= curRect.Left )
                {
                    curRect.Right = curRect.Left + 50;
                    curRect.Bottom = curRect.Top + 50;
                }
                // smartRectangle Display
                Interop.Common.CVB.CCVBOverlay.OverlayObjectRemove( axCVdisplay1, _seq );
                Interop.Common.CVB.CCVBOverlay.SmartRectangleDraw( axCVdisplay1, _seq, Interop.Common.CVB.CCVBOverlay.TDRectToTArea( curRect ), Interop.Common.CVB.CCVBOverlay.ColorFG, Interop.Common.CVB.CCVBOverlay.ColorHL, true );

                Interop.Common.CVB.CCVBOverlay.OverlayRemove( axCVdisplay1, ( _seq + cMainUtils.cLabel ) );
                Interop.Common.CVB.CCVBOverlay.LabelDraw( axCVdisplay1, ( _seq + 1 ).ToString(), Color.White, ( _seq + cMainUtils.cLabel ), curRect.Left, curRect.Top );

                this.axCVdisplay1.Refresh();
            }
            catch ( Exception ex )
            {
                logException( "fnShowSmartRectangle Error : " + ex.Message.ToString() );
            }
        }
        private void fnShowHValueTarget(bool _isDrag, int _seq)
        {
            if ( this.axCVdisplay1.Image == 0 )
                return;

            try
            {
                int centerX = 0;
                int centerY = 0;

                centerX = Interop.Common.Util.CUtil.mStringToInt( lbl_InspArea_Z_X.Text );
                centerY = Interop.Common.Util.CUtil.mStringToInt( lbl_InspArea_Z_Y.Text );

                // Target 표시
                Interop.Common.CVB.CCVBOverlay.OverlayObjectRemove( axCVdisplay1, cMainUtils.cTarget + _seq );
                Interop.Common.CVB.CCVBOverlay.TargetDraw( axCVdisplay1, cMainUtils.cTarget + _seq, centerX, centerY, 1, 100, 100, Color.Yellow, Color.Yellow, true );

                // 레이블 표시 - 이미지 Size 가 다르므로 레이블과 Target 이 구분이 가능하도록 이미지 Size 에 따라서 레이블 위치를 변경 함.
                Interop.Common.CVB.CCVBOverlay.OverlayRemove( axCVdisplay1, _seq + cMainUtils.cLabel + cMainUtils.cTarget );
                Interop.Common.CVB.CCVBOverlay.LabelDraw( axCVdisplay1, " " + ( _seq + 1 ).ToString() + " ", Color.White, ( _seq + cMainUtils.cLabel + cMainUtils.cTarget ), centerX - 25, centerY - ( Cvb.Image.ImageHeight( axCVdisplay1.Image ) > 2000 ? 105 : 75 ) );

                int nTargetX = ( Interop.Common.Util.CUtil.mStringToInt( lblMaster_X.Text.Trim() ) - centerX ) * -1;
                int nTargetY = ( Interop.Common.Util.CUtil.mStringToInt( lblMaster_Y.Text.Trim() ) - centerY ) * -1;

                //Interop.Common.Util.CDelegate.SetText( txtMaster_HX, nTargetX.ToString() );
                //Interop.Common.Util.CDelegate.SetText( txtMaster_HY, nTargetY.ToString() );

                this.axCVdisplay1.Refresh();
            }
            catch ( Exception ex )
            {
                logException( "fnShowHValueTarget Error : " + ex.Message.ToString() );
            }
        }
        private void fnGetMasterFind()
        {
            Interop.Common.CVB.CCVBOverlay.mOverlayDisplayAllClear( ref this.axCVdisplay1 );
            Interop.Common.CVB.cStruct.sLMI_StampInfo sLmiInfo = new Interop.Common.CVB.cStruct.sLMI_StampInfo();

            string sf2Path = string.Empty;
            Interop.Common.CVB.cStruct.stCvbArea area;

            _settingSFListTemp = new cDBInfo.InspSettingsSF();
            _settingHListTemp = new cDBInfo.InspSettingsHeight();

            try
            {
                sf2Path = string.Empty;
                area = new Interop.Common.CVB.cStruct.stCvbArea();

                int iMaxNumSolutions = mainForm.iMaxNumSolutions;
                int iMinimalThreshold = mainForm.iMinimalThreshold;
                int iPrecision = mainForm.iPrecision;
                int iRelativeThreshold = mainForm.iRelativeThreshold;
                int iLocXY = mainForm.iLocXY;
                //dPixelmmX = mainForm.dPixelmmX;
                //dPixelmmY = mainForm.dPixelmmY;
                bool bIsFeatures = mainForm.bIsFeatures;

                if ( Cvb.Image.ImageDimension( axCVimageLoad.Image ) == 3 )
                {
                    Interop.Common.CVB.Util.UtilImage.mGetLMISenserInfo_New( axCVimageLoad.Image, ref sLmiInfo );
                    dPixelmmX = sLmiInfo.XResolution;
                    dPixelmmY = sLmiInfo.YResolution;
                }

                Interop.Common.CVB.cStruct.stShapeFinderOutputtData[] resultDataList;

                string errMessage = string.Empty;

                area.Left = _settingSFList.INSP_LEFT;
                area.Top = _settingSFList.INSP_TOP;
                area.Right = _settingSFList.INSP_RIGHT;
                area.Bottom = _settingSFList.INSP_BOTTOM;

                string sfPath = cMainUtils.mSFPath( cboModel.Text.Trim());
                Interop.Common.CVB.Util.UtilShapeFinder.RunProcess( sfPath
                                                                , this.axCVimageMono8.Image
                                                                , area
                                                                , iMaxNumSolutions
                                                                , iMinimalThreshold
                                                                , iPrecision
                                                                , iRelativeThreshold
                                                                , iLocXY
                                                                , 0 //qty
                                                                , sLmiInfo.XResolution
                                                                , bIsFeatures
                                                                , ref this.axCVdisplay1
                                                                , out resultDataList
                                                                , out errMessage
                                                                , false
                                                                );

                if ( string.IsNullOrEmpty( errMessage ) && resultDataList.Length > 0 )
                {
                    //Find Master SF
                    _settingSFListTemp.MASTER_X = (int)resultDataList[ 0 ].CenterX;
                    _settingSFListTemp.MASTER_Y = (int)resultDataList[ 0 ].CenterY;

                    dPixelmmX = sLmiInfo.XResolution;
                    _settingSFListTemp.MASTER_X_MM = (float)( System.Math.Truncate( _settingSFListTemp.MASTER_X * dPixelmmX * 100 ) ) * 0.01f;
                    dPixelmmY = sLmiInfo.YResolution;
                    _settingSFListTemp.MASTER_Y_MM = (float)( System.Math.Truncate( _settingSFListTemp.MASTER_Y * dPixelmmY * 100 ) ) * 0.01f;

                    //_settingSFListTemp.MASTER_X_MM -= (float)sLmiInfo.XOffset;
                    //_settingSFListTemp.MASTER_Y_MM -= (float)sLmiInfo.YOffset;

                    Interop.Common.CVB.CCVBOverlay.CrosshairDraw( this.axCVdisplay1, cMainUtils.cCross, (int)resultDataList[ 0 ].CenterX, (int)resultDataList[ 0 ].CenterY, 50, 50, Color.Red, Color.Red, false );

                    //Find Master Height
                    //int nPosX = Interop.Common.Util.CUtil.mStringToInt( lbl_InspArea_Z_X.Text.Trim() );
                    //int nPosY = Interop.Common.Util.CUtil.mStringToInt( lbl_InspArea_Z_Y.Text.Trim() );

                    //Cvb.Image.TDRect tdRect = cMainUtils.mGetHeightArea( nPosX, nPosY );
                    //Cvb.Image.TDRect tdRect2 = cMainUtils.mGetHeightArea( (int)_settingHList.MASTER_X, (int)_settingSFList.MASTER_Y );
                   
                    //if ( cboInspNo.SelectedIndex == 0 )
                    //{
                    //    _settingHListTemp.MASTER_X = _settingSFListTemp.MASTER_X - 300;
                    //    _settingHListTemp.MASTER_Y = _settingSFListTemp.MASTER_Y;
                    //}
                    //else
                    //{
                    //    _settingHListTemp.MASTER_X = _settingSFListTemp.MASTER_X - 300;
                    //    _settingHListTemp.MASTER_Y = _settingSFListTemp.MASTER_Y;
                    //}
                    //Cvb.Image.TDRect tdRect = cMainUtils.mGetHeightArea( (int)_settingHListTemp.MASTER_X, (int)_settingHListTemp.MASTER_Y );
                    //int tmpZ;
                    //tmpZ = Interop.Common.CVB.Util.UtilImage.mGetLMISenserHValue( this.axCVimageLoad, (int)tdRect.Left, (int)tdRect.Top, (int)tdRect.Right, (int)tdRect.Bottom );
                    //tmpZ = Interop.Common.CVB.Util.UtilImage.mGetLMISenserHValue( this.axCVimageMono16, (int)tdRect.Left, (int)tdRect.Top, (int)tdRect.Right, (int)tdRect.Bottom );

                    //_settingHListTemp.MASTER_Z = tmpZ;
                }
                axCVdisplay1.Refresh();
            }
            catch ( Exception ex )
            {
                logException( "fnGetMasterFind Error : " + ex.Message.ToString() );
            }
        }
        private void fnGetMasterFindHeight()
        {
            //Interop.Common.CVB.CCVBOverlay.mOverlayDisplayAllClear( ref this.axCVdisplay1 );
            Interop.Common.CVB.cStruct.sLMI_StampInfo sLmiInfo = new Interop.Common.CVB.cStruct.sLMI_StampInfo();

            _settingHListTemp = new cDBInfo.InspSettingsHeight();

            try
            {
                dPixelmmZ = mainForm.dPixelmmZ;

                if (Cvb.Image.ImageDimension(axCVimageLoad.Image) == 3)
                {
                    Interop.Common.CVB.Util.UtilImage.mGetLMISenserInfo_New(axCVimageLoad.Image, ref sLmiInfo);
                    dPixelmmZ = sLmiInfo.ZResolution;
                }

                Cvb.Image.TDRect tdRect = cMainUtils.mGetHeightArea(Interop.Common.Util.CUtil.StringToInt(lbl_InspArea_Z_X.Text.Trim()), Interop.Common.Util.CUtil.StringToInt(lbl_InspArea_Z_Y.Text.Trim()));
                if (Cvb.Image.ImageDimension(this.axCVimageLoad.Image) == 3)
                {
                    _settingHListTemp.MASTER_Z = Interop.Common.CVB.Util.UtilImage.mGetLMISenserHValue( this.axCVimageLoad, (int)tdRect.Left, (int)tdRect.Top, (int)tdRect.Right, (int)tdRect.Bottom );
                }
                _settingHListTemp.MASTER_Z_MM = (float)(System.Math.Truncate(_settingHListTemp.MASTER_Z * dPixelmmZ * 100)) * 0.01f;

                Interop.Common.CVB.CCVBOverlay.RectangleDraw( this.axCVdisplay1, cMainUtils.cTarget, tdRect, Color.Yellow, Color.Yellow, false );
                Interop.Common.CVB.CCVBOverlay.CrosshairDraw( this.axCVdisplay1, cMainUtils.cCrossH, (int)_settingHListTemp.MASTER_X, (int)_settingHListTemp.MASTER_Y, 50, 50, Color.Yellow, Color.Yellow, false );

                axCVdisplay1.Refresh();
            }
            catch ( Exception ex )
            {
                Interop.Common.Util.cLog.FileWrite_Str( "fnGetMasterFindHeight Error : " + ex.Message.ToString(), Interop.Common.Util.cLog.eLogType.EXCEPTION );
            }
        }
        

























        private void fnLoadModelInfomation()
        {
            string _No = string.Empty;
            string _gubun = string.Empty;
            string _model = string.Empty;
            DataTable makeData = new DataTable();
            DataTable makeHData = new DataTable();
            try
            {
                if ( true == string.IsNullOrEmpty( cboModel.Text.Trim() ) ) return;
                if ( true == string.IsNullOrEmpty( cboInspNo.Text.Trim() ) ) return;
                _model = cboModel.Text.Trim();
                _No = cboInspNo.Text.Trim();

                makeData = localdbConn.GetSelectTable( cDBInfo.fnGetModelSettingSFData( _model ) );
                if ( makeData.Rows.Count > 0 )
                {
                    _settingSFList.MODEL = _model;

                    _settingSFList.INSP_TOP = Interop.Common.Util.CUtil.mStringToInt( makeData.Rows[ 0 ][ 1 ].ToString() );
                    _settingSFList.INSP_LEFT = Interop.Common.Util.CUtil.mStringToInt( makeData.Rows[ 0 ][ 2 ].ToString() );
                    _settingSFList.INSP_BOTTOM = Interop.Common.Util.CUtil.mStringToInt( makeData.Rows[ 0 ][ 3 ].ToString() );
                    _settingSFList.INSP_RIGHT = Interop.Common.Util.CUtil.mStringToInt( makeData.Rows[ 0 ][ 4 ].ToString() );

                    _settingSFList.MASTER_X = Interop.Common.Util.CUtil.mStringToInt( makeData.Rows[ 0 ][ 5 ].ToString() );
                    _settingSFList.MASTER_Y = Interop.Common.Util.CUtil.mStringToInt( makeData.Rows[ 0 ][ 6 ].ToString() );
                    _settingSFList.MASTER_X_MM = Interop.Common.Util.CUtil.StringToFloat( makeData.Rows[ 0 ][ 7 ].ToString() );
                    _settingSFList.MASTER_Y_MM = Interop.Common.Util.CUtil.StringToFloat( makeData.Rows[ 0 ][ 8 ].ToString() );

                    Interop.Common.Util.CDelegate.SetText( lbl_InspArea_Left, _settingSFList.INSP_LEFT.ToString() );
                    Interop.Common.Util.CDelegate.SetText( lbl_InspArea_Top, _settingSFList.INSP_TOP.ToString() );
                    Interop.Common.Util.CDelegate.SetText( lbl_InspArea_Right, _settingSFList.INSP_RIGHT.ToString() );
                    Interop.Common.Util.CDelegate.SetText( lbl_InspArea_Bottom, _settingSFList.INSP_BOTTOM.ToString() );

                    Interop.Common.Util.CDelegate.SetText( lblMaster_X, _settingSFList.MASTER_X.ToString() );
                    Interop.Common.Util.CDelegate.SetText( lblMaster_Y, _settingSFList.MASTER_Y.ToString() );

                    Interop.Common.Util.CDelegate.SetText( lblSFPath, cMainUtils.mSFPath( _model ) );

                    makeHData = localdbConn.GetSelectTable( cDBInfo.fnGetModelSettingHeightData( _model, _No ) );
                    if ( makeHData.Rows.Count > 0 )
                    {
                        _settingHList.MODEL = _model;
                        _settingHList.RESNO = Interop.Common.Util.CUtil.mStringToInt( _No );
                        _settingHList.INSP_X = Interop.Common.Util.CUtil.mStringToInt( makeHData.Rows[ 0 ][ 2 ].ToString() );
                        _settingHList.INSP_Y = Interop.Common.Util.CUtil.mStringToInt( makeHData.Rows[ 0 ][ 3 ].ToString() );

                        _settingHList.MASTER_X = Interop.Common.Util.CUtil.mStringToInt( makeHData.Rows[ 0 ][ 4 ].ToString() );
                        _settingHList.MASTER_Y = Interop.Common.Util.CUtil.mStringToInt( makeHData.Rows[ 0 ][ 5 ].ToString() );
                        _settingHList.MASTER_Z = Interop.Common.Util.CUtil.mStringToInt( makeHData.Rows[ 0 ][ 6 ].ToString() );

                        _settingHList.MASTER_X_MM = Interop.Common.Util.CUtil.mStringToInt( makeHData.Rows[ 0 ][ 7 ].ToString() );
                        _settingHList.MASTER_Y_MM = Interop.Common.Util.CUtil.mStringToInt( makeHData.Rows[ 0 ][ 8 ].ToString() );
                        _settingHList.MASTER_Z_MM = Interop.Common.Util.CUtil.StringToFloat( makeHData.Rows[ 0 ][ 9 ].ToString() );

                        _settingHList.JUDGE_MIN = Interop.Common.Util.CUtil.StringToFloat( makeHData.Rows[ 0 ][ 10 ].ToString() );
                        _settingHList.JUDGE_MAX = Interop.Common.Util.CUtil.StringToFloat( makeHData.Rows[ 0 ][ 11 ].ToString() );
                        _settingHList.JUDGE_OFFSET = Interop.Common.Util.CUtil.StringToFloat( makeHData.Rows[ 0 ][ 12 ].ToString() );

                        Interop.Common.Util.CDelegate.SetText( lbl_InspArea_Z_X, _settingHList.INSP_X.ToString() );
                        Interop.Common.Util.CDelegate.SetText( lbl_InspArea_Z_Y, _settingHList.INSP_Y.ToString() );
                        Interop.Common.Util.CDelegate.SetText( lblMaster_Z, _settingHList.MASTER_Z.ToString() );

                        Interop.Common.Util.CDelegate.SetText( txtSpec_MIN, _settingHList.JUDGE_MIN.ToString() );
                        Interop.Common.Util.CDelegate.SetText( txtSpec_MAX, _settingHList.JUDGE_MAX.ToString() );
                        Interop.Common.Util.CDelegate.SetText( txtSpec_OFFSET, _settingHList.JUDGE_OFFSET.ToString() );
                    }
                    else
                    { 
                    }
                }
                else
                {
                    MessageBox.Show( this, "Standard Data Load Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
                Interop.Common.CVB.CCVBOverlay.OverlayObjectRemoveAll( axCVdisplay1 );
            }
            catch ( Exception ex )
            {
                logException( "fnLoadModelInfomation Error : " + ex.Message.ToString() );
            }



        }





    }
}

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
    public partial class frmServoSetting : Form
    {
        public delegate void motionCloseEventHandler();
        public event motionCloseEventHandler motionCloseEvent;

        private Interop.Common.PLC.Melsec.CMxComponentDirect cMxCom = null;

        private double dAccel = 0.0d;
        private double dDecel = 0.0d;
        private double dVelocity = 0.0d;
        private double dPosition = 0.0d;

        private string sMotionPath = string.Empty;



        public frmServoSetting()
        {
            InitializeComponent();
        }
        public frmServoSetting(Interop.Common.PLC.Melsec.CMxComponentDirect _base)
        {
            InitializeComponent();
            if ( _base == null )
            {
                fnMxCompomponentOpen();
            }
            else
            {
                cMxCom = _base;
            }
        }
        private void frmServoSetting_Load(object sender, EventArgs e)
        {
            try
            {
                sMotionPath = Application.StartupPath + @"\Settings\Servo.ini";
            }
            catch ( Exception ex )
            {
                logException( "frmServoSetting_Load Error : " + ex.Message.ToString() );
            }
        }
        private void frmServoSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if ( motionCloseEvent != null )
                {
                    motionCloseEvent();
                }
            }
            catch ( Exception ex )
            {
                logException( "frmServoSetting_FormClosing Error : " + ex.Message.ToString() );
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAxis01_Move01_Click(object sender, EventArgs e)
        {
            try
            {
                double accl = Interop.Common.Util.CUtil.StringToDouble( txtACCL.Text.Trim() );
                double dccl = Interop.Common.Util.CUtil.StringToDouble( txtDCCL.Text.Trim() );
                double vel = Interop.Common.Util.CUtil.StringToDouble( txtAxis01_Spd01.Text.Trim() );
                double pos = Interop.Common.Util.CUtil.StringToDouble( txtAxis01_Pos01.Text.Trim() );
                fnServoMove( accl, dccl, vel, pos );
            }
            catch ( Exception ex )
            {
                logException( "btnAxis01_Move01_Click Error : " + ex.Message.ToString() );
            }
        }





        private void logException(string _msg)
        {
            Interop.Common.Util.cLog.FileWrite_Str( _msg, Interop.Common.Util.cLog.eLogType.EXCEPTION );
        }







        private void fnServoMove(double _accl, double _dccl, double _vel, double _pos)
        {
            string posMove = string.Empty;
            string posVel = string.Empty;
            string posAcc = string.Empty;
            string posDcc = string.Empty;
            
            try
            {
                posMove = Interop.Common.Util.cIni.IniReadValue( "INSP_POS", "MOVE_POS", sMotionPath );
                posVel = Interop.Common.Util.cIni.IniReadValue( "INSP_POS", "MOVE_VEL", sMotionPath );
                posAcc = Interop.Common.Util.cIni.IniReadValue( "INSP_POS", "MOVE_ACC", sMotionPath );
                posDcc = Interop.Common.Util.cIni.IniReadValue( "INSP_POS", "MOVE_DCC", sMotionPath );

                cMxCom.Word_Write_Str( "D9014", posMove, 2 );
                cMxCom.Word_Write_Str( "D9016", posVel, 2 );
                cMxCom.Word_Write_Str( "D9018", posAcc, 2 );
                cMxCom.Word_Write_Str( "D9020", posDcc, 2 );

                cMxCom.Word_Write( "D9012", 1 );
                System.Threading.Thread.Sleep( 1000 );
                cMxCom.Word_Write( "D9012", 0 );
            }
            catch ( Exception ex )
            {
                logException( "fnServoMove Error : " + ex.Message.ToString() );
            }
        }


        private void fnMxCompomponentOpen()
        {
            try
            {
                if ( cMxCom == null )
                {
                    cMxCom = new Interop.Common.PLC.Melsec.CMxComponentDirect();
                }
#if UsePLC
                this.cMxCom.Channel_Open(0);
#endif
                if ( true == cMxCom.isOpen )
                {
                    fnSetPCMemoryClear();
                }
            }
            catch ( Exception ex )
            {
                logException( "PLC 연결 실패 : " + ex.ToString() );
            }
        }
        private void fnSetPCMemoryClear()
        {
            try
            {
                cMxCom.Word_Write_Str( "D9014", "", 2 );
                cMxCom.Word_Write_Str( "D9016", "", 2 );
                cMxCom.Word_Write_Str( "D9018", "", 2 );
                cMxCom.Word_Write_Str( "D9020", "", 2 );

                cMxCom.Word_Write( "D9012", 0 );
            }
            catch ( Exception ex )
            {
                logException( "fnSetPCMemoryClear Error : " + ex.Message.ToString() );
            }
        }












    }
}

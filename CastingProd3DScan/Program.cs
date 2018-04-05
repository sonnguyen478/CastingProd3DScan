using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace CastingProd3DScan
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );

            bool checkOther = false;
            Mutex m_OneProcess = null;

            try
            {
                m_OneProcess = new System.Threading.Mutex( true, "Casting Prod 3D Inspection", out checkOther );

                if ( checkOther == false )
                {
                    MessageBox.Show( "이미 실행 중 입니다." );
                    return;
                }
                Application.Run( new frmMain() );
                //Application.Run( new frmModelSetting() );
            }
            catch ( Exception ex )
            {
                System.Diagnostics.Debug.WriteLine( ex.Message.ToString() );
            }

        }
    }
}

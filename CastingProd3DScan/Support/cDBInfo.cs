using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CastingProd3DScan
{
    public static class cDBInfo
    {
        public struct InspSaveMain
        {
            public string dateTime;
            public string model;
            public string totalResult;
            public string savePath;

            public void Clear()
            {
                dateTime = string.Empty;
                model = string.Empty;
                totalResult = string.Empty;
                savePath = string.Empty;
            }
        }
        public struct InspSaveSub
        {
            public string dateTime;
            public string model;
            public int resNo;
            public string posJudge;
            public int posX;
            public int posY;
            public int posZ;
            public float valueX;
            public float valueY;
            public float valueZ;

            public void Clear()
            {
                dateTime = string.Empty;
                model = string.Empty;
                resNo = 0;
                posJudge = string.Empty;
                posX = 0;
                posY = 0;
                posZ = 0;
                valueX = 0.0f;
                valueY = 0.0f;
                valueZ = 0.0f;
            }
        }
        public struct InspSettingsHeight
        {
            public string MODEL;
            public int RESNO;
            public float INSP_X;
            public float INSP_Y;
            public float MASTER_X;
            public float MASTER_Y;
            public float MASTER_Z;
            public float MASTER_X_MM;
            public float MASTER_Y_MM;
            public float MASTER_Z_MM;

            public float JUDGE_MIN;
            public float JUDGE_MAX;
            public float JUDGE_OFFSET;

            public void Clear()
            {
                MODEL = string.Empty;
                RESNO = 0;
                INSP_X = 0;
                INSP_Y = 0;
                MASTER_X = 0;
                MASTER_Y = 0;
                MASTER_Z = 0;
                MASTER_X_MM = 0.0f;
                MASTER_Y_MM = 0.0f;
                MASTER_Z_MM = 0.0f;

                JUDGE_MIN = 0.0f;
                JUDGE_MAX = 0.0f;
                JUDGE_OFFSET = 0.0f;
            }
        }
        public struct InspSettingsSF
        {
            public string MODEL;
            public int INSP_TOP;
            public int INSP_LEFT;
            public int INSP_BOTTOM;
            public int INSP_RIGHT;

            public float MASTER_X;
            public float MASTER_Y;
            public float MASTER_X_MM;
            public float MASTER_Y_MM;

            public void Clear()
            {
                MODEL = string.Empty;
                INSP_TOP = 0;
                INSP_LEFT = 0;
                INSP_BOTTOM = 0;
                INSP_RIGHT = 0;

                MASTER_X = 0;
                MASTER_Y = 0;
                MASTER_X_MM = 0.0f;
                MASTER_Y_MM = 0.0f;
            }
        }








        public static string saveHistoryMain(InspSaveMain _target)
        {
            string strSQL = string.Empty;
            try
            {
                strSQL = string.Empty;
                strSQL = "INSERT INTO TB_HISTORY_MAIN(DATE_TIME,MODEL,TOT_RESULT,SAVE_PATH)\n";
                strSQL += string.Format("VALUES( '{0}','{1}','{2}','{3}')\n", _target.dateTime, _target.model, _target.totalResult, _target.savePath);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
                strSQL = string.Empty;
            }
            return strSQL;
        }
        public static string saveHistorySub(InspSaveSub _target)
        {
            string strSQL = string.Empty;
            try
            {
                strSQL = string.Empty;

                strSQL = "INSERT INTO TB_HISTORY_SUB(DATE_TIME,MODEL,RES_NO,RESULT\n";
                strSQL += "                          ,POS_X,POS_Y,POS_Z\n";
                strSQL += "                          ,VALUE_X,VALUE_Y,VALUE_Z)\n";
                strSQL += "VALUES(\n";
                strSQL += string.Format("'{0}',\n", _target.dateTime);
                strSQL += string.Format("'{0}',\n", _target.model);
                strSQL += string.Format("{0},\n", _target.resNo);
                strSQL += string.Format("'{0}',\n", _target.posJudge);
                strSQL += string.Format("{0},\n", _target.posX);
                strSQL += string.Format("{0},\n", _target.posY);
                strSQL += string.Format("{0},\n", _target.posZ);
                strSQL += string.Format("{0},\n", _target.valueX);
                strSQL += string.Format("{0},\n", _target.valueY);
                strSQL += string.Format("{0})\n", _target.valueZ);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
                strSQL = string.Empty;
            }
            return strSQL;
        }
        public static string fnGetModelSettingSFData(string _model)
        {
            string strSQL = string.Empty;
            try
            {
                strSQL = string.Format( "SELECT * FROM   TB_SETTINGS_SF WHERE  MODEL = '{0}'\n", _model );
            }
            catch ( Exception ex )
            {
                System.Diagnostics.Debug.WriteLine( ex.Message.ToString() );
                strSQL = string.Empty;
            }
            return strSQL;
        }
        public static string fnGetModelSettingHeightData(string _model, string _No)
        {
            string strSQL = string.Empty;
            try
            {
                strSQL = "SELECT * FROM TB_SETTINGS_HEIGHT\n";
                strSQL += string.Format( "WHERE  MODEL = '{0}'\n", _model );
                strSQL += string.Format( "AND   RES_NO = {0}", _No );
            }
            catch ( Exception ex )
            {
                System.Diagnostics.Debug.WriteLine( ex.Message.ToString() );
                strSQL = string.Empty;
            }
            return strSQL;
        }
        public static string fnGetModelSettingHeightData(string _model)
        {
            string strSQL = string.Empty;
            try
            {
                strSQL = "SELECT * FROM TB_SETTINGS_HEIGHT\n";
                strSQL += string.Format( "WHERE  MODEL = '{0}'\n", _model );
            }
            catch ( Exception ex )
            {
                System.Diagnostics.Debug.WriteLine( ex.Message.ToString() );
                strSQL = string.Empty;
            }
            return strSQL;
        }
        public static string fnGetModelList()
        {
            string strSQL = string.Empty;
            try
            {
                strSQL = "SELECT MODEL FROM TB_SETTINGS_SF GROUP BY MODEL";
            }
            catch ( Exception ex )
            {
                System.Diagnostics.Debug.WriteLine( ex.Message.ToString() );
                strSQL = string.Empty;
            }
            return strSQL;
        }
        public static string fnUpdateSettingSF(InspSettingsSF _target)
        {
            string strSQL = string.Empty;
            try
            {
                strSQL = "UPDATE TB_SETTINGS_SF\n";
                strSQL += string.Format("SET    INSP_TOP = {0}\n", _target.INSP_TOP);
                strSQL += string.Format("      ,INSP_LEFT = {0}\n", _target.INSP_LEFT);
                strSQL += string.Format("      ,INSP_BOTTOM = {0}\n", _target.INSP_BOTTOM);
                strSQL += string.Format("      ,INSP_RIGHT = {0}\n", _target.INSP_RIGHT);
                strSQL += string.Format("      ,MASTER_X = {0}\n", _target.MASTER_X);
                strSQL += string.Format("      ,MASTER_Y = {0}\n", _target.MASTER_Y);
                strSQL += string.Format("      ,MASTER_X_MM = {0}\n", _target.MASTER_X_MM);
                strSQL += string.Format("      ,MASTER_Y_MM = {0}\n", _target.MASTER_Y_MM);
                strSQL += string.Format("WHERE  MODEL = '{0}'\n", _target.MODEL);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
                strSQL = string.Empty;
            }
            return strSQL;
        }
        public static string fnInsertSettingSF(InspSettingsSF _target)
        {
            string strSQL = string.Empty;
            try
            {
                strSQL += "INSERT INTO TB_SETTINGS_SF(MODEL\n";
                strSQL += "                          ,INSP_TOP,INSP_LEFT,INSP_BOTTOM,INSP_RIGHT\n";
                strSQL += "                          ,MASTER_X,MASTER_Y,MASTER_X_MM,MASTER_Y_MM)\n";
                strSQL += string.Format("VALUES('{0}'\n", _target.MODEL);
                strSQL += string.Format("      ,{0}\n", _target.INSP_TOP);
                strSQL += string.Format("      ,{0}\n", _target.INSP_LEFT);
                strSQL += string.Format("      ,{0}\n", _target.INSP_BOTTOM);
                strSQL += string.Format("      ,{0}\n", _target.INSP_RIGHT);
                strSQL += string.Format("      ,{0}\n", _target.MASTER_X);
                strSQL += string.Format("      ,{0}\n", _target.MASTER_Y);
                strSQL += string.Format("      ,{0}\n", _target.MASTER_X_MM);
                strSQL += string.Format("      ,{0})\n", _target.MASTER_Y_MM);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
                strSQL = string.Empty;
            }
            return strSQL;
        }
        public static string fnUpdateSettingHeight(InspSettingsHeight _target)
        {
            string strSQL = string.Empty;
            try
            {
                strSQL = "UPDATE TB_SETTINGS_HEIGHT\n";
                strSQL += string.Format("SET    INSP_X = {0}\n", _target.INSP_X);
                strSQL += string.Format("      ,INSP_Y = {0}\n", _target.INSP_Y);
                strSQL += string.Format("      ,MASTER_X = {0}\n", _target.MASTER_X);
                strSQL += string.Format("      ,MASTER_Y = {0}\n", _target.MASTER_Y);
                strSQL += string.Format("      ,MASTER_Z = {0}\n", _target.MASTER_Z);
                strSQL += string.Format("      ,MASTER_X_MM = {0}\n", _target.MASTER_X_MM);
                strSQL += string.Format("      ,MASTER_Y_MM = {0}\n", _target.MASTER_Y_MM);
                strSQL += string.Format("      ,MASTER_Z_MM = {0}\n", _target.MASTER_Z_MM);
                strSQL += string.Format("      ,JUDGE_MIN = {0}\n", _target.JUDGE_MIN);
                strSQL += string.Format("      ,JUDGE_MAX = {0}\n", _target.JUDGE_MAX);
                strSQL += string.Format("      ,JUDGE_OFFSET = {0}\n", _target.JUDGE_OFFSET);
                strSQL += string.Format("WHERE  MODEL = '{0}'\n", _target.MODEL);
                strSQL += string.Format("AND    RES_NO = {0}\n", _target.RESNO);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
                strSQL = string.Empty;
            }
            return strSQL;
        }
        public static string fnInsertSettingHeight(InspSettingsHeight _target)
        {
            string strSQL = string.Empty;
            try
            {
                strSQL += "INSERT INTO TB_SETTINGS_HEIGHT(MODEL,RES_NO\n";
                strSQL += "                              ,INSP_X,INSP_Y\n";
                strSQL += "                              ,MASTER_X,MASTER_Y,MASTER_Z\n";
                strSQL += "                              ,MASTER_X_MM,MASTER_Y_MM,MASTER_Z_MM\n";
                strSQL += "                              ,JUDGE_MIN,JUDGE_MAX,JUDGE_OFFSET)\n";
                strSQL += string.Format("VALUES('{0}'\n", _target.MODEL);
                strSQL += string.Format("      ,{0}\n", _target.RESNO);
                strSQL += string.Format("      ,{0}\n", _target.INSP_X);
                strSQL += string.Format("      ,{0}\n", _target.INSP_Y);
                strSQL += string.Format("      ,{0}\n", _target.MASTER_X);
                strSQL += string.Format("      ,{0}\n", _target.MASTER_Y);
                strSQL += string.Format("      ,{0}\n", _target.MASTER_Z);
                strSQL += string.Format("      ,{0}\n", _target.MASTER_X_MM);
                strSQL += string.Format("      ,{0}\n", _target.MASTER_Y_MM);
                strSQL += string.Format("      ,{0}\n", _target.MASTER_Z_MM);
                strSQL += string.Format("      ,{0}\n", _target.JUDGE_MIN);
                strSQL += string.Format("      ,{0}\n", _target.JUDGE_MAX);
                strSQL += string.Format("      ,{0})\n", _target.JUDGE_OFFSET);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
                strSQL = string.Empty;
            }
            return strSQL;
        }
















    }
}

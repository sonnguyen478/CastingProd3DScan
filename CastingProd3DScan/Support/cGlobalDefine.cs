using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CastingProd3DScan
{
    public sealed class cGlobalDefine
    {
        public static Color ColorOK = Color.PaleGreen;
        public static Color ColorNG = Color.Red;
        public static Color ColorDefault = Color.White;
        public static Color ColorYellow = Color.Yellow;

        public static string sPathData = @"D:\DataImages";

        //public const int cLabel = 100;
        //public const int cCross = 1000;
        //public const int cTarget = 10000;

        public enum eJudge
        {
            NONE = 0,
            OK = 1,
            NG = 2,
        }
        public enum ePLCSignal
        {
            HEARTBIT = 0,
            INSP_MODEL = 1,
            INSP_POS = 2,
            PLC_BY_PASS = 3,
        }

        public enum ePCSignal
        {
            HEARTBIT = 0,
            INSP_START=1,
            INSP_END=2,
            INSP_RESULT=3,

            JOG_PLUS,
            JOG_MINUS,
            JOG_VEL,
            JOG_ACCL,
            JOG_DCCL,

            POS_MOVE,
            POS_VALUE,
            POS_VEL,
            POS_ACCL,
            POS_DCCL,
        }

        public struct stProdCount
        {
            public uint nTotal;
            public uint nOK;
            public uint nRP;
            public uint nNG;
            public float nOKPer;
            public float nRPPer;
            public float nNGPer;
        }






    }


}

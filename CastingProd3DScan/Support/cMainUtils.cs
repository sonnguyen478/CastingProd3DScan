using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CastingProd3DScan
{
    public class cMainUtils
    {
        public const int cLabel = 100;
        public const int cCross = 1000;
        public const int cCrossH = 1100;
        public const int cTarget = 10000;


        public static Color mGetJudgeColor(string _judeg)
        {
            Color c = cGlobalDefine.ColorOK;

            if ( _judeg.Equals( "OK" ) )
            {
                c = cGlobalDefine.ColorOK;
            }
            else if ( _judeg.Equals( "NG" ) )
            {
                c = cGlobalDefine.ColorNG;
            }

            return c;
        }
        public static string mSFPath(string _model)
        {
            string _path = "";
            _path = System.Windows.Forms.Application.StartupPath + "\\SETTINGS\\SF\\" + _model + ".sf2";
            return _path;
        }
        //public static string mGetSaveImgePath(string _date, string _model, int _inspNo, string _judge)
        //{
        //    string dirPath = string.Empty;
        //    string fileName = string.Empty;
        //    string fullPath = string.Empty;
        //    try
        //    {
        //        dirPath = string.Format( "{0}\\{1}\\{2}", Interop.Common.cGlobal.sPathData, _date.Substring( 0, 8 ), _model );
        //        fileName = string.Format( "{1}_{2}_AREA{0:00}.jpg", _inspNo, _date, _judge );

        //        if ( !System.IO.Directory.Exists( dirPath ) )
        //        {
        //            System.IO.Directory.CreateDirectory( dirPath );
        //        }

        //        fullPath = dirPath + "\\" + fileName;
        //    }
        //    catch ( Exception Ex )
        //    {
        //        System.Diagnostics.Debug.WriteLine( Ex.ToString() );
        //        fullPath = Interop.Common.cGlobal.sPathData + "\\" + _date.Substring( 0, 8 ) + "\\" + _model + "\\" + _date + ".jpg";
        //    }

        //    return fullPath;
        //}

        //public static string mGetSaveImgeNGPath(string _date, string _model, int _inspNo, string _judge)
        //{
        //    string dirPath = string.Empty;
        //    string fileName = string.Empty;
        //    string fullPath = string.Empty;
        //    try
        //    {
        //        dirPath = string.Format( "{0}\\{1}\\NG\\{2}\\2D", Interop.Common.cGlobal.sPathData, _date.Substring( 0, 8 ), _model );
        //        fileName = string.Format( "AREA{0:00}.jpg", _inspNo );

        //        if ( !System.IO.Directory.Exists( dirPath ) )
        //        {
        //            System.IO.Directory.CreateDirectory( dirPath );
        //        }

        //        fullPath = dirPath + "\\" + fileName;
        //    }
        //    catch ( Exception Ex )
        //    {
        //        System.Diagnostics.Debug.WriteLine( Ex.ToString() );
        //        fullPath = Interop.Common.cGlobal.sPathData + "\\" + _date.Substring( 0, 8 ) + "\\" + _model + "\\" + _date + ".jpg";
        //    }

        //    return fullPath;
        //}

        //public static string mGetSaveImgePathTIF(string _date, string _model, int _inspNo, string _judge)
        //{
        //    string dirPath = string.Empty;
        //    string fileName = string.Empty;
        //    string fullPath = string.Empty;

        //    try
        //    {
        //        //dirPath = string.Format( "{0}\\{1}\\{2}\\3D", Interop.Common.cGlobal.sPathData, _date.Substring( 0, 8 ), _model );
        //        //fileName = string.Format( "AREA{0:00}.TIF", _inspNo );

        //        dirPath = string.Format( "{0}\\{1}\\{2}\\3D", Interop.Common.cGlobal.sPathData, _date.Substring( 0, 8 ), _model );
        //        fileName = string.Format( "{1}_{2}_AREA{0:00}.TIF", _inspNo, _date, _judge );

        //        if ( !System.IO.Directory.Exists( dirPath ) )
        //        {
        //            System.IO.Directory.CreateDirectory( dirPath );
        //        }

        //        fullPath = dirPath + "\\" + fileName;
        //    }
        //    catch ( Exception Ex )
        //    {
        //        System.Diagnostics.Debug.WriteLine( Ex.ToString() );
        //        fullPath = Interop.Common.cGlobal.sPathData + "\\" + _date.Substring( 0, 8 ) + "\\" + _model + "\\" + _date + ".TIF";
        //    }
        //    return fullPath;
        //}
        //public static string mGetSaveImgeNGPathTIF(string _date, string _model, int _inspNo, string _judge)
        //{
        //    string dirPath = string.Empty;
        //    string fileName = string.Empty;
        //    string fullPath = string.Empty;

        //    try
        //    {
        //        //dirPath = string.Format("{0}\\{1}\\NG\\{2}\\3D\\{3}", Interop.Common.CGlobal.sPathData, _data.Substring(0, 8), _cartype, _inspNo);
        //        //fileName = string.Format("{0}-{1}-AREA{2:00}.TIF", _data.Substring(8, 6), _cn, _inspNo);
        //        dirPath = string.Format( "{0}\\{1}\\NG\\{2}\\3D", Interop.Common.cGlobal.sPathData, _date.Substring( 0, 8 ), _model );
        //        fileName = string.Format( "{1}AREA{0:00}.TIF", _inspNo, _date );

        //        if ( !System.IO.Directory.Exists( dirPath ) )
        //        {
        //            System.IO.Directory.CreateDirectory( dirPath );
        //        }

        //        fullPath = dirPath + "\\" + fileName;
        //    }
        //    catch ( Exception Ex )
        //    {
        //        System.Diagnostics.Debug.WriteLine( Ex.ToString() );
        //        fullPath = Interop.Common.cGlobal.sPathData + "\\" + _date.Substring( 0, 8 ) + "\\" + _model + "\\" + _date + ".TIF";
        //    }
        //    return fullPath;
        //}
        //public static string mGetSaveImgePathTIF_Manual(string _date, string _model, int _inspNo, string _judge)
        //{
        //    string dirPath = string.Empty;
        //    string fileName = string.Empty;
        //    string fullPath = string.Empty;

        //    try
        //    {
        //        dirPath = string.Format( "{0}\\MANUAL\\{1}\\{2}\\3D", Interop.Common.cGlobal.sPathData, _date.Substring( 0, 8 ), _model );
        //        fileName = string.Format( "{0}-AREA{1:00}.TIF", _date.Substring( 8, 6 ), _inspNo );

        //        if ( !System.IO.Directory.Exists( dirPath ) )
        //        {
        //            System.IO.Directory.CreateDirectory( dirPath );
        //        }

        //        fullPath = dirPath + "\\" + fileName;
        //    }
        //    catch ( Exception Ex )
        //    {
        //        System.Diagnostics.Debug.WriteLine( Ex.ToString() );
        //        fullPath = Interop.Common.cGlobal.sPathData + "\\NANUAL\\" + _date.Substring( 0, 8 ) + "\\" + _model + "\\" + _date + ".jpg";
        //    }
        //    return fullPath;
        //}
        public static double fnMoveCalculation(int _basePoint, int _mPoint, double _Pixelmm, float _Offset, bool _rightPlus)
        {
            double dReturn = 0;
            dReturn = ( (int)_basePoint - (int)_mPoint ) * _Pixelmm + _Offset;
            dReturn *= _rightPlus ? 1 : -1;

            return dReturn;
        }
        public static double fnMoveCalculation_New(double _basePoint, int _mPoint, double _Pixelmm, float _Offset, bool _rightPlus, double _stampValue)
        {
            double dReturn = 0;
            double makeValue = 0.0d;
            makeValue = ( _mPoint * _Pixelmm ) - _stampValue;

            dReturn = _basePoint - ( makeValue + _Offset );
            dReturn *= _rightPlus ? 1 : -1;

            return dReturn;
        }
        public static Cvb.Image.TDRect mGetHeightArea(int _x, int _y)
        {
            Cvb.Image.TDRect tdRect = new Cvb.Image.TDRect();

            int w = 20;
            int h = 10;
            int xOffset = 0;
            int yOffset = 0;

            tdRect.Left = _x + xOffset - w * 0.5;
            tdRect.Top = _y + yOffset - h * 0.5; ;
            tdRect.Right = tdRect.Left + w;
            tdRect.Bottom = tdRect.Top + h;

            return tdRect;
        }
        public static void fnConvert3DImage(ref AxCVIMAGELib.AxCVimage _target, bool _leftringt, bool _topbottom)
        {

            try
            {
                if ( Cvb.Image.ImageDimension( _target.Image ) == 3 )
                {
                    //1. LMI 정보 Read 
                    Interop.Common.CVB.cStruct.sLMI_StampInfo sLmiInfo = new Interop.Common.CVB.cStruct.sLMI_StampInfo();
                    Interop.Common.CVB.Util.UtilImage.mGetLMISenserInfo_New( _target.Image, ref sLmiInfo );

                    //////// 2.회전시키기
                    //////_target.Image = Interop.Common.CVB.Util.UtilImage.ImageMirror( Interop.Common.CVB.cEnum.eMirror.LeftRight, _target.Image );
                    //////_target.Image = Interop.Common.CVB.Util.UtilImage.ImageMirror( Interop.Common.CVB.cEnum.eMirror.TopBottom, _target.Image );

                    //3. LiM 정보 Write
                    int tmpValue = 0;
                    int _startY = 0;

                    unsafe
                    {
                        IntPtr pBase;
                        int nXInc;
                        int nYInc;
                        int tmp_01 = 0;
                        int tmp_02 = 0;
                        int tmp_03 = 0;
                        int tmp_04 = 0;

                        System.UInt16* pPixel;

                        if ( Cvb.Utilities.GetLinearAccess( _target.Image, 2, out pBase, out nXInc, out nYInc ) )
                        {
                            tmp_01 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.VERSION1 * nXInc + 0 * nYInc ) );
                            tmp_02 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.VERSION2 * nXInc + 0 * nYInc ) );
                            tmp_03 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.VERSION3 * nXInc + 0 * nYInc ) );
                            tmp_04 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.VERSION4 * nXInc + 0 * nYInc ) );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.VERSION1, _startY, ref tmp_01 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.VERSION2, _startY, ref tmp_02 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.VERSION3, _startY, ref tmp_03 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.VERSION4, _startY, ref tmp_04 );

                            tmp_01 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.FRAME_COUNT1 * nXInc + 0 * nYInc ) );
                            tmp_02 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.FRAME_COUNT2 * nXInc + 0 * nYInc ) );
                            tmp_03 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.FRAME_COUNT3 * nXInc + 0 * nYInc ) );
                            tmp_04 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.FRAME_COUNT4 * nXInc + 0 * nYInc ) );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.FRAME_COUNT1, _startY, ref tmp_01 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.FRAME_COUNT2, _startY, ref tmp_02 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.FRAME_COUNT3, _startY, ref tmp_03 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.FRAME_COUNT4, _startY, ref tmp_04 );

                            tmp_01 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.ENCODER_VALUE1 * nXInc + 0 * nYInc ) );
                            tmp_02 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.ENCODER_VALUE2 * nXInc + 0 * nYInc ) );
                            tmp_03 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.ENCODER_VALUE3 * nXInc + 0 * nYInc ) );
                            tmp_04 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.ENCODER_VALUE4 * nXInc + 0 * nYInc ) );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.ENCODER_VALUE1, _startY, ref tmp_01 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.ENCODER_VALUE2, _startY, ref tmp_02 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.ENCODER_VALUE3, _startY, ref tmp_03 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.ENCODER_VALUE4, _startY, ref tmp_04 );

                            tmp_01 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.ENCODER_INDEX1 * nXInc + 0 * nYInc ) );
                            tmp_02 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.ENCODER_INDEX2 * nXInc + 0 * nYInc ) );
                            tmp_03 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.ENCODER_INDEX3 * nXInc + 0 * nYInc ) );
                            tmp_04 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.ENCODER_INDEX4 * nXInc + 0 * nYInc ) );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.ENCODER_INDEX1, _startY, ref tmp_01 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.ENCODER_INDEX2, _startY, ref tmp_02 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.ENCODER_INDEX3, _startY, ref tmp_03 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.ENCODER_INDEX4, _startY, ref tmp_04 );

                            tmp_01 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.DIGITAL_INPUT_STATES1 * nXInc + 0 * nYInc ) );
                            tmp_02 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.DIGITAL_INPUT_STATES2 * nXInc + 0 * nYInc ) );
                            tmp_03 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.DIGITAL_INPUT_STATES3 * nXInc + 0 * nYInc ) );
                            tmp_04 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.DIGITAL_INPUT_STATES4 * nXInc + 0 * nYInc ) );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.DIGITAL_INPUT_STATES1, _startY, ref tmp_01 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.DIGITAL_INPUT_STATES2, _startY, ref tmp_02 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.DIGITAL_INPUT_STATES3, _startY, ref tmp_03 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.DIGITAL_INPUT_STATES4, _startY, ref tmp_04 );

                            tmp_01 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.X_OFFSET1 * nXInc + 0 * nYInc ) );
                            tmp_02 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.X_OFFSET2 * nXInc + 0 * nYInc ) );
                            tmp_03 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.X_OFFSET3 * nXInc + 0 * nYInc ) );
                            tmp_04 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.X_OFFSET4 * nXInc + 0 * nYInc ) );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.X_OFFSET1, _startY, ref tmp_01 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.X_OFFSET2, _startY, ref tmp_02 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.X_OFFSET3, _startY, ref tmp_03 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.X_OFFSET4, _startY, ref tmp_04 );

                            tmp_01 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.X_RESOLUTION1 * nXInc + 0 * nYInc ) );
                            tmp_02 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.X_RESOLUTION2 * nXInc + 0 * nYInc ) );
                            tmp_03 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.X_RESOLUTION3 * nXInc + 0 * nYInc ) );
                            tmp_04 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.X_RESOLUTION4 * nXInc + 0 * nYInc ) );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.X_RESOLUTION1, _startY, ref tmp_01 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.X_RESOLUTION2, _startY, ref tmp_02 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.X_RESOLUTION3, _startY, ref tmp_03 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.X_RESOLUTION4, _startY, ref tmp_04 );

                            tmp_01 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Y_OFFSET1 * nXInc + 0 * nYInc ) );
                            tmp_02 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Y_OFFSET2 * nXInc + 0 * nYInc ) );
                            tmp_03 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Y_OFFSET3 * nXInc + 0 * nYInc ) );
                            tmp_04 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Y_OFFSET4 * nXInc + 0 * nYInc ) );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Y_OFFSET1, _startY, ref tmp_01 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Y_OFFSET2, _startY, ref tmp_02 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Y_OFFSET3, _startY, ref tmp_03 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Y_OFFSET4, _startY, ref tmp_04 );

                            tmp_01 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Y_RESOLUTION1 * nXInc + 0 * nYInc ) );
                            tmp_02 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Y_RESOLUTION2 * nXInc + 0 * nYInc ) );
                            tmp_03 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Y_RESOLUTION3 * nXInc + 0 * nYInc ) );
                            tmp_04 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Y_RESOLUTION4 * nXInc + 0 * nYInc ) );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Y_RESOLUTION1, _startY, ref tmp_01 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Y_RESOLUTION2, _startY, ref tmp_02 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Y_RESOLUTION3, _startY, ref tmp_03 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Y_RESOLUTION4, _startY, ref tmp_04 );

                            tmp_01 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Z_OFFSET1 * nXInc + 0 * nYInc ) );
                            tmp_02 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Z_OFFSET2 * nXInc + 0 * nYInc ) );
                            tmp_03 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Z_OFFSET3 * nXInc + 0 * nYInc ) );
                            tmp_04 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Z_OFFSET4 * nXInc + 0 * nYInc ) );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Z_OFFSET1, _startY, ref tmp_01 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Z_OFFSET2, _startY, ref tmp_02 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Z_OFFSET3, _startY, ref tmp_03 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Z_OFFSET4, _startY, ref tmp_04 );

                            tmp_01 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Z_RESOLUTION1 * nXInc + 0 * nYInc ) );
                            tmp_02 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Z_RESOLUTION2 * nXInc + 0 * nYInc ) );
                            tmp_03 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Z_RESOLUTION3 * nXInc + 0 * nYInc ) );
                            tmp_04 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Z_RESOLUTION4 * nXInc + 0 * nYInc ) );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Z_RESOLUTION1, _startY, ref tmp_01 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Z_RESOLUTION2, _startY, ref tmp_02 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Z_RESOLUTION3, _startY, ref tmp_03 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.Z_RESOLUTION4, _startY, ref tmp_04 );

                            tmp_01 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.HEIGHT_MAP_WIDTH1 * nXInc + 0 * nYInc ) );
                            tmp_02 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.HEIGHT_MAP_WIDTH2 * nXInc + 0 * nYInc ) );
                            tmp_03 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.HEIGHT_MAP_WIDTH3 * nXInc + 0 * nYInc ) );
                            tmp_04 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.HEIGHT_MAP_WIDTH4 * nXInc + 0 * nYInc ) );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.HEIGHT_MAP_WIDTH1, _startY, ref tmp_01 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.HEIGHT_MAP_WIDTH2, _startY, ref tmp_02 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.HEIGHT_MAP_WIDTH3, _startY, ref tmp_03 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.HEIGHT_MAP_WIDTH4, _startY, ref tmp_04 );

                            tmp_01 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.HEIGHT_MAP_HEIGHT1 * nXInc + 0 * nYInc ) );
                            tmp_02 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.HEIGHT_MAP_HEIGHT2 * nXInc + 0 * nYInc ) );
                            tmp_03 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.HEIGHT_MAP_HEIGHT3 * nXInc + 0 * nYInc ) );
                            tmp_04 = *( (System.UInt16*)( (int)pBase + (int)Interop.Common.CVB.cEnum.eLmiStampInfo.HEIGHT_MAP_HEIGHT4 * nXInc + 0 * nYInc ) );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.HEIGHT_MAP_HEIGHT1, _startY, ref tmp_01 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.HEIGHT_MAP_HEIGHT2, _startY, ref tmp_02 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.HEIGHT_MAP_HEIGHT3, _startY, ref tmp_03 );
                            Cvb.Image.SetPixel( _target.Image, 2, (int)Interop.Common.CVB.cEnum.eLmiStampInfo.HEIGHT_MAP_HEIGHT4, _startY, ref tmp_04 );
                        }
                    }
                }
            }
            catch ( Exception ex )
            {
            }
        }

        public static int mConvertMM(double _Pixelmm, float _value)
        {
            //int dReturn = 0;
            return (int)( _value / _Pixelmm ); //dReturn;
        }


    }
}

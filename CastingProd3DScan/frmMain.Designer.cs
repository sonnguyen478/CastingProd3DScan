namespace CastingProd3DScan
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel2 = new System.Windows.Forms.Panel();
            this.IO_PC_PosMove = new System.Windows.Forms.Label();
            this.IO_PC_InspResult = new System.Windows.Forms.Label();
            this.IO_PC_InspEnd = new System.Windows.Forms.Label();
            this.IO_PC_InspStart = new System.Windows.Forms.Label();
            this.lblCurrInspTime = new System.Windows.Forms.Label();
            this.lblCurrInspModel = new System.Windows.Forms.Label();
            this.IO_PC_Fliker = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.IO_PLC_ByPass = new System.Windows.Forms.Label();
            this.IO_PLC_InspStart = new System.Windows.Forms.Label();
            this.IO_PLC_Fliker = new System.Windows.Forms.Label();
            this.lblTotalResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnServoSetting = new System.Windows.Forms.Button();
            this.btnModelSetting = new System.Windows.Forms.Button();
            this.lblInspCnt_Total = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblInspCnt_NGRate = new System.Windows.Forms.Label();
            this.lblInspCnt_OKRate = new System.Windows.Forms.Label();
            this.btnProdCntReset = new System.Windows.Forms.Button();
            this.lblInspCnt_NG = new System.Windows.Forms.Label();
            this.lblInspCnt_OK = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Result_X_01 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Result_Y_01 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Result_Z_01 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Result_X_02 = new System.Windows.Forms.Label();
            this.Result_Y_02 = new System.Windows.Forms.Label();
            this.Result_Z_02 = new System.Windows.Forms.Label();
            this.axCVdisplay1 = new AxCVDISPLAYLib.AxCVdisplay();
            this.label1 = new System.Windows.Forms.Label();
            this.Result_Jdg_01 = new System.Windows.Forms.Label();
            this.Result_Jdg_02 = new System.Windows.Forms.Label();
            this.lblSystemTime = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVelWrite = new System.Windows.Forms.Button();
            this.btnSnapTEST = new System.Windows.Forms.Button();
            this.btnPosWrite = new System.Windows.Forms.Button();
            this.btnGrapFalse = new System.Windows.Forms.Button();
            this.btnGrapTrue = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.axCVgrabber_Snap = new AxCVGRABBERLib.AxCVgrabber();
            this.label5 = new System.Windows.Forms.Label();
            this.axCVimage_Snap = new AxCVIMAGELib.AxCVimage();
            this.axCVimage1_display8 = new AxCVIMAGELib.AxCVimage();
            this.axCVimage1_insp16 = new AxCVIMAGELib.AxCVimage();
            this.axCVimage1_org = new AxCVIMAGELib.AxCVimage();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bgWorkPLC = new System.ComponentModel.BackgroundWorker();
            this.pnlLMI = new System.Windows.Forms.Panel();
            this.lblLMIMSG = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tmrSystem = new System.Windows.Forms.Timer(this.components);
            this.lstComm = new System.Windows.Forms.ListBox();
            this.lstVision = new System.Windows.Forms.ListBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.pgrDrive_C = new System.Windows.Forms.ProgressBar();
            this.lblFreeSpace_C = new System.Windows.Forms.Label();
            this.lblFreeSpace_D = new System.Windows.Forms.Label();
            this.pgrDrive_D = new System.Windows.Forms.ProgressBar();
            this.label33 = new System.Windows.Forms.Label();
            this.lblInspCnt_RP = new System.Windows.Forms.Label();
            this.lblInspCnt_RPRate = new System.Windows.Forms.Label();
            this.tmrPLCReset = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axCVdisplay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axCVgrabber_Snap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCVimage_Snap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCVimage1_display8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCVimage1_insp16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCVimage1_org)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLMI.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.IO_PC_PosMove);
            this.panel2.Controls.Add(this.IO_PC_InspResult);
            this.panel2.Controls.Add(this.IO_PC_InspEnd);
            this.panel2.Controls.Add(this.IO_PC_InspStart);
            this.panel2.Controls.Add(this.lblCurrInspTime);
            this.panel2.Controls.Add(this.lblCurrInspModel);
            this.panel2.Controls.Add(this.IO_PC_Fliker);
            this.panel2.Controls.Add(this.label54);
            this.panel2.Controls.Add(this.label36);
            this.panel2.Controls.Add(this.label35);
            this.panel2.Controls.Add(this.IO_PLC_ByPass);
            this.panel2.Controls.Add(this.IO_PLC_InspStart);
            this.panel2.Controls.Add(this.IO_PLC_Fliker);
            this.panel2.Location = new System.Drawing.Point(1, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 39);
            this.panel2.TabIndex = 2;
            // 
            // IO_PC_PosMove
            // 
            this.IO_PC_PosMove.BackColor = System.Drawing.Color.White;
            this.IO_PC_PosMove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IO_PC_PosMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IO_PC_PosMove.Location = new System.Drawing.Point(664, 1);
            this.IO_PC_PosMove.Name = "IO_PC_PosMove";
            this.IO_PC_PosMove.Size = new System.Drawing.Size(86, 35);
            this.IO_PC_PosMove.TabIndex = 0;
            this.IO_PC_PosMove.Text = "Pos\r\nMove";
            this.IO_PC_PosMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IO_PC_InspResult
            // 
            this.IO_PC_InspResult.BackColor = System.Drawing.Color.White;
            this.IO_PC_InspResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IO_PC_InspResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IO_PC_InspResult.Location = new System.Drawing.Point(751, 1);
            this.IO_PC_InspResult.Name = "IO_PC_InspResult";
            this.IO_PC_InspResult.Size = new System.Drawing.Size(86, 35);
            this.IO_PC_InspResult.TabIndex = 0;
            this.IO_PC_InspResult.Text = "Insp\r\nResult";
            this.IO_PC_InspResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IO_PC_InspEnd
            // 
            this.IO_PC_InspEnd.BackColor = System.Drawing.Color.White;
            this.IO_PC_InspEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IO_PC_InspEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IO_PC_InspEnd.Location = new System.Drawing.Point(577, 1);
            this.IO_PC_InspEnd.Name = "IO_PC_InspEnd";
            this.IO_PC_InspEnd.Size = new System.Drawing.Size(86, 35);
            this.IO_PC_InspEnd.TabIndex = 0;
            this.IO_PC_InspEnd.Text = "Insp\r\nEnd";
            this.IO_PC_InspEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IO_PC_InspStart
            // 
            this.IO_PC_InspStart.BackColor = System.Drawing.Color.White;
            this.IO_PC_InspStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IO_PC_InspStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IO_PC_InspStart.Location = new System.Drawing.Point(490, 1);
            this.IO_PC_InspStart.Name = "IO_PC_InspStart";
            this.IO_PC_InspStart.Size = new System.Drawing.Size(86, 35);
            this.IO_PC_InspStart.TabIndex = 0;
            this.IO_PC_InspStart.Text = "Insp\r\nStart";
            this.IO_PC_InspStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrInspTime
            // 
            this.lblCurrInspTime.BackColor = System.Drawing.Color.White;
            this.lblCurrInspTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrInspTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCurrInspTime.Location = new System.Drawing.Point(1096, 1);
            this.lblCurrInspTime.Name = "lblCurrInspTime";
            this.lblCurrInspTime.Size = new System.Drawing.Size(163, 35);
            this.lblCurrInspTime.TabIndex = 0;
            this.lblCurrInspTime.Text = "2017/00/00 00:00:00";
            this.lblCurrInspTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrInspModel
            // 
            this.lblCurrInspModel.BackColor = System.Drawing.Color.White;
            this.lblCurrInspModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrInspModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCurrInspModel.Location = new System.Drawing.Point(1007, 1);
            this.lblCurrInspModel.Name = "lblCurrInspModel";
            this.lblCurrInspModel.Size = new System.Drawing.Size(89, 35);
            this.lblCurrInspModel.TabIndex = 0;
            this.lblCurrInspModel.Text = "Model";
            this.lblCurrInspModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IO_PC_Fliker
            // 
            this.IO_PC_Fliker.BackColor = System.Drawing.Color.White;
            this.IO_PC_Fliker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IO_PC_Fliker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IO_PC_Fliker.Location = new System.Drawing.Point(403, 1);
            this.IO_PC_Fliker.Name = "IO_PC_Fliker";
            this.IO_PC_Fliker.Size = new System.Drawing.Size(86, 35);
            this.IO_PC_Fliker.TabIndex = 0;
            this.IO_PC_Fliker.Text = "PC\r\nStatus";
            this.IO_PC_Fliker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label54
            // 
            this.label54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label54.ForeColor = System.Drawing.Color.White;
            this.label54.Location = new System.Drawing.Point(891, 1);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(115, 35);
            this.label54.TabIndex = 0;
            this.label54.Text = "Current Info";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(334, 1);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(68, 35);
            this.label36.TabIndex = 0;
            this.label36.Text = "PC I/O";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(3, 1);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(68, 35);
            this.label35.TabIndex = 0;
            this.label35.Text = "PLC I/O";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IO_PLC_ByPass
            // 
            this.IO_PLC_ByPass.BackColor = System.Drawing.Color.White;
            this.IO_PLC_ByPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IO_PLC_ByPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IO_PLC_ByPass.Location = new System.Drawing.Point(246, 1);
            this.IO_PLC_ByPass.Name = "IO_PLC_ByPass";
            this.IO_PLC_ByPass.Size = new System.Drawing.Size(86, 35);
            this.IO_PLC_ByPass.TabIndex = 0;
            this.IO_PLC_ByPass.Text = "ByPass";
            this.IO_PLC_ByPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IO_PLC_InspStart
            // 
            this.IO_PLC_InspStart.BackColor = System.Drawing.Color.White;
            this.IO_PLC_InspStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IO_PLC_InspStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IO_PLC_InspStart.Location = new System.Drawing.Point(159, 1);
            this.IO_PLC_InspStart.Name = "IO_PLC_InspStart";
            this.IO_PLC_InspStart.Size = new System.Drawing.Size(86, 35);
            this.IO_PLC_InspStart.TabIndex = 0;
            this.IO_PLC_InspStart.Text = "Insp\r\nPos";
            this.IO_PLC_InspStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IO_PLC_Fliker
            // 
            this.IO_PLC_Fliker.BackColor = System.Drawing.Color.White;
            this.IO_PLC_Fliker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IO_PLC_Fliker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IO_PLC_Fliker.Location = new System.Drawing.Point(72, 1);
            this.IO_PLC_Fliker.Name = "IO_PLC_Fliker";
            this.IO_PLC_Fliker.Size = new System.Drawing.Size(86, 35);
            this.IO_PLC_Fliker.TabIndex = 0;
            this.IO_PLC_Fliker.Text = "PLC\r\nStatus";
            this.IO_PLC_Fliker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalResult
            // 
            this.lblTotalResult.BackColor = System.Drawing.Color.PaleGreen;
            this.lblTotalResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 51.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotalResult.Location = new System.Drawing.Point(1, 828);
            this.lblTotalResult.Name = "lblTotalResult";
            this.lblTotalResult.Size = new System.Drawing.Size(270, 111);
            this.lblTotalResult.TabIndex = 3;
            this.lblTotalResult.Text = "OK";
            this.lblTotalResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 791);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "검사 결과";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExit.Image = global::CastingProd3DScan.Properties.Resources.exit_24x24_;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(1168, 828);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 82);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnServoSetting
            // 
            this.btnServoSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnServoSetting.Image = global::CastingProd3DScan.Properties.Resources.settings;
            this.btnServoSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnServoSetting.Location = new System.Drawing.Point(973, 869);
            this.btnServoSetting.Name = "btnServoSetting";
            this.btnServoSetting.Size = new System.Drawing.Size(195, 41);
            this.btnServoSetting.TabIndex = 5;
            this.btnServoSetting.Text = "Servo Setting";
            this.btnServoSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServoSetting.UseVisualStyleBackColor = true;
            this.btnServoSetting.Click += new System.EventHandler(this.btnServoSetting_Click);
            // 
            // btnModelSetting
            // 
            this.btnModelSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnModelSetting.Image = global::CastingProd3DScan.Properties.Resources.work;
            this.btnModelSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModelSetting.Location = new System.Drawing.Point(973, 828);
            this.btnModelSetting.Name = "btnModelSetting";
            this.btnModelSetting.Size = new System.Drawing.Size(195, 41);
            this.btnModelSetting.TabIndex = 5;
            this.btnModelSetting.Text = "Model Setting";
            this.btnModelSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModelSetting.UseVisualStyleBackColor = true;
            this.btnModelSetting.Click += new System.EventHandler(this.btnModelSetting_Click);
            // 
            // lblInspCnt_Total
            // 
            this.lblInspCnt_Total.BackColor = System.Drawing.Color.White;
            this.lblInspCnt_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInspCnt_Total.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInspCnt_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblInspCnt_Total.ForeColor = System.Drawing.Color.Black;
            this.lblInspCnt_Total.Location = new System.Drawing.Point(723, 827);
            this.lblInspCnt_Total.Name = "lblInspCnt_Total";
            this.lblInspCnt_Total.Size = new System.Drawing.Size(148, 29);
            this.lblInspCnt_Total.TabIndex = 4;
            this.lblInspCnt_Total.Text = "999999";
            this.lblInspCnt_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(646, 827);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 29);
            this.label14.TabIndex = 1;
            this.label14.Text = "총수량";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInspCnt_NGRate
            // 
            this.lblInspCnt_NGRate.BackColor = System.Drawing.Color.White;
            this.lblInspCnt_NGRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInspCnt_NGRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInspCnt_NGRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblInspCnt_NGRate.ForeColor = System.Drawing.Color.Black;
            this.lblInspCnt_NGRate.Location = new System.Drawing.Point(794, 912);
            this.lblInspCnt_NGRate.Name = "lblInspCnt_NGRate";
            this.lblInspCnt_NGRate.Size = new System.Drawing.Size(77, 28);
            this.lblInspCnt_NGRate.TabIndex = 9;
            this.lblInspCnt_NGRate.Text = "0%";
            this.lblInspCnt_NGRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInspCnt_OKRate
            // 
            this.lblInspCnt_OKRate.BackColor = System.Drawing.Color.White;
            this.lblInspCnt_OKRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInspCnt_OKRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInspCnt_OKRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblInspCnt_OKRate.ForeColor = System.Drawing.Color.Black;
            this.lblInspCnt_OKRate.Location = new System.Drawing.Point(794, 856);
            this.lblInspCnt_OKRate.Name = "lblInspCnt_OKRate";
            this.lblInspCnt_OKRate.Size = new System.Drawing.Size(77, 28);
            this.lblInspCnt_OKRate.TabIndex = 8;
            this.lblInspCnt_OKRate.Text = "100.00%";
            this.lblInspCnt_OKRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnProdCntReset
            // 
            this.btnProdCntReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnProdCntReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnProdCntReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProdCntReset.ForeColor = System.Drawing.Color.Black;
            this.btnProdCntReset.Image = global::CastingProd3DScan.Properties.Resources.Change;
            this.btnProdCntReset.Location = new System.Drawing.Point(871, 827);
            this.btnProdCntReset.Name = "btnProdCntReset";
            this.btnProdCntReset.Size = new System.Drawing.Size(101, 114);
            this.btnProdCntReset.TabIndex = 7;
            this.btnProdCntReset.Text = "수량\r\n초기화";
            this.btnProdCntReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProdCntReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProdCntReset.UseVisualStyleBackColor = true;
            this.btnProdCntReset.Click += new System.EventHandler(this.btnProdCntReset_Click);
            // 
            // lblInspCnt_NG
            // 
            this.lblInspCnt_NG.BackColor = System.Drawing.Color.White;
            this.lblInspCnt_NG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInspCnt_NG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInspCnt_NG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblInspCnt_NG.ForeColor = System.Drawing.Color.Black;
            this.lblInspCnt_NG.Location = new System.Drawing.Point(723, 912);
            this.lblInspCnt_NG.Name = "lblInspCnt_NG";
            this.lblInspCnt_NG.Size = new System.Drawing.Size(71, 28);
            this.lblInspCnt_NG.TabIndex = 6;
            this.lblInspCnt_NG.Text = "0";
            this.lblInspCnt_NG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInspCnt_OK
            // 
            this.lblInspCnt_OK.BackColor = System.Drawing.Color.White;
            this.lblInspCnt_OK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInspCnt_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInspCnt_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblInspCnt_OK.ForeColor = System.Drawing.Color.Black;
            this.lblInspCnt_OK.Location = new System.Drawing.Point(723, 856);
            this.lblInspCnt_OK.Name = "lblInspCnt_OK";
            this.lblInspCnt_OK.Size = new System.Drawing.Size(71, 28);
            this.lblInspCnt_OK.TabIndex = 5;
            this.lblInspCnt_OK.Text = "99999";
            this.lblInspCnt_OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(646, 912);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 28);
            this.label13.TabIndex = 3;
            this.label13.Text = "부적합";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(646, 856);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 28);
            this.label12.TabIndex = 2;
            this.label12.Text = "적합";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(646, 791);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "검사 수량";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(973, 791);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "환경 설정";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Result_X_01
            // 
            this.Result_X_01.BackColor = System.Drawing.Color.White;
            this.Result_X_01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result_X_01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Result_X_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Result_X_01.ForeColor = System.Drawing.Color.Black;
            this.Result_X_01.Location = new System.Drawing.Point(313, 853);
            this.Result_X_01.Name = "Result_X_01";
            this.Result_X_01.Size = new System.Drawing.Size(85, 29);
            this.Result_X_01.TabIndex = 4;
            this.Result_X_01.Text = "000";
            this.Result_X_01.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(272, 791);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(372, 36);
            this.label6.TabIndex = 4;
            this.label6.Text = "검사 정보";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(313, 828);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "X";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(399, 828);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Y";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Result_Y_01
            // 
            this.Result_Y_01.BackColor = System.Drawing.Color.White;
            this.Result_Y_01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result_Y_01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Result_Y_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Result_Y_01.ForeColor = System.Drawing.Color.Black;
            this.Result_Y_01.Location = new System.Drawing.Point(399, 853);
            this.Result_Y_01.Name = "Result_Y_01";
            this.Result_Y_01.Size = new System.Drawing.Size(85, 29);
            this.Result_Y_01.TabIndex = 4;
            this.Result_Y_01.Text = "000";
            this.Result_Y_01.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(485, 828);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Z";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Result_Z_01
            // 
            this.Result_Z_01.BackColor = System.Drawing.Color.White;
            this.Result_Z_01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result_Z_01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Result_Z_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Result_Z_01.ForeColor = System.Drawing.Color.Black;
            this.Result_Z_01.Location = new System.Drawing.Point(485, 853);
            this.Result_Z_01.Name = "Result_Z_01";
            this.Result_Z_01.Size = new System.Drawing.Size(85, 29);
            this.Result_Z_01.TabIndex = 4;
            this.Result_Z_01.Text = "000";
            this.Result_Z_01.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(272, 828);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 23);
            this.label15.TabIndex = 4;
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(272, 853);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 29);
            this.label16.TabIndex = 4;
            this.label16.Text = "01";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(272, 882);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 29);
            this.label17.TabIndex = 4;
            this.label17.Text = "02";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Result_X_02
            // 
            this.Result_X_02.BackColor = System.Drawing.Color.White;
            this.Result_X_02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result_X_02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Result_X_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Result_X_02.ForeColor = System.Drawing.Color.Black;
            this.Result_X_02.Location = new System.Drawing.Point(313, 882);
            this.Result_X_02.Name = "Result_X_02";
            this.Result_X_02.Size = new System.Drawing.Size(85, 29);
            this.Result_X_02.TabIndex = 4;
            this.Result_X_02.Text = "000";
            this.Result_X_02.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Result_Y_02
            // 
            this.Result_Y_02.BackColor = System.Drawing.Color.White;
            this.Result_Y_02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result_Y_02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Result_Y_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Result_Y_02.ForeColor = System.Drawing.Color.Black;
            this.Result_Y_02.Location = new System.Drawing.Point(399, 882);
            this.Result_Y_02.Name = "Result_Y_02";
            this.Result_Y_02.Size = new System.Drawing.Size(85, 29);
            this.Result_Y_02.TabIndex = 4;
            this.Result_Y_02.Text = "000";
            this.Result_Y_02.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Result_Z_02
            // 
            this.Result_Z_02.BackColor = System.Drawing.Color.White;
            this.Result_Z_02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result_Z_02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Result_Z_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Result_Z_02.ForeColor = System.Drawing.Color.Black;
            this.Result_Z_02.Location = new System.Drawing.Point(485, 882);
            this.Result_Z_02.Name = "Result_Z_02";
            this.Result_Z_02.Size = new System.Drawing.Size(85, 29);
            this.Result_Z_02.TabIndex = 4;
            this.Result_Z_02.Text = "000";
            this.Result_Z_02.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // axCVdisplay1
            // 
            this.axCVdisplay1.Location = new System.Drawing.Point(2, 124);
            this.axCVdisplay1.Name = "axCVdisplay1";
            this.axCVdisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCVdisplay1.OcxState")));
            this.axCVdisplay1.Size = new System.Drawing.Size(970, 666);
            this.axCVdisplay1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(571, 828);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Judge";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Result_Jdg_01
            // 
            this.Result_Jdg_01.BackColor = System.Drawing.Color.PaleGreen;
            this.Result_Jdg_01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result_Jdg_01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Result_Jdg_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Result_Jdg_01.ForeColor = System.Drawing.Color.Black;
            this.Result_Jdg_01.Location = new System.Drawing.Point(571, 853);
            this.Result_Jdg_01.Name = "Result_Jdg_01";
            this.Result_Jdg_01.Size = new System.Drawing.Size(73, 29);
            this.Result_Jdg_01.TabIndex = 4;
            this.Result_Jdg_01.Text = "OK";
            this.Result_Jdg_01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Result_Jdg_02
            // 
            this.Result_Jdg_02.BackColor = System.Drawing.Color.PaleGreen;
            this.Result_Jdg_02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result_Jdg_02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Result_Jdg_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Result_Jdg_02.ForeColor = System.Drawing.Color.Black;
            this.Result_Jdg_02.Location = new System.Drawing.Point(571, 882);
            this.Result_Jdg_02.Name = "Result_Jdg_02";
            this.Result_Jdg_02.Size = new System.Drawing.Size(73, 29);
            this.Result_Jdg_02.TabIndex = 4;
            this.Result_Jdg_02.Text = "OK";
            this.Result_Jdg_02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSystemTime
            // 
            this.lblSystemTime.BackColor = System.Drawing.Color.White;
            this.lblSystemTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSystemTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemTime.Location = new System.Drawing.Point(973, 910);
            this.lblSystemTime.Name = "lblSystemTime";
            this.lblSystemTime.Size = new System.Drawing.Size(290, 30);
            this.lblSystemTime.TabIndex = 0;
            this.lblSystemTime.Text = "2017/00/00 00:00:00";
            this.lblSystemTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::CastingProd3DScan.Properties.Resources.Logo2;
            this.pictureBox2.Location = new System.Drawing.Point(1056, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(356, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(696, 59);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HaeWon IND. 3D Surface Height Inspection";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 81);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVelWrite);
            this.groupBox2.Controls.Add(this.btnSnapTEST);
            this.groupBox2.Controls.Add(this.btnPosWrite);
            this.groupBox2.Controls.Add(this.btnGrapFalse);
            this.groupBox2.Controls.Add(this.btnGrapTrue);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(701, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 61);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " TEST ";
            // 
            // btnVelWrite
            // 
            this.btnVelWrite.ForeColor = System.Drawing.Color.Black;
            this.btnVelWrite.Location = new System.Drawing.Point(88, 37);
            this.btnVelWrite.Name = "btnVelWrite";
            this.btnVelWrite.Size = new System.Drawing.Size(94, 21);
            this.btnVelWrite.TabIndex = 3;
            this.btnVelWrite.Text = "Vel PLC Write";
            this.btnVelWrite.UseVisualStyleBackColor = true;
            this.btnVelWrite.Click += new System.EventHandler(this.btnVelWrite_Click);
            // 
            // btnSnapTEST
            // 
            this.btnSnapTEST.ForeColor = System.Drawing.Color.Black;
            this.btnSnapTEST.Location = new System.Drawing.Point(183, 15);
            this.btnSnapTEST.Name = "btnSnapTEST";
            this.btnSnapTEST.Size = new System.Drawing.Size(79, 21);
            this.btnSnapTEST.TabIndex = 3;
            this.btnSnapTEST.Text = "Sanp TEST";
            this.btnSnapTEST.UseVisualStyleBackColor = true;
            this.btnSnapTEST.Click += new System.EventHandler(this.btnSnapTEST_Click);
            // 
            // btnPosWrite
            // 
            this.btnPosWrite.ForeColor = System.Drawing.Color.Black;
            this.btnPosWrite.Location = new System.Drawing.Point(88, 15);
            this.btnPosWrite.Name = "btnPosWrite";
            this.btnPosWrite.Size = new System.Drawing.Size(94, 21);
            this.btnPosWrite.TabIndex = 3;
            this.btnPosWrite.Text = "Pos PLC Write";
            this.btnPosWrite.UseVisualStyleBackColor = true;
            this.btnPosWrite.Click += new System.EventHandler(this.btnPosWrite_Click);
            // 
            // btnGrapFalse
            // 
            this.btnGrapFalse.ForeColor = System.Drawing.Color.Black;
            this.btnGrapFalse.Location = new System.Drawing.Point(6, 37);
            this.btnGrapFalse.Name = "btnGrapFalse";
            this.btnGrapFalse.Size = new System.Drawing.Size(81, 21);
            this.btnGrapFalse.TabIndex = 1;
            this.btnGrapFalse.Text = "Grap False";
            this.btnGrapFalse.UseVisualStyleBackColor = true;
            this.btnGrapFalse.Click += new System.EventHandler(this.btnGrapFalse_Click);
            // 
            // btnGrapTrue
            // 
            this.btnGrapTrue.ForeColor = System.Drawing.Color.Black;
            this.btnGrapTrue.Location = new System.Drawing.Point(6, 15);
            this.btnGrapTrue.Name = "btnGrapTrue";
            this.btnGrapTrue.Size = new System.Drawing.Size(81, 21);
            this.btnGrapTrue.TabIndex = 1;
            this.btnGrapTrue.Text = "Grap True";
            this.btnGrapTrue.UseVisualStyleBackColor = true;
            this.btnGrapTrue.Click += new System.EventHandler(this.btnGrapTrue_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.axCVgrabber_Snap);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.axCVimage_Snap);
            this.groupBox1.Controls.Add(this.axCVimage1_display8);
            this.groupBox1.Controls.Add(this.axCVimage1_insp16);
            this.groupBox1.Controls.Add(this.axCVimage1_org);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 71);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(3, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 20);
            this.label9.TabIndex = 82;
            this.label9.Text = "원본";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axCVgrabber_Snap
            // 
            this.axCVgrabber_Snap.Enabled = true;
            this.axCVgrabber_Snap.Location = new System.Drawing.Point(153, 34);
            this.axCVgrabber_Snap.Name = "axCVgrabber_Snap";
            this.axCVgrabber_Snap.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCVgrabber_Snap.OcxState")));
            this.axCVgrabber_Snap.Size = new System.Drawing.Size(32, 32);
            this.axCVgrabber_Snap.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(117, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 83;
            this.label5.Text = "LMI";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axCVimage_Snap
            // 
            this.axCVimage_Snap.Enabled = true;
            this.axCVimage_Snap.Location = new System.Drawing.Point(117, 34);
            this.axCVimage_Snap.Name = "axCVimage_Snap";
            this.axCVimage_Snap.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCVimage_Snap.OcxState")));
            this.axCVimage_Snap.Size = new System.Drawing.Size(32, 32);
            this.axCVimage_Snap.TabIndex = 2;
            this.axCVimage_Snap.ImageSnaped += new System.EventHandler(this.axCVimage_Snap_ImageSnaped);
            // 
            // axCVimage1_display8
            // 
            this.axCVimage1_display8.Enabled = true;
            this.axCVimage1_display8.Location = new System.Drawing.Point(79, 34);
            this.axCVimage1_display8.Name = "axCVimage1_display8";
            this.axCVimage1_display8.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCVimage1_display8.OcxState")));
            this.axCVimage1_display8.Size = new System.Drawing.Size(32, 32);
            this.axCVimage1_display8.TabIndex = 2;
            // 
            // axCVimage1_insp16
            // 
            this.axCVimage1_insp16.Enabled = true;
            this.axCVimage1_insp16.Location = new System.Drawing.Point(41, 34);
            this.axCVimage1_insp16.Name = "axCVimage1_insp16";
            this.axCVimage1_insp16.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCVimage1_insp16.OcxState")));
            this.axCVimage1_insp16.Size = new System.Drawing.Size(32, 32);
            this.axCVimage1_insp16.TabIndex = 2;
            // 
            // axCVimage1_org
            // 
            this.axCVimage1_org.Enabled = true;
            this.axCVimage1_org.Location = new System.Drawing.Point(3, 34);
            this.axCVimage1_org.Name = "axCVimage1_org";
            this.axCVimage1_org.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCVimage1_org.OcxState")));
            this.axCVimage1_org.Size = new System.Drawing.Size(32, 32);
            this.axCVimage1_org.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(79, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 20);
            this.label11.TabIndex = 81;
            this.label11.Text = "출력";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(41, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 20);
            this.label18.TabIndex = 80;
            this.label18.Text = "검사";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::CastingProd3DScan.Properties.Resources.Haewon_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(4, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bgWorkPLC
            // 
            this.bgWorkPLC.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkPLC_DoWork);
            // 
            // pnlLMI
            // 
            this.pnlLMI.BackColor = System.Drawing.Color.Silver;
            this.pnlLMI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLMI.Controls.Add(this.lblLMIMSG);
            this.pnlLMI.Controls.Add(this.label19);
            this.pnlLMI.Location = new System.Drawing.Point(212, 392);
            this.pnlLMI.Name = "pnlLMI";
            this.pnlLMI.Size = new System.Drawing.Size(550, 157);
            this.pnlLMI.TabIndex = 247;
            this.pnlLMI.Visible = false;
            // 
            // lblLMIMSG
            // 
            this.lblLMIMSG.BackColor = System.Drawing.Color.Transparent;
            this.lblLMIMSG.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLMIMSG.ForeColor = System.Drawing.Color.Black;
            this.lblLMIMSG.Location = new System.Drawing.Point(0, 55);
            this.lblLMIMSG.Name = "lblLMIMSG";
            this.lblLMIMSG.Size = new System.Drawing.Size(548, 74);
            this.lblLMIMSG.TabIndex = 1;
            this.lblLMIMSG.Text = "3D 카메라 스캔 중...";
            this.lblLMIMSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Black;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(0, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(548, 29);
            this.label19.TabIndex = 0;
            this.label19.Text = "검사 진행 정보 Display";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrSystem
            // 
            this.tmrSystem.Interval = 400;
            this.tmrSystem.Tick += new System.EventHandler(this.tmrSystem_Tick);
            // 
            // lstComm
            // 
            this.lstComm.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lstComm.FormattingEnabled = true;
            this.lstComm.ItemHeight = 15;
            this.lstComm.Location = new System.Drawing.Point(973, 449);
            this.lstComm.Name = "lstComm";
            this.lstComm.Size = new System.Drawing.Size(290, 274);
            this.lstComm.TabIndex = 248;
            this.lstComm.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstComm_MouseDoubleClick);
            // 
            // lstVision
            // 
            this.lstVision.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lstVision.FormattingEnabled = true;
            this.lstVision.ItemHeight = 15;
            this.lstVision.Location = new System.Drawing.Point(973, 149);
            this.lstVision.Name = "lstVision";
            this.lstVision.Size = new System.Drawing.Size(290, 274);
            this.lstVision.TabIndex = 248;
            this.lstVision.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstVision_MouseDoubleClick);
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(973, 423);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(290, 25);
            this.label22.TabIndex = 4;
            this.label22.Text = "PLC 통신 이력";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(973, 124);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(290, 24);
            this.label23.TabIndex = 4;
            this.label23.Text = "Vision 처리 이력";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(973, 724);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(290, 24);
            this.label24.TabIndex = 4;
            this.label24.Text = "Disk Space Status";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(973, 749);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(83, 20);
            this.label31.TabIndex = 4;
            this.label31.Text = "Drive C :";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(973, 771);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(83, 20);
            this.label32.TabIndex = 4;
            this.label32.Text = "Drive D :";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgrDrive_C
            // 
            this.pgrDrive_C.Location = new System.Drawing.Point(1057, 749);
            this.pgrDrive_C.Name = "pgrDrive_C";
            this.pgrDrive_C.Size = new System.Drawing.Size(152, 20);
            this.pgrDrive_C.TabIndex = 249;
            // 
            // lblFreeSpace_C
            // 
            this.lblFreeSpace_C.BackColor = System.Drawing.Color.Transparent;
            this.lblFreeSpace_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFreeSpace_C.ForeColor = System.Drawing.Color.White;
            this.lblFreeSpace_C.Location = new System.Drawing.Point(1215, 749);
            this.lblFreeSpace_C.Name = "lblFreeSpace_C";
            this.lblFreeSpace_C.Size = new System.Drawing.Size(48, 20);
            this.lblFreeSpace_C.TabIndex = 4;
            this.lblFreeSpace_C.Text = "100%";
            this.lblFreeSpace_C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFreeSpace_D
            // 
            this.lblFreeSpace_D.BackColor = System.Drawing.Color.Transparent;
            this.lblFreeSpace_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFreeSpace_D.ForeColor = System.Drawing.Color.White;
            this.lblFreeSpace_D.Location = new System.Drawing.Point(1215, 771);
            this.lblFreeSpace_D.Name = "lblFreeSpace_D";
            this.lblFreeSpace_D.Size = new System.Drawing.Size(48, 20);
            this.lblFreeSpace_D.TabIndex = 4;
            this.lblFreeSpace_D.Text = "100%";
            this.lblFreeSpace_D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgrDrive_D
            // 
            this.pgrDrive_D.Location = new System.Drawing.Point(1057, 771);
            this.pgrDrive_D.Name = "pgrDrive_D";
            this.pgrDrive_D.Size = new System.Drawing.Size(152, 20);
            this.pgrDrive_D.TabIndex = 249;
            // 
            // label33
            // 
            this.label33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label33.ForeColor = System.Drawing.Color.Brown;
            this.label33.Location = new System.Drawing.Point(646, 884);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(77, 28);
            this.label33.TabIndex = 3;
            this.label33.Text = "리페어";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInspCnt_RP
            // 
            this.lblInspCnt_RP.BackColor = System.Drawing.Color.White;
            this.lblInspCnt_RP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInspCnt_RP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInspCnt_RP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblInspCnt_RP.ForeColor = System.Drawing.Color.Black;
            this.lblInspCnt_RP.Location = new System.Drawing.Point(723, 884);
            this.lblInspCnt_RP.Name = "lblInspCnt_RP";
            this.lblInspCnt_RP.Size = new System.Drawing.Size(71, 28);
            this.lblInspCnt_RP.TabIndex = 6;
            this.lblInspCnt_RP.Text = "0";
            this.lblInspCnt_RP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInspCnt_RPRate
            // 
            this.lblInspCnt_RPRate.BackColor = System.Drawing.Color.White;
            this.lblInspCnt_RPRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInspCnt_RPRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInspCnt_RPRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblInspCnt_RPRate.ForeColor = System.Drawing.Color.Black;
            this.lblInspCnt_RPRate.Location = new System.Drawing.Point(794, 884);
            this.lblInspCnt_RPRate.Name = "lblInspCnt_RPRate";
            this.lblInspCnt_RPRate.Size = new System.Drawing.Size(77, 28);
            this.lblInspCnt_RPRate.TabIndex = 9;
            this.lblInspCnt_RPRate.Text = "0%";
            this.lblInspCnt_RPRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmrPLCReset
            // 
            this.tmrPLCReset.Interval = 400;
            this.tmrPLCReset.Tick += new System.EventHandler(this.tmrPLCReset_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1264, 941);
            this.Controls.Add(this.pgrDrive_D);
            this.Controls.Add(this.pgrDrive_C);
            this.Controls.Add(this.lstVision);
            this.Controls.Add(this.lstComm);
            this.Controls.Add(this.pnlLMI);
            this.Controls.Add(this.lblInspCnt_OKRate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblInspCnt_RPRate);
            this.Controls.Add(this.lblInspCnt_NGRate);
            this.Controls.Add(this.lblInspCnt_OK);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Result_Jdg_02);
            this.Controls.Add(this.Result_Z_02);
            this.Controls.Add(this.Result_Y_02);
            this.Controls.Add(this.Result_Jdg_01);
            this.Controls.Add(this.Result_Z_01);
            this.Controls.Add(this.Result_X_02);
            this.Controls.Add(this.Result_Y_01);
            this.Controls.Add(this.Result_X_01);
            this.Controls.Add(this.lblInspCnt_Total);
            this.Controls.Add(this.lblSystemTime);
            this.Controls.Add(this.lblInspCnt_RP);
            this.Controls.Add(this.lblInspCnt_NG);
            this.Controls.Add(this.btnModelSetting);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnServoSetting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnProdCntReset);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.lblFreeSpace_D);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.lblFreeSpace_C);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalResult);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axCVdisplay1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "3D Height Inspection - Ver.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axCVdisplay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axCVgrabber_Snap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCVimage_Snap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCVimage1_display8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCVimage1_insp16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCVimage1_org)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLMI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxCVDISPLAYLib.AxCVdisplay axCVdisplay1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnServoSetting;
        private System.Windows.Forms.Button btnModelSetting;
        private System.Windows.Forms.Label lblInspCnt_Total;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblInspCnt_NGRate;
        private System.Windows.Forms.Label lblInspCnt_OKRate;
        private System.Windows.Forms.Button btnProdCntReset;
        private System.Windows.Forms.Label lblInspCnt_NG;
        private System.Windows.Forms.Label lblInspCnt_OK;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Result_X_01;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Result_Y_01;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Result_Z_01;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label Result_X_02;
        private System.Windows.Forms.Label Result_Y_02;
        private System.Windows.Forms.Label Result_Z_02;
        private System.Windows.Forms.Label IO_PLC_Fliker;
        private System.Windows.Forms.Label IO_PC_PosMove;
        private System.Windows.Forms.Label IO_PC_InspEnd;
        private System.Windows.Forms.Label IO_PC_InspStart;
        private System.Windows.Forms.Label IO_PC_Fliker;
        private System.Windows.Forms.Label IO_PLC_InspStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Result_Jdg_01;
        private System.Windows.Forms.Label Result_Jdg_02;
        private System.Windows.Forms.Label lblCurrInspTime;
        private System.Windows.Forms.Label lblCurrInspModel;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label lblSystemTime;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AxCVGRABBERLib.AxCVgrabber axCVgrabber_Snap;
        private AxCVIMAGELib.AxCVimage axCVimage1_org;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private AxCVIMAGELib.AxCVimage axCVimage_Snap;
        private AxCVIMAGELib.AxCVimage axCVimage1_display8;
        private AxCVIMAGELib.AxCVimage axCVimage1_insp16;
        private System.ComponentModel.BackgroundWorker bgWorkPLC;
        private System.Windows.Forms.Panel pnlLMI;
        private System.Windows.Forms.Label lblLMIMSG;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label IO_PLC_ByPass;
        private System.Windows.Forms.Timer tmrSystem;
        private System.Windows.Forms.ListBox lstComm;
        private System.Windows.Forms.ListBox lstVision;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ProgressBar pgrDrive_C;
        private System.Windows.Forms.Label lblFreeSpace_C;
        private System.Windows.Forms.Label lblFreeSpace_D;
        private System.Windows.Forms.ProgressBar pgrDrive_D;
        private System.Windows.Forms.Label IO_PC_InspResult;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblInspCnt_RP;
        private System.Windows.Forms.Label lblInspCnt_RPRate;
        private System.Windows.Forms.Button btnGrapFalse;
        private System.Windows.Forms.Button btnGrapTrue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVelWrite;
        private System.Windows.Forms.Button btnPosWrite;
        private System.Windows.Forms.Button btnSnapTEST;
        private System.Windows.Forms.Timer tmrPLCReset;
    }
}


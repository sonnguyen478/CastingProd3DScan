namespace CastingProd3DScan
{
    partial class frmModelSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModelSetting));
            this.btnImageLoad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboModel = new System.Windows.Forms.ComboBox();
            this.cboInspNo = new System.Windows.Forms.ComboBox();
            this.lbl_INSPResult_Total = new System.Windows.Forms.Label();
            this.chkAuto = new System.Windows.Forms.CheckBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnRunInspection = new System.Windows.Forms.Button();
            this.lblCurrentCount = new System.Windows.Forms.Label();
            this.lblOpenFilePath = new System.Windows.Forms.Label();
            this.btnMasterLoad = new System.Windows.Forms.Button();
            this.btnMasterFind = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnInspAreaDisplayHeight = new System.Windows.Forms.Button();
            this.btnInspAreaDisplay = new System.Windows.Forms.Button();
            this.btnResetAreaPTN = new System.Windows.Forms.Button();
            this.btnResetAreaHeight = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.lbl_InspArea_Bottom = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.lbl_InspArea_Right = new System.Windows.Forms.Label();
            this.lbl_InspArea_Top = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lbl_InspArea_Left = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_InspArea_Z_X = new System.Windows.Forms.Label();
            this.lbl_InspArea_Z_Y = new System.Windows.Forms.Label();
            this.Spec_X = new System.Windows.Forms.Label();
            this.txtSpec_MIN = new System.Windows.Forms.TextBox();
            this.txtSpec_MAX = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblMaster_X = new System.Windows.Forms.Label();
            this.lblMaster_Y = new System.Windows.Forms.Label();
            this.lblMaster_Z = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_InspResult_Z = new System.Windows.Forms.Label();
            this.Insp_Z = new System.Windows.Forms.Label();
            this.lbl_InspResult_Y = new System.Windows.Forms.Label();
            this.Insp_Y = new System.Windows.Forms.Label();
            this.lbl_InspResult_X = new System.Windows.Forms.Label();
            this.Insp_X = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSFPath = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSpec_OFFSET = new System.Windows.Forms.TextBox();
            this.axCVimageMono8 = new AxCVIMAGELib.AxCVimage();
            this.axCVimageLoad = new AxCVIMAGELib.AxCVimage();
            this.axCVimageMono16 = new AxCVIMAGELib.AxCVimage();
            this.axCVdisplay3 = new AxCVDISPLAYLib.AxCVdisplay();
            this.axCVdisplay2 = new AxCVDISPLAYLib.AxCVdisplay();
            this.axCVdisplay1 = new AxCVDISPLAYLib.AxCVdisplay();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axCVimageMono8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCVimageLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCVimageMono16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCVdisplay3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCVdisplay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCVdisplay1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImageLoad
            // 
            this.btnImageLoad.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnImageLoad.Location = new System.Drawing.Point(1163, 0);
            this.btnImageLoad.Name = "btnImageLoad";
            this.btnImageLoad.Size = new System.Drawing.Size(100, 61);
            this.btnImageLoad.TabIndex = 84;
            this.btnImageLoad.Text = "File Open";
            this.btnImageLoad.UseVisualStyleBackColor = true;
            this.btnImageLoad.Click += new System.EventHandler(this.btnImageLoad_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(902, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 82;
            this.label2.Text = "Model";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(902, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 83;
            this.label1.Text = "INSP No";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboModel
            // 
            this.cboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboModel.FormattingEnabled = true;
            this.cboModel.Location = new System.Drawing.Point(1003, 1);
            this.cboModel.Name = "cboModel";
            this.cboModel.Size = new System.Drawing.Size(160, 29);
            this.cboModel.TabIndex = 80;
            this.cboModel.SelectedIndexChanged += new System.EventHandler(this.cboModel_SelectedIndexChanged);
            // 
            // cboInspNo
            // 
            this.cboInspNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInspNo.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboInspNo.FormattingEnabled = true;
            this.cboInspNo.Location = new System.Drawing.Point(1003, 31);
            this.cboInspNo.Name = "cboInspNo";
            this.cboInspNo.Size = new System.Drawing.Size(160, 29);
            this.cboInspNo.TabIndex = 81;
            this.cboInspNo.SelectedIndexChanged += new System.EventHandler(this.cboInspNo_SelectedIndexChanged);
            // 
            // lbl_INSPResult_Total
            // 
            this.lbl_INSPResult_Total.BackColor = System.Drawing.Color.White;
            this.lbl_INSPResult_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_INSPResult_Total.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_INSPResult_Total.Location = new System.Drawing.Point(902, 186);
            this.lbl_INSPResult_Total.Name = "lbl_INSPResult_Total";
            this.lbl_INSPResult_Total.Size = new System.Drawing.Size(248, 124);
            this.lbl_INSPResult_Total.TabIndex = 91;
            this.lbl_INSPResult_Total.Text = "T OK/NG";
            this.lbl_INSPResult_Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkAuto
            // 
            this.chkAuto.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAuto.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.chkAuto.Location = new System.Drawing.Point(1175, 154);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(88, 33);
            this.chkAuto.TabIndex = 90;
            this.chkAuto.Text = "AUTO";
            this.chkAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkAuto.UseVisualStyleBackColor = true;
            this.chkAuto.CheckedChanged += new System.EventHandler(this.chkAuto_CheckedChanged);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNext.Location = new System.Drawing.Point(1115, 154);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(61, 33);
            this.btnNext.TabIndex = 89;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPrev.Location = new System.Drawing.Point(902, 154);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(61, 33);
            this.btnPrev.TabIndex = 88;
            this.btnPrev.Text = "◀";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnRunInspection
            // 
            this.btnRunInspection.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRunInspection.Image = global::CastingProd3DScan.Properties.Resources.work;
            this.btnRunInspection.Location = new System.Drawing.Point(1149, 185);
            this.btnRunInspection.Name = "btnRunInspection";
            this.btnRunInspection.Size = new System.Drawing.Size(114, 126);
            this.btnRunInspection.TabIndex = 87;
            this.btnRunInspection.Text = "Inspection";
            this.btnRunInspection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRunInspection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRunInspection.UseVisualStyleBackColor = true;
            this.btnRunInspection.Click += new System.EventHandler(this.btnRunInspection_Click);
            // 
            // lblCurrentCount
            // 
            this.lblCurrentCount.BackColor = System.Drawing.Color.White;
            this.lblCurrentCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentCount.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCurrentCount.Location = new System.Drawing.Point(963, 155);
            this.lblCurrentCount.Name = "lblCurrentCount";
            this.lblCurrentCount.Size = new System.Drawing.Size(152, 31);
            this.lblCurrentCount.TabIndex = 86;
            this.lblCurrentCount.Text = "99/100";
            this.lblCurrentCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOpenFilePath
            // 
            this.lblOpenFilePath.BackColor = System.Drawing.Color.White;
            this.lblOpenFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOpenFilePath.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.lblOpenFilePath.Location = new System.Drawing.Point(902, 60);
            this.lblOpenFilePath.Name = "lblOpenFilePath";
            this.lblOpenFilePath.Size = new System.Drawing.Size(361, 94);
            this.lblOpenFilePath.TabIndex = 85;
            this.lblOpenFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMasterLoad
            // 
            this.btnMasterLoad.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMasterLoad.Image = global::CastingProd3DScan.Properties.Resources.shuffle_24x24_;
            this.btnMasterLoad.Location = new System.Drawing.Point(1083, 442);
            this.btnMasterLoad.Name = "btnMasterLoad";
            this.btnMasterLoad.Size = new System.Drawing.Size(180, 61);
            this.btnMasterLoad.TabIndex = 96;
            this.btnMasterLoad.Text = "Master Coordinate LOAD";
            this.btnMasterLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMasterLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMasterLoad.UseVisualStyleBackColor = true;
            this.btnMasterLoad.Click += new System.EventHandler(this.btnMasterLoad_Click);
            // 
            // btnMasterFind
            // 
            this.btnMasterFind.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMasterFind.Image = global::CastingProd3DScan.Properties.Resources.search;
            this.btnMasterFind.Location = new System.Drawing.Point(902, 442);
            this.btnMasterFind.Name = "btnMasterFind";
            this.btnMasterFind.Size = new System.Drawing.Size(181, 61);
            this.btnMasterFind.TabIndex = 95;
            this.btnMasterFind.Text = "Master Coordinate FIND";
            this.btnMasterFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMasterFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMasterFind.UseVisualStyleBackColor = true;
            this.btnMasterFind.Click += new System.EventHandler(this.btnMasterFind_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSaveSettings.Image = global::CastingProd3DScan.Properties.Resources.save;
            this.btnSaveSettings.Location = new System.Drawing.Point(902, 747);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(360, 48);
            this.btnSaveSettings.TabIndex = 94;
            this.btnSaveSettings.Text = "SAVE Settings";
            this.btnSaveSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnInspAreaDisplayHeight
            // 
            this.btnInspAreaDisplayHeight.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInspAreaDisplayHeight.Image = ((System.Drawing.Image)(resources.GetObject("btnInspAreaDisplayHeight.Image")));
            this.btnInspAreaDisplayHeight.Location = new System.Drawing.Point(1083, 382);
            this.btnInspAreaDisplayHeight.Name = "btnInspAreaDisplayHeight";
            this.btnInspAreaDisplayHeight.Size = new System.Drawing.Size(180, 61);
            this.btnInspAreaDisplayHeight.TabIndex = 92;
            this.btnInspAreaDisplayHeight.Text = "Inspection Area \r\nDisplay(Height)";
            this.btnInspAreaDisplayHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInspAreaDisplayHeight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInspAreaDisplayHeight.UseVisualStyleBackColor = true;
            this.btnInspAreaDisplayHeight.Click += new System.EventHandler(this.btnInspAreaDisplayHeight_Click);
            // 
            // btnInspAreaDisplay
            // 
            this.btnInspAreaDisplay.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInspAreaDisplay.Image = ((System.Drawing.Image)(resources.GetObject("btnInspAreaDisplay.Image")));
            this.btnInspAreaDisplay.Location = new System.Drawing.Point(902, 382);
            this.btnInspAreaDisplay.Name = "btnInspAreaDisplay";
            this.btnInspAreaDisplay.Size = new System.Drawing.Size(181, 61);
            this.btnInspAreaDisplay.TabIndex = 93;
            this.btnInspAreaDisplay.Text = "Inspection Area \r\nDisplay(Pattern)";
            this.btnInspAreaDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInspAreaDisplay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInspAreaDisplay.UseVisualStyleBackColor = true;
            this.btnInspAreaDisplay.Click += new System.EventHandler(this.btnInspAreaDisplay_Click);
            // 
            // btnResetAreaPTN
            // 
            this.btnResetAreaPTN.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnResetAreaPTN.Image = ((System.Drawing.Image)(resources.GetObject("btnResetAreaPTN.Image")));
            this.btnResetAreaPTN.Location = new System.Drawing.Point(902, 502);
            this.btnResetAreaPTN.Name = "btnResetAreaPTN";
            this.btnResetAreaPTN.Size = new System.Drawing.Size(181, 33);
            this.btnResetAreaPTN.TabIndex = 108;
            this.btnResetAreaPTN.Text = "ResetArea(PTN)";
            this.btnResetAreaPTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetAreaPTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetAreaPTN.UseVisualStyleBackColor = true;
            this.btnResetAreaPTN.Click += new System.EventHandler(this.btnResetAreaPTN_Click);
            // 
            // btnResetAreaHeight
            // 
            this.btnResetAreaHeight.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnResetAreaHeight.Image = ((System.Drawing.Image)(resources.GetObject("btnResetAreaHeight.Image")));
            this.btnResetAreaHeight.Location = new System.Drawing.Point(1083, 502);
            this.btnResetAreaHeight.Name = "btnResetAreaHeight";
            this.btnResetAreaHeight.Size = new System.Drawing.Size(180, 33);
            this.btnResetAreaHeight.TabIndex = 107;
            this.btnResetAreaHeight.Text = "ResetArea(Height)";
            this.btnResetAreaHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetAreaHeight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetAreaHeight.UseVisualStyleBackColor = true;
            this.btnResetAreaHeight.Click += new System.EventHandler(this.btnResetAreaHeight_Click);
            // 
            // label34
            // 
            this.label34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label34.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(1083, 581);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(57, 23);
            this.label34.TabIndex = 109;
            this.label34.Text = "BOTTOM";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_InspArea_Bottom
            // 
            this.lbl_InspArea_Bottom.BackColor = System.Drawing.Color.White;
            this.lbl_InspArea_Bottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_InspArea_Bottom.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_InspArea_Bottom.Location = new System.Drawing.Point(1141, 581);
            this.lbl_InspArea_Bottom.Name = "lbl_InspArea_Bottom";
            this.lbl_InspArea_Bottom.Size = new System.Drawing.Size(122, 23);
            this.lbl_InspArea_Bottom.TabIndex = 110;
            this.lbl_InspArea_Bottom.Text = "00";
            this.lbl_InspArea_Bottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label33.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(902, 536);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(361, 22);
            this.label33.TabIndex = 111;
            this.label33.Text = "INSP AREA(Pattern)";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label39
            // 
            this.label39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label39.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label39.ForeColor = System.Drawing.Color.White;
            this.label39.Location = new System.Drawing.Point(1083, 558);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(57, 23);
            this.label39.TabIndex = 112;
            this.label39.Text = "TOP";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label53
            // 
            this.label53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label53.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label53.ForeColor = System.Drawing.Color.White;
            this.label53.Location = new System.Drawing.Point(902, 581);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(57, 23);
            this.label53.TabIndex = 113;
            this.label53.Text = "RIGHT";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_InspArea_Right
            // 
            this.lbl_InspArea_Right.BackColor = System.Drawing.Color.White;
            this.lbl_InspArea_Right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_InspArea_Right.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_InspArea_Right.Location = new System.Drawing.Point(960, 581);
            this.lbl_InspArea_Right.Name = "lbl_InspArea_Right";
            this.lbl_InspArea_Right.Size = new System.Drawing.Size(122, 23);
            this.lbl_InspArea_Right.TabIndex = 114;
            this.lbl_InspArea_Right.Text = "00";
            this.lbl_InspArea_Right.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_InspArea_Top
            // 
            this.lbl_InspArea_Top.BackColor = System.Drawing.Color.White;
            this.lbl_InspArea_Top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_InspArea_Top.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_InspArea_Top.Location = new System.Drawing.Point(1141, 558);
            this.lbl_InspArea_Top.Name = "lbl_InspArea_Top";
            this.lbl_InspArea_Top.Size = new System.Drawing.Size(122, 23);
            this.lbl_InspArea_Top.TabIndex = 115;
            this.lbl_InspArea_Top.Text = "00";
            this.lbl_InspArea_Top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label31.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(902, 558);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(57, 23);
            this.label31.TabIndex = 116;
            this.label31.Text = "LEFT";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_InspArea_Left
            // 
            this.lbl_InspArea_Left.BackColor = System.Drawing.Color.White;
            this.lbl_InspArea_Left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_InspArea_Left.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_InspArea_Left.Location = new System.Drawing.Point(960, 558);
            this.lbl_InspArea_Left.Name = "lbl_InspArea_Left";
            this.lbl_InspArea_Left.Size = new System.Drawing.Size(122, 23);
            this.lbl_InspArea_Left.TabIndex = 117;
            this.lbl_InspArea_Left.Text = "00";
            this.lbl_InspArea_Left.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1083, 629);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 120;
            this.label4.Text = "Y";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(902, 629);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 122;
            this.label3.Text = "X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(902, 605);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(361, 23);
            this.label12.TabIndex = 121;
            this.label12.Text = "INSP AREA(Height)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_InspArea_Z_X
            // 
            this.lbl_InspArea_Z_X.BackColor = System.Drawing.Color.White;
            this.lbl_InspArea_Z_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_InspArea_Z_X.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_InspArea_Z_X.Location = new System.Drawing.Point(960, 629);
            this.lbl_InspArea_Z_X.Name = "lbl_InspArea_Z_X";
            this.lbl_InspArea_Z_X.Size = new System.Drawing.Size(122, 23);
            this.lbl_InspArea_Z_X.TabIndex = 118;
            this.lbl_InspArea_Z_X.Text = "00";
            this.lbl_InspArea_Z_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_InspArea_Z_Y
            // 
            this.lbl_InspArea_Z_Y.BackColor = System.Drawing.Color.White;
            this.lbl_InspArea_Z_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_InspArea_Z_Y.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_InspArea_Z_Y.Location = new System.Drawing.Point(1141, 629);
            this.lbl_InspArea_Z_Y.Name = "lbl_InspArea_Z_Y";
            this.lbl_InspArea_Z_Y.Size = new System.Drawing.Size(122, 23);
            this.lbl_InspArea_Z_Y.TabIndex = 119;
            this.lbl_InspArea_Z_Y.Text = "00";
            this.lbl_InspArea_Z_Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Spec_X
            // 
            this.Spec_X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Spec_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Spec_X.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Spec_X.ForeColor = System.Drawing.Color.White;
            this.Spec_X.Location = new System.Drawing.Point(903, 916);
            this.Spec_X.Name = "Spec_X";
            this.Spec_X.Size = new System.Drawing.Size(70, 23);
            this.Spec_X.TabIndex = 124;
            this.Spec_X.Text = "Height";
            this.Spec_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSpec_MIN
            // 
            this.txtSpec_MIN.BackColor = System.Drawing.Color.Black;
            this.txtSpec_MIN.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSpec_MIN.ForeColor = System.Drawing.Color.White;
            this.txtSpec_MIN.Location = new System.Drawing.Point(974, 915);
            this.txtSpec_MIN.Name = "txtSpec_MIN";
            this.txtSpec_MIN.Size = new System.Drawing.Size(96, 25);
            this.txtSpec_MIN.TabIndex = 131;
            this.txtSpec_MIN.Text = "00";
            this.txtSpec_MIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSpec_MAX
            // 
            this.txtSpec_MAX.BackColor = System.Drawing.Color.Black;
            this.txtSpec_MAX.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSpec_MAX.ForeColor = System.Drawing.Color.White;
            this.txtSpec_MAX.Location = new System.Drawing.Point(1070, 915);
            this.txtSpec_MAX.Name = "txtSpec_MAX";
            this.txtSpec_MAX.Size = new System.Drawing.Size(96, 25);
            this.txtSpec_MAX.TabIndex = 127;
            this.txtSpec_MAX.Text = "00";
            this.txtSpec_MAX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label40
            // 
            this.label40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label40.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label40.ForeColor = System.Drawing.Color.White;
            this.label40.Location = new System.Drawing.Point(1070, 892);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(96, 22);
            this.label40.TabIndex = 134;
            this.label40.Text = "MAX";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label68
            // 
            this.label68.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label68.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label68.ForeColor = System.Drawing.Color.White;
            this.label68.Location = new System.Drawing.Point(974, 892);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(96, 22);
            this.label68.TabIndex = 133;
            this.label68.Text = "MIN";
            this.label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(1142, 676);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 21);
            this.label14.TabIndex = 141;
            this.label14.Text = "Z";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(1022, 676);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 21);
            this.label15.TabIndex = 140;
            this.label15.Text = "Y";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(902, 676);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 21);
            this.label16.TabIndex = 139;
            this.label16.Text = "X";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(902, 653);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(360, 23);
            this.label13.TabIndex = 138;
            this.label13.Text = "기준좌표 Master";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaster_X
            // 
            this.lblMaster_X.BackColor = System.Drawing.Color.White;
            this.lblMaster_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMaster_X.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaster_X.Location = new System.Drawing.Point(935, 676);
            this.lblMaster_X.Name = "lblMaster_X";
            this.lblMaster_X.Size = new System.Drawing.Size(87, 21);
            this.lblMaster_X.TabIndex = 136;
            this.lblMaster_X.Text = "00";
            this.lblMaster_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaster_Y
            // 
            this.lblMaster_Y.BackColor = System.Drawing.Color.White;
            this.lblMaster_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMaster_Y.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaster_Y.Location = new System.Drawing.Point(1055, 676);
            this.lblMaster_Y.Name = "lblMaster_Y";
            this.lblMaster_Y.Size = new System.Drawing.Size(87, 21);
            this.lblMaster_Y.TabIndex = 135;
            this.lblMaster_Y.Text = "00";
            this.lblMaster_Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaster_Z
            // 
            this.lblMaster_Z.BackColor = System.Drawing.Color.White;
            this.lblMaster_Z.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMaster_Z.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaster_Z.Location = new System.Drawing.Point(1175, 676);
            this.lblMaster_Z.Name = "lblMaster_Z";
            this.lblMaster_Z.Size = new System.Drawing.Size(87, 21);
            this.lblMaster_Z.TabIndex = 137;
            this.lblMaster_Z.Text = "00";
            this.lblMaster_Z.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(903, 868);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(359, 23);
            this.label6.TabIndex = 138;
            this.label6.Text = "판정 기준";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(903, 892);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 124;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_InspResult_Z
            // 
            this.lbl_InspResult_Z.BackColor = System.Drawing.Color.White;
            this.lbl_InspResult_Z.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_InspResult_Z.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_InspResult_Z.Location = new System.Drawing.Point(1084, 359);
            this.lbl_InspResult_Z.Name = "lbl_InspResult_Z";
            this.lbl_InspResult_Z.Size = new System.Drawing.Size(179, 23);
            this.lbl_InspResult_Z.TabIndex = 149;
            this.lbl_InspResult_Z.Text = "00";
            this.lbl_InspResult_Z.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Insp_Z
            // 
            this.Insp_Z.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Insp_Z.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Insp_Z.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Insp_Z.ForeColor = System.Drawing.Color.White;
            this.Insp_Z.Location = new System.Drawing.Point(1013, 359);
            this.Insp_Z.Name = "Insp_Z";
            this.Insp_Z.Size = new System.Drawing.Size(70, 23);
            this.Insp_Z.TabIndex = 148;
            this.Insp_Z.Text = "Z";
            this.Insp_Z.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_InspResult_Y
            // 
            this.lbl_InspResult_Y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_InspResult_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_InspResult_Y.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_InspResult_Y.Location = new System.Drawing.Point(1084, 335);
            this.lbl_InspResult_Y.Name = "lbl_InspResult_Y";
            this.lbl_InspResult_Y.Size = new System.Drawing.Size(179, 23);
            this.lbl_InspResult_Y.TabIndex = 151;
            this.lbl_InspResult_Y.Text = "00";
            this.lbl_InspResult_Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Insp_Y
            // 
            this.Insp_Y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Insp_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Insp_Y.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Insp_Y.ForeColor = System.Drawing.Color.White;
            this.Insp_Y.Location = new System.Drawing.Point(1013, 335);
            this.Insp_Y.Name = "Insp_Y";
            this.Insp_Y.Size = new System.Drawing.Size(70, 23);
            this.Insp_Y.TabIndex = 150;
            this.Insp_Y.Text = "Y";
            this.Insp_Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_InspResult_X
            // 
            this.lbl_InspResult_X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_InspResult_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_InspResult_X.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_InspResult_X.Location = new System.Drawing.Point(1084, 311);
            this.lbl_InspResult_X.Name = "lbl_InspResult_X";
            this.lbl_InspResult_X.Size = new System.Drawing.Size(179, 23);
            this.lbl_InspResult_X.TabIndex = 146;
            this.lbl_InspResult_X.Text = "00";
            this.lbl_InspResult_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Insp_X
            // 
            this.Insp_X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Insp_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Insp_X.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Insp_X.ForeColor = System.Drawing.Color.White;
            this.Insp_X.Location = new System.Drawing.Point(1013, 311);
            this.Insp_X.Name = "Insp_X";
            this.Insp_X.Size = new System.Drawing.Size(70, 23);
            this.Insp_X.TabIndex = 145;
            this.Insp_X.Text = "X";
            this.Insp_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(903, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 71);
            this.label8.TabIndex = 147;
            this.label8.Text = "Insp\r\nResult";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSFPath
            // 
            this.lblSFPath.BackColor = System.Drawing.Color.White;
            this.lblSFPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSFPath.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblSFPath.Location = new System.Drawing.Point(902, 697);
            this.lblSFPath.Name = "lblSFPath";
            this.lblSFPath.Size = new System.Drawing.Size(360, 51);
            this.lblSFPath.TabIndex = 136;
            this.lblSFPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1166, 892);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 22);
            this.label5.TabIndex = 134;
            this.label5.Text = "OFFSET";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSpec_OFFSET
            // 
            this.txtSpec_OFFSET.BackColor = System.Drawing.Color.Black;
            this.txtSpec_OFFSET.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSpec_OFFSET.ForeColor = System.Drawing.Color.White;
            this.txtSpec_OFFSET.Location = new System.Drawing.Point(1166, 915);
            this.txtSpec_OFFSET.Name = "txtSpec_OFFSET";
            this.txtSpec_OFFSET.Size = new System.Drawing.Size(96, 25);
            this.txtSpec_OFFSET.TabIndex = 127;
            this.txtSpec_OFFSET.Text = "00";
            this.txtSpec_OFFSET.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // axCVimageMono8
            // 
            this.axCVimageMono8.Enabled = true;
            this.axCVimageMono8.Location = new System.Drawing.Point(859, 11);
            this.axCVimageMono8.Name = "axCVimageMono8";
            this.axCVimageMono8.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCVimageMono8.OcxState")));
            this.axCVimageMono8.Size = new System.Drawing.Size(32, 32);
            this.axCVimageMono8.TabIndex = 144;
            // 
            // axCVimageLoad
            // 
            this.axCVimageLoad.Enabled = true;
            this.axCVimageLoad.Location = new System.Drawing.Point(821, 11);
            this.axCVimageLoad.Name = "axCVimageLoad";
            this.axCVimageLoad.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCVimageLoad.OcxState")));
            this.axCVimageLoad.Size = new System.Drawing.Size(32, 32);
            this.axCVimageLoad.TabIndex = 143;
            // 
            // axCVimageMono16
            // 
            this.axCVimageMono16.Enabled = true;
            this.axCVimageMono16.Location = new System.Drawing.Point(783, 11);
            this.axCVimageMono16.Name = "axCVimageMono16";
            this.axCVimageMono16.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCVimageMono16.OcxState")));
            this.axCVimageMono16.Size = new System.Drawing.Size(32, 32);
            this.axCVimageMono16.TabIndex = 142;
            // 
            // axCVdisplay3
            // 
            this.axCVdisplay3.Location = new System.Drawing.Point(711, 656);
            this.axCVdisplay3.Margin = new System.Windows.Forms.Padding(2);
            this.axCVdisplay3.Name = "axCVdisplay3";
            this.axCVdisplay3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCVdisplay3.OcxState")));
            this.axCVdisplay3.Padding = new System.Windows.Forms.Padding(2);
            this.axCVdisplay3.Size = new System.Drawing.Size(190, 284);
            this.axCVdisplay3.TabIndex = 79;
            this.axCVdisplay3.Visible = false;
            // 
            // axCVdisplay2
            // 
            this.axCVdisplay2.Location = new System.Drawing.Point(1, 656);
            this.axCVdisplay2.Margin = new System.Windows.Forms.Padding(2);
            this.axCVdisplay2.Name = "axCVdisplay2";
            this.axCVdisplay2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCVdisplay2.OcxState")));
            this.axCVdisplay2.Padding = new System.Windows.Forms.Padding(2);
            this.axCVdisplay2.Size = new System.Drawing.Size(190, 284);
            this.axCVdisplay2.TabIndex = 78;
            this.axCVdisplay2.Visible = false;
            // 
            // axCVdisplay1
            // 
            this.axCVdisplay1.Location = new System.Drawing.Point(1, 1);
            this.axCVdisplay1.Margin = new System.Windows.Forms.Padding(2);
            this.axCVdisplay1.Name = "axCVdisplay1";
            this.axCVdisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCVdisplay1.OcxState")));
            this.axCVdisplay1.Padding = new System.Windows.Forms.Padding(2);
            this.axCVdisplay1.Size = new System.Drawing.Size(900, 939);
            this.axCVdisplay1.TabIndex = 77;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(903, 844);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 23);
            this.label10.TabIndex = 116;
            this.label10.Text = "Center to H Pos";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(1084, 843);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 25);
            this.textBox1.TabIndex = 131;
            this.textBox1.Text = "00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmModelSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1264, 941);
            this.Controls.Add(this.lbl_InspResult_Z);
            this.Controls.Add(this.Insp_Z);
            this.Controls.Add(this.lbl_InspResult_Y);
            this.Controls.Add(this.Insp_Y);
            this.Controls.Add(this.lbl_InspResult_X);
            this.Controls.Add(this.Insp_X);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.axCVimageMono8);
            this.Controls.Add(this.axCVimageLoad);
            this.Controls.Add(this.axCVimageMono16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblSFPath);
            this.Controls.Add(this.lblMaster_X);
            this.Controls.Add(this.lblMaster_Y);
            this.Controls.Add(this.lblMaster_Z);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Spec_X);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtSpec_MIN);
            this.Controls.Add(this.txtSpec_OFFSET);
            this.Controls.Add(this.txtSpec_MAX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label68);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_InspArea_Z_X);
            this.Controls.Add(this.lbl_InspArea_Z_Y);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.lbl_InspArea_Bottom);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.lbl_InspArea_Right);
            this.Controls.Add(this.lbl_InspArea_Top);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.lbl_InspArea_Left);
            this.Controls.Add(this.btnResetAreaPTN);
            this.Controls.Add(this.btnResetAreaHeight);
            this.Controls.Add(this.btnMasterLoad);
            this.Controls.Add(this.btnMasterFind);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.btnInspAreaDisplayHeight);
            this.Controls.Add(this.btnInspAreaDisplay);
            this.Controls.Add(this.lbl_INSPResult_Total);
            this.Controls.Add(this.chkAuto);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnRunInspection);
            this.Controls.Add(this.lblCurrentCount);
            this.Controls.Add(this.lblOpenFilePath);
            this.Controls.Add(this.btnImageLoad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboModel);
            this.Controls.Add(this.cboInspNo);
            this.Controls.Add(this.axCVdisplay3);
            this.Controls.Add(this.axCVdisplay2);
            this.Controls.Add(this.axCVdisplay1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmModelSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Model Setting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmModelSetting_FormClosing);
            this.Load += new System.EventHandler(this.frmModelSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axCVimageMono8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCVimageLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCVimageMono16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCVdisplay3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCVdisplay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCVdisplay1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxCVDISPLAYLib.AxCVdisplay axCVdisplay3;
        private AxCVDISPLAYLib.AxCVdisplay axCVdisplay2;
        private AxCVDISPLAYLib.AxCVdisplay axCVdisplay1;
        private System.Windows.Forms.Button btnImageLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboModel;
        private System.Windows.Forms.ComboBox cboInspNo;
        private System.Windows.Forms.Label lbl_INSPResult_Total;
        private System.Windows.Forms.CheckBox chkAuto;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnRunInspection;
        private System.Windows.Forms.Label lblCurrentCount;
        private System.Windows.Forms.Label lblOpenFilePath;
        private System.Windows.Forms.Button btnMasterLoad;
        private System.Windows.Forms.Button btnMasterFind;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnInspAreaDisplayHeight;
        private System.Windows.Forms.Button btnInspAreaDisplay;
        private System.Windows.Forms.Button btnResetAreaPTN;
        private System.Windows.Forms.Button btnResetAreaHeight;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lbl_InspArea_Bottom;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label lbl_InspArea_Right;
        private System.Windows.Forms.Label lbl_InspArea_Top;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lbl_InspArea_Left;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_InspArea_Z_X;
        private System.Windows.Forms.Label lbl_InspArea_Z_Y;
        private System.Windows.Forms.Label Spec_X;
        private System.Windows.Forms.TextBox txtSpec_MIN;
        private System.Windows.Forms.TextBox txtSpec_MAX;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblMaster_X;
        private System.Windows.Forms.Label lblMaster_Y;
        private System.Windows.Forms.Label lblMaster_Z;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private AxCVIMAGELib.AxCVimage axCVimageMono16;
        private AxCVIMAGELib.AxCVimage axCVimageLoad;
        private AxCVIMAGELib.AxCVimage axCVimageMono8;
        private System.Windows.Forms.Label lbl_InspResult_Z;
        private System.Windows.Forms.Label Insp_Z;
        private System.Windows.Forms.Label lbl_InspResult_Y;
        private System.Windows.Forms.Label Insp_Y;
        private System.Windows.Forms.Label lbl_InspResult_X;
        private System.Windows.Forms.Label Insp_X;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSFPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSpec_OFFSET;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
    }
}
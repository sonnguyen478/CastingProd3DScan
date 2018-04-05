namespace CastingProd3DScan
{
    partial class frmServoSetting
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
            this.label49 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnAxis01_Move01 = new System.Windows.Forms.Button();
            this.txtAxis01_Spd01 = new System.Windows.Forms.TextBox();
            this.txtAxis01_Pos01 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDCCL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtACCL = new System.Windows.Forms.TextBox();
            this.groupBox8.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.SuspendLayout();
            // 
            // label49
            // 
            this.label49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label49.Dock = System.Windows.Forms.DockStyle.Top;
            this.label49.Font = new System.Drawing.Font("HY견고딕", 14.25F);
            this.label49.ForeColor = System.Drawing.Color.White;
            this.label49.Location = new System.Drawing.Point(0, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(404, 54);
            this.label49.TabIndex = 6;
            this.label49.Text = "  Motion Settings";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("HY견고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = global::CastingProd3DScan.Properties.Resources.exit_24x24_;
            this.btnClose.Location = new System.Drawing.Point(304, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 34);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Black;
            this.groupBox8.Controls.Add(this.groupBox14);
            this.groupBox8.Controls.Add(this.btnAxis01_Move01);
            this.groupBox8.Controls.Add(this.txtAxis01_Spd01);
            this.groupBox8.Controls.Add(this.txtAxis01_Pos01);
            this.groupBox8.Controls.Add(this.label40);
            this.groupBox8.Controls.Add(this.label41);
            this.groupBox8.Controls.Add(this.label42);
            this.groupBox8.Font = new System.Drawing.Font("HY견고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox8.ForeColor = System.Drawing.Color.White;
            this.groupBox8.Location = new System.Drawing.Point(10, 57);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(384, 151);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Position Data";
            // 
            // btnAxis01_Move01
            // 
            this.btnAxis01_Move01.Font = new System.Drawing.Font("HY견고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAxis01_Move01.ForeColor = System.Drawing.Color.Black;
            this.btnAxis01_Move01.Location = new System.Drawing.Point(298, 58);
            this.btnAxis01_Move01.Name = "btnAxis01_Move01";
            this.btnAxis01_Move01.Size = new System.Drawing.Size(81, 28);
            this.btnAxis01_Move01.TabIndex = 2;
            this.btnAxis01_Move01.Text = "Move";
            this.btnAxis01_Move01.UseVisualStyleBackColor = true;
            this.btnAxis01_Move01.Click += new System.EventHandler(this.btnAxis01_Move01_Click);
            // 
            // txtAxis01_Spd01
            // 
            this.txtAxis01_Spd01.BackColor = System.Drawing.Color.Black;
            this.txtAxis01_Spd01.Font = new System.Drawing.Font("HY견고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtAxis01_Spd01.ForeColor = System.Drawing.Color.Yellow;
            this.txtAxis01_Spd01.Location = new System.Drawing.Point(208, 59);
            this.txtAxis01_Spd01.Name = "txtAxis01_Spd01";
            this.txtAxis01_Spd01.Size = new System.Drawing.Size(89, 26);
            this.txtAxis01_Spd01.TabIndex = 1;
            this.txtAxis01_Spd01.Text = "0.00";
            this.txtAxis01_Spd01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAxis01_Pos01
            // 
            this.txtAxis01_Pos01.BackColor = System.Drawing.Color.Black;
            this.txtAxis01_Pos01.Font = new System.Drawing.Font("HY견고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtAxis01_Pos01.ForeColor = System.Drawing.Color.Yellow;
            this.txtAxis01_Pos01.Location = new System.Drawing.Point(117, 59);
            this.txtAxis01_Pos01.Name = "txtAxis01_Pos01";
            this.txtAxis01_Pos01.Size = new System.Drawing.Size(89, 26);
            this.txtAxis01_Pos01.TabIndex = 1;
            this.txtAxis01_Pos01.Text = "0.00";
            this.txtAxis01_Pos01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label40
            // 
            this.label40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label40.Font = new System.Drawing.Font("HY견고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label40.Location = new System.Drawing.Point(208, 30);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(89, 26);
            this.label40.TabIndex = 0;
            this.label40.Text = "Speed";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label41
            // 
            this.label41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label41.Font = new System.Drawing.Font("HY견고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label41.Location = new System.Drawing.Point(117, 30);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(89, 26);
            this.label41.TabIndex = 0;
            this.label41.Text = "Position";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label42
            // 
            this.label42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label42.Font = new System.Drawing.Font("HY견고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label42.Location = new System.Drawing.Point(6, 59);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(109, 26);
            this.label42.TabIndex = 0;
            this.label42.Text = "Move POS";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox14
            // 
            this.groupBox14.BackColor = System.Drawing.Color.Black;
            this.groupBox14.Controls.Add(this.label4);
            this.groupBox14.Controls.Add(this.txtDCCL);
            this.groupBox14.Controls.Add(this.label3);
            this.groupBox14.Controls.Add(this.txtACCL);
            this.groupBox14.Font = new System.Drawing.Font("HY견고딕", 11.25F);
            this.groupBox14.ForeColor = System.Drawing.Color.White;
            this.groupBox14.Location = new System.Drawing.Point(6, 92);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(373, 45);
            this.groupBox14.TabIndex = 9;
            this.groupBox14.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("HY견고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "ACCL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDCCL
            // 
            this.txtDCCL.BackColor = System.Drawing.Color.Black;
            this.txtDCCL.Font = new System.Drawing.Font("HY견고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDCCL.ForeColor = System.Drawing.Color.Yellow;
            this.txtDCCL.Location = new System.Drawing.Point(271, 17);
            this.txtDCCL.Name = "txtDCCL";
            this.txtDCCL.Size = new System.Drawing.Size(92, 22);
            this.txtDCCL.TabIndex = 1;
            this.txtDCCL.Text = "0.00";
            this.txtDCCL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("HY견고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(189, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "DCCL";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtACCL
            // 
            this.txtACCL.BackColor = System.Drawing.Color.Black;
            this.txtACCL.Font = new System.Drawing.Font("HY견고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtACCL.ForeColor = System.Drawing.Color.Yellow;
            this.txtACCL.Location = new System.Drawing.Point(92, 17);
            this.txtACCL.Name = "txtACCL";
            this.txtACCL.Size = new System.Drawing.Size(92, 22);
            this.txtACCL.TabIndex = 1;
            this.txtACCL.Text = "0.00";
            this.txtACCL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmServoSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(404, 215);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label49);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmServoSetting";
            this.Text = "frmServoSetting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServoSetting_FormClosing);
            this.Load += new System.EventHandler(this.frmServoSetting_Load);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnAxis01_Move01;
        private System.Windows.Forms.TextBox txtAxis01_Spd01;
        private System.Windows.Forms.TextBox txtAxis01_Pos01;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDCCL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtACCL;
    }
}
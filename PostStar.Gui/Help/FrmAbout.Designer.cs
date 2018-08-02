namespace PostStar.Gui.Help
{
    partial class FrmAbout
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.llLicense = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSendBugReport = new System.Windows.Forms.Button();
            this.btnSendMoreFunctionReport = new System.Windows.Forms.Button();
            this.btnCheerUp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "POST-STAR (ver 0.9)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.linkLabel1.Location = new System.Drawing.Point(159, 39);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(154, 17);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.post-star.co.kr";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // llLicense
            // 
            this.llLicense.AutoSize = true;
            this.llLicense.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.llLicense.Location = new System.Drawing.Point(152, 56);
            this.llLicense.Name = "llLicense";
            this.llLicense.Size = new System.Drawing.Size(161, 17);
            this.llLicense.TabIndex = 3;
            this.llLicense.TabStop = true;
            this.llLicense.Text = "License : Apache 2.0";
            this.llLicense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLicense_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(6, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "History";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 219);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(304, 82);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "왜 만들었나?\r\n-->\r\n어떻게 만들어나?\r\n-->\r\n앞으로는?\r\n-->\r\n";
            // 
            // btnSendBugReport
            // 
            this.btnSendBugReport.Location = new System.Drawing.Point(157, 318);
            this.btnSendBugReport.Name = "btnSendBugReport";
            this.btnSendBugReport.Size = new System.Drawing.Size(156, 59);
            this.btnSendBugReport.TabIndex = 7;
            this.btnSendBugReport.Text = "버그 알려주기";
            this.btnSendBugReport.UseVisualStyleBackColor = true;
            this.btnSendBugReport.Click += new System.EventHandler(this.btnSendBugReport_Click);
            // 
            // btnSendMoreFunctionReport
            // 
            this.btnSendMoreFunctionReport.Location = new System.Drawing.Point(157, 390);
            this.btnSendMoreFunctionReport.Name = "btnSendMoreFunctionReport";
            this.btnSendMoreFunctionReport.Size = new System.Drawing.Size(156, 59);
            this.btnSendMoreFunctionReport.TabIndex = 8;
            this.btnSendMoreFunctionReport.Text = "추가기능 요청하기";
            this.btnSendMoreFunctionReport.UseVisualStyleBackColor = true;
            this.btnSendMoreFunctionReport.Click += new System.EventHandler(this.btnSendMoreFunctionReport_Click);
            // 
            // btnCheerUp
            // 
            this.btnCheerUp.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCheerUp.Image = global::PostStar.Gui.Properties.Resources.CheerupIcon;
            this.btnCheerUp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCheerUp.Location = new System.Drawing.Point(9, 318);
            this.btnCheerUp.Name = "btnCheerUp";
            this.btnCheerUp.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.btnCheerUp.Size = new System.Drawing.Size(134, 131);
            this.btnCheerUp.TabIndex = 6;
            this.btnCheerUp.Text = "응원하기";
            this.btnCheerUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCheerUp.UseVisualStyleBackColor = true;
            this.btnCheerUp.Click += new System.EventHandler(this.btnCheerUp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PostStar.Gui.Properties.Resources.ic_grade_black_36dp;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 89);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(9, 92);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(304, 79);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Copyright(C) 2018 SINE, All rights reserved.\r\n\r\n이 프로그램은 저작권법과 국제협약의 보호를 받습니다. 이 프" +
    "로그램의 전부 또는 일부를 무단으로 사용, 복제, 배포하는 행위는 민사, 형사법에 의해 엄격히 규제되고 있으며, 기소사유가 됩니다.";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 461);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnSendMoreFunctionReport);
            this.Controls.Add(this.btnSendBugReport);
            this.Controls.Add(this.btnCheerUp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.llLicense);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "About";
            this.Load += new System.EventHandler(this.FrmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel llLicense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCheerUp;
        private System.Windows.Forms.Button btnSendBugReport;
        private System.Windows.Forms.Button btnSendMoreFunctionReport;
        private System.Windows.Forms.TextBox textBox2;
    }
}
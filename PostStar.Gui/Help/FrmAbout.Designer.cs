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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCheerUp = new System.Windows.Forms.Button();
            this.btnSendBugReport = new System.Windows.Forms.Button();
            this.btnSendMoreFunctionReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PostStar.Gui.Properties.Resources.ic_grade_black_48dp;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "POST-STAR (ver 0.9)";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.linkLabel1.Location = new System.Drawing.Point(115, 39);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(154, 17);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.post-star.co.kr";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.linkLabel2.Location = new System.Drawing.Point(115, 56);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(161, 17);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "License : Apache 2.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "History";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 174);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(304, 127);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "왜 만들었나?\r\n-->\r\n어떻게 만들어나?\r\n-->\r\n앞으로는?\r\n-->\r\n";
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
            // 
            // btnSendBugReport
            // 
            this.btnSendBugReport.Location = new System.Drawing.Point(157, 318);
            this.btnSendBugReport.Name = "btnSendBugReport";
            this.btnSendBugReport.Size = new System.Drawing.Size(156, 59);
            this.btnSendBugReport.TabIndex = 7;
            this.btnSendBugReport.Text = "버그 알려주기";
            this.btnSendBugReport.UseVisualStyleBackColor = true;
            // 
            // btnSendMoreFunctionReport
            // 
            this.btnSendMoreFunctionReport.Location = new System.Drawing.Point(157, 390);
            this.btnSendMoreFunctionReport.Name = "btnSendMoreFunctionReport";
            this.btnSendMoreFunctionReport.Size = new System.Drawing.Size(156, 59);
            this.btnSendMoreFunctionReport.TabIndex = 8;
            this.btnSendMoreFunctionReport.Text = "추가기능 요청하기";
            this.btnSendMoreFunctionReport.UseVisualStyleBackColor = true;
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 461);
            this.Controls.Add(this.btnSendMoreFunctionReport);
            this.Controls.Add(this.btnSendBugReport);
            this.Controls.Add(this.btnCheerUp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCheerUp;
        private System.Windows.Forms.Button btnSendBugReport;
        private System.Windows.Forms.Button btnSendMoreFunctionReport;
    }
}
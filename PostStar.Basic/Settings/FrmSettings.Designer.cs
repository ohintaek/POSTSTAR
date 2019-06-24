namespace PostStar.Basic.Settings
{
    partial class FrmSettings
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
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.cbAutoRun = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxRecentMessage = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbSendFailOption_None = new System.Windows.Forms.RadioButton();
            this.rbSendFailOption_Retry = new System.Windows.Forms.RadioButton();
            this.cbAlertOption_Display = new System.Windows.Forms.CheckBox();
            this.cbAlertOption_UseSound = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(341, 367);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 31);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "적용";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(422, 367);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "나는";
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(50, 32);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(447, 25);
            this.txtNickName.TabIndex = 3;
            // 
            // cbAutoRun
            // 
            this.cbAutoRun.AutoSize = true;
            this.cbAutoRun.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbAutoRun.Location = new System.Drawing.Point(15, 323);
            this.cbAutoRun.Name = "cbAutoRun";
            this.cbAutoRun.Size = new System.Drawing.Size(211, 19);
            this.cbAutoRun.TabIndex = 4;
            this.cbAutoRun.Text = "Window 시작시 자동실행";
            this.cbAutoRun.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "트레이아이콘 메뉴에 받은메시지 바로가기";
            // 
            // cbxRecentMessage
            // 
            this.cbxRecentMessage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRecentMessage.FormattingEnabled = true;
            this.cbxRecentMessage.Items.AddRange(new object[] {
            "최근 3개",
            "최근 5개",
            "최근 10개"});
            this.cbxRecentMessage.Location = new System.Drawing.Point(331, 182);
            this.cbxRecentMessage.Name = "cbxRecentMessage";
            this.cbxRecentMessage.Size = new System.Drawing.Size(121, 23);
            this.cbxRecentMessage.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(458, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "표시";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "메시지 보내기 실패하면";
            // 
            // rbSendFailOption_None
            // 
            this.rbSendFailOption_None.AutoSize = true;
            this.rbSendFailOption_None.Location = new System.Drawing.Point(50, 251);
            this.rbSendFailOption_None.Name = "rbSendFailOption_None";
            this.rbSendFailOption_None.Size = new System.Drawing.Size(143, 19);
            this.rbSendFailOption_None.TabIndex = 11;
            this.rbSendFailOption_None.TabStop = true;
            this.rbSendFailOption_None.Text = "다시 보내지 않음";
            this.rbSendFailOption_None.UseVisualStyleBackColor = true;
            // 
            // rbSendFailOption_Retry
            // 
            this.rbSendFailOption_Retry.AutoSize = true;
            this.rbSendFailOption_Retry.Location = new System.Drawing.Point(50, 276);
            this.rbSendFailOption_Retry.Name = "rbSendFailOption_Retry";
            this.rbSendFailOption_Retry.Size = new System.Drawing.Size(171, 19);
            this.rbSendFailOption_Retry.TabIndex = 12;
            this.rbSendFailOption_Retry.TabStop = true;
            this.rbSendFailOption_Retry.Text = "1분 후 다시 전송시도";
            this.rbSendFailOption_Retry.UseVisualStyleBackColor = true;
            // 
            // cbAlertOption_Display
            // 
            this.cbAlertOption_Display.AutoSize = true;
            this.cbAlertOption_Display.Location = new System.Drawing.Point(50, 115);
            this.cbAlertOption_Display.Name = "cbAlertOption_Display";
            this.cbAlertOption_Display.Size = new System.Drawing.Size(224, 19);
            this.cbAlertOption_Display.TabIndex = 6;
            this.cbAlertOption_Display.Text = "받은메시지 즉시 화면에 표시";
            this.cbAlertOption_Display.UseVisualStyleBackColor = true;
            // 
            // cbAlertOption_UseSound
            // 
            this.cbAlertOption_UseSound.AutoSize = true;
            this.cbAlertOption_UseSound.Location = new System.Drawing.Point(50, 140);
            this.cbAlertOption_UseSound.Name = "cbAlertOption_UseSound";
            this.cbAlertOption_UseSound.Size = new System.Drawing.Size(144, 19);
            this.cbAlertOption_UseSound.TabIndex = 8;
            this.cbAlertOption_UseSound.Text = "수신 알림음 사용";
            this.cbAlertOption_UseSound.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(12, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "메시지를 받으면";
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 410);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbAlertOption_UseSound);
            this.Controls.Add(this.rbSendFailOption_Retry);
            this.Controls.Add(this.cbAlertOption_Display);
            this.Controls.Add(this.rbSendFailOption_None);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxRecentMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAutoRun);
            this.Controls.Add(this.txtNickName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.CheckBox cbAutoRun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxRecentMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbSendFailOption_None;
        private System.Windows.Forms.RadioButton rbSendFailOption_Retry;
        private System.Windows.Forms.CheckBox cbAlertOption_Display;
        private System.Windows.Forms.CheckBox cbAlertOption_UseSound;
        private System.Windows.Forms.Label label5;
    }
}
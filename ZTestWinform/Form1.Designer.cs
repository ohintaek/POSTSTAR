namespace ZTestWinform
{
    partial class Form1
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbMessageBody = new RichTextBoxEx.RichTextBoxEx();
            this.button1 = new System.Windows.Forms.Button();
            this.rtbMessageBodyOutput = new RichTextBoxEx.RichTextBoxEx();
            this.SuspendLayout();
            // 
            // rtbMessageBody
            // 
            this.rtbMessageBody.AllowBullets = true;
            this.rtbMessageBody.AllowDefaultInsertText = true;
            this.rtbMessageBody.AllowDefaultSmartText = true;
            this.rtbMessageBody.AllowHyphenation = true;
            this.rtbMessageBody.AllowPictures = true;
            this.rtbMessageBody.AllowSpellCheck = false;
            this.rtbMessageBody.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.rtbMessageBody.FilePath = "";
            this.rtbMessageBody.Location = new System.Drawing.Point(1, 0);
            this.rtbMessageBody.Name = "rtbMessageBody";
            this.rtbMessageBody.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat{\\fonttbl{\\f0\\fnil\\fcharset0 Arial;}}\r\n{\\" +
    "*\\generator Riched20 10.0.17763}\\viewkind4\\uc1 \r\n\\pard\\fs20\\lang1042 richTextBox" +
    "Ex1\\par\r\n}\r\n";
            this.rtbMessageBody.SetColorWithFont = true;
            this.rtbMessageBody.ShowToolStrip = true;
            this.rtbMessageBody.Size = new System.Drawing.Size(415, 400);
            this.rtbMessageBody.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(719, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbMessageBodyOutput
            // 
            this.rtbMessageBodyOutput.AllowBullets = true;
            this.rtbMessageBodyOutput.AllowDefaultInsertText = true;
            this.rtbMessageBodyOutput.AllowDefaultSmartText = true;
            this.rtbMessageBodyOutput.AllowHyphenation = true;
            this.rtbMessageBodyOutput.AllowPictures = true;
            this.rtbMessageBodyOutput.AllowSpellCheck = false;
            this.rtbMessageBodyOutput.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.rtbMessageBodyOutput.FilePath = "";
            this.rtbMessageBodyOutput.Location = new System.Drawing.Point(422, 0);
            this.rtbMessageBodyOutput.Name = "rtbMessageBodyOutput";
            this.rtbMessageBodyOutput.Rtf = "{\\rtf1\\ansi\\ansicpg949\\deff0\\nouicompat\\deflang1033\\deflangfe1042{\\fonttbl{\\f0\\fn" +
    "il\\fcharset0 Arial;}}\r\n{\\*\\generator Riched20 10.0.17763}\\viewkind4\\uc1 \r\n\\pard\\" +
    "fs20\\lang1042\\par\r\n}\r\n";
            this.rtbMessageBodyOutput.SetColorWithFont = true;
            this.rtbMessageBodyOutput.ShowToolStrip = true;
            this.rtbMessageBodyOutput.Size = new System.Drawing.Size(366, 400);
            this.rtbMessageBodyOutput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbMessageBodyOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbMessageBody);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBoxEx.RichTextBoxEx rtbMessageBody;
        private System.Windows.Forms.Button button1;
        private RichTextBoxEx.RichTextBoxEx rtbMessageBodyOutput;
    }
}


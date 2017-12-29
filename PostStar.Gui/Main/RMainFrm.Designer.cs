namespace PostStar.Gui.Main
{
    partial class RMainFrm
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
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnMsgHistoryBox = new System.Windows.Forms.Button();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.lbxRecentMsgList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(-1, -1);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(284, 39);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "&About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(-1, 38);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(284, 39);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.Text = "Se&tting";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnMsgHistoryBox
            // 
            this.btnMsgHistoryBox.Location = new System.Drawing.Point(-1, 77);
            this.btnMsgHistoryBox.Name = "btnMsgHistoryBox";
            this.btnMsgHistoryBox.Size = new System.Drawing.Size(284, 39);
            this.btnMsgHistoryBox.TabIndex = 2;
            this.btnMsgHistoryBox.Text = "Message &History Box";
            this.btnMsgHistoryBox.UseVisualStyleBackColor = true;
            this.btnMsgHistoryBox.Click += new System.EventHandler(this.btnMsgHistoryBox_Click);
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(-1, 312);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(284, 86);
            this.btnSendMsg.TabIndex = 3;
            this.btnSendMsg.Text = "&Send Message";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // lbxRecentMsgList
            // 
            this.lbxRecentMsgList.FormattingEnabled = true;
            this.lbxRecentMsgList.ItemHeight = 15;
            this.lbxRecentMsgList.Location = new System.Drawing.Point(-1, 116);
            this.lbxRecentMsgList.Name = "lbxRecentMsgList";
            this.lbxRecentMsgList.Size = new System.Drawing.Size(284, 184);
            this.lbxRecentMsgList.TabIndex = 4;
            // 
            // RMainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 397);
            this.Controls.Add(this.lbxRecentMsgList);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.btnMsgHistoryBox);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RMainFrm";
            this.Text = "POST STAR";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnMsgHistoryBox;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.ListBox lbxRecentMsgList;
    }
}


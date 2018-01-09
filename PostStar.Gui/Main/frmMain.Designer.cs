namespace PostStar.Gui.Main
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnMsgHistoryBox = new System.Windows.Forms.Button();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lbxRecentMsgList = new System.Windows.Forms.ListBox();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAbout.Location = new System.Drawing.Point(3, 3);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(371, 34);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "&About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetting.Location = new System.Drawing.Point(3, 43);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(371, 34);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.Text = "Se&tting";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnMsgHistoryBox
            // 
            this.btnMsgHistoryBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMsgHistoryBox.Location = new System.Drawing.Point(3, 83);
            this.btnMsgHistoryBox.Name = "btnMsgHistoryBox";
            this.btnMsgHistoryBox.Size = new System.Drawing.Size(371, 34);
            this.btnMsgHistoryBox.TabIndex = 2;
            this.btnMsgHistoryBox.Text = "Message &History Box";
            this.btnMsgHistoryBox.UseVisualStyleBackColor = true;
            this.btnMsgHistoryBox.Click += new System.EventHandler(this.btnMsgHistoryBox_Click);
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSendMsg.Location = new System.Drawing.Point(3, 313);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(371, 94);
            this.btnSendMsg.TabIndex = 3;
            this.btnSendMsg.Text = "&Send Message";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "POST-STAR";
            this.notifyIcon.BalloonTipTitle = "00 users";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.Controls.Add(this.btnAbout, 0, 0);
            this.tlpMain.Controls.Add(this.btnSendMsg, 0, 4);
            this.tlpMain.Controls.Add(this.btnSetting, 0, 1);
            this.tlpMain.Controls.Add(this.btnMsgHistoryBox, 0, 2);
            this.tlpMain.Controls.Add(this.lbxRecentMsgList, 0, 3);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(10);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 5;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(377, 410);
            this.tlpMain.TabIndex = 5;
            // 
            // lbxRecentMsgList
            // 
            this.lbxRecentMsgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxRecentMsgList.FormattingEnabled = true;
            this.lbxRecentMsgList.ItemHeight = 15;
            this.lbxRecentMsgList.Location = new System.Drawing.Point(3, 123);
            this.lbxRecentMsgList.Name = "lbxRecentMsgList";
            this.lbxRecentMsgList.Size = new System.Drawing.Size(371, 184);
            this.lbxRecentMsgList.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 410);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "POST STAR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.tlpMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnMsgHistoryBox;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.ListBox lbxRecentMsgList;
    }
}


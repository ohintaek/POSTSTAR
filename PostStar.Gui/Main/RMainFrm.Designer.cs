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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RMainFrm));
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnMsgHistoryBox = new System.Windows.Forms.Button();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.lbxRecentMsgList = new System.Windows.Forms.ListBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(355, 186);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(284, 39);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "&About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(355, 225);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(284, 39);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.Text = "Se&tting";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnMsgHistoryBox
            // 
            this.btnMsgHistoryBox.Location = new System.Drawing.Point(355, 264);
            this.btnMsgHistoryBox.Name = "btnMsgHistoryBox";
            this.btnMsgHistoryBox.Size = new System.Drawing.Size(284, 39);
            this.btnMsgHistoryBox.TabIndex = 2;
            this.btnMsgHistoryBox.Text = "Message &History Box";
            this.btnMsgHistoryBox.UseVisualStyleBackColor = true;
            this.btnMsgHistoryBox.Click += new System.EventHandler(this.btnMsgHistoryBox_Click);
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(355, 499);
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
            this.lbxRecentMsgList.Location = new System.Drawing.Point(355, 303);
            this.lbxRecentMsgList.Name = "lbxRecentMsgList";
            this.lbxRecentMsgList.Size = new System.Drawing.Size(284, 184);
            this.lbxRecentMsgList.TabIndex = 4;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(51, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 464);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // RMainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 619);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbxRecentMsgList);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.btnMsgHistoryBox);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RMainFrm";
            this.Text = "POST STAR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RMainFrm_FormClosing);
            this.Load += new System.EventHandler(this.RMainFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnMsgHistoryBox;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.ListBox lbxRecentMsgList;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}


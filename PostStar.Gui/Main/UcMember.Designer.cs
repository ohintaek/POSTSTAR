namespace PostStar.Gui.Main
{
    partial class UcMember
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcMember));
            this.tlpMember = new System.Windows.Forms.TableLayoutPanel();
            this.pbxStatusIcon = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmsMember = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowMemberInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatusIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMember
            // 
            this.tlpMember.ColumnCount = 3;
            this.tlpMember.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMember.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tlpMember.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.tlpMember.Controls.Add(this.pbxStatusIcon, 0, 0);
            this.tlpMember.Controls.Add(this.lblName, 1, 0);
            this.tlpMember.Controls.Add(this.pictureBox1, 2, 0);
            this.tlpMember.Location = new System.Drawing.Point(0, 0);
            this.tlpMember.Name = "tlpMember";
            this.tlpMember.RowCount = 1;
            this.tlpMember.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMember.Size = new System.Drawing.Size(340, 30);
            this.tlpMember.TabIndex = 0;
            // 
            // pbxStatusIcon
            // 
            this.pbxStatusIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxStatusIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbxStatusIcon.Image")));
            this.pbxStatusIcon.Location = new System.Drawing.Point(3, 3);
            this.pbxStatusIcon.Name = "pbxStatusIcon";
            this.pbxStatusIcon.Size = new System.Drawing.Size(24, 24);
            this.pbxStatusIcon.TabIndex = 0;
            this.pbxStatusIcon.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblName.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(36, 6);
            this.lblName.Margin = new System.Windows.Forms.Padding(6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 18);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "홍길동";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            this.lblName.DoubleClick += new System.EventHandler(this.lblName_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(312, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // cmsMember
            // 
            this.cmsMember.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.tsmShowMemberInfo,
            this.toolStripMenuItem3});
            this.cmsMember.Name = "cmsMember";
            this.cmsMember.Size = new System.Drawing.Size(176, 104);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(175, 24);
            this.toolStripMenuItem1.Text = "메시지";
            // 
            // tsmShowMemberInfo
            // 
            this.tsmShowMemberInfo.Name = "tsmShowMemberInfo";
            this.tsmShowMemberInfo.Size = new System.Drawing.Size(175, 24);
            this.tsmShowMemberInfo.Text = "프로필";
            this.tsmShowMemberInfo.Click += new System.EventHandler(this.tsmShowMemberInfo_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(175, 24);
            this.toolStripMenuItem3.Text = "숨기기";
            // 
            // UcMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpMember);
            this.Name = "UcMember";
            this.Size = new System.Drawing.Size(340, 77);
            this.Load += new System.EventHandler(this.UcMember_Load);
            this.Leave += new System.EventHandler(this.UcMember_Leave);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UcMember_MouseClick);
            this.MouseEnter += new System.EventHandler(this.UcMember_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UcMember_MouseLeave);
            this.MouseHover += new System.EventHandler(this.UcMember_MouseHover);
            this.tlpMember.ResumeLayout(false);
            this.tlpMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatusIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsMember.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMember;
        private System.Windows.Forms.PictureBox pbxStatusIcon;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip cmsMember;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmShowMemberInfo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

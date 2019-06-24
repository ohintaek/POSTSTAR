namespace PostStar.Basic.Main
{
    partial class UcMe
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
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.lblNickName = new System.Windows.Forms.Label();
            this.cbxBusyStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.BackgroundImage = global::PostStar.Basic.Properties.Resources.ic_portrait_black_48dp;
            this.pbxPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxPhoto.Location = new System.Drawing.Point(4, 4);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(76, 65);
            this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPhoto.TabIndex = 0;
            this.pbxPhoto.TabStop = false;
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNickName.Location = new System.Drawing.Point(111, 6);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(62, 17);
            this.lblNickName.TabIndex = 1;
            this.lblNickName.Text = "홍길동";
            // 
            // cbxBusyStatus
            // 
            this.cbxBusyStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBusyStatus.FormattingEnabled = true;
            this.cbxBusyStatus.Items.AddRange(new object[] {
            "대화가능",
            "자리비움",
            "대화불가능"});
            this.cbxBusyStatus.Location = new System.Drawing.Point(114, 32);
            this.cbxBusyStatus.Name = "cbxBusyStatus";
            this.cbxBusyStatus.Size = new System.Drawing.Size(121, 23);
            this.cbxBusyStatus.TabIndex = 2;
            // 
            // UcMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.cbxBusyStatus);
            this.Controls.Add(this.lblNickName);
            this.Controls.Add(this.pbxPhoto);
            this.Name = "UcMe";
            this.Size = new System.Drawing.Size(459, 72);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxPhoto;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.ComboBox cbxBusyStatus;
    }
}

namespace PostStar.Basic.Messaging
{
    partial class FrmSendMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSendMessage));
            this.lvAttachFile = new System.Windows.Forms.ListView();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.rtbMessageBody = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.afFile = new PostStar.Basic.Main.UcAttachFile();
            this.SuspendLayout();
            // 
            // lvAttachFile
            // 
            this.lvAttachFile.AllowDrop = true;
            this.lvAttachFile.HideSelection = false;
            this.lvAttachFile.Location = new System.Drawing.Point(157, 310);
            this.lvAttachFile.Name = "lvAttachFile";
            this.lvAttachFile.Size = new System.Drawing.Size(43, 33);
            this.lvAttachFile.TabIndex = 10;
            this.lvAttachFile.UseCompatibleStateImageBehavior = false;
            this.lvAttachFile.View = System.Windows.Forms.View.List;
            this.lvAttachFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvAttachFile_DragDrop);
            this.lvAttachFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvAttachFile_DragEnter);
            this.lvAttachFile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvAttachFile_KeyDown);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddUser.BackgroundImage")));
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddUser.Location = new System.Drawing.Point(382, 310);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(55, 33);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // rtbMessageBody
            // 
            this.rtbMessageBody.Location = new System.Drawing.Point(7, 6);
            this.rtbMessageBody.Name = "rtbMessageBody";
            this.rtbMessageBody.Size = new System.Drawing.Size(430, 298);
            this.rtbMessageBody.TabIndex = 12;
            this.rtbMessageBody.Text = "";
            this.rtbMessageBody.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvAttachFile_DragDrop);
            this.rtbMessageBody.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvAttachFile_DragEnter);
            this.rtbMessageBody.TextChanged += new System.EventHandler(this.rtbMessageBody_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(7, 310);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(130, 33);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "&SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // afFile
            // 
            this.afFile.Location = new System.Drawing.Point(207, 310);
            this.afFile.Name = "afFile";
            this.afFile.Size = new System.Drawing.Size(49, 35);
            this.afFile.TabIndex = 14;
            // 
            // FrmSendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 348);
            this.Controls.Add(this.afFile);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtbMessageBody);
            this.Controls.Add(this.lvAttachFile);
            this.Controls.Add(this.btnAddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "FrmSendMessage";
            this.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Text = "새 매시지";
            this.Load += new System.EventHandler(this.FrmSendMessage_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ListView lvAttachFile;
        private System.Windows.Forms.RichTextBox rtbMessageBody;
        private System.Windows.Forms.Button btnSend;
        private Main.UcAttachFile afFile;
    }
}
namespace PostStar.Basic.SendMessage
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
            this.txtMessageBody = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblReceiveTarget = new System.Windows.Forms.Label();
            this.lvAttachFile = new System.Windows.Forms.ListView();
            this.btnAddAttach = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMessageBody
            // 
            this.txtMessageBody.Location = new System.Drawing.Point(8, 6);
            this.txtMessageBody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMessageBody.Multiline = true;
            this.txtMessageBody.Name = "txtMessageBody";
            this.txtMessageBody.Size = new System.Drawing.Size(491, 290);
            this.txtMessageBody.TabIndex = 1;
            this.txtMessageBody.TextChanged += new System.EventHandler(this.txtMessageBody_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSend, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(303, 388);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 42);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(103, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 38);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSend.Location = new System.Drawing.Point(3, 2);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 38);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "&Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblReceiveTarget
            // 
            this.lblReceiveTarget.AutoSize = true;
            this.lblReceiveTarget.Location = new System.Drawing.Point(97, 394);
            this.lblReceiveTarget.Name = "lblReceiveTarget";
            this.lblReceiveTarget.Size = new System.Drawing.Size(113, 15);
            this.lblReceiveTarget.TabIndex = 9;
            this.lblReceiveTarget.Text = "홍길동 외 00 명";
            // 
            // lvAttachFile
            // 
            this.lvAttachFile.AllowDrop = true;
            this.lvAttachFile.HideSelection = false;
            this.lvAttachFile.Location = new System.Drawing.Point(8, 304);
            this.lvAttachFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvAttachFile.Name = "lvAttachFile";
            this.lvAttachFile.Size = new System.Drawing.Size(420, 76);
            this.lvAttachFile.TabIndex = 10;
            this.lvAttachFile.UseCompatibleStateImageBehavior = false;
            this.lvAttachFile.View = System.Windows.Forms.View.List;
            this.lvAttachFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvAttachFile_DragDrop);
            this.lvAttachFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvAttachFile_DragEnter);
            this.lvAttachFile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvAttachFile_KeyDown);
            // 
            // btnAddAttach
            // 
            this.btnAddAttach.Image = global::PostStar.Basic.Properties.Resources.ic_note_add_black_18dp;
            this.btnAddAttach.Location = new System.Drawing.Point(437, 304);
            this.btnAddAttach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddAttach.Name = "btnAddAttach";
            this.btnAddAttach.Size = new System.Drawing.Size(63, 78);
            this.btnAddAttach.TabIndex = 11;
            this.btnAddAttach.UseVisualStyleBackColor = true;
            this.btnAddAttach.Click += new System.EventHandler(this.btnAddAttach_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddUser.BackgroundImage")));
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddUser.Location = new System.Drawing.Point(8, 390);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 38);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // FrmSendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 435);
            this.Controls.Add(this.btnAddAttach);
            this.Controls.Add(this.lvAttachFile);
            this.Controls.Add(this.lblReceiveTarget);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtMessageBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSendMessage";
            this.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Text = "메시지 보내기";
            this.Load += new System.EventHandler(this.FrmSendMessage_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMessageBody;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblReceiveTarget;
        private System.Windows.Forms.ListView lvAttachFile;
        private System.Windows.Forms.Button btnAddAttach;
    }
}
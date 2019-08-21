using PostStar.Basic.Common;
using PostStar.Communicator;
using PostStar.Communicator.DataStructure;
using PostStar.Communicator.TransData.Messages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PostStar.Basic.SendMessage
{
    /// <summary>
    /// 메시지 전송화면
    /// </summary>
    public partial class FrmSendMessage : PostStar.Basic.Common.FrmBaseDialog
    {
        /// <summary>
        /// 메시지를 수신할 멤버목록
        /// </summary>
        private List<Member> targetMemberList;

        /// <summary>
        /// Constructor
        /// </summary>
        public FrmSendMessage(Member member)
        {
            InitializeComponent();

            targetMemberList = new List<Member>();
            targetMemberList.Add(member);
        }

        /// <summary>
        /// 화면을 구성한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSendMessage_Load(object sender, EventArgs e)
        {
            if (targetMemberList.Count > 1)
                this.Text = String.Format("{0}외 {1}명에게 메시지 보내기", targetMemberList[0].nickName, targetMemberList.Count);
            else
                this.Text = String.Format("{0}에게 메시지 보내기", targetMemberList[0].nickName);

            btnSend.Enabled = false;
        }

        /// <summary>
        /// 전송창을 닫는다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 메시지 내용을 전송한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                // 0. 입력내용이 없다면 Return
                String inputMessage = this.txtMessageBody.Text.Trim();
                if (inputMessage == string.Empty)
                    return;

                // 1. 입력된 내용을 상대방에게 전송한다.  
                IMessageSender msgSender = new MessageSender(GlobalData.me);
                foreach (Member memer in this.targetMemberList)
                {
                    PostStarMessage starMessage = new PostStarMessage(GlobalData.me);
                    starMessage.text = inputMessage;                    
                    msgSender.Send(memer, starMessage);
                }

                // 2. 전송 내용을 이력에 기록한다.
                //...

                // 9. 창을 닫는다.
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMessageBody_TextChanged(object sender, EventArgs e)
        {
            if (this.txtMessageBody.TextLength > 0)
                btnSend.Enabled = true;
            else
                btnSend.Enabled = false;
        }

        /// <summary>
        /// 첨부파일을 추가한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Multiselect = true;
            openFileDlg.ShowDialog();
            foreach (string addFileName in openFileDlg.FileNames)
            {
                addAttachFile(addFileName);
            }
        }

        /// <summary>
        /// 첨부파일을 추가한다.(Drag & Drop)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvAttachFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            for (int i = 0; i < s.Length; i++)
            {
                addAttachFile(s[i]);
            }
        }
        
        /// <summary>
        /// 리스트박스에 파일을 추가한다.
        /// </summary>
        /// <param name="addFileName"></param>
        private void addAttachFile(String addFileName)
        {
            FileInfo fi = new FileInfo(addFileName);
            String itemName = String.Format("{0} ({1:#,##9} b)", addFileName, fi.Length);

            // 기존에 추가한 파일인지 확인한다.(TODO : existItem = true 되는 경우가 없음... 오류 픽스 필요...)
            bool existItem = false;
            foreach(var item in lvAttachFile.Items)
            {
                if (itemName == item.ToString())
                {
                    existItem = true;
                    break;
                }
            }

            if (existItem)
                return;

            lvAttachFile.Items.Add(itemName);
        }

        /// <summary>
        /// 첨부파일 리스트에 첨부파일 드래그 효과를 설정한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvAttachFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// 첨부파일을 제거한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvAttachFile_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode != Keys.Delete)
                return;

            if (lvAttachFile.Items.Count == 0)
                return;

            if (lvAttachFile.SelectedItems.Count == 0)
                return;

            for (int i = 0; i < lvAttachFile.SelectedItems.Count; i++)
                lvAttachFile.Items.Remove(lvAttachFile.SelectedItems[i]);
        }
    }
}

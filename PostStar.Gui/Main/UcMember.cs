using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PostStar.Gui.SendMessage;

namespace PostStar.Gui.Main
{
    /// <summary>
    /// 멤버를 표시하는 UI Control
    /// </summary>
    public partial class UcMember : UserControl
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="userName"></param>
        public UcMember(String userName)
        {
            InitializeComponent();

            this.lblName.Text = userName;
        }

        /// <summary>
        /// 화면을 구성한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UcMember_Load(object sender, EventArgs e)
        {
            tlpMember.Dock = DockStyle.Fill;
            this.Height = 30/* Control의 높이 */;

            this.ContextMenuStrip = this.cmsMember;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblName_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UcMember_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        /// <summary>
        /// 이름을 더블클릭하면 메시지 전송창을 표시한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblName_DoubleClick(object sender, EventArgs e)
        {
            FrmSendMessage frmSendMessage = new FrmSendMessage();
            frmSendMessage.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UcMember_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("fff");
            this.BackColor = Color.LightSkyBlue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UcMember_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UcMember_Leave(object sender, EventArgs e)
        {

        }
    }
}

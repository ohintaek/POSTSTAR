using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PostStar.Communicator.DataStructure;

namespace PostStar.Basic.Main
{
    public partial class UcMe : UserControl
    {
        Member me;

        /// <summary>
        /// Constructor
        /// </summary>
        public UcMe()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 사용자 정보를 설정한다.
        /// </summary>
        /// <param name="me"></param>
        public void setMe(Member me)
        {
            this.me = me;
            this.lblNickName.Text = me.nickName;
        }
    }
}

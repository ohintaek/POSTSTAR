using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZTestWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtbMessageBodyOutput.Rtf = rtbMessageBody.Rtf;

            if (File.Exists("c:\\a.rtf"))
                File.Delete("c:\\a.rtf");

            using (FileStream fs = new FileStream("c:\\a.rtf", FileMode.CreateNew))
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(rtbMessageBodyOutput.Rtf);
                sw.Flush();
                sw.Close();
                fs.Close();
            }


        }
    }
}

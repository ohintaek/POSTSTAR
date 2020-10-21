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
            rtbMessageBodyOutput.Enabled = false;

            if (File.Exists("c:\\a.rtf"))
                File.Delete("c:\\a.rtf");

            using (FileStream fs = new FileStream("c:\\a.rtf", FileMode.CreateNew))
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(rtbMessageBodyOutput.Rtf);
                sw.Close();
                fs.Close();
            }


        }

        private void rtbMessageBody_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void rtbMessageBody_DragDrop(object sender, DragEventArgs e)
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
            foreach (var item in lvAttachFile.Items)
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
    }
}

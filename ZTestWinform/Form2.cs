using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZTestWinform
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Form2_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Form2_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            for (int i = 0; i < s.Length; i++)
            {
                MessageBox.Show(s[i]);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (System.IO.File.Exists("c:\\b.rtf"))
                System.IO.File.Delete("c:\\b.rtf");

            richTextBox1.SaveFile("c:\\b.rtf", RichTextBoxStreamType.RichText);

              richTextBox2.Rtf = richTextBox1.Rtf;
            
            richTextBox2.LoadFile("c:\\b.rtf", RichTextBoxStreamType.RichText);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.ReadOnly = !richTextBox2.ReadOnly;
            richTextBox2.Update();
        }
    }
}

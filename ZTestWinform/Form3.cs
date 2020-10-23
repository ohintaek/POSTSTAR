using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZTestWinform
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            //Extracting icon fonts from the WF Fabric.ttf file and inserting into system memory.
            Stream fontAsStream = this.GetType().Assembly.GetManifestResourceStream("ZTestWinform.SAP-icons.ttf");
            byte[] fontAsByte = new byte[fontAsStream.Length];
            fontAsStream.Read(fontAsByte, 0, (int)fontAsStream.Length);
            fontAsStream.Close();
            IntPtr memPointer = System.Runtime.InteropServices.Marshal.AllocHGlobal(System.Runtime.InteropServices.Marshal.SizeOf(typeof(byte)) * fontAsByte.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontAsByte, 0, memPointer, fontAsByte.Length);
            pfc.AddMemoryFont(memPointer, fontAsByte.Length);

            //Icon font's unicode "0xe700" is converted to string and drawn using e.Graphics with WF Fabric set as font family. 
            string iconChar = char.ConvertFromUtf32(0xe068);
            Font iconFont = new Font(pfc.Families[0], 18.5f, FontStyle.Bold);
            e.Graphics.DrawString(iconChar, iconFont, new SolidBrush(Color.Black), new PointF(10, 10));

            //Icon font's unicode "0xe710" is converted to string and drawn using e.Graphics with WF Fabric set as font family.
            iconChar = char.ConvertFromUtf32(0xe029);
            e.Graphics.DrawString(iconChar, iconFont, new SolidBrush(Color.Red), new PointF(40, 40));

            //Icon font's unicode "0xe720" is converted to string and drawn using e.Graphics with WF Fabric set as font family.
            iconChar = char.ConvertFromUtf32(0xe015);
            e.Graphics.DrawString(iconChar, iconFont, new SolidBrush(Color.Green), new PointF(70, 70));
        }
    }
}

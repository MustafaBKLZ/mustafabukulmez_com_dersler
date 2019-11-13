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

namespace mustafabukulmez_com_dersler._024_Drag_And_Drop
{
    public partial class dragdrop : Form
    {
        public dragdrop()
        {
            InitializeComponent();
        }

        private void dragdrop_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, true);
                BelgeyiOku(s[0]);
            }
        }

        private string BelgeyiOku(string dosya_yolu)
        {
            StreamReader dosyaOku = new StreamReader(dosya_yolu, Encoding.GetEncoding("windows-1254"));
            string yazi = dosyaOku.ReadLine();
            while (yazi != null)
            {
                textBox1.Text += (yazi) + Environment.NewLine;
                yazi = dosyaOku.ReadLine();
            }
            dosyaOku.Close();
            return yazi;
        }

        private void textBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.All;
            }
        }
    }
}

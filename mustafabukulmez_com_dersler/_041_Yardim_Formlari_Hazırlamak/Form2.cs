using System;
using System.Windows.Forms;

namespace mustafabukulmez_com_dersler._041_Yardim_Formlari_Hazırlamak
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
        public void LoadHTML(string HTMLFile)
        {
            this.webBrowser1.Url = new Uri(String.Format("file:///{0}/", System.IO.Directory.GetCurrentDirectory() + "\\_041_Yardim_Formlari_Hazırlamak\\YardimDosyalari\\" + HTMLFile));
        }
    }
}

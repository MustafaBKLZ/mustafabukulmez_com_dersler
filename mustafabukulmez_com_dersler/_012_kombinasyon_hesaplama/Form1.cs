using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//https://mustafabukulmez.com/2019/01/05/c-kombinasyon-hesaplama/
namespace mustafabukulmez_com_dersler._012_kombinasyon_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_kombinasyon_hesapla_Click(object sender, EventArgs e)
        {
            Kombinasyon_Hesapla();
        }

        int n, r, kombinasyon, fakt, fakt1, fakt2;
        void Kombinasyon_Hesapla()
        {
            n = Convert.ToInt32(txt_n.Text);
            r = Convert.ToInt32(txt_r.Text);

            fakt = n;
            for (int i = n - 1; i >= 1; i--)
            {
                fakt = fakt * i;
            }
            fakt2 = r;
            for (int i = r - 1; i >= 1; i--)
            {
                fakt2 = fakt2 * i;
            }
            //https://mustafabukulmez.com/2019/01/05/c-kombinasyon-hesaplama/
            int number;
            number = n - r;
            fakt1 = number;
            for (int i = number - 1; i >= 1; i--)
            {
                fakt1 = fakt1 * i;
            }
            fakt1 = fakt2 * fakt1;
            kombinasyon = fakt / fakt1;
            txt_sonuc.Text = kombinasyon.ToString();
        }
    }
}
//https://mustafabukulmez.com/2019/01/05/c-kombinasyon-hesaplama/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//https://mustafabukulmez.com/2019/01/05/c-permutasyon-hesaplama/
namespace mustafabukulmez_com_dersler._013_permutasyon_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_permutasyon_hesapla_Click(object sender, EventArgs e)
        {
            Permutasyon_Hesapla();
        }

        int n, r, per, fakt, fakt1;
        void Permutasyon_Hesapla()
        {
            n = Convert.ToInt32(txt_n.Text);
            r = Convert.ToInt32(txt_r.Text);

            fakt = n;
            for (int i = n - 1; i >= 1; i--)
            {
                fakt = fakt * i;
            }

            int number;
            number = n - r;
            fakt1 = number;
            for (int i = number - 1; i >= 1; i--)
            {
                fakt1 = fakt1 * i;
            }
            per = fakt / fakt1;
            txt_sonuc.Text = per.ToString();
        }
    }
}
//https://mustafabukulmez.com/2019/01/05/c-permutasyon-hesaplama/
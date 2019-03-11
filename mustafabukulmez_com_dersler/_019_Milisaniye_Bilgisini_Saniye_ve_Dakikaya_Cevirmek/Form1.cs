using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//https://mustafabukulmez.com/2019/03/11/c-milisaniye-convert-saniye-ve-dakikaya-cevirmek/
namespace mustafabukulmez_com_dersler._019_Milisaniye_Bilgisini_Saniye_ve_Dakikaya_Cevirmek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_cevir_Click(object sender, EventArgs e)
        {
            long ms = Convert.ToInt64(txt_mili_saniye.Text);

            TimeSpan t = TimeSpan.FromMilliseconds(ms);
            lbl_gun.Text = string.Format("{0:D2} Gün", t.Days);
            lbl_saat.Text = string.Format("{0:D2} Saat", t.Hours);
            lbl_dakika.Text = string.Format("{0:D2} Dakika", t.Minutes);
            lbl_saniye.Text = string.Format("{0:D2} Saniye", t.Seconds);
         

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mustafabukulmez_com_dersler._021_Rastgele_Sifre_Olusturma
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
        int[] zorluk;
        private void button1_Click(object sender, EventArgs e)
        {
            txt_olusan_sfire.Text = "";
            int sifre;
            string karakter = "";

            Random rastgele = new Random();
            if (cmb_zorluk.SelectedIndex >= 0)
            {
                switch (cmb_zorluk.SelectedIndex)
                {
                    case 0: zorluk = new int[] { 65, 80 }; ; break;  // ASCII kod tablosundaki harf ve özel karakter kodları
                    case 1: zorluk = new int[] { 65, 91 }; ; break;  // ASCII kod tablosundaki harf ve özel karakter kodları
                    case 2: zorluk = new int[] { 65, 100 }; ; break ;// ASCII kod tablosundaki harf ve özel karakter kodları
                }

                for (int i = 0; i < nud_sifre_karakter_adet.Value; i++)
                {
                    sifre = rastgele.Next(zorluk[0], zorluk[1]);
                    karakter += Convert.ToChar(sifre); // Rastgele seçilmiş olan sayıyı harf ve özel karakterlere çeviriyoruz.
                }
                txt_olusan_sfire.Text = karakter;
            }
            else
            {
                MessageBox.Show("Zorluk seçmelisiniz.");
            }

        }

  
    }
}

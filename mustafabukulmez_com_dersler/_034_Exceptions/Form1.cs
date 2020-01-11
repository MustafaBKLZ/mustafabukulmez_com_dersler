using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mustafabukulmez_com_dersler._034_Exceptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region ArgumentException Çıkarma ve Yakalama Örneği
        private void btn_ArgumentException_Click(object sender, EventArgs e)
        {
            txt_cikti.Text = "";
            int[] sayilar = { 10, 7 };
            foreach (var sayi in sayilar)
            {
                try
                {
                    SayiKontrol(sayi);
                }
                catch (ArgumentException ex)
                {
                    txt_cikti.Text += ex.GetType().Name + ":" + ex.Message;
                }
            }
        }
        static int SayiKontrol(int sayi)
        {
            if ((sayi & 1) == 1)
                throw new ArgumentException(sayi.ToString() + " Sayı çift sayı değil", "sayi");

            return sayi / 2;
        }
        #endregion

        #region ArgumentNullException Çıkarma ve Yakalama Örneği
        private void btn_ArgumentNullException_Click(object sender, EventArgs e)
        {
            txt_cikti.Text = "";
            try
            {
                strBirlestir("mustafa", "");
            }
            catch (ArgumentNullException ex)
            {
                txt_cikti.Text += ex.GetType().Name + ":" + ex.Message;
            }

        }
        string strBirlestir(string ad, string soyad)
        {
            if (string.IsNullOrEmpty(ad) || string.IsNullOrWhiteSpace(ad))
            {
                throw new ArgumentNullException("ad", ad + " Ad değeri boş olamaz");
            }
            else if (string.IsNullOrEmpty(soyad) || string.IsNullOrWhiteSpace(soyad))
            {
                throw new ArgumentNullException("soyad", soyad + " Soyad değeri boş olamaz");
            }
            else
            {
                return ad + " " + soyad;
            }
        }

        #endregion

        #region ArgumentNullException Çıkarma ve Yakalama Örneği
        private void btn_ArguOutOfRangeExce_Click(object sender, EventArgs e)
        {
            txt_cikti.Text = "";
            // Hata Veren Örnek
            //string s = "1234";
            //try
            //{
            //    bool b = Char.IsNumber(s, 5);
            //}
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    txt_cikti.Text += ex.GetType().Name + ":" + ex.Message;
            //}

            try
            {
                _000_Classlar.Misafirler misafir1 = new _000_Classlar.Misafirler("Mustafa", "Bükülmez", 17);
                MessageBox.Show(misafir1.MisafirBilgi());
            }
            catch (ArgumentOutOfRangeException ex)
            {
                txt_cikti.Text += ex.GetType().Name + ":" + ex.Message;
            }
        }
        #endregion








        private void btn_IndexOutOfRangeException_Click(object sender, EventArgs e)
        {
            int[] arr1 = new int[3];
            arr1[0] = 0;
            arr1[1] = 1;
            arr1[2] = 2;
            int ii = arr1[4];



            int[] arr = new int[5];
            arr[0] = 0;
            arr[1] = 1;
            arr[2] = 2;
            arr[3] = 3;
            arr[4] = 4;
            for (int i = 0; i < arr.Length + 1; i++)
            {
                arr[i] = arr[i] + 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
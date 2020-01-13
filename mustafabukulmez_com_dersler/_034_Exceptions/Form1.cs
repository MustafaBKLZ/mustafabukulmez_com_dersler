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
        //https://mustafabukulmez.com/2020/01/10/c-argumentexception-nedenleri-ve-kullanimi/
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
        //https://mustafabukulmez.com/2020/01/11/c-argumentnullexception-nedenleri-ve-kullanimi/
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
        //https://mustafabukulmez.com/2020/01/12/c-argumentoutofrangeexception-nedenleri-ve-kullanimi/
        #endregion

        #region IndexOutOfRangeException Çıkarma ve Yakalama Örneği
        private void btn_IndexOutOfRangeException_Click(object sender, EventArgs e)
        {
            //int[] arr1 = new int[5];
            //arr1[0] = 1;
            //arr1[1] = 2;
            //arr1[2] = 3;
            //arr1[3] = 4;
            //arr1[4] = 5;
            //int ii = arr1[5];

            //int[] arr = new int[5];
            //arr[0] = 0;
            //arr[1] = 1;
            //arr[2] = 2;
            //arr[3] = 3;
            //arr[4] = 4;
            //for (int i = 0; i < arr.Length + 1; i++)
            //{
            //    arr[i] = arr[i] + 1;
            //}

            try
            {
                _000_Classlar.Misafirler misafir1 = new _000_Classlar.Misafirler("Mustafa", "Bükülmez", 57);
                MessageBox.Show(misafir1.MisafirBilgi());
            }
            catch (IndexOutOfRangeException ex)
            {
                txt_cikti.Text += ex.GetType().Name + ":" + ex.Message;
            }
        }
        //https://mustafabukulmez.com/2020/01/13/c-indexoutofrangeexception-nedenleri-ve-kullanimi/
        #endregion

        #region FormatException Çıkarma ve Yakalama Örneği
        private void btn_FormatException_Click(object sender, EventArgs e)
        {
            //string s1 = "OK";
            //bool b2 = Convert.ToBoolean(s1);

            //string s2 = "18 00";
            //DateTime dt = Convert.ToDateTime(s2);

            //string s3 = "18:15";
            //double d1 = Convert.ToDouble(s3);

            string gelenDeger = "MB___asdasd_adas__@__asdasda@BüM";
            try
            {
                Islem(gelenDeger);
            }
            catch (FormatException ex)
            {

                txt_cikti.Text += ex.GetType().Name + ":" + ex.Message;
            }

        }
        void Islem(string text)
        {
            if (text.Substring(0, 2) == "MB" & text.Substring(text.Length - 2, 2) == "BM")
            {
                MessageBox.Show("OK!");
            }
            else
            {
                throw new FormatException("Gelen değer istenen formata uymuyor. İlk iki karakter MB, son iki karakter BM olmalıdır.");
            }
        }
        //https://mustafabukulmez.com/2020/01/13/c-formatexception-ve-nedenleri-kullanimi/
        #endregion
    }
}
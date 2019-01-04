using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

//https://mustafabukulmez.com/2018/11/28/c-string-sayisal-deger-kontrolu/

namespace mustafabukulmez_com_dersler._6_String_Sayisal_Deger_Kontrolu
{
    // burası class seviyesi olarak geçiyor.
    public partial class Form1 : Form
    {
        // bu alan form ile ilgili tanımlamaların yapıldığı alan
        public Form1()
        {
            InitializeComponent();
        }

        #region YÖNTEM 5 --
        static bool sayiMi_5(string deger)
        {
            try
            {
                int.Parse(deger);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void btn_kontrol_et_5_Click(object sender, EventArgs e)
        {
            if (sayiMi_5(txt_Deger.Text))
                lbl_durum.Text = "Sayıdır.";
            else
                lbl_durum.Text = "Sayı Değildir.";



            lbl_durum.Text = sayiMi_5(txt_Deger.Text) ? "Sayıdır." : "Sayı Değildir.";
        }


        #endregion

        #region YÖNTEM 4 --

        static bool sayiMi_4(string a)
        {
            bool sonuc = true;
            for (int i = 0; i < a.Length; i++)
                if (!char.IsDigit(a[i]))
                    sonuc = false;      //Eğer karakter sayı değilse false döner
            return sonuc;
        }
        private void btn_kontrol_et_4_Click(object sender, EventArgs e)
        {
            if (sayiMi_4(txt_Deger.Text))
                lbl_durum.Text = "Sayıdır.";
            else
                lbl_durum.Text = "Sayı Değildir.";
        }

        #endregion

        #region YÖNTEM 3 -- 
        public Boolean SayiMi_3(String strVeri)
        {
            if (String.IsNullOrEmpty(strVeri) == true)
            {
                return false;
            }
            else
            {
                Regex desen = new Regex("^[0-9]*$");
                return desen.IsMatch(strVeri);
            }
        }
        private void btn_kontrol_et_3_Click(object sender, EventArgs e)
        {
            if (SayiMi_3(txt_Deger.Text))
                lbl_durum.Text = "Sayıdır.";
            else
                lbl_durum.Text = "Sayı Değildir.";
        }
        #endregion

        #region YÖNTEM 1 --
        private void btn_kontrol_et_Click(object sender, EventArgs e)
        {
            if (SayiMi_1(txt_Deger.Text) == true)
            {
                lbl_durum.Text = "Sayıdır.";
            }
            else
            {
                lbl_durum.Text = "Sayı Değildir.";
            }
        }
        bool SayiMi_1(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }
        #endregion



        #region YÖNTEM 2 --

        private void btn_kontrol_et_2_Click(object sender, EventArgs e)
        {
            if (txt_Deger.Text.SayiMi())
                lbl_durum.Text = "Sayıdır.";
            else
                lbl_durum.Text = "Sayı Değildir.";
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    #region YÖNTEM 2 --
    public static class ExtensionManager
    {
        public static bool SayiMi(this string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }
    }
    //public static class ExtensionManager_2
    //{
    //    public static bool SayiMi_2(this string value)
    //    {
    //        double oReturn = 0;
    //        return double.TryParse(value, out oReturn);
    //    }
    //}
    #endregion
}

//https://mustafabukulmez.com/2018/11/28/c-string-sayisal-deger-kontrolu/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mustafabukulmez_com_dersler._038_Kredi_Karti_Bilgileri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_kontrol_Click(object sender, EventArgs e)
        {
            string kart_no = _000_Classlar.Global.KartNoTemizle(txt_card_no.Text);
            lbl_kart_turu.Text = Kart_Turu(kart_no);
            lbl_bin_kodu.Text = BIN_Kodu(kart_no);
            lbl_hesap_no.Text = Hesap_No(kart_no);
            lbl_kontrol_sayi.Text = Luhn_Kod(kart_no);

        }

        string Kart_Turu(string kart_no)
        {
            switch (kart_no.Substring(0, 1))
            {
                case "1": return "Hava Yolları Kartı";
                case "2": return "Hava Yolları Kartı";
                //case "2": goto case "1";
                case "3": return "Seyahat/Eğlence Kartı";
                case "4": return "Hesap Kartı";
                case "5": return "Hesap Kartı";
                case "6": return "Alışveriş Kartı";
                case "7": return "Akaryakıt Kartı";
                case "8": return "Haberleşme Kartı";
                case "9": return "Uluslararası Kart";
                default: return "Bilinmeyen Kart Türü";
            }
        }
        string BIN_Kodu(string kart_no)
        {
            return kart_no.Substring(0, 6);
        }

        string Hesap_No(string kart_no)
        {
            return kart_no.Substring(6, 9);
        }
        string Luhn_Kod(string kart_no)
        {
            return kart_no.Substring(kart_no.Length - 1, 1);
        }

    }
}

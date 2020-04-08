using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mustafabukulmez_com_dersler._036_Kredi_Karti_Tipini_Bulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_kontrol_Click(object sender, EventArgs e)
        {
            Regex visaRegex = new Regex("^4[0-9]{12}(?:[0-9]{3})?$");
            Regex masterRegex = new Regex("^5[1-5][0-9]{14}$");
            Regex expressRegex = new Regex("^3[47][0-9]{13}$");
            Regex dinersRegex = new Regex("^3(?:0[0-5]|[68][0-9])[0-9]{11}$");
            Regex discoverRegex = new Regex("^6(?:011|5[0-9]{2})[0-9]{12}$");
            Regex jcbRegex = new Regex("^(?:2131|1800|35\\d{3})\\d{11}$");


            if (visaRegex.IsMatch(txt_card_no.Text))
                lbl_sonuc.Text = "VISA";
            else if (masterRegex.IsMatch(txt_card_no.Text))
                lbl_sonuc.Text = "MASTERCARD";
            else if (expressRegex.IsMatch(txt_card_no.Text))
                lbl_sonuc.Text = "AEXPRESS";
            else if (dinersRegex.IsMatch(txt_card_no.Text))
                lbl_sonuc.Text = "DINERS";
            else if (discoverRegex.IsMatch(txt_card_no.Text))
                lbl_sonuc.Text = "DISCOVERS";
            else if (jcbRegex.IsMatch(txt_card_no.Text))
                lbl_sonuc.Text = "JCB";
            else
                lbl_sonuc.Text = "Bilinmiyor";
        }
    }
}

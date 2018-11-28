using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//https://mustafabukulmez.com/2018/11/28/c-textbox-sadece-sayi_harf-girisi-yaptirmak/


namespace mustafabukulmez_com_dersler._5_TextBox_sadece_sayi_harf_girisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_sadece_sayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_sadece_harf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txt_ozel_giremez_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '£' || e.KeyChar == '½' ||
                e.KeyChar == '€' || e.KeyChar == '₺' ||
                e.KeyChar == '¨' || e.KeyChar == 'æ' ||
                e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 58 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }
        }
        // MessageBox.Show(((int)e.KeyChar).ToString());
        private void txt_bosluk_giremez_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }            
        }
    }
}

//https://mustafabukulmez.com/2018/11/28/c-textbox-sadece-sayi_harf-girisi-yaptirmak/

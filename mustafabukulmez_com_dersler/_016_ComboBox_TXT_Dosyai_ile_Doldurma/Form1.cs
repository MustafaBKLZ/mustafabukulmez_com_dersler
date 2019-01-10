using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//https://mustafabukulmez.com/2019/01/10/c-combobox-txt-dosyasi-ile-doldurma/
namespace mustafabukulmez_com_dersler._016_ComboBox_TXT_Dosyai_ile_Doldurma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sistem.GlobalClass.AracMarkalari(cmb_arac_marka);
        }

    }
}
//https://mustafabukulmez.com/2019/01/10/c-combobox-txt-dosyasi-ile-doldurma/
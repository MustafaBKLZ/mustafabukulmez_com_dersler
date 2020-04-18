using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mustafabukulmez_com_dersler._039_Dinamik_Form_ve_Nesne_Uretme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_stok_Sec_Click(object sender, EventArgs e)
        {
            string sql_query = "Select 1=1";
            _000_Classlar.SecimListe.SecimListesiAc(txt_kod, txt_adi, sql_query);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mustafabukulmez_com_dersler._020_Excel_OLEDB_Baglanti_ve_Veri_Okuma_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //https://mustafabukulmez.com/2019/03/15/c-excel-oledb-baglanti-ve-veri-okuma-class/
        }

        private void btn_sec_Click(object sender, EventArgs e)
        {
            txt_excel_yolu.Text = ExcelBaglanOku.ExcelYoluSec();
        }

        private void btn_oku_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ExcelBaglanOku.ExcelOku();
        }
    }
}

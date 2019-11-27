using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

    
        private void btn_klasorden_coklu_sec_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] dosyalar = Directory.GetFiles(fbd.SelectedPath);
                foreach (string dosya in dosyalar)
                {
                    if (dosya.EndsWith(".xls"))
                        listBox1.Items.Add(dosya);
                }
            }
        }

        private void btn_secilenleri_oku_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                ExcelBaglanOku.ExcelYol = listBox1.Items[i].ToString();
                dt = ExcelBaglanOku.ExcelOku();
                ds.Tables.Add(dt);
            }

            DataTable dtAll = ds.Tables[0].Copy();
            for (var i = 1; i < ds.Tables.Count; i++)
            {
                dtAll.Merge(ds.Tables[i]);
            }
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dtAll;

           
        }

    }
}

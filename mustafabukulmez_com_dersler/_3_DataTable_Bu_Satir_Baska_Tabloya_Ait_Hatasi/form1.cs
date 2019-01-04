using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


//https://mustafabukulmez.com/2018/11/27/c-datatable-bu-satir-baska-bir-tabloya-ait-hatasi-cozumu/

namespace mustafabukulmez_com_dersler._3_DataTable_Bu_Satir_Baska_Tabloya_Ait_Hatasi
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e)
        {
            DataTable dt_son = new DataTable();
            DataRow dr;

            DataTable dt1 = new DataTable();
            dt1.TableName = "Tablo1";
            dr = dt1.Rows[dt1.Rows.Count - 1]; // eğer kolon sayısı 0 ise hata verecektir.
            //dt_son.Rows.Add(dr);
            dt_son.ImportRow(dr);

            DataTable dt2 = new DataTable();
            dt2.TableName = "Tablo2";
            dr = dt2.Rows[dt2.Rows.Count - 1]; // eğer kolon sayısı 0 ise hata verecektir.
                                               //dt_son.Rows.Add(dr);
            dt_son.ImportRow(dr);

            DataTable dt3 = new DataTable();
            dt3.TableName = "Tablo3";
            dr = dt3.Rows[dt3.Rows.Count - 1]; // eğer kolon sayısı 0 ise hata verecektir.
            //dt_son.Rows.Add(dr);
            dt_son.ImportRow(dr);

            DataTable dt4 = new DataTable();
            dt4.TableName = "Tablo4";
            dr = dt4.Rows[dt4.Rows.Count - 1]; // eğer kolon sayısı 0 ise hata verecektir.
            //dt_son.Rows.Add(dr);
            dt_son.ImportRow(dr);

            DataTable dt5 = new DataTable();
            dt5.TableName = "Tablo5";
            dr = dt5.Rows[dt5.Rows.Count - 1]; // eğer kolon sayısı 0 ise hata verecektir.
            //dt_son.Rows.Add(dr);
            dt_son.ImportRow(dr);
        }
    }
}
//https://mustafabukulmez.com/2018/11/27/c-datatable-bu-satir-baska-bir-tabloya-ait-hatasi-cozumu/
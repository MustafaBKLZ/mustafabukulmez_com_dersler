using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace mustafabukulmez_com_dersler._000_Classlar
{
    public class SecimListe
    {
        private static Form fr = new Form();
        private static DataGridView dgv= new DataGridView();                
        private static TextBox txt_kod;
        private static TextBox txt_ad;


        /// <summary>
        /// Otomatik seçim listesini açar. DataGridView ekler ve DataGridView'i sql_query sorgusuna göre doldurur
        /// </summary>
        /// <param name="txt_kodu">Kod bilgisinin yazılacağı TextBox</param>
        /// <param name="txt_adi">Ad bilgisinin yazılacağı TextBox</param>
        /// <param name="sql_query">DataGridView 'de görünecek listenin SQL sorgusu</param>
        /// <param name="FormBaslik">Seçim listesinin form adı. Varsayılan - "Seçim Listesi"</param>
        public static void SecimListesiAc(TextBox txt_kodu, TextBox txt_adi, string sql_query, string FormBaslik = "Seçim Listesi")
        {
            dgv.Dock = DockStyle.Fill;
            dgv.CellClick += Dgv_CellClick;
            dgv_update(sql_query);

            txt_kod = txt_kodu;
            txt_ad = txt_adi;

            fr.Height = 600;
            fr.Width = 400;
            fr.Controls.Add(dgv);
            fr.StartPosition = FormStartPosition.CenterScreen;
            fr.Text = FormBaslik;
            fr.ShowDialog();
        }

        private static void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv.Rows[e.RowIndex];
            if (row != null)
            {
                txt_kod.Text = row.Cells["Kod"].Value.ToString();
                txt_ad.Text = row.Cells["Ad"].Value.ToString();
                fr.Close();
            }
        }

        private static DataTable RastgeleDT()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Kod");
            dt.Columns.Add("Ad");
            DataRow row1 = dt.NewRow();
            row1["Kod"] = "PC1";
            row1["Ad"] = "Bilgisayar 1";
            dt.Rows.Add(row1);

            DataRow row2 = dt.NewRow();
            row2["Kod"] = "HDD1";
            row2["Ad"] = "HDD 1";
            dt.Rows.Add(row2);

            DataRow row3 = dt.NewRow();
            row3["Kod"] = "ETHERNET1";
            row3["Ad"] = "ETHERNET 1";
            dt.Rows.Add(row3);

            return dt;
        }

        private static void dgv_update(string sql_query)
        {
            // RastgeleDT() metodu projede sql bağlantısı olmadığı için örnek olması amacı ile yapılmıştır. 
            // Burada parametre olarak alınan SQL Sorgusunu DataGridView' e dolduracak kodları yazarsınız.

            try
            {
                dgv.DataSource = RastgeleDT();
            }
            catch (InvalidOperationException)
            {
            }
        }



    }
}

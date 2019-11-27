using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mustafabukulmez_com_dersler._020_Excel_OLEDB_Baglanti_ve_Veri_Okuma_Class
{
    public class ExcelBaglanOku
    {
        public static string ExcelYol = "";
        public static string ExcelYoluSec()
        {
            string Platform = "";
            OpenFileDialog ac = new OpenFileDialog();

            if (Environment.Is64BitProcess)
            { ac.Filter = "Excel dosyaları(*.xlsx)|*.xlsx"; Platform = "x64. Sadece XLSX Dosyaları"; }
            else
            { ac.Filter = "Excel dosyaları(*.xls)|*.xls"; Platform = "x86. Sadece XLS Dosyaları"; }

            ac.Title = "Platform " + Platform;
            ac.ShowDialog();
            ExcelYol = ac.FileName.ToString();

            return ac.SafeFileName;
        }
        //https://mustafabukulmez.com/2019/03/15/c-excel-oledb-baglanti-ve-veri-okuma-class/
        public static DataTable ExcelOku()
        {
            DataTable dtexcel = new DataTable();

            if (ExcelYol.Trim().Length > 0)
            {
                DataTable schemaTable = new DataTable();
                string strConn = "";


                if (Environment.Is64BitProcess)
                    strConn = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source=" + ExcelYol + "; Extended Properties = \"Excel 12.0; HDR = Yes; IMEX = 0\"";
                else
                    strConn = "Provider = Microsoft.Jet.OLEDB.4.0;  Data Source=" + ExcelYol + "; Extended Properties = \"Excel 8.0; HDR = Yes; IMEX = 0\"";


                OleDbConnection conn = new OleDbConnection(strConn);
                conn.Open();
                schemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                DataRow schemaRow = schemaTable.Rows[0];
                string sheet = schemaRow["TABLE_NAME"].ToString();
                if (!sheet.EndsWith("_"))
                {
                    string query = "SELECT  * FROM [" + sheet + "]";
                    OleDbDataAdapter daexcel = new OleDbDataAdapter(query, conn);
                    dtexcel.Locale = CultureInfo.CurrentCulture;
                    daexcel.Fill(dtexcel);
                }
                conn.Close();

            }
            else
            {
                MessageBox.Show("Okunacak EXCEL dosyası bulunamadı. Lütfen önce okunacak EXCEL dosyası seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            return dtexcel;
        }

    }
}
//https://mustafabukulmez.com/2019/03/15/c-excel-oledb-baglanti-ve-veri-okuma-class/
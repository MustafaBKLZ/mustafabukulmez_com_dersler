using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mustafabukulmez_com_dersler._023_XML_Islemleri
{
    public partial class XML_Diger_Islemler : Form
    {
        public XML_Diger_Islemler()
        {
            InitializeComponent();
        }

        private void XML_Diger_Islemler_Load(object sender, EventArgs e)
        {

        }




        #region C# DataSet ile XML Dosyası Nasıl Oluşturulur?
        DataTable dt;
        private void Btn_dataset_ile_olustur_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.DataSetName = "Projeler";

            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Proje_ID", Type.GetType("System.Int32")));
            dt.Columns.Add(new DataColumn("Proje_Adı", Type.GetType("System.String")));
            dt.Columns.Add(new DataColumn("proje_Ucreti", Type.GetType("System.Int32")));

            fillRows(1, "Proje 1", 1111);
            fillRows(2, "Proje 2", 2222);
            fillRows(3, "Proje 3", 3333);
            fillRows(4, "Proje 4", 4444);
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "Proje";
            ds.WriteXml(_000_Classlar.Global.AppPath + "\\_023_XML_Islemleri\\XML\\Proje.xml");

            MessageBox.Show("Tamamdır");
        }
        private void fillRows(int pID, string pName, int pPrice)
        {
            DataRow dr;
            dr = dt.NewRow();
            dr["Proje_ID"] = pID;
            dr["Proje_Adı"] = pName;
            dr["proje_Ucreti"] = pPrice;
            dt.Rows.Add(dr);
        }
        #endregion


    }
}

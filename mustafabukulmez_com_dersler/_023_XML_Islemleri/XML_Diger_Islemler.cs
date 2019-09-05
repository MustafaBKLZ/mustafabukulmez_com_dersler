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
using System.Xml;

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

        private void Button1_Click(object sender, EventArgs e)
        {
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(_000_Classlar.Global.AppPath + "\\_023_XML_Islemleri\\XML\\Proje.xml", new XmlReaderSettings());
            DataSet ds = new DataSet();
            ds.ReadXml(xmlFile);
            dataGridView1.DataSource = ds.Tables[0];


        }

        private void Btn_xml_de_ara_Click(object sender, EventArgs e)
        {
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(_000_Classlar.Global.AppPath + "\\_023_XML_Islemleri\\XML\\Proje.xml", new XmlReaderSettings());
            DataSet ds = new DataSet();
            DataView dv;
            ds.ReadXml(xmlFile);

            dv = new DataView(ds.Tables[0]);
            dv.Sort = "Proje_Adı";
            int index = dv.Find(txt_aranacak_metin.Text);

            if (index == -1)
            {
                lbl_sonuc.Text = "Sonuç: Bulunamadı.";
            }
            else
            {
                lbl_sonuc.Text = "Sonuç: Adı: " + dv[index]["Proje_Adı"].ToString() + " || Fiyatı:" + dv[index]["proje_Ucreti"].ToString();
            }
        }

        private void Btn_xml_filtre_Click(object sender, EventArgs e)
        {
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(_000_Classlar.Global.AppPath + "\\_023_XML_Islemleri\\XML\\Proje.xml", new XmlReaderSettings());
            DataSet ds = new DataSet();
            DataView dv;
            ds.ReadXml(xmlFile);
            dv = new DataView(ds.Tables[0], "proje_Ucreti > = " + txt_ucret_filtre.Text + "", "Proje_Adı", DataViewRowState.CurrentRows);
            dv.ToTable().WriteXml("Result.xml");

            dataGridView2.DataSource = dv.ToTable();

        }

        private void Btn_xml_den_excel_Click(object sender, EventArgs e)
        {
            //Microsoft.Office.Interop.Excel.Application xlApp;
            //Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            //Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            //object misValue = System.Reflection.Missing.Value;

            //DataSet ds = new DataSet();
            //XmlReader xmlFile;
            //int i = 0;
            //int j = 0;

            //// xlApp = new Microsoft.Office.Interop.Excel.ApplicationClass(); 
            //// Burada bir hata var ama çözemedim


            ////xlWorkBook = xlApp.Workbooks.Add(misValue);
            //xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //xmlFile = XmlReader.Create("Product.xml", new XmlReaderSettings());
            //ds.ReadXml(xmlFile);

            //for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            //{
            //    for (j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
            //    {
            //        xlWorkSheet.Cells[i + 1, j + 1] = ds.Tables[0].Rows[i].ItemArray[j].ToString();
            //    }
            //}

            //xlWorkBook.SaveAs("Specify path here\\xml2excel.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //xlWorkBook.Close(true, misValue, misValue);
            //xlApp.Quit();

            //releaseObject(xlApp);
            //releaseObject(xlWorkBook);
            //releaseObject(xlWorkSheet);

            //MessageBox.Show("Done .. ");
        }
        //private void releaseObject(object obj)
        //{
        //    try
        //    {
        //        System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
        //        obj = null;
        //    }
        //    catch (Exception ex)
        //    {
        //        obj = null;
        //    }
        //    finally
        //    {
        //        GC.Collect();
        //    }
        //} 

        private void Button1_Click_1(object sender, EventArgs e)
        {


            try
            {
                System.Data.OleDb.OleDbConnection MyConnection;
                System.Data.DataSet ds;
                System.Data.OleDb.OleDbDataAdapter MyCommand;
                MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + _000_Classlar.Global.AppPath + "\\_023_XML_Islemleri\\XML\\Test.xls" + "';Extended Properties=Excel 8.0;");
                MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Sayfa1$]", MyConnection);
                MyCommand.TableMappings.Add("Table", "Test");
                ds = new System.Data.DataSet();
                MyCommand.Fill(ds);
                MyConnection.Close();
                ds.WriteXml(_000_Classlar.Global.AppPath + "\\_023_XML_Islemleri\\XML\\Test.xml");
                dataGridView2.DataSource = ds.Tables[0];


             

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }



    }
}

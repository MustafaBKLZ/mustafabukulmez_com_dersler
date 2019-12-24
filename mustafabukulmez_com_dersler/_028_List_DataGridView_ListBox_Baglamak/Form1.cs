using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//https://mustafabukulmez.com/2019/12/24/c-list-ogelerini-datagridview-ve-listbox-a-baglamak/
namespace mustafabukulmez_com_dersler._028_List_DataGridView_ListBox_Baglamak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> lst1 = new List<string>();
        List<string> lst2 = new List<string>();
        List<string> lst3 = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            lst1.Add("1 - C# Programlama");
            lst1.Add("2 - C# Eğitim Seti");
            lst1.Add("3 - C# Dersleri");
            lst1.Add("4 - C# Nedir?");
            lst1.Add("5 - C# Örnekleri");
            lst1.Add("6 - C# 6");
            lst1.Add("7 - C# 7");
            lst1.Add("8 - C# 8");
            lst1.Add("9 - C# 9");
            lst1.Add("10 - C# 10");

            lst2.Add("1 - SQL Eğitim Seti");
            lst2.Add("2 - SQL Dersleri");
            lst2.Add("3 - SQL Nedir?");
            lst2.Add("4 - SQL Örnekleri");

            lst3.Add("1 - LinkedIn");
            lst3.Add("2 - Facebook");
            lst3.Add("3 - İnstagram");
            lst3.Add("4 - Twitter");
            lst3.Add("5 - Twitter");


        }

        void Temizle()
        {
            listBox1.Items.Clear();
            dataGridView1.DataSource = null;
        }
        private void btn_tek_Click(object sender, EventArgs e)
        {
            Temizle();

            for (int i = 0; i < lst1.Count; i++)
            {
                listBox1.Items.Add(lst1[i]);
            }

            DataTable dt = new DataTable();
            DataColumn dtcol1 = new DataColumn("İçerik 1");
            dt.Columns.Add(dtcol1);
            for (int i = 0; i < lst1.Count; i++)
            {
                dt.Rows.Add(lst1[i]);
            }
            dataGridView1.DataSource = dt;
        }

        private void btn_iki_Click(object sender, EventArgs e)
        {
            Temizle();

            List<string> lstmerge = new List<string>();
            lstmerge.AddRange(lst1);
            lstmerge.AddRange(lst2);
            for (int i = 0; i < lstmerge.Count; i++)
            {
                listBox1.Items.Add(lstmerge[i]);
            }

            DataTable dt = new DataTable();
            DataColumn dtcol1 = new DataColumn("İçerik 1");
            DataColumn dtcol2 = new DataColumn("İçerik 2");
            dt.Columns.Add(dtcol1);
            dt.Columns.Add(dtcol2);
            string val1 = "", val2 = "";
            for (int i = 0; i < lst1.Count; i++)
            {
                try { val1 = lst1[i]; } catch (ArgumentOutOfRangeException) { val1 = "--"; }
                try { val2 = lst2[i]; } catch (ArgumentOutOfRangeException) { val2 = "--"; }
                dt.Rows.Add(val1, val2);
            }
            dataGridView1.DataSource = dt;
        }
        //https://mustafabukulmez.com/2019/12/24/c-list-ogelerini-datagridview-ve-listbox-a-baglamak/
        private void btn_uc_Click(object sender, EventArgs e)
        {
            Temizle();
            List<string> lstmerge = new List<string>();
            lstmerge.AddRange(lst1);
            lstmerge.AddRange(lst2);
            lstmerge.AddRange(lst3);
            for (int i = 0; i < lstmerge.Count; i++)
            {
                listBox1.Items.Add(lstmerge[i]);
            }

            DataTable dt = new DataTable();
            DataColumn dtcol1 = new DataColumn("İçerik 1");
            DataColumn dtcol2 = new DataColumn("İçerik 2");
            DataColumn dtcol3 = new DataColumn("İçerik 3");
            dt.Columns.Add(dtcol1);
            dt.Columns.Add(dtcol2);
            dt.Columns.Add(dtcol3);
            string val1 = "", val2 = "", val3 = "";
            for (int i = 0; i < lst1.Count; i++)
            {
                try { val1 = lst1[i]; } catch (ArgumentOutOfRangeException) { val1 = "--"; }
                try { val2 = lst2[i]; } catch (ArgumentOutOfRangeException) { val2 = "--"; }
                try { val3 = lst3[i]; } catch (ArgumentOutOfRangeException) { val3 = "--"; }
                dt.Rows.Add(val1, val2, val3);
            }
            dataGridView1.DataSource = dt;
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
//https://mustafabukulmez.com/2019/12/24/c-list-ogelerini-datagridview-ve-listbox-a-baglamak/
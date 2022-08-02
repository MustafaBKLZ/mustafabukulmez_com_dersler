using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace mustafabukulmez_com_dersler._047_Dizideki_Bir_Elemanın_Indeksini_Bulmak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Yontem_1_Load(object sender, EventArgs e)
        {
            txt_Sayi.Text = "0";
        }

        void find(string metot)
        {
            try
            {
                int item = Convert.ToInt16(txt_Sayi.Text);
                int index = 0;

                switch (metot)
                {
                    case "IndexOf":
                        index = MyArray.array.findIndex_IndexOf(item);
                        lbl_Sonuc.Text = metot + ": İndex numarası: " + index;
                        break;
                    case "FindIndex":
                        index = MyArray.array.findIndex_FindIndex(item);
                        lbl_Sonuc.Text = metot + ": İndex numarası: " + index;
                        break;
                    case "Enumrable_First":
                        index = MyArray.array.findIndex_EnumrableFirst(item);
                        lbl_Sonuc.Text = metot + ": İndex numarası: " + index;
                        break;
                    case "Enumrable_FirstOrDefault":
                        index = MyArray.array.findIndex_EnumrableFirstOrDefault(item);
                        lbl_Sonuc.Text = metot + ": İndex numarası: " + index;
                        break;
                    case "Performing_Linear_Search":
                        index = MyArray.array.findIndex_PerformingLinearSearch(item);
                        lbl_Sonuc.Text = metot + ": İndex numarası: " + index;
                        break;
                }
            }
            catch (Exception)
            {
                txt_Sayi.Text = "0";
                MessageBox.Show("Lütfen bir sayı giriniz.");
            }
        }

        private void btn_IndexOf_Click(object sender, EventArgs e)
        {
            find("IndexOf");
        }

        private void btn_FindIndex_Click(object sender, EventArgs e)
        {
            find("FindIndex");
        }

        private void btn_Enumrable_First_Click(object sender, EventArgs e)
        {
            find("Enumrable_First");
        }

        private void btn_Enumrable_FirstOrDefault_Click(object sender, EventArgs e)
        {
            find("Enumrable_FirstOrDefault");
        }

        private void btn_Performing_Linear_Search_Click(object sender, EventArgs e)
        {
            find("Performing_Linear_Search");
        }

    }
}

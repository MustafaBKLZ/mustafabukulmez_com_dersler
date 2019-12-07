using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//https://mustafabukulmez.com/2019/12/07/c-listboxlar-arasi-drag-drop-surukle-birak/
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mustafabukulmez_com_dersler._027_Listboxlar_Arasi_Surukle_Birak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ListBox listbox_Item_Alinan;
        ListBox lstbox_Item_Birakilan;
        int Listbox_Index = 0;
        //https://mustafabukulmez.com/2019/12/07/c-listboxlar-arasi-drag-drop-surukle-birak/
        private void Form1_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        void Doldur()
        {
            //for (int i = 0; i < 40; i++)
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                listBox1.Items.Add("List" + (i + 1).ToString() + " - " + (i + 1).ToString());
            }
        }

        private void btn_rastgele_dagit_Click(object sender, EventArgs e)
        {
            Sıfırla();

            Random Rnd = new Random(); // Random bir ListBox seçmek için.
            int RandomSayi = 0;

            for (int i = 0; i < listBox1.Items.Count; i++) // ilk olarak herşeyi ListBox1'e yüklediğimiz için.
            {
                RandomSayi = Rnd.Next(panel1.Controls.Count - 1);
                // Almak istediğimiz Random sayı, Panel içindeki Listbox sayısı kadar olmasını istiyoruz.
                // -1 vermemizdeki sebep ise index'leme 0 dan başlar. Sayısı elle yazmadığımız tam Listbox sayısı kadar 
                // olmasını istemiyoruz. Sayıdan 1 az olsun ki index'ler tutsun.

                lstbox_Item_Birakilan = (ListBox)panel1.Controls[RandomSayi];
                // Panelde sadece Listbox'lar olduğundan dolayı progra kırılmaz.
                // Elde ettiğimiz Random sayı ile birlikte panelden bir ListBox seçiyoruz.

                lstbox_Item_Birakilan.Items.Add(listBox1.Items[i]);
                // Random sayı ile elimize aldığımız Listbox'a sıradaki itemi ekliyoruz.

                Application.DoEvents();
            }
            listBox1.Items.Clear();
            //Tüm itemler dağıtılacağından dolayı ListBox1'i temizliyoruz.
        }
        private void btn_esit_dagit_Click(object sender, EventArgs e)
        {
            Sıfırla();

            // Düzgün çalışması için Designer.cs'de  listboxların eklenme sırası düzgün olmalı. Yoksa ortadan başlıyor.
            // Ayrıca Designer 'de de sıralı olması gerekiyor.
            for (int i = 0; i < panel1.Controls.Count - 1; i++)
            {
                lstbox_Item_Birakilan = (ListBox)panel1.Controls[i + 1];
                string name = lstbox_Item_Birakilan.Name;
                lstbox_Item_Birakilan.Items.Add(listBox1.Items[1]);
                listBox1.Items.Remove(listBox1.Items[1]);

            }
        }


        //https://mustafabukulmez.com/2019/12/07/c-listboxlar-arasi-drag-drop-surukle-birak/
        private void btn_sifirla_Click(object sender, EventArgs e)
        {
            Sıfırla();
        }
        void Sıfırla()
        {
            foreach (ListBox item in panel1.Controls)
            {
                item.Items.Clear();
            }
            Doldur();
        }
        private void listBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
                e.Effect = DragDropEffects.Move;
        }
        private void listBox_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
                e.Effect = DragDropEffects.All;
        }
        private void listBox_MouseDown(object sender, MouseEventArgs e)
        {
            listbox_Item_Alinan = sender as ListBox;

            Point kor_nokta = new Point(e.X, e.Y);
            Listbox_Index = listbox_Item_Alinan.IndexFromPoint(kor_nokta);
            if (Listbox_Index == -1)
                return;
            if (e.Button == MouseButtons.Left)
                listbox_Item_Alinan.DoDragDrop(listbox_Item_Alinan.Items[Listbox_Index].ToString(), DragDropEffects.All);
        }
        private void listBox_DragDrop(object sender, DragEventArgs e)
        {
            lstbox_Item_Birakilan = sender as ListBox;
            lstbox_Item_Birakilan.Items.Add(listbox_Item_Alinan.Items[Listbox_Index]);
            listbox_Item_Alinan.Items.Remove(listbox_Item_Alinan.Items[Listbox_Index]);
        }


    }
}
//https://mustafabukulmez.com/2019/12/07/c-listboxlar-arasi-drag-drop-surukle-birak/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        void Doldur()
        {
            for (int i = 0; i < 40; i++)
            {
                listBox1.Items.Add("List" + (i + 1).ToString() + " - " + (i + 1).ToString());
            }
        }

        private void btn_sifirla_Click(object sender, EventArgs e)
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
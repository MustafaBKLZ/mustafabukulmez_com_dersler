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

namespace mustafabukulmez_com_dersler._035_Klasordeki_Dosya_Bilgilerini_Almak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        FileInfo[] Files;
        private void btn_klasor_Sec_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                ////YOL I
                DirectoryInfo d = new DirectoryInfo(fbd.SelectedPath);
                Files = d.GetFiles("*.txt"); // sadece txt dosyaları
                //Files = d.GetFiles(); // tüm dosyalar
                string str = "";
                foreach (FileInfo file in Files)
                {
                    listBox1.Items.Add(file.Name);
                }

                //// YOL II
                //string[] filePaths = Directory.GetFiles(fbd.SelectedPath, "*.txt", SearchOption.TopDirectoryOnly); // sadece txt dosyaları
                //string[] filePaths = Directory.GetFiles(fbd.SelectedPath, "*.*", SearchOption.TopDirectoryOnly); // tüm dosyalar.
                //foreach (string file in filePaths)
                //{
                //    listBox1.Items.Add(file);
                //}

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string str = listBox1.GetItemText(listBox1.SelectedItem);
            int index = listBox1.SelectedIndex;
            listBox2.Items.Clear();
            listBox2.Items.Add("Length : " + Files[index].Length);
            listBox2.Items.Add("LastWriteTime : " + Files[index].LastWriteTime);
            listBox2.Items.Add("Extension : " + Files[index].Extension);
            listBox2.Items.Add("LastAccessTime : " + Files[index].LastAccessTime);
            textBox1.Text = File.ReadAllText(Files[index].FullName);
        }
    }
}

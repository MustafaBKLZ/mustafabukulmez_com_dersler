using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace mustafabukulmez_com_dersler._2_FolderBrowserDialog_Kullanimi
{
    public partial class FolderBrowserDialogKullanimi_ : DevExpress.XtraEditors.XtraForm
    {
        public FolderBrowserDialogKullanimi_()
        {
            InitializeComponent();
        }
        string Secili_Klsaor_Yolu = "";

        //https://mustafabukulmez.com/2018/11/20/c-folderbrowserdialog-kullanimi-ornekli-anlatim/ 

        private void btn_goster_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Klasor = new FolderBrowserDialog();
            //Klasor.RootFolder = Environment.SpecialFolder.CommonProgramFiles;  
            Klasor.ShowNewFolderButton = false;
            Klasor.Description = "Lütfen Bir Dosya Seçin";
            if (Klasor.ShowDialog() == DialogResult.OK)
            {
                Secili_Klsaor_Yolu = Klasor.SelectedPath;
                lbl_klasor_yolu.Text = Klasor.SelectedPath;

                // Xml dosyalarının olduğu klasörü aldık.
                DirectoryInfo XMLKonum = new DirectoryInfo(Klasor.SelectedPath);
                // klasördeki, sadece xml uzantılı dosyaları aldık
                FileInfo[] Dosyalar = XMLKonum.GetFiles("*.xml");
                listBox1.Items.Clear();
                // Array List'imizi listbox1'in datasource'una aktardık.
                listBox1.DataSource = Dosyalar;
            }
            else
            {
                MessageBox.Show("Hiçbir Klasör Seçilmedi");
            }
        }

        private void FolderBrowserDialogKullanimi__Load(object sender, EventArgs e)
        {

        }
    }
}
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

namespace mustafabukulmez_com_dersler._040_Metin_Belgesi_Okuma_Yazma
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
        private void btn_yaz_Click(object sender, EventArgs e)
        {
            Metin_Yaz(txt_yazilacak_metin.Text);
        }
        void Metin_Yaz(string text)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.CreatePrompt = true; // dosya yoksa üret
            save.OverwritePrompt = true; // üzerine yazma uyarısı
            save.Title = "Metin Dosyaları";
            save.DefaultExt = "txt";
            save.Filter = "txt Dosyaları (*.txt)|*.txt|Tüm Dosyalar(*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                if (chk_altina_ekle.CheckState == CheckState.Checked)
                {
                    // Burada AppandText metodunu kullanmak için FileStream kullandık. Bunun amacı farklı yöntemleri görmenizi istememdir.
                    FileStream fs = new FileStream(save.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    fs.Close();
                    File.AppendAllText(save.FileName, Environment.NewLine + txt_yazilacak_metin.Text);
                }
                else
                {
                    if (File.Exists(save.FileName))
                    {
                        StreamReader Oku = new StreamReader(save.FileName);
                        string okunan = Oku.ReadToEnd();
                        Oku.Close();
                        if (okunan.Trim() != string.Empty)
                        {
                            switch (MessageBox.Show("Seçtiğiniz belge boş değil. Üzerine yazmak istiyorsanız -EVET-, ekrana getirmek istiyorsanız -HAYIR-, işlemi iptal etmek istiyorsanız -VAZGEÇ-'i seçin", "İşlem Seçin", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                            {
                                case DialogResult.Cancel:
                                    break;
                                case DialogResult.Yes:
                                    StreamWriter Kayit = new StreamWriter(save.FileName);
                                    Kayit.WriteLine(text);
                                    Kayit.Close();
                                    break;
                                case DialogResult.No:
                                    txt_yazilacak_metin.Text = okunan;
                                    break;
                            }
                        }
                    }
                    else
                    {
                        StreamWriter Kayit = new StreamWriter(save.FileName);
                        Kayit.WriteLine(text);
                        Kayit.Close();
                    }
                }
            }
        }

        void Dosya_Olustur(string dosya_full_yol)
        {
            // dosya_full_yol = C:\\MetinBelgei\Yeni Metin Belgesi.txt
            if (!File.Exists(dosya_full_yol))// = if (File.Exists(dosya_full_yol) == false)
            {
                File.Create(dosya_full_yol);
            }
        }

        private void btn_oku_Click(object sender, EventArgs e)
        {
            Metin_Oku();
        }
        void Metin_Oku()
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "txt Dosyaları (*.txt)|*.txt|Tüm Dosyalar(*.*)|*.*";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Metin Dosyası Seçiniz..";
            if (file.ShowDialog() == DialogResult.OK)
            {
                StreamReader Kayit = new StreamReader(file.FileName);
                txt_okunan_metin.Text = Kayit.ReadToEnd();
                Kayit.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Diagnostics;

//https://mustafabukulmez.com/2019/12/28/c-process-islemleri-neler-yapilabilir/
namespace mustafabukulmez_com_dersler._030_Process_islemleri_Neler_Yapılabilir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string fileName = @"D:\Deneme.txt";
        string writeText = "Bu bir deneme yazısıdır.";
        private void Form1_Load(object sender, EventArgs e)
        {
            // çalışmak için bir dosya oluşturduk.
            System.IO.FileStream fs = new System.IO.FileStream(fileName, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write);
            fs.Close();
            System.IO.File.AppendAllText(fileName, Environment.NewLine + writeText);

            txt_dosya.Text = fileName;
            txt_word_ile.Text = fileName;
        }

        private void btn_klasor_ac_Click(object sender, EventArgs e)
        {
            Process.Start(txt_klasor.Text);
        }
        private void btn_dosya_ac_Click(object sender, EventArgs e)
        {
            Process.Start(txt_dosya.Text);
        }
        private void btn_google_Click(object sender, EventArgs e)
        {
            Process.Start("http://google.com/search?q=" + txt_google_ara.Text);
        }
        //https://mustafabukulmez.com/2019/12/28/c-process-islemleri-neler-yapilabilir/
        private void btn_word_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "WINWORD.EXE";
            startInfo.Arguments = txt_word_ile.Text;
            Process.Start(startInfo);
        }

        private void btn_islemler_liste_Click(object sender, EventArgs e)
        {
            IslemlerListesi();
        }
        void IslemlerListesi()
        {
            Process[] islemler = Process.GetProcesses();
            list_islemler.Items.Add(string.Format("Toplam: {0}", islemler.Length));
            list_islemler.Items.Add("------------");
            foreach (Process islem in islemler)
            {
                list_islemler.Items.Add(islem.Id);
            }
        }

        private void btn_islemler_adi_Click(object sender, EventArgs e)
        {
            Process[] islemler = Process.GetProcessesByName(txt_aranacak_islem.Text);
            list_islemler_adlari.Items.Add(txt_aranacak_islem.Text + " Adı İle " + islemler.Length + " Adet İşlem Çalışıyor");
            list_islemler_adlari.Items.Add("--------------");
            foreach (Process islem in islemler)
            {
                list_islemler_adlari.Items.Add("       " + txt_aranacak_islem.Text + " işlemi çalışıyor. ID = " + islem.Id);
            }
        }

        private void list_islemler_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_id_ile_kapat.Text = list_islemler.SelectedItem.ToString();
        }
        private void btn_islem_kapat_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] islemler = Process.GetProcesses();
                foreach (Process islem in islemler)
                    if (islem.Id == Convert.ToInt32(txt_id_ile_kapat.Text))
                    {
                        try
                        {
                            islem.Kill();
                            IslemlerListesi();
                        }
                        catch (Win32Exception)
                        {
                            MessageBox.Show("Bu işlem kapatılamaz.");
                        }
                        break;
                    }
            }
            catch (FormatException)
            {
                Process islem = Process.Start("notepad.exe");
                System.Threading.Thread.Sleep(3000);
                islem.Kill();
            }
        }

    }
}


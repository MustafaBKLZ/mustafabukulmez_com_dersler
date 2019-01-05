using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace mustafabukulmez_com_dersler
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Kurulu_Antivirus_Bulmak_Click(object sender, EventArgs e)
        {
            _001_Kurulu_Antivirus_Bulmak.AntivirusBulmak fr = new _001_Kurulu_Antivirus_Bulmak.AntivirusBulmak();
            fr.ShowDialog();
        }

        private void btn_FolderBrowserDialog_Kullanimi_Click(object sender, EventArgs e)
        {
            _002_FolderBrowserDialog_Kullanimi.FolderBrowserDialogKullanimi_ fr = new _002_FolderBrowserDialog_Kullanimi.FolderBrowserDialogKullanimi_();
            fr.ShowDialog();
        }

        private void btn_dt_bu_satir_baska_tabloya_ait_Click(object sender, EventArgs e)
        {
            _003_DataTable_Bu_Satir_Baska_Tabloya_Ait_Hatasi.form1 fr = new _003_DataTable_Bu_Satir_Baska_Tabloya_Ait_Hatasi.form1();
            fr.ShowDialog();
        }

        private void btn_thread_Sleep_Click(object sender, EventArgs e)
        {
            _004_Thread_Sleep_ile_Islem_Suresini_Uzatmak.thread_sleep fr = new _004_Thread_Sleep_ile_Islem_Suresini_Uzatmak.thread_sleep();
            fr.ShowDialog();
        }

        private void btn__5_TextBox_sadece_sayi_harf_girisi_Click(object sender, EventArgs e)
        {
            _005_TextBox_sadece_sayi_harf_girisi.Form1 fr = new _005_TextBox_sadece_sayi_harf_girisi.Form1();
            fr.ShowDialog();
        }

        private void btn_6_String_Sayisal_Deger_Kontrolu_Click(object sender, EventArgs e)
        {
            _006_String_Sayisal_Deger_Kontrolu.Form1 fr = new _006_String_Sayisal_Deger_Kontrolu.Form1();
            fr.ShowDialog();
        }

        private void btn_7_Kelime_heceleme_islemi_Click(object sender, EventArgs e)
        {
            _007_Kelime_heceleme_islemi.Form2 fr = new _007_Kelime_heceleme_islemi.Form2();
            fr.ShowDialog();
        }

        private void btn__8_Gridview_den_textbox_a_Veri_cekme_Click(object sender, EventArgs e)
        {
            _008_Gridview_den_textbox_a_Veri_cekme.ListeForm fr = new _008_Gridview_den_textbox_a_Veri_cekme.ListeForm();
            fr.ShowDialog();
        }

        private void btn__9_NotiftyIcon_Kullanimi_Click(object sender, EventArgs e)
        {
            _009_NotiftyIcon_Kullanimi.AnaMenu fr = new _009_NotiftyIcon_Kullanimi.AnaMenu();
            fr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _010_LINQ_to_XML.LINQ_to_XML fr = new _010_LINQ_to_XML.LINQ_to_XML();
            fr.ShowDialog();
        }

        private void btn__011_Sayilari_Roma_Rakamina_Cevir_Click(object sender, EventArgs e)
        {
            _011_Sayilari_Roma_Rakamina_Cevir.Form1 fr = new _011_Sayilari_Roma_Rakamina_Cevir.Form1();
            fr.ShowDialog();
        }

        private void btn__012_kombinasyon_hesaplama_Click(object sender, EventArgs e)
        {
            _012_kombinasyon_hesaplama.Form1 fr = new _012_kombinasyon_hesaplama.Form1();
            fr.ShowDialog();
        }
    }
}
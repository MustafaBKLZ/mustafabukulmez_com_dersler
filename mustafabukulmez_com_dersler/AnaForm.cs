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
            treeView1.Nodes.Add("Ders 001 - C# Kurulu Anti Virüs Programını Bulmak");
            treeView1.Nodes.Add("Ders 002 - C# FolderBrowserDialog Kullanimi");
            treeView1.Nodes.Add("Ders 003 - C# DataTable 'Bu satır başka bir tabloya ait' Hatası Çözümü");
            treeView1.Nodes.Add("Ders 004 - C# Thread Sleep ile İşlem Süresini Uzatmak");
            treeView1.Nodes.Add("Ders 005 - C# Textbox Sadece Sayı Harf Girişi Yaptırmak");
            treeView1.Nodes.Add("Ders 006 - C# String Sayısal Değer Kontrolü");
            treeView1.Nodes.Add("Ders 007 - C# Kelime Heceleme İşlemi");
            treeView1.Nodes.Add("Ders 008 - C# DataGridView'den Veri Çekme");
            treeView1.Nodes.Add("Ders 009 - C# NotifyIcon Kullanımı ve NotifyIcon Bildirimleri");
            treeView1.Nodes.Add("Ders 010 - C# Linq To XML ile XML Dosyalarla Çalışmak");
            treeView1.Nodes.Add("Ders 011 - C# Sayıyı Roma Rakamlarına Çevirme");
            treeView1.Nodes.Add("Ders 012 - C# Kombinasyon Hesaplama ");
            treeView1.Nodes.Add("Ders 013 - C# Permütasyon Hesaplama ");
            treeView1.Nodes.Add("Ders 014 - C# ToolTip Kullanımı - Nesneler İçin Açıklama");
            treeView1.Nodes.Add("Ders 015 - C# Extension Methods - Genişletme Metodları 1, 2, 3");
            treeView1.Nodes.Add("Ders 016 - C# ComboBox TXT Dosyası ile Doldurma");
            treeView1.Nodes.Add("Ders 017 - C# Kill Proccess - Otomatik Program Kapatmak");
            treeView1.Nodes.Add("Ders 018 - C# List<T> Listeler Arasındaki Farkları Bulmak - (Generic List)");
            treeView1.Nodes.Add("Ders 019 - C# Milisaniye Bilgisini Saniye ve Dakikaya Çevirmek");
            treeView1.Nodes.Add("Ders 020 - C# Excel OLEDB Bağlantı ve Veri Okuma – Class");
            treeView1.Nodes.Add("Ders 021 - C# Rastgele Şifre Oluşturma");
            treeView1.Nodes.Add("Ders 022 - C# Özel MessageBox Yapımı");
            treeView1.Nodes.Add("Ders 023 - C# XML İşlemleri");
            treeView1.Nodes.Add("Ders 024 - C# Drag Drop");
            treeView1.Nodes.Add("Ders 025 - C# Çoklu Excel Dosyası Okuma");
            treeView1.Nodes.Add("Ders 026 - C# User Control Kullanımı");
            treeView1.Nodes.Add("Ders 027 - C# Listboxlar Arası Sürükle Bırak");
            treeView1.Nodes.Add("Ders 028 - C# List Ögelerini DataGridView ve ListBox'a Bağlamak");
            treeView1.Nodes.Add("Ders 029 - C# Formdaki Tüm TextBox Nesnelerini Temizlemek");
            treeView1.Nodes.Add("Ders 030 - C# Process İşlemleri - Neler Yapılabilir?");
            treeView1.Nodes.Add("Ders 031 - C# Çalışan Bir Uygulamanın Sahibi Nasıl Bulunur?");
            treeView1.Nodes.Add("Ders 032 - C# XML Serialization ve Deserialization İşlemleri");


            MessageBox.Show(_000_Classlar.TCKimlikNoKontrol.Kontrol("15735859942")); // sallama bir TC No

        }







        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Index + 1)
            {
                case 1: new _001_Kurulu_Antivirus_Bulmak.AntivirusBulmak() { }.ShowDialog(); break;
                case 2: new _002_FolderBrowserDialog_Kullanimi.FolderBrowserDialogKullanimi_() { }.ShowDialog(); break;
                case 3: new _003_DataTable_Bu_Satir_Baska_Tabloya_Ait_Hatasi.form1() { }.ShowDialog(); break;
                case 4: new _004_Thread_Sleep_ile_Islem_Suresini_Uzatmak.thread_sleep() { }.ShowDialog(); break;
                case 5: new _005_TextBox_sadece_sayi_harf_girisi.Form1() { }.ShowDialog(); break;
                case 6: new _006_String_Sayisal_Deger_Kontrolu.Form1() { }.ShowDialog(); break;
                case 7: new _007_Kelime_heceleme_islemi.Form2() { }.ShowDialog(); break;
                case 8: new _008_Gridview_den_textbox_a_Veri_cekme.ListeForm() { }.ShowDialog(); break;
                case 9: new _009_NotiftyIcon_Kullanimi.AnaMenu() { }.ShowDialog(); break;
                case 10: new _010_LINQ_to_XML.LINQ_to_XML() { }.ShowDialog(); break;
                case 11: new _011_Sayilari_Roma_Rakamina_Cevir.Form1() { }.ShowDialog(); break;
                case 12: new _012_kombinasyon_hesaplama.Form1() { }.ShowDialog(); break;
                case 13: new _013_permutasyon_hesaplama.Form1() { }.ShowDialog(); break;
                case 14: new _014_Tooltip_Kullanimi.Form1() { }.ShowDialog(); break;
                case 15: new _015_Extension_Methods.Form1() { }.ShowDialog(); break;
                case 16: new _016_ComboBox_TXT_Dosyai_ile_Doldurma.Form1() { }.ShowDialog(); break;
                case 17: new _17_Kill_Proccess_Program_Kapatmak.Form1() { }.ShowDialog(); break;
                case 18: new _018_Listeler_Arasındaki_Farkları_Bulmak.Form1() { }.ShowDialog(); break;
                case 19: new _019_Milisaniye_Bilgisini_Saniye_ve_Dakikaya_Cevirmek.Form1() { }.ShowDialog(); break;
                case 20: new _020_Excel_OLEDB_Baglanti_ve_Veri_Okuma_Class.Form1() { }.ShowDialog(); break;
                case 21: new _021_Rastgele_Sifre_Olusturma.Form1() { }.ShowDialog(); break;
                case 22: new _022_Ozel_MessageBox_Yapimi.AnaForm() { }.ShowDialog(); break;
                case 23: new _023_XML_Islemleri.XML_AnaForm() { }.ShowDialog(); break;
                case 24: new _024_Drag_And_Drop.dragdrop() { }.ShowDialog(); break;
                case 25: new _020_Excel_OLEDB_Baglanti_ve_Veri_Okuma_Class.Form1() { }.ShowDialog(); break;
                case 26: new _026_UserControl_Kullanimi.Form1() { }.ShowDialog(); break;
                case 27: new _027_Listboxlar_Arasi_Surukle_Birak.Form1() { }.ShowDialog(); break;
                case 28: new _028_List_DataGridView_ListBox_Baglamak.Form1() { }.ShowDialog(); break;
                case 29: new _029_Formdaki_Tum_TextBox_Nesnelerini_Temizlemek.Form1() { }.ShowDialog(); break;
                case 30: new _030_Process_islemleri_Neler_Yapılabilir.Form1() { }.ShowDialog(); break;
                case 31: new _031_Calisan_Uygulamanin_Sahibi_Kim.Form1() { }.ShowDialog(); break;
                case 32: new _032_Serialization_Deserialization.Form1() { }.ShowDialog(); break;

            }
        }


    }
}
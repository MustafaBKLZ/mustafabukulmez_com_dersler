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

namespace mustafabukulmez_com_dersler
{
    public partial class AnaForm : DevExpress.XtraEditors.XtraForm
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btn_Kurulu_Antivirus_Bulmak_Click(object sender, EventArgs e)
        {
            _1_Kurulu_Antivirus_Bulmak.AntivirusBulmak fr = new _1_Kurulu_Antivirus_Bulmak.AntivirusBulmak();
            fr.ShowDialog();
        }

        private void btn_FolderBrowserDialog_Kullanimi_Click(object sender, EventArgs e)
        {
            _2_FolderBrowserDialog_Kullanimi.FolderBrowserDialogKullanimi_ fr = new _2_FolderBrowserDialog_Kullanimi.FolderBrowserDialogKullanimi_();
            fr.ShowDialog();
        }

        private void btn_dt_bu_satir_baska_tabloya_ait_Click(object sender, EventArgs e)
        {
            _3_DataTable_Bu_Satir_Baska_Tabloya_Ait_Hatasi.form1 fr = new _3_DataTable_Bu_Satir_Baska_Tabloya_Ait_Hatasi.form1();
            fr.ShowDialog();
        }

        private void btn_thread_Sleep_Click(object sender, EventArgs e)
        {
            _4_Thread_Sleep_ile_Islem_Suresini_Uzatmak.thread_sleep fr = new _4_Thread_Sleep_ile_Islem_Suresini_Uzatmak.thread_sleep();
            fr.ShowDialog();
        }
    }
}
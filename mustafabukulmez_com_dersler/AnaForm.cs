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
            Kurulu_Antivirus_Bulmak.AntivirusBulmak fr = new Kurulu_Antivirus_Bulmak.AntivirusBulmak();
            fr.ShowDialog();
        }

        private void btn_FolderBrowserDialog_Kullanimi_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog_Kullanimi.FolderBrowserDialogKullanimi_ fr = new FolderBrowserDialog_Kullanimi.FolderBrowserDialogKullanimi_();
            fr.ShowDialog();
        }
    }
}
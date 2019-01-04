using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;

namespace mustafabukulmez_com_dersler._1_Kurulu_Antivirus_Bulmak
{
    public partial class AntivirusBulmak : Form
    {
        public AntivirusBulmak()
        {
            InitializeComponent();
        }

        //https://mustafabukulmez.com/2018/11/20/c-folderbrowserdialog-kullanimi-ornekli-anlatim/ 

        private void AntivirusBulmak_Load(object sender, EventArgs e)
        {
            ManagementObjectSearcher s = new ManagementObjectSearcher("root\\SecurityCenter2", "Select * from AntivirusProduct",
           new EnumerationOptions(null, System.TimeSpan.MaxValue, 1, true, false, true, true, false, true, true));
            // sistem database'i üzerinden 
            // Select * from AntivirusProduct
            // sorgusu ile kurulu olan antivirüs'ü buluyoruz.

            var sonucGetir = s.Get(); 
            foreach (var aramaSonucu in sonucGetir)
            {
                textEdit1.Text = (aramaSonucu["displayName"].ToString());
                textEdit2.Text = (aramaSonucu["pathToSignedProductExe"].ToString());
            }
        }
    }
}

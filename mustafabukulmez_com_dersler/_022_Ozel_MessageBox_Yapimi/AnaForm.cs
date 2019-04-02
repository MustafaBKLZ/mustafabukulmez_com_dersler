using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//https://mustafabukulmez.com/2019/04/02/c-ozel-messagebox-yapimi/
namespace mustafabukulmez_com_dersler._022_Ozel_MessageBox_Yapimi
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
        private void btn_devam_et_Click(object sender, EventArgs e)
        {
            DialogResult cvp = Mesaj("Deneme Mesaj", "Deneme mesaş Başlık");
            lbl_mesaj.Text = "Verilen Cevap " + cvp.ToString();
        }

        DialogResult Mesaj(string Mesaj, string Baslik)
        {
            MyMessageBox fr = new MyMessageBox();
            fr.Text = Baslik;
            fr.lbl_mesaj.Text = Mesaj;
            fr.ShowDialog();
            return fr.cevap;
            //https://mustafabukulmez.com/2019/04/02/c-ozel-messagebox-yapimi/
        }
    }
}

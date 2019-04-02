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
    public partial class MyMessageBox : Form
    {
        public MyMessageBox()
        {
            InitializeComponent();
        }

        public DialogResult cevap;
        private void MyMessageBox_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_devam_Click(object sender, EventArgs e)
        {
            cevap = DialogResult.OK;
            Close();
        }

        private void btn_vazgeç_Click(object sender, EventArgs e)
        {
            cevap = DialogResult.Abort;
            Close();
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            cevap = DialogResult.Cancel;
            Close();
        }

        //https://mustafabukulmez.com/2019/04/02/c-ozel-messagebox-yapimi/
    }
}

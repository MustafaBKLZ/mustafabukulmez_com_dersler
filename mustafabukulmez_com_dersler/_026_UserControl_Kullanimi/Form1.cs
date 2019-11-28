using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mustafabukulmez_com_dersler._026_UserControl_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.btn_kullanici_sec.Click += Btn_kullanici_sec_Click;
        }

        private void Btn_kullanici_sec_Click(object sender, EventArgs e)
        {
            userControl11.txt_kulkod.Text = "0";
            userControl11.txt_kul_adi.Text = "Mustafa BÜKÜLMEZ";
        }
    }
}

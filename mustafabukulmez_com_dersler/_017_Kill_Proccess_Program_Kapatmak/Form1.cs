using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mustafabukulmez_com_dersler._17_Kill_Proccess_Program_Kapatmak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     //   https://mustafabukulmez.com/2019/02/28/c-kill-proccess-otomatik-program-kapatmak/
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            //foreach (var process in Process.GetProcessesByName("Kapatılacak Programın Adı"))

            foreach (var process in Process.GetProcessesByName(txt_kapatilacak_program_adi.Text))
            {
                process.Kill();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

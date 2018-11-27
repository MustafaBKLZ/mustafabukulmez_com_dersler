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
using System.Threading;

//https://mustafabukulmez.com/c-sharp-egitim-seti-erp-programlama/

namespace mustafabukulmez_com_dersler._4_Thread_Sleep_ile_Islem_Suresini_Uzatmak
{
    public partial class thread_sleep : DevExpress.XtraEditors.XtraForm
    {
        public thread_sleep()
        {
            InitializeComponent();
        }

        private void thread_sleep_Load(object sender, EventArgs e) { }

        int saniye1 = 0, saniye2 = 0;

        private void btn_basla_normal_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            for (int i = 0; i < 10; i++)
            {
                listBox2.Items.Add(i);
                Application.DoEvents(); // işlemi anında yapsın bizde görelim.
            }
            timer2.Enabled = false;
        }


        private void btn_basla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(i);
                Thread.Sleep(1000); // milisaniye cinsinden
                Application.DoEvents(); // işlemi anında yapsın bizde görelim.
            }
            timer1.Enabled = false;
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye1++;
            lbl_tmr_1.Text = saniye1 + " SN. Sürdü";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            saniye2++;
            lbl_tmr_2.Text = saniye2 + " SN. Sürdü";
        }


    }
}
//https://mustafabukulmez.com/c-sharp-egitim-seti-erp-programlama/
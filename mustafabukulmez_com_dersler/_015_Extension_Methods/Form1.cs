using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//https://mustafabukulmez.com/2019/01/05/c-extension-methods-genisletme-metodlari-1/
//https://mustafabukulmez.com/2019/01/05/c-extension-methods-genisletme-metodlari-2/

namespace mustafabukulmez_com_dersler._015_Extension_Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        void Extension_Method_1()
        {
            string str = textBox1.Text;
            int i = str.ToInt32();
            i = textBox1.ToInt32();
            i = this.ToInt32();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToClearText();
        }
        private void btn_kontrol_Click(object sender, EventArgs e)
        {
            MailAddress mail = textBox2.Text.ToMailAdress();
            MessageBox.Show(mail.Address);
        }
        private void btn_karakter_al_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox3.Text.ToGetLeftChar(5));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox3.Text.ToGetLRightChar(5));
        }

    }



    //https://mustafabukulmez.com/2019/01/05/c-extension-methods-genisletme-metodlari-1/
    //https://mustafabukulmez.com/2019/01/05/c-extension-methods-genisletme-metodlari-2/
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace mustafabukulmez_com_dersler._045_SHA384_Sifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string metin = "mustafabükülmez";
            label1.Text = metin + " metnin SHA384 hash çıktısı - ";
            textBox1.Text = SHA384Hash(metin);
        }

        string SHA384Hash(string text)
        {
            string source = text;
            using (SHA384 sha384Hash = SHA384.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
                byte[] hashBytes = sha384Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                return hash;
            }
        }
    }
}

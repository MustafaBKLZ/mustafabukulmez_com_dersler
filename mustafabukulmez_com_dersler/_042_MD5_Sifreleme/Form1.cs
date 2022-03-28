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

namespace mustafabukulmez_com_dersler._042_MD5_Sifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            // DB'den okunan şifre olduğunu varsayalım
            string sifre1 = MD5Hash("mustafabükülmez");
           
            // şifre alanına girilen şifre olduğunu varsayaşım
            string sifre2 = MD5Hash("mustafabükülmez");


            if (sifre1 == sifre2)
            {
                MessageBox.Show("Şifre doğru");
            }
        }

        public static string MD5Hash(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(text);
            dizi = md5.ComputeHash(dizi);
            StringBuilder sb = new StringBuilder();
            foreach (byte ba in dizi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            return sb.ToString();
        }


    }
}

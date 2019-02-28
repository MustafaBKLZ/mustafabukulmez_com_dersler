using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mustafabukulmez_com_dersler._018_Listeler_Arasındaki_Farkları_Bulmak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> liste_A = new List<string>();
            liste_A.Add("A");
            liste_A.Add("B");
            liste_A.Add("C");
            liste_A.Add("D");
            liste_A.Add("E");


            List<string> liste_B = new List<string>();
            liste_B.Add("A");
            liste_B.Add("1");
            liste_B.Add("C");
            liste_B.Add("2");
            liste_B.Add("E");

            listBox1.DataSource = liste_A;
            listBox2.DataSource = liste_B;



            listBox3.DataSource = liste_A.Except(liste_B).ToList();
            listBox4.DataSource = liste_B.Except(liste_A).ToList();
        }
    }
}


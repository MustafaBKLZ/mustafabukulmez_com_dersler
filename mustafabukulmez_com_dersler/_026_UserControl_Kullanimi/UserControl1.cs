using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mustafabukulmez_com_dersler._026_UserControl_Kullanimi
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btn_kullanici_sec_Click(object sender, EventArgs e)
        {
            Form form1 = new Form();
            form1.Height = 300;
            form1.Width = 300;
            form1.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//https://mustafabukulmez.com/2019/01/05/c-tooltip-kullanimi-nesneler-icin-aciklama/
namespace mustafabukulmez_com_dersler._014_Tooltip_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ToolTip Controls_Tooltip(string baslik, string aciklama, Control cntrl)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.Active = true; // Görünsün mü?
            toolTip.ToolTipTitle = baslik; // Çıkacak Mesajın Başlığı
            toolTip.ToolTipIcon = ToolTipIcon.Info; // Çıkacak Mesajda yer alacak ıkon
            toolTip.UseFading = true; // Silinerek kaybolma ve yavaşça görünme
            toolTip.UseAnimation = true; // Animasyonlu açılış
            toolTip.IsBalloon = true; // Baloncuk şekli mi dikdörtgen mi?
            toolTip.ShowAlways = true; // her zaman göster
            toolTip.AutoPopDelay = 3000; // Mesajın açık kalma süresi
            toolTip.ReshowDelay = 3000; // Mause çekildikten kaç ms sonra kaybolsun
            toolTip.InitialDelay = 1000; // Mesajın açılma süresi
            toolTip.BackColor = Color.Red; // arka plan rengi
            toolTip.ForeColor = Color.White; // yazı rengi
            toolTip.SetToolTip(cntrl, aciklama); // Hangi kontrolde görünsün
            return toolTip;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controls_Tooltip("Bu ComboBox'tur", "ComboBox için tooltip tir", comboBox1);
            foreach (Control item in this.Controls)
            {
                if (item.ToString() == "System.Windows.Forms.TextBox")
                {
                    Controls_Tooltip("Bu " + item.ToString() + " nesnesidir.", "Bu nesnenin adı ise " + item.Name, item);
                }               
            }
        }
        //https://mustafabukulmez.com/2019/01/05/c-tooltip-kullanimi-nesneler-icin-aciklama/
    }
}

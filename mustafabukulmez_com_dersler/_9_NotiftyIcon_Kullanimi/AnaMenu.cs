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
using System.Reflection;
//https://mustafabukulmez.com/2019/01/04/c-notifyicon-kullanimi-ve-c-notifyicon-bildirimleri/
namespace mustafabukulmez_com_dersler._9_NotiftyIcon_Kullanimi
{
    public partial class AnaMenu : DevExpress.XtraEditors.XtraForm
    {
        public AnaMenu()
        {
            InitializeComponent();
        }
        int TamamenKapat = 0;

        NotifyIcon notify_Icon = new NotifyIcon();
        private void AnaMenu_Load(object sender, EventArgs e)
        {
            notify_Icon.Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);

        }

        void NotifyBildirim(string baslik, string mesaj)
        {
            notify_Icon.BalloonTipText = mesaj;
            notify_Icon.BalloonTipIcon = ToolTipIcon.Info;
            notify_Icon.BalloonTipTitle = baslik;
            notify_Icon.ShowBalloonTip(3000);
        }
        //https://mustafabukulmez.com/2019/01/04/c-notifyicon-kullanimi-ve-c-notifyicon-bildirimleri/
        private void AnaMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TamamenKapat == 1)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                NotifyIcon();
                NotifyBildirim("Program kapatılmadı!", "Programı kapatamazsınız. Bu sebeple arka planda çalışmaya devam edecek!");
            }
        }
        private void AnaMenu_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                NotifyIcon();
                NotifyBildirim("Program simge durumuna getirildi!", "Program arka planda çalışmaya devam edecek!");
            }
        }

        void NotifyIcon()
        {
            this.Hide();
            notify_Icon.Visible = true;
            notify_Icon.Text = "Notify Icon Uygulaması";
            notify_Icon.BalloonTipTitle = "Notify Icon uygulaması arka planda çalışıyor";
            notify_Icon.BalloonTipText = "Program sağ alt köşede konumlandı.";
            notify_Icon.BalloonTipIcon = ToolTipIcon.Info;
            notify_Icon.ShowBalloonTip(2000);

            notify_Icon.ContextMenuStrip = contextMenuStrip1;

            // notifyIcon için event ataması yaptık
            notify_Icon.MouseDoubleClick += new MouseEventHandler(notify_Icon_MouseDoubleClick);
        }
        void notify_Icon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notify_Icon.Visible = false;
        }

        private void uygulamayıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TamamenKapat = 1;
            Application.Exit();
        }
        private void öneGetirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            notify_Icon.Visible = false;
        }

    }
}
//https://mustafabukulmez.com/2019/01/04/c-notifyicon-kullanimi-ve-c-notifyicon-bildirimleri/
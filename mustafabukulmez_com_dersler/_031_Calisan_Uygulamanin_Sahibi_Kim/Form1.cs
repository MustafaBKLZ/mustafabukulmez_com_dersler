using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mustafabukulmez_com_dersler._031_Calisan_Uygulamanin_Sahibi_Kim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_exe_adi.Text = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            txt_win_kullanici.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }

        private void btn_islemler_getir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName(txt_exe_adi.Text);
            for (int i = 0; i < processes.Count(); i++)
            {
                txt_id.Text = processes[i].Id.ToString();
                GetProcessOwner(processes[i].Id);
            }
        }



        public string GetProcessOwner(int processId)
        {
            string query = "Select * From Win32_Process Where ProcessID = " + processId;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection processList = searcher.Get();

            foreach (ManagementObject obj in processList)
            {
                string[] argList = new string[] { string.Empty, string.Empty };
                int returnVal = Convert.ToInt32(obj.InvokeMethod("GetOwner", argList));
                if (returnVal == 0)
                {
                    // return DOMAIN\user
                    string owner = argList[1] + "\\" + argList[0];
                    txt_user.Text = owner;
                    return owner;
                }
            }
            return "Sahiplik Yok";
        }


    }
}

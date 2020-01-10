using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace mustafabukulmez_com_dersler
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int kapat = 0;
            string exe_Adi = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            string aktif_kullanici = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName(exe_Adi);
            string mevcut_calisan_kul_adi = "";
            for (int i = 0; i < processes.Count(); i++)
            {
                mevcut_calisan_kul_adi = GetProcessOwner(processes[i].Id);
            }

            if (System.Diagnostics.Process.GetProcessesByName(exe_Adi).Length > 1)
            {
                if (mevcut_calisan_kul_adi == aktif_kullanici)
                {
                    kapat = 1;
                    MessageBox.Show("Program zaten çalışıyor");
                }
            }
                       
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (kapat == 0)
            {
                Application.Run(new AnaForm());
            }

        }

        static string GetProcessOwner(int processId)
        {
            string query = "Select * From Win32_Process Where ProcessID = " + processId;
            System.Management.ManagementObjectSearcher searcher = new System.Management.ManagementObjectSearcher(query);
            System.Management.ManagementObjectCollection processList = searcher.Get();

            foreach (System.Management.ManagementObject obj in processList)
            {
                string[] argList = new string[] { string.Empty, string.Empty };
                int returnVal = Convert.ToInt32(obj.InvokeMethod("GetOwner", argList));
                if (returnVal == 0)
                {
                    // return DOMAIN\user
                    string owner = argList[1] + "\\" + argList[0];
                    return owner;
                }
            }
            return "Sahiplik Yok";
        }
    }
}

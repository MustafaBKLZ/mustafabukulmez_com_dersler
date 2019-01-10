using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//https://mustafabukulmez.com/2019/01/10/c-combobox-txt-dosyasi-ile-doldurma/
namespace mustafabukulmez_com_dersler._016_ComboBox_TXT_Dosyai_ile_Doldurma.Sistem
{
    public class GlobalClass
    {
        public static string AppPath = System.Windows.Forms.Application.StartupPath;
        public static void AracMarkalari(ComboBox comboBox1)
        {
            string[] lineOfContents = File.ReadAllLines(GlobalClass.AppPath + "\\_016_ComboBox_TXT_Dosyai_ile_Doldurma\\AracMarkaları.txt", Encoding.GetEncoding("iso-8859-9"));
            // NOT: Burada TXT doyası alt bir klasörde yer aldığından
            // yukarıda da o klasör adını yazmak zorundayız.
            // Projeyi build ettiğinizde Bin/Debug klasörüne baktığınızda
            // _016_ComboBox_TXT_Dosyai_ile_Doldurma adına bir klasör olduğunu görürsünüz.

            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split('\r');
                comboBox1.Items.Add(tokens[0]);
            }

        }
    }
}
//https://mustafabukulmez.com/2019/01/10/c-combobox-txt-dosyasi-ile-doldurma/
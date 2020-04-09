using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mustafabukulmez_com_dersler._000_Classlar
{
    public class Global
    {
        public static string AppPath = System.Windows.Forms.Application.StartupPath;// EXE dosyasının olduğu klasör yolunu verir.

        public static string KartNoTemizle(string text)
        {
            text = text.Replace("-", "").Replace(" ", "").Replace("(", "").Replace(")", "").Replace("_", "");
            return text;
        }
    }
}

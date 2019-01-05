using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

//https://mustafabukulmez.com/2019/01/05/c-extension-methods-genisletme-metodlari-1/
//https://mustafabukulmez.com/2019/01/05/c-extension-methods-genisletme-metodlari-2/
//https://mustafabukulmez.com/2019/01/06/c-extension-methods-genisletme-metodlari-3/

namespace mustafabukulmez_com_dersler._015_Extension_Methods
{
    public static class MyExtensionMethods
    {
        public static int ToInt32(this object sayi)
        {
            try
            {
                if (sayi == null) throw new Exception();
                int x = Convert.ToInt32(sayi);
                return x;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public static string ToClearText(this string TXT)
        {
            TXT = TXT.ToUpper().Replace("SQL", "").Replace("SELECT", "").Replace("DELETE", "").Replace("UPDATE", "")
                .Replace("WHERE", "").Replace("ALTER", "").Replace("INSERT", "");
            return TXT.Trim();
        }
        public static MailAddress ToMailAdress(this string txt)
        {
            MailAddress mail;
            if (txt.Trim() == string.Empty) throw new Exception();
            try
            {
                mail = new MailAddress(txt);
                return mail;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static string ToGetLeftChar(this string txt, int KarakterSayisi)
        {
            if (txt.Length < KarakterSayisi)
                return txt;
            else
                return txt.Substring(0, KarakterSayisi);
        }
        public static string ToGetLRightChar(this string txt, int KarakterSayisi)
        {
            if (txt.Length < KarakterSayisi)
                return txt;
            else
                return txt.Substring(txt.Length - KarakterSayisi, KarakterSayisi);
        }



        public static double ToDouble(this object sayi)
        {
            try
            {
                if (sayi == null) throw new Exception();
                double x = Convert.ToDouble(sayi);
                return x;
            }
            catch (Exception)
            {
                return 1;
            }
        }
        public static DateTime ToDateTime(this object s)
        {
            try
            {
                return Convert.ToDateTime(s);
            }
            catch (Exception)
            {
                return DateTime.MinValue;
            }
        }
        public static bool ToBoolean(this object s)
        {
            try
            {
                return Convert.ToBoolean(s);
            }
            catch (Exception)
            {
                return false;
            }
        }


        public static string ToTelefonFormat(this string telefon)
        {
            Match match;
            string desen = "", DogruTelefon = "";
            telefon = telefon.Replace("-", "").Replace("_", "").Replace("(", "").Replace(")", "").Replace(" ", "").Replace("+", "");
            if (telefon.Substring(0, 2) == "95")
            {
                telefon = telefon.Remove(0, 1);
            }
            switch (telefon.Length)
            {
                case 10:
                    desen = @"^(5(\d{9}))$";
                    break;
                case 11:
                    desen = @"^(05(\d{9}))$";
                    break;
                case 12:
                    desen = @"^(905(\d{9}))$";
                    break;
                default:

                    break;
            }
            match = Regex.Match(telefon, desen, RegexOptions.IgnoreCase);
            if (match.Success)
                switch (telefon.Length)
                {
                    case 10:
                        DogruTelefon = "0" + telefon;
                        break;
                    case 11:
                        DogruTelefon = telefon;
                        break;
                    case 12:
                        DogruTelefon = telefon.Remove(0, 1);
                        break;
                    default:
                        DogruTelefon = "0";
                        break;
                }

            return DogruTelefon;
        }


        public static CheckState ToCheckState(this object value)
        {
            CheckState cs = new CheckState();
            switch (value.ToString())
            {
                case "0":
                    cs = CheckState.Unchecked;
                    break;
                case "false":
                    cs = CheckState.Unchecked;
                    break;
                case "False":
                    cs = CheckState.Unchecked;
                    break;
                case "Unchecked":
                    cs = CheckState.Unchecked;
                    break;

                case "1":
                    cs = CheckState.Checked;
                    break;
                case "true":
                    cs = CheckState.Checked;
                    break;
                case "True":
                    cs = CheckState.Checked;
                    break;
                case "Checked":
                    cs = CheckState.Checked;
                    break;

                case "Indeterminate":        
                    cs = CheckState.Indeterminate;// içi dolu checkbox ne tick var ne boş             
                    break;
                default:
                    cs = CheckState.Indeterminate;// içi dolu checkbox ne tick var ne boş             
                    break;
            }
            return cs;
        }
    }
}
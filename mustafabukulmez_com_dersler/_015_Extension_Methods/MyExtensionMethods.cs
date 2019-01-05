using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

//https://mustafabukulmez.com/2019/01/05/c-extension-methods-genisletme-metodlari-1/
//https://mustafabukulmez.com/2019/01/05/c-extension-methods-genisletme-metodlari-2/

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
    }
}
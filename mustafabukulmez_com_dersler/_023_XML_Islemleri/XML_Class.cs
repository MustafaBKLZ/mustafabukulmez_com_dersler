using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mustafabukulmez_com_dersler._023_XML_Islemleri
{
    public class XML_Class
    {

        // Burada öncelikle tablomuzdaki kolonların tanımlamasını yapmalıyız. Yani tablomuzu modellemeliyiz.
        // Normal bir değişken olarak ya da prop olarak tanımlama yapabilirsiniz.
        // İkisi de çalışır.
        public class Personeller
        {
            public string Adi { get; set; }            //public string Adi = "";
            public int ID = 0;            //public int ID { get; set; }
            public string Soyadi = "";            //public string Soyadi { get; set; }

            // Değişkeni prop olarak tanımlarsanız, VS 2019'da o değişkene yapılan referansların sayısını görebilirsiniz.
            // Yani o değişkenin kaç yerde kullanıldığını görebilirsiniz.
        }

            
        /// <summary>
        /// Personeller XML dosyasına Persone 
        /// </summary>
        /// <param name="per">Personeller Class'ı </param>
        public static void Personeller_Kaydet(Personeller per)
        {
            // Tablomuzu yukarıdaki gibi modelledikten sonra kayıt işlemini yapacak metodumuzu hazırlıyoruz.
            string file_path = _000_Classlar.Global.AppPath + "//XML//Personeller.xml";
            XDocument xDoc = new XDocument();
            xDoc = XDocument.Load(file_path);

            XElement rootElement = xDoc.Root;
            XElement newElement = new XElement("Personel");

            XAttribute idAttribute = new XAttribute("id", per.ID);
            XElement adiElement = new XElement("ad", per.Adi);
            XElement soyadiElement = new XElement("soyad", per.Soyadi);

            newElement.Add(idAttribute, adiElement, soyadiElement);
            rootElement.Add(newElement);
            xDoc.Save(file_path);
        }





    }
}

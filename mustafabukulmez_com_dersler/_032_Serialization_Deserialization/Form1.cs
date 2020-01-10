using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace mustafabukulmez_com_dersler._032_Serialization_Deserialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string strPersonelData;

        private void btn_Serialization_Click(object sender, EventArgs e)
        {
            Personel yeni_Personel = new Personel()
            {
                Adi = txt_adi.Text,
                Soyadi = txt_soyadi.Text,
                Telefon = txt_tel.Text,
                Mail_Adres = txt_mail.Text
            };

            strPersonelData = SerializeObject(yeni_Personel);
            txt_xml_cikti.Text = strPersonelData;
        }
        void Temizle()
        {
            txt_adi.Text = "";
            txt_soyadi.Text = "";
            txt_tel.Text = "";
            txt_mail.Text = "";
        }
        private string SerializeObject(Personel PersObject)
        {
            XmlSerializer MySerializer = new XmlSerializer(typeof(Personel));
            TextWriter TW = new StringWriter();
            MySerializer.Serialize(TW, PersObject);
            Temizle();
            return TW.ToString();
        }

        private void btn_Deserialization_Click(object sender, EventArgs e)
        {
            DeserializeXml(strPersonelData);
        }
            private void DeserializeXml(string XmlData)
            {
                XmlSerializer MyDeserializer = new XmlSerializer(typeof(Personel));
                StringReader SR = new StringReader(XmlData);
                XmlReader XR = new XmlTextReader(SR);
                if (MyDeserializer.CanDeserialize(XR))
                {
                    Personel GelenBilgiler = (Personel)MyDeserializer.Deserialize(XR);
                    PersonelGoster(GelenBilgiler);
                    txt_xml_cikti.Text = "";
                }
            }
        private void PersonelGoster(Personel PersonelObject)
        {
            txt_adi.Text = PersonelObject.Adi;
            txt_soyadi.Text = PersonelObject.Soyadi;
            txt_tel.Text = PersonelObject.Telefon;
            txt_mail.Text = PersonelObject.Mail_Adres;
        }
    }
}

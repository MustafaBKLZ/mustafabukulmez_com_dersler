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
using System.Xml.Linq;

namespace mustafabukulmez_com_dersler._023_XML_Islemleri
{
    public partial class XML_AnaForm : Form
    {
        public XML_AnaForm()
        {
            InitializeComponent();
        }

        //TAVSİYE: Load eventi her zaman en üstte olsun. Yani şuanki olan kısımda...
        private void XML_AnaForm_Load(object sender, EventArgs e)
        {
            XML_URLden_Oku();
        }


        XDocument xDoc = new XDocument();
        string directory_path = _000_Classlar.Global.AppPath + "//XML";
        string file_path = _000_Classlar.Global.AppPath + "//XML//Personeller.xml";
        int xml_ID = 0;


        void Load_Or_Create_XML()
        {
            // eğer bu klasör yoksa klasörü açacak
            if (Directory.Exists(directory_path) == false)
            {
                Directory.CreateDirectory(directory_path);
            }

            // eğer bu xml dosya yoksa temel bir xml dosyası oluşturacağız.
            if (File.Exists(file_path) == false)
            {
                // verdiğimiz xml dosya yolunda xml dosya oluşturuluyor.
                FileStream fs = new FileStream(file_path, FileMode.OpenOrCreate);

                // temel bir xml dosyası hazırlıyoruz.
                string YazilacakIcerik = "<?xml version=\"1.0\" encoding=\"utf-8\" ?> "
                    + Environment.NewLine + "<Personeller> "
                    + Environment.NewLine + "</Personeller>";
                fs.Flush();
                fs.Close();

                // oluşturulan xml dosyasının okunabilmesi için gerekli olan şeyleri içerisine yazdık.
                File.AppendAllText(file_path, YazilacakIcerik);

                // xml dosyasını yükledik
                xDoc = XDocument.Load(file_path);
                lbl_bildirim.Text = "XML Dosya Oluşturuldu ve Yüklendi.";
            }
            else
            {
                // zaten bir xml dosyası vardır ve onu yükledik.
                xDoc = XDocument.Load(file_path);
                lbl_bildirim.Text = "XML Dosya Yüklendi.";
            }

            // xml dosyamızdaki verileri datagirdview de  gösterdik.
            DataGridView_Doldur(file_path);
        }
        void XML_Veri_Ekle()
        {
            // XML dosyamızı yükledik
            xDoc = XDocument.Load(file_path);

            //Oluşturduğumuz Root elementine XML dökümanında ki root elementini seçmesini sağlıyoruz.
            XElement rootElement = xDoc.Root;

            //Yeni bir element oluşturuyoruz.
            XElement newElement = new XElement("Personel");

            //Elementimize attribute yani Id ataması yapıyoruz.
            XAttribute idAttribute = new XAttribute("id", txt_id.Text); // <Personel id="1">

            // verilerimiz
            XElement adiElement = new XElement("ad", txt_ad.Text);  // <ad>Cenk</ad>
            XElement soyadiElement = new XElement("soyad", txt_soyad.Text); // <soyad>Yiğit</soyad>
            // verilerimiz

            //Verilerimizi Personel elementimizin içine sıralı bir şekilde ekliyoruz.
            newElement.Add(idAttribute, adiElement, soyadiElement);

            //Oluşturduğumuz yeni elementi root tagının içine ekliyoruz.
            rootElement.Add(newElement);

            //Yaptığımız işlemi kayıt ediyoruz.
            xDoc.Save(file_path);

            DataGridView_Doldur(file_path);
        }
        void XML_Veri_Guncelle()
        {
            // XML dosyamızı yükledik
            xDoc = XDocument.Load(file_path);

            XElement rootElement = xDoc.Root;
            //Oluşturduğumuz Root elementine XML dökümanında ki root elementini seçmesini sağlıyoruz.

            foreach (XElement Personeller in rootElement.Elements())
            //Root Tagımız içindeki rehber Elementlerinde dönmeye başlıyoruz.
            {
                if (Personeller.Attribute("id").Value == txt_id.Text)
                //attributes id si 1 olan veri yakalıyoruz Xml Dosyamızda Fatih Olan kişi.
                {
                    Personeller.Element("ad").Value = txt_ad.Text;
                    Personeller.Element("soyad").Value = txt_soyad.Text;
                    //attributes id si 1 olan anıl adlı kişiyi selim yap.
                    break;
                    //Dongüden çık.
                }
            }
            xDoc.Save(file_path);
            //Yaptığımız işlemi kayıt ediyoruz.

            DataGridView_Doldur(file_path);
        }
        void XML_Veri_Sil()
        {
            // XML dosyamızı yükledik
            xDoc = XDocument.Load(file_path);

            XElement rootElement = xDoc.Root;
            //Oluşturduğumuz Root elementine XML dökümanında ki root elementini seçmesini sağlıyoruz.

            foreach (XElement Personeller in rootElement.Elements())
            //Root Tagımız içindeki rehber Elementlerinde dönmeye başlıyoruz...
            {
                if (Personeller.Attribute("id").Value == txt_id.Text)
                //attributes id si 2 olan elementi yakalıyoruz Xml Dosyamızda Seyfi Olan kişi...
                {
                    Personeller.Remove();
                    //attributes id si 2 olan elementi Remove metodu ile siliyoruz.
                }
            }
            xDoc.Save(file_path);
            //Yaptığımız işlemi kayıt ediyoruz.

            DataGridView_Doldur(file_path);
        }


        void XML_Veri_Ekle_2()
        {
            XML_Class.Personeller per = new XML_Class.Personeller()
            {
                ID = Convert.ToInt32(txt_id.Text),
                Adi = txt_ad.Text,
                Soyadi = txt_soyad.Text,
            };
            XML_Class.Personeller_Kaydet(per);
        }



        void DataGridView_Doldur(string path)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(path);
            try
            {
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (IndexOutOfRangeException)
            {
                lbl_bildirim.Text = "XML Dosyası boş olduğundan gösterilecek veri bulunamadı.";
            }
        }
        void Temizle()
        {
            xml_ID = 0;
            txt_id.Text = "";
            txt_ad.Text = "";
            txt_soyad.Text = "";
        }


        private void Btn_xml_dosya_olustur_Click(object sender, EventArgs e)
        {
            // XML dosya yoksa oluşturdul
            // XML dosya varsa okuduk
            // Okunan XML dosya içeriğini datagirdview'de gösterdik.
            Load_Or_Create_XML();
        }
        private void Btn_xml_kaydet_Click(object sender, EventArgs e)
        {
            if (xml_ID == 0)
            {
                // XML_Veri_Ekle_2();
                XML_Veri_Ekle();
            }
            else
            {
                XML_Veri_Guncelle();
            }
            Temizle();
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataIndexNo = dataGridView1.Rows[e.RowIndex].Index.ToString();
            txt_ad.Text = dataGridView1.Rows[e.RowIndex].Cells["ad"].Value.ToString();
            txt_soyad.Text = dataGridView1.Rows[e.RowIndex].Cells["soyad"].Value.ToString();
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            xml_ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
        }
        private void Btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void Btn_sil_Click(object sender, EventArgs e)
        {
            XML_Veri_Sil();
            Temizle();
        }


        void XML_URLden_Oku()
        {
            


            // string URLString = "http://localhost/books.xml";
            string URLString = _000_Classlar.Global.AppPath + "\\XML\\Personeller.xml";
            XmlTextReader reader = new XmlTextReader(URLString);

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.                        
                        Console.Write("<" + reader.Name);
                        while (reader.MoveToNextAttribute()) // Read the attributes.                            
                            Console.Write(" " + reader.Name + "='" + reader.Value + "'");
                        Console.Write(">"); Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text: //Display the text in each element.                       
                        Console.WriteLine(reader.Value);
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.                        
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;
                }
            }

            xDoc = XDocument.Load(URLString);
            DataGridView_Doldur(URLString);


        }




    }
}

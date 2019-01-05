using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
//https://mustafabukulmez.com/2019/01/05/c-linq-to-xml-ile-xml-dosyalarla-calismak/
namespace mustafabukulmez_com_dersler._010_LINQ_to_XML
{
    public partial class LINQ_to_XML : Form
    {
        public LINQ_to_XML()
        {
            InitializeComponent();
        }

        string Root_Element = "PERSONELLER";
        string Root_Child_Element = "Personel";
        string AppPath = System.Windows.Forms.Application.StartupPath;// EXE dosyasının olduğu klasör yolunu verir.
        XDocument xDoc;

        private void btn_Bilgileri_Goster_Click(object sender, EventArgs e)
        {
            Clear_All();

            // Her işlemde kullanacağımızdan bunu en dışa aldık.
            string DosyaPath = AppPath + "\\_010_LINQ_to_XML\\myXML.xml";
            xDoc = XDocument.Load(DosyaPath);
            // Her işlemde kullanacağımızdan bunu en dışa aldık.


            XML_to_GridView(DosyaPath); // XML deki Verileri GRID'e Doldurmak
            XML_Element_Elements(xDoc); // XML deki Verileri ListBox'a Doldurmak
            XML_Node_Attiribute(xDoc); // XML deki Aktif=True olan Verileri ListBox'a Doldurmak
            XML_Tum_Childleri_Oku(xDoc); // XML deki tüm Personel child elementlerdeki Ad bilgisini okuduk.
            XML_sum_count_avg(xDoc); // XML deki tüm Personel child elementler üzerinden sum, count, avg bilgilerini oluşturduk.
            XML_sum_count_avg_Attirubte(xDoc);  // XML deki tüm Personel child elementler üzerinden sum, count, avg bilgilerini oluşturduk.
            XMl_Select_Order_By(xDoc); // XML - Select Ad From PERSONELLER order by Ad Desc
            XML_Select_Group_By(xDoc); // XML - Select Departman, sum(maas) From PERSONELLER group by Departman

        }
        void Clear_All()
        {
            listBox_attiribute.Items.Clear();
            listBox_normal.Items.Clear();
            listBox_sadece_tek_node.Items.Clear();
            dataGridView1.DataSource = null;
            listBox_select_order_by.Items.Clear();
            listBox_Group_by.Items.Clear();
        }
        void XML_to_GridView(string _DosyaPath)
        {
            DataSet ds = new DataSet();
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(_DosyaPath, new XmlReaderSettings());
            ds.ReadXml(xmlFile);
            dataGridView1.DataSource = ds.Tables[0];
        }
        void XML_Element_Elements(XDocument xDoc)
        {
            foreach (XElement urun in xDoc.Element(Root_Element).Elements(Root_Child_Element))
            // PERSONELLER root node ve onun içindeki Personel child node lerini gezeceğiz.
            {
                listBox_normal.Items.Add(string.Format("{0} - {1} - {2} - {3}",
                    urun.Element("ID").Value, // PERSONELLER > Personel > ID
                    urun.Element("Ad").Value, // PERSONELLER > Personel > Ad
                    urun.Element("Maas").Value, // PERSONELLER > Personel > Maas
                    urun.Element("Departman").Value // PERSONELLER > Personel > Departman
                    ));
            }
        }
        //https://mustafabukulmez.com/2019/01/05/c-linq-to-xml-ile-xml-dosyalarla-calismak/
        void XML_Node_Attiribute(XDocument xDoc)
        {
            foreach (XElement urun in xDoc.Element(Root_Element).Elements(Root_Child_Element))
            // PERSONELLER root node ve onun içindeki Personel child node lerini gezeceğiz.
            {
                XAttribute att = urun.Attribute("Aktif");

                if (att != null && att.Value == "True")
                {
                    listBox_attiribute.Items.Add(string.Format("{0} - {1} - {2} - {3}",
                urun.Element("ID").Value, // PERSONELLER > Personel > ID
                urun.Element("Ad").Value, // PERSONELLER > Personel > Ad
                urun.Element("Maas").Value, // PERSONELLER > Personel > Maas
                urun.Element("Departman").Value // PERSONELLER > Personel > Departman
                ));
                }
            }
        }
        void XML_Tum_Childleri_Oku(XDocument xDoc)
        {
            // burada PERSONELLER root elementini yazmamıza gerek yok. Çünkü xDoc.Root. kısmı işimizi çözüyor.
            foreach (XElement element in xDoc.Root.Elements(Root_Child_Element).Elements("Ad"))
            {
                // burada Attirbute ye bakmadığımızdan tüm isimler gelecektir.
                listBox_sadece_tek_node.Items.Add(element.Value);
            }
        }
        void XML_sum_count_avg(XDocument xDoc)
        {
            // PERSONELLER kök elementi altında sadece Personel elementleri yer aldığından dolayı 
            // xDoc.Root.Elements().Sum(....) şeklinde yazarak Maas toplamlarını alabiliriz.

            double toplamFiyat = xDoc.Root.Elements(Root_Child_Element).Sum(element => double.Parse(element.Element("Maas").Value));
            txt_sum.Text = toplamFiyat.ToString();

            int toplamAdet = xDoc.Root.Elements(Root_Child_Element).Count();
            txt_count.Text = toplamAdet.ToString();

            double maasOrtalamasi = xDoc.Root.Elements(Root_Child_Element).Average(element => double.Parse(element.Element("Maas").Value));
            txt_avg.Text = maasOrtalamasi.ToString();

        }
        void XML_sum_count_avg_Attirubte(XDocument xDoc)
        {
            // PERSONELLER kök elementi altında sadece Personel elementleri yer aldığından dolayı 
            // xDoc.Root.Elements().Sum(....) şeklinde yazarak Maas toplamlarını alabiliriz.

            double toplamFiyat = xDoc.Root.Elements().Where(xe => xe.Attribute("Aktif").Value == "True").Sum(urun => double.Parse(urun.Element("Maas").Value));
            txt_sum_true.Text = toplamFiyat.ToString();

            int toplamAdet = xDoc.Root.Elements().Where(xe => xe.Attribute("Aktif").Value == "True").Count();
            txt_count_true.Text = toplamAdet.ToString();

            double maasOrtalamasi = xDoc.Root.Elements().Where(xe => xe.Attribute("Aktif").Value == "True").Average(element => double.Parse(element.Element("Maas").Value));
            txt_avg_true.Text = maasOrtalamasi.ToString();

        }
        void XMl_Select_Order_By(XDocument xDoc)
        {
            // A-Z sıralama OrderBy, Z-A sıralama OrderByDescending
            string[] Ad = (xDoc.Root.Elements().Select(xe => xe.Element("Ad").Value).OrderByDescending(ad => ad).ToArray());

            // listbox nesnesinin datasource suna Array List'i atayarak dizideki tüm verilerin yüklenmesini sağlıyoruz.
            listBox_select_order_by.DataSource = Ad;
        }
        void XML_Select_Group_By(XDocument xDoc)
        {
            foreach (var grup in xDoc.Root.Elements().GroupBy(xe => xe.Element("Departman").Value))
            {
                listBox_Group_by.Items.Add(
                grup.Key + " : " + grup.Sum(xe => double.Parse(xe.Element("Maas").Value))
                );
            }
        }
    }
}

//https://mustafabukulmez.com/2019/01/05/c-linq-to-xml-ile-xml-dosyalarla-calismak/
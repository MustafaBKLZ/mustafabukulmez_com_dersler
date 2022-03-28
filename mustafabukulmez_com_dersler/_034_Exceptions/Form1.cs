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

namespace mustafabukulmez_com_dersler._034_Exceptions
{
    public partial class Form1 : Form
    {
        int sayi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        #region ArgumentException Çıkarma ve Yakalama Örneği
        private void btn_ArgumentException_Click(object sender, EventArgs e)
        {
            txt_cikti.Text = "";
            int[] sayilar = { 10, 7 };
            foreach (var sayi in sayilar)
            {
                try
                {
                    SayiKontrol(sayi);
                }
                catch (ArgumentException ex)
                {
                    txt_cikti.Text += ex.GetType().Name + ":" + ex.Message + Environment.NewLine;
                }
            }
        }
        static int SayiKontrol(int sayi)
        {
            if ((sayi & 1) == 1)
                throw new ArgumentException(sayi.ToString() + " Sayı çift sayı değil", "sayi");

            return sayi / 2;
        }
        //https://mustafabukulmez.com/2020/01/10/c-argumentexception-nedenleri-ve-kullanimi/
        #endregion

        #region ArgumentNullException Çıkarma ve Yakalama Örneği
        private void btn_ArgumentNullException_Click(object sender, EventArgs e)
        {
            txt_cikti.Text = "";
            try
            {
                strBirlestir("mustafa", "");
            }
            catch (ArgumentNullException ex)
            {
                txt_cikti.Text += ex.GetType().Name + ":" + ex.Message + Environment.NewLine;
            }

        }
        string strBirlestir(string ad, string soyad)
        {
            if (string.IsNullOrEmpty(ad) || string.IsNullOrWhiteSpace(ad))
            {
                throw new ArgumentNullException("ad", ad + " Ad değeri boş olamaz");
            }
            else if (string.IsNullOrEmpty(soyad) || string.IsNullOrWhiteSpace(soyad))
            {
                throw new ArgumentNullException("soyad", soyad + " Soyad değeri boş olamaz");
            }
            else
            {
                return ad + " " + soyad;
            }
        }
        //https://mustafabukulmez.com/2020/01/11/c-argumentnullexception-nedenleri-ve-kullanimi/
        #endregion

        #region ArgumentNullException Çıkarma ve Yakalama Örneği
        private void btn_ArguOutOfRangeExce_Click(object sender, EventArgs e)
        {
            txt_cikti.Text = "";
            // Hata Veren Örnek
            //string s = "1234";
            //try
            //{
            //    bool b = Char.IsNumber(s, 5);
            //}
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    txt_cikti.Text += ex.GetType().Name + ":" + ex.Message;
            //}

            try
            {
                _000_Classlar.Misafirler misafir1 = new _000_Classlar.Misafirler("Mustafa", "Bükülmez", 17);
                MessageBox.Show(misafir1.MisafirBilgi());
            }
            catch (ArgumentOutOfRangeException ex)
            {
                txt_cikti.Text += ex.GetType().Name + ":" + ex.Message + Environment.NewLine;
            }
        }
        //https://mustafabukulmez.com/2020/01/12/c-argumentoutofrangeexception-nedenleri-ve-kullanimi/
        #endregion

        #region IndexOutOfRangeException Çıkarma ve Yakalama Örneği
        private void btn_IndexOutOfRangeException_Click(object sender, EventArgs e)
        {
            //int[] arr1 = new int[5];
            //arr1[0] = 1;
            //arr1[1] = 2;
            //arr1[2] = 3;
            //arr1[3] = 4;
            //arr1[4] = 5;
            //int ii = arr1[5];

            //int[] arr = new int[5];
            //arr[0] = 0;
            //arr[1] = 1;
            //arr[2] = 2;
            //arr[3] = 3;
            //arr[4] = 4;
            //for (int i = 0; i < arr.Length + 1; i++)
            //{
            //    arr[i] = arr[i] + 1;
            //}

            try
            {
                _000_Classlar.Misafirler misafir1 = new _000_Classlar.Misafirler("Mustafa", "Bükülmez", 57);
                MessageBox.Show(misafir1.MisafirBilgi());
            }
            catch (IndexOutOfRangeException ex)
            {
                txt_cikti.Text += ex.GetType().Name + ":" + ex.Message + Environment.NewLine;
            }
        }
        //https://mustafabukulmez.com/2020/01/13/c-indexoutofrangeexception-nedenleri-ve-kullanimi/
        #endregion

        #region FormatException Çıkarma ve Yakalama Örneği
        private void btn_FormatException_Click(object sender, EventArgs e)
        {
            //string s1 = "OK";
            //bool b2 = Convert.ToBoolean(s1);

            //string s2 = "18 00";
            //DateTime dt = Convert.ToDateTime(s2);

            //string s3 = "18:15";
            //double d1 = Convert.ToDouble(s3);

            string gelenDeger = "MB___asdasd_adas__@__asdasda@BüM";
            try
            {
                Islem(gelenDeger);
            }
            catch (FormatException ex)
            {

                txt_cikti.Text += ex.GetType().Name + ":" + ex.Message + Environment.NewLine;
            }

        }
        void Islem(string text)
        {
            if (text.Substring(0, 2) == "MB" & text.Substring(text.Length - 2, 2) == "BM")
            {
                MessageBox.Show("OK!");
            }
            else
            {
                throw new FormatException("Gelen değer istenen formata uymuyor. İlk iki karakter MB, son iki karakter BM olmalıdır.");
            }
        }
        //https://mustafabukulmez.com/2020/01/13/c-formatexception-ve-nedenleri-kullanimi/
        #endregion

        #region DirectoryNotFoundException Çıkarma ve Yakalama Örneği
        private void btn_DirectoryNotFoundException_Click(object sender, EventArgs e)
        {
            string path = "C:\\78987asdas";
            try
            {
                Directory.Delete(path);
            }
            catch (DirectoryNotFoundException ex)
            {
                txt_cikti.Text += ex.GetType().Name + ":" + ex.Message + Environment.NewLine;
            }
        }
        //https://mustafabukulmez.com/2020/01/14/c-directorynotfoundexception-nedenleri/
        #endregion

        #region FileNotFoundException Çıkarma ve Yakalama Örneği
        private void btn_FileNotFoundException_Click(object sender, EventArgs e)
        {
            string path = "C:\\asd.txt";
            string path2 = "D:\\asd.txt";
            try
            {
                File.Copy(path, path2);
            }
            catch (FileNotFoundException ex)
            {
                txt_cikti.Text += ex.GetType().Name + ":" + ex.Message + Environment.NewLine;
            }
        }
        //https://mustafabukulmez.com/2020/01/14/c-filenotfoundexception-nedenleri/
        #endregion

        #region DivideByZeroException Çıkarma ve Yakalama Örneği
        private void btDivideByZeroException_Click(object sender, EventArgs e)
        {
            int number1 = 3000;
            int number2 = 0;
            try
            {
                int result = number1 / number2;
            }
            catch (DivideByZeroException ex)
            {
                txt_cikti.Text += ex.GetType().Name + ":" + ex.Message + Environment.NewLine;
            }
        }
        //https://mustafabukulmez.com/2020/01/19/c-dividebyzeo-overflow-notfinitenumber-exception-nedenleri/
        #endregion

        #region OverFlowException Çıkarma ve Yakalama Örneği
        private void btn_OverFlowException_Click(object sender, EventArgs e)
        {
            int value = 780000000;
            checked
            {
                try
                {
                    int square = value * value;
                }
                catch (OverflowException ex)
                {
                    double square = Math.Pow(value, 2);
                    txt_cikti.Text = ex.GetType().Name + ":" + ex.Message + Environment.NewLine + string.Format("Exception: {0} > {1:E}.", square, Int32.MaxValue);
                }
            }

            sayi = 5;
        }
        //https://mustafabukulmez.com/2020/01/19/c-dividebyzeo-overflow-notfinitenumber-exception-nedenleri/
        #endregion

        #region NotFiniteNumberException Çıkarma ve Yakalama Örneği
        private void btn_NotFiniteNumberException_Click(object sender, EventArgs e)
        {
            try
            {
                Single x = 5;
                x = x / 0;
                x = x + 1;
            }
            catch (NotFiniteNumberException ex)
            {
                //bla bla bla 
            }
            sayi = 5;
        }
        //https://mustafabukulmez.com/2020/01/19/c-dividebyzeo-overflow-notfinitenumber-exception-nedenleri/
        #endregion

        #region NullReferenceException Çıkarma ve Yakalama Örneği
        private void btn_NullReferenceException_Click(object sender, EventArgs e)
        {
            //int[] values = null;
            //for (int ctr = 0; ctr <= 9; ctr++)
            //    values[ctr] = ctr * 2;
            string disaridan_alinan_deger = null;
            try
            {
                yapilacak_islem(disaridan_alinan_deger);
            }
            catch (NullReferenceException ex)
            {
                txt_cikti.Text += ex.GetType().Name + ":" + ex.Message + Environment.NewLine;
            }
        }
        string yapilacak_islem(string s)
        {
            if (s == null)
            {
                throw new NullReferenceException("XXX Değeri boş bir değer olamaz. Bir değer girmek zorundasınız.");
            }
            else
            {
                // islemler
                return s;
            }
        }
        //https://mustafabukulmez.com/2020/01/26/c-nullreferenceexception-nedenleri-ve-kullanimi/
        #endregion

        #region OutOfMemoryException Çıkarma ve Yakalama Örneği
        private void btn_OutOfMemoryException_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(15, 15);
            sb.Append("Substring #1 ");
            try
            {
                sb.Insert(0, "Substring #2 ", 1);
            }
            catch (OutOfMemoryException ex)
            {
                txt_cikti.Text += ex.GetType().Name + ":" + ex.Message + Environment.NewLine;
            }
        }
        //https://mustafabukulmez.com/2020/01/26/c-outofmemoryexception-nedenleri/
        #endregion

        #region InvalidCastException Çıkarma ve Yakalama Örneği
        private void btn_InvalidCastException_Click(object sender, EventArgs e)
        {
            // bu hatalı bir dönüşüm.
            try
            {
                char c = 'C';
                DateTime dt = Convert.ToDateTime(c);
            }
            catch (InvalidCastException ex)
            {
                txt_cikti.Text += ex.GetType().Name + ":" + ex.Message + Environment.NewLine;
            }

            // Bu örnek doğru bir örnek değildir. Sadece hatanın sebebini görmenizi istediğim için kullanıyorum.
            try
            {
                sayi = 5;
                // formdaki bütün buttonlara bir işlem yapmak istiyorum
                foreach (Button item in this.Controls)
                {
                    // formdaki tüm itemlere bir button gibi davranmasını istedik
                    // aslında bir convert yani dönüşüm yapmak istiyoruz.
                    Button b = (Button)sender;
                    // tüm butonların text özelliğine +1 ifadesinin eklenmesini istedim.
                    b.Text = b.Text + "+1";
                }
            }
            catch (InvalidCastException ex)
            {
                // ama bu kodlarda bir hata alacağım.
                // çünkü formda dönüşümü desteklenmeyecek başka nesneler var.
                // txt_cikti adındaki nesne bir textbox olduğundan dolayı
                // bir button gibi davranamaz bu yüzden InvalidCastException hatası alırız.
                txt_cikti.Text += ex.GetType().Name + ":" + ex.Message + Environment.NewLine;
                // Ayrıca tüm döngüyü try içine aldığımızdan ilk hatada döngü kırılacak ve 
                // işlem tamamlanmadan kesilecek.
            }


            // bu doğru bir dönüşüm
            try
            {
                int i = 1;
                bool bl = Convert.ToBoolean(i);
            }
            catch (InvalidCastException ex)
            {
                txt_cikti.Text += ex.GetType().Name + ":" + ex.Message + Environment.NewLine;
            }

            sayi = 5;
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}







using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//https://mustafabukulmez.com/2018/11/30/c-kelime-heceleme-islemi/

namespace mustafabukulmez_com_dersler._7_Kelime_heceleme_islemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e) { }
        private void btn_isle_Click(object sender, EventArgs e)
        {
            txt_cikan_cumle.Text = CumleHeceleme(txt_girilen_cumle.Text);
        }
        string CumleHeceleme(string Metin)
        {
            const string Sesli_Harfler = "aeıioöuüAEIİOÖUÜ";
            const string Sessiz_Harfler = "bçdfgğhjklmnprsştvyzBÇDFGĞHJKLMNPRSŞTVYZ";
            const string OzelKarakterler = "., ;\'!?\"";
            Metin = (Metin + " ");
            string Hece = "";
            int Index = 1;
            string AlinanHece = "";
            IslemeBasla:

            for (int i = Index; (i <= Metin.Length); i++)
            {
                //Önce karakterleri kontrol et. Eğer boşluk varsa döngüyü tekrar çalıştır
                if (((OzelKarakterler.IndexOf(Metin.Substring((i - 1), 1), 0) + 1) > 0))
                {
                    // boşluk ise direkt başa dön 
                    AlinanHece = Metin.Substring((Index - 1), 1);
                    Hece = (Hece + AlinanHece);
                    Index++;
                    goto IslemeBasla;
                }

                if (((Sessiz_Harfler.IndexOf(Metin.Substring((i - 1), 1), 0) + 1) > 0))
                {
                    // ilk harf sessiz 
                    if (((Sesli_Harfler.IndexOf(Metin.Substring(i, 1), 0) + 1) > 0))
                    {
                        // ikinci harf sesli 
                        if (((Sessiz_Harfler.IndexOf(Metin.Substring((i + 1), 1), 0) + 1) > 0))
                        {
                            // Üçüncü harf sessiz 
                            if (((Sesli_Harfler.IndexOf(Metin.Substring((i + 2), 1), 0) + 1) > 0))
                            {
                                // dördüncü  harf sesli ise ilk iki harf hecedir. 
                                AlinanHece = (Metin.Substring((Index - 1), 2) + "-");
                                Hece = (Hece + AlinanHece);
                                Index += 2;
                                goto IslemeBasla;
                            }

                            if (((Sessiz_Harfler.IndexOf(Metin.Substring((i + 2), 1), 0) + 1) > 0))
                            {
                                // dördüncü harf te sessiz 
                                if (((Sesli_Harfler.IndexOf(Metin.Substring((i + 3), 1), 0) + 1) > 0))
                                {
                                    // 5.harf sesli ise ilk 3 harf hecedir. 
                                    AlinanHece = (Metin.Substring((Index - 1), 3) + "-");
                                    Hece = (Hece + AlinanHece);
                                    Index += 3;
                                    goto IslemeBasla;
                                }
                                if (((Sessiz_Harfler.IndexOf(Metin.Substring((i + 3), 1), 0) + 1) > 0))
                                {
                                    // 5.harf sessiz ise ilk 4 harf hecedir. 
                                    AlinanHece = (Metin.Substring((Index - 1), 4) + "-");
                                    Hece = (Hece + AlinanHece);
                                    Index += 4;
                                    goto IslemeBasla;
                                }
                            }
                        }
                        if (((Sesli_Harfler.IndexOf(Metin.Substring((i + 1), 1), 0) + 1) > 0))
                        {
                            // Üçüncü harf sesli ise ilk iki harf hecedir. 
                            AlinanHece = (Metin.Substring((Index - 1), 2) + "-");
                            Hece = (Hece + AlinanHece);
                            Index += 2;
                            goto IslemeBasla;
                        }
                    }
                    if (((Sessiz_Harfler.IndexOf(Metin.Substring(i, 1), 0) + 1) > 0))
                    {
                        // ikinci de sessiz ise ilk 4 harf hecedir. 
                        AlinanHece = (Metin.Substring((Index - 1), 4) + "-");
                        Hece = (Hece + AlinanHece);
                        Index += 4;
                        goto IslemeBasla;
                    }
                }



                if (((Sesli_Harfler.IndexOf(Metin.Substring((i - 1), 1), 0) + 1) > 0))
                {
                    // ilk harf sesli 
                    if (((Sessiz_Harfler.IndexOf(Metin.Substring(i, 1), 0) + 1) > 0))
                    {
                        // ikinci harf sessiz 
                        if (((Sessiz_Harfler.IndexOf(Metin.Substring((i + 1), 1), 0) + 1) > 0))
                        {
                            // Üçüncü harf sessiz. 
                            if (((Sesli_Harfler.IndexOf(Metin.Substring((i + 2), 1), 0) + 1) > 0))
                            {
                                // Dördüncü harf sesli ise ilk iki harf hecedir. 
                                AlinanHece = (Metin.Substring((Index - 1), 2) + "-");
                                Hece = (Hece + AlinanHece);
                                Index += 2;
                                goto IslemeBasla;
                            }
                            if (((Sessiz_Harfler.IndexOf(Metin.Substring((i + 2), 1), 0) + 1) > 0))
                            {
                                // dördüncü harf te sessiz ise ilk üç harf hecedir. 
                                AlinanHece = (Metin.Substring((Index - 1), 3) + "-");
                                Hece = (Hece + AlinanHece);
                                Index += 3;
                                goto IslemeBasla;
                            }
                        }
                        if (((Sesli_Harfler.IndexOf(Metin.Substring((i + 1), 1), 0) + 1) > 0))
                        {
                            // Üçüncü harf sesli.Bu durumda ilk harf hece demektir. 
                            AlinanHece = (Metin.Substring((Index - 1), 1) + "-");
                            Hece = (Hece + AlinanHece);
                            Index++;
                            goto IslemeBasla;
                        }
                    }
                }
            }
            return Hece;
        }


    }
}

//https://mustafabukulmez.com/2018/11/30/c-kelime-heceleme-islemi/
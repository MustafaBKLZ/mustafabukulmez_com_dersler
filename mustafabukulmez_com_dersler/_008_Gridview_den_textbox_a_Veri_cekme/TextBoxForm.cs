using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//https://mustafabukulmez.com/2018/12/31/c-datagridviewden-veri-cekme/
namespace mustafabukulmez_com_dersler._008_Gridview_den_textbox_a_Veri_cekme
{
    public partial class TextBoxForm : Form
    {
        public TextBoxForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand com = new SqlCommand();
        DataSet ds = new DataSet();

        // Bu değişkene grid formundan ID değerini atayacağız.
        public int Okunan_ID = 0;


        private void TextBoxForm_Load(object sender, EventArgs e)
        {
            txt_ID.Text = Okunan_ID.ToString();

            // Burada Okunan_ID varsa yani bir kaydı güncellemek için bu formu açtırdıysak,
            // Aldığımız ID değerin ile sqlden tüm verileri çekip textboxlara aktaracağız. 
            // Okunan_ID değeri 0 ise güncelleme işlemi değildir.
            if (Okunan_ID > 0)
            {
                Oku();
            }
        }
        void Oku()
        {
            DataTable dt = new DataTable();
            con = new SqlConnection(@"Server=.\SQL2014;Database=mustafabukulmez;User ID=sa; Password=a123456;pooling=true; ");
            da = new SqlDataAdapter("Select * From PERSONEL_TANIMLARI where per_RECno = " + Okunan_ID + "", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Personel");
            dt = ds.Tables["Personel"];
            con.Close();

            //https://mustafabukulmez.com/2018/12/31/c-datagridviewden-veri-cekme/
            txt_per_adi.Text = dt.Rows[0]["per_Adi"].ToString();
            txt_per_soyad.Text = dt.Rows[0]["per_Soyadi"].ToString();
            txt_per_TC.Text = dt.Rows[0]["per_TC"].ToString();
            txt_per_tel.Text = dt.Rows[0]["per_Telefon"].ToString();



        }



    }
}
//https://mustafabukulmez.com/2018/12/31/c-datagridviewden-veri-cekme/
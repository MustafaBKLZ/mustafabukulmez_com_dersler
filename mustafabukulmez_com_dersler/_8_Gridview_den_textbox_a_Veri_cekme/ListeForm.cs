using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//https://mustafabukulmez.com/2018/12/31/c-datagridviewden-veri-cekme/
namespace mustafabukulmez_com_dersler._8_Gridview_den_textbox_a_Veri_cekme
{
    public partial class ListeForm : Form
    {
        public ListeForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand com = new SqlCommand();
        DataSet ds = new DataSet();

        void griddoldur()
        {
            con = new SqlConnection(@"Server=.\SQL2014;Database=mustafabukulmez;User ID=sa; Password=a123456;pooling=true; ");
            da = new SqlDataAdapter("Select * From PERSONEL_TANIMLARI", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Personel");
            dataGridView1.DataSource = ds.Tables["Personel"];
            con.Close();
        }

        //https://mustafabukulmez.com/2018/12/31/c-datagridviewden-veri-cekme/
        private void ListeForm_Load(object sender, EventArgs e)
        {
            griddoldur();
        }
        int ID = 0;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            KaydiGuncelle();
        }
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KaydiGuncelle();
        }
        void KaydiGuncelle()
        {
            // ilk kolon ID kolonu olduğundan ID değerimizi alıyoruz. Burada sadece ID 'yi alacağız.
            ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()); //[0] sütun numarası
            // ID değerini aldıktan sonra diğer forma göndereceğiz ve orada bir datatable üzerinden verileri
            // alacağız

            TextBoxForm fr = new TextBoxForm();
            fr.Okunan_ID = ID;
            fr.ShowDialog();

            // Güncellemeyi yaptıktan sonra listeyi güncellemek için... 
            // Açılan form kapandığında işlemlere kaldığı yerden devam eder böylece listeyi güncellemiş oluruz.
            // NOT: Formu ShowDialog() olarak açmak zorundasınız.  Yoksa form açıldıktan sonra işleme devam eder
            // Bu yüzden açılan form kapandıktan sonra güncelleme yapmaz.
            griddoldur();
        }


    }
}
//https://mustafabukulmez.com/2018/12/31/c-datagridviewden-veri-cekme/
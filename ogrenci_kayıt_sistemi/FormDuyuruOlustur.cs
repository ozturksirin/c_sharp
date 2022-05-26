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

namespace ogrenci_kayıt_sistemi
{
    public partial class FormDuyuruOlustur : Form
    {
        public FormDuyuruOlustur()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        void Listele()
        {
            SqlCommand komut = new SqlCommand("Select * From TblDuyurular", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void FormDuyuruOlustur_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblDuyurular(icerik)values(@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", RchDuyuru.Text);
            komut.ExecuteNonQuery();

            MessageBox.Show("Duyuru Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            Listele();
        }
    }
}

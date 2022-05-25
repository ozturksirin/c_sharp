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
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }
                   
        public string numara;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmOgretmen_Load(object sender, EventArgs e)
        {
            //numarayı label aracına yazdırma
            LblNumara.Text = numara;

            //numaraya göre isim bilgisi getirme

            SqlCommand komut = new SqlCommand("Select * From TblOgretmen where Numara=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", numara);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[1] +" "+ dr[2];
            }

            bgl.baglanti().Close();

            //formLoad da metodu çağırıyoruz
            OgrenciListesi();

            NotListesi();
        }

        void OgrenciListesi() //metod tanımlıyoruz 
        {
            SqlCommand komut = new SqlCommand("Select * From TblOgrenci", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void NotListesi()
        {
            SqlCommand komut = new SqlCommand("Execute Ogrenciler", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        String Fotograf;
        private void BtnFotografSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Fotograf = openFileDialog1.FileName;
            pictureBox1.ImageLocation = Fotograf;

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblOgrenci(ad,soyad,numara,sifre,fotograf)values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskNumara.Text);
            komut.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p5", Fotograf);
            komut.ExecuteNonQuery();

            MessageBox.Show("Öğrenci Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            OgrenciListesi();
            NotListesi();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskNumara.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

            pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }
    }
}

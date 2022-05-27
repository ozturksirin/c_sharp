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
    public partial class FrmOgrenci : Form
    {
        internal string numara;

        public FrmOgrenci()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string Numara;
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            label3.Text = Numara;

            //numaraya göre isim bilgisini getirme

            SqlCommand komut = new SqlCommand("Select * From TblOgrenci where Numara=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Numara);

            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                LblAdSoyad.Text = dr[1] + " " + dr[2];
                pictureBox1.ImageLocation = dr[5].ToString();

            }

            bgl.baglanti().Close();


            //not listesi

            SqlCommand komut2 = new SqlCommand("Select * From TblNotlar where  OGRID=(Select ID From TblOgrenci where Numara=@p1)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", LblNumara.Text);

            SqlDataReader dr2 = komut2.ExecuteReader();

            while(dr2.Read())
            {
                LblSınav1.Text = dr[1].ToString();
                LblSınav2.Text = dr[2].ToString();
                LblsSınav3.Text = dr[3].ToString();
                LblProje.Text = dr[4].ToString();
                LblOrtalama.Text = dr[5].ToString();
            }

            bgl.baglanti().Close();

            if(Convert.ToDouble(LblOrtalama.Text)>=50)
            {
                LblDurum.Text = "GEÇTİ";
            }

            else
            {
                LblDurum.Text = "KALDI";
            }
            
        }
    }
}

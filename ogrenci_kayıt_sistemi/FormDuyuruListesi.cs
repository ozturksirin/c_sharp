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
    public partial class FormDuyuruListesi : Form
    {
        public FormDuyuruListesi()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FormDuyuruListesi_Load(object sender, EventArgs e)
        {
            ListBox lst = new ListBox();
            Point lstKonum = new Point(10, 10);
            lst.Name = "ListBox1";
            lst.Height = 200;
            lst.Width = 150;
            lst.Location = lstKonum;
            this.Controls.Add(lst);

            //duyuruları listeleme komutu

            SqlCommand komut = new SqlCommand("Select * From TblDuyurular", bgl.baglanti());

            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                lst.Items.Add(dr[0] + " " + dr[1]);
            }

            bgl.baglanti().Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ogrenci_kayıt_sistemi
{
    class SqlBaglantisi
    {

        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=EXCALIBUR;Initial Catalog=ogrenciNotKayitDB;Integrated Security=True");
            baglan.Open();
            return baglan;


        }


    }
}

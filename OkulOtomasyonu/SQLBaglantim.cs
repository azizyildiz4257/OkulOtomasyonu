using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulOtomasyonu
{
    internal class SQLBaglantim
    {
        public SqlConnection Baglan()
        {
            SqlConnection bgl = new SqlConnection(@"Data Source=.;Initial Catalog=OkulOtomasyonu;Integrated Security=True");
            bgl.Open();
            return bgl;
        }
    }
}

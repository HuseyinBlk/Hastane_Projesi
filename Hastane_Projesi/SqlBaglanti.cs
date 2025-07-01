using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Hastane_Projesi
{
    internal class SqlBaglanti
    {
        public SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection("Data Source=ADMINISTRATOR\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True;TrustServerCertificate=True");
            connect.Open();
            return connect;
        }
       

    }
}

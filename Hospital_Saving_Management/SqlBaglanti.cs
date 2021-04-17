using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hospital_Saving_Management
{
    public class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=FIRAT-PC\\SQLEXPRESS;Initial Catalog=Hospital_management;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}

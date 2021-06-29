using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace BobNaeNwa
{
    public class MySqlController
    {
        private string constr;
        public MySqlController()
        {
            //var config = new ConfigurationBuilder().AddEnvironmentVariables().Build();
            this.constr = $"SERVER = localhost, 3306; DATABASE = bobnaenwa; UID = root; PASSWORD = 1163116a;";
        }
        public DataSet ExcuteSQL(string SQL)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(this.constr))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(SQL, conn);
                adapter.Fill(ds);
            }
            return ds;
        }
    }
}
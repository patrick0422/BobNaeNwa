using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobNaeNwa
{
    class MySqlController
    {
        private string constr;
        MySqlController(string address, string port, string DBName, string id, string pw)
        {
            this.constr = $"SERVER = {address},{port}; DATABASE = {DBName}; UID = {id}; PASSWORD = {pw};";
        }
        public DataSet ExcuteSQL(string SQL, string fillMember = "")
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(SQL, conn);
                adapter.Fill(ds, fillMember);
            }
            return ds;
        }
    }
}
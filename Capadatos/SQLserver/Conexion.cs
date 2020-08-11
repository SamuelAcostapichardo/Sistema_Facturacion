using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Capadatos
{
    public class Conexion
    {


        private readonly string conection = ConfigurationManager.ConnectionStrings["sinnombre.Properties.Settings.Setting"].ConnectionString;

        public SqlConnection Getconection()
        {
            return new SqlConnection(conection);
        }

        public DataTable GetDataTable(string v)
        {
            if (v is null)
            {
                throw new ArgumentNullException(nameof(v));
            }

            return new DataTable();
        }

        public SqlDataAdapter Getdataadapter(SqlCommand comand)
        {
            if (comand is null)
            {
                throw new ArgumentNullException(nameof(comand));
            }

            return new SqlDataAdapter(comand);
        }

        public SqlCommand GetSqlCommand()
        {
            return new SqlCommand();
        }

        public SqlDataAdapter Getsqlcon(string V, SqlConnection B)
        {
            if (V is null)
            {
                throw new ArgumentNullException(nameof(V));
            }

            if (B is null)
            {
                throw new ArgumentNullException(nameof(B));
            }

            return new SqlDataAdapter(V,B);
        }
    }
}

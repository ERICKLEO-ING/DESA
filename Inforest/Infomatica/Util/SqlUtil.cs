using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Infomatica.Restaurante.Model;
using System.Data;

namespace Infomatica.Util
{
    public class SqlUtil
    {
        /// <summary>
        /// Consulta Sql que Retorna un DataTable
        /// </summary>
        public DataTable ConsultaSQL(string Isql, string Conexion)
        {
            Conexion = "Data Source=192.168.3.37;Initial Catalog=inforest9009;User ID = sa; Password = sistemas; ";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(Isql, Conexion);
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Consulta Sql que Retorna un DataTable 
        /// </summary>
        public SqlDataAdapter ConsultaSQL(string Isql, string Conexion,string s)
        {
            Conexion = "Data Source=192.168.3.37;Initial Catalog=inforest9009;User ID = sa; Password = sistemas; ";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(Isql, Conexion);
            //da.Fill(dt);
            return da;
        }
    }
}

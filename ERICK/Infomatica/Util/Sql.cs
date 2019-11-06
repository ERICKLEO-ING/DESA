using Infomatica.Restaurante.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Infomatica.Util
{
    class Sql
    {
        public static IDataReader ConsultaQuery(string _SqlQuery)
        {
            try
            {
                ConnectionState originalState = VG.CnRest.State;
                if (originalState != ConnectionState.Open)
                    VG.CnRest.Open();
                IDbCommand command = VG.CnRest.CreateCommand();
                command.CommandText = _SqlQuery;
                IDataReader Resp = command.ExecuteReader();
                command.Dispose();
                return Resp;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}


namespace Infomatica.Restaurante.Controller
{
    using System;
    using Infomatica.Restaurante.Model;
    using Infomatica.Util;
    public class GrupoController
    {
        public void GetGrupo()
        {
            try
            {
                VG.Grupo = Util.DataReaderMapToList<GrupoModel>(Sql.ConsultaQuery("select * from vGrupo "));
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}

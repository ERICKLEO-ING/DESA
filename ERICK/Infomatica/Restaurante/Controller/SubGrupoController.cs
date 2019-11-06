
namespace Infomatica.Restaurante.Controller
{
    using System;
    using Infomatica.Restaurante.Model;
    using Infomatica.Util;
    public class SubGrupoController
    {
        public void GetSubGrupo()
        {
            try
            {
                VG.SubGrupo = Util.DataReaderMapToList<SubGrupoModel>(Sql.ConsultaQuery("select * from vSubGrupo "));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

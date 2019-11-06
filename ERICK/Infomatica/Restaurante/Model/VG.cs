namespace Infomatica.Restaurante.Model
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Data;
    public class VG
    {
       public static IDbConnection CnRest { get; set; }
       public static List<GrupoModel> Grupo { get; set; }
       public static List<SubGrupoModel> SubGrupo { get; set; }
    }
}

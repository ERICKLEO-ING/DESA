using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoService.Infomatica.Model
{
    public class VariableGeneral
    {
        #region Uber
        public static bool lUber { get; set; }
        #endregion

        #region Rappi
        public static bool lRappi { get; set; }
        public static string TokenRappi { get; set; }
        public static string LoginRappi { get; set; }
        public static string OrdersRappi { get; set; }
        public static string TakeRappi { get; set; }
        public static string RejectRappi { get; set; }
        public static string MenuRappi { get; set; }
        #endregion

    }
}

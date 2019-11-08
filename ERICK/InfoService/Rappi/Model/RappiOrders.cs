using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoService.Rappi.Model
{
    class RappiOrders
    {
        public Order order { get; set; }
        public Client client { get; set; }
        public Store store { get; set; }
    }
}

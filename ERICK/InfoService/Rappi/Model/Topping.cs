using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoService.Rappi.Model
{
    public class Topping
    {
        public string sku { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string type { get; set; }
        public string subtype { get; set; }
        public object comments { get; set; }
        public int units { get; set; }
    }
}

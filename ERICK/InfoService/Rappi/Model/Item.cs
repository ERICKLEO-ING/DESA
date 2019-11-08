using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoService.Rappi.Model
{
    public class Item
    {
        public string sku { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string type { get; set; }
        public string subtype { get; set; }
        public string comments { get; set; }
        public int units { get; set; }
        public int percentage_price_variation { get; set; }
        public double price_discount { get; set; }
        public int discount_percentage_by_rappi { get; set; }
        public List<Topping> toppings { get; set; }
    }
}

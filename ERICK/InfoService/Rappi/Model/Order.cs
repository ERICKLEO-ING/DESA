using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoService.Rappi.Model
{
    public class Order
    {
        public string id { get; set; }
        public double totalValue { get; set; }
        public int tip { get; set; }
        public int whims { get; set; }
        public double totalProducts { get; set; }
        public int totalRappiPay { get; set; }
        public double totalOrderValue { get; set; }
        public string deliveryMethod { get; set; }
        public string paymentMethod { get; set; }
        public string createdAt { get; set; }
        public List<Item> items { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string OrderDescription { get; set; }
        public string OrderPriority { get; set; }
        public string OrderStatus { get; set; }
        public int CustomerID { get; set; }

    }
}

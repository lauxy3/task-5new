using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartApi.Models
{
    public class Cart
    {
        public int CartID { get; set; }
        public string CartDescription { get; set; }
        public string CartPriority { get; set; }
        public string CartStatus { get; set; }
        public int customerID { get; set; }
    }
}

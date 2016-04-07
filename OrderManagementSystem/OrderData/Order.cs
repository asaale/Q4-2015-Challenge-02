using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STG.CodeChallenge2.OrderManagement.OrderData
{
    public class Order
    {
        public string ID { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public string SKU { get; set; }

        public Cost Cost { get; set; }

        public string Buyer { get; set; }

        public double Weight { get; set; }
        
        public string ShippingAddress { get; set; }
    }
}

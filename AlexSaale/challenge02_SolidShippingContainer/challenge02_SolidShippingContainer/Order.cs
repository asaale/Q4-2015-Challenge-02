using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challenge02_SolidShippingContainer.ShippingMethods;

namespace challenge02_SolidShippingContainer
{
    public class Order
    {
        public IShippingMethod ShippingMethod { get; set; }
        public double Weight { get; set; }

        public double CalculateTotalWithShipping()
        {
            return ShippingMethod.CalculateShippingCost(Weight);
        }
    }
}

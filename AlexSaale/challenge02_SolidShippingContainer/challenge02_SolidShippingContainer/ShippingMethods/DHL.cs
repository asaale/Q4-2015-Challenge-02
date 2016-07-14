using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge02_SolidShippingContainer.ShippingMethods
{
    public class DHL : IShippingMethod 
    {
        public double CalculateShippingCost(double weight)
        {
            return weight * 4.50;
        }

        public string GetName()
        {
            return "DHL";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge02_SolidShippingContainer.ShippingMethods
{
    public class USPS : IShippingMethod 
    {
        public double CalculateShippingCost(double weight)
        {
            return weight * 3.75;
        }

        public string GetName()
        {
            return "USPS";
        }
    }
}

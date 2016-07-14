using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge02_SolidShippingContainer.ShippingMethods
{
    public class UPS : IShippingMethod
    {
        public double CalculateShippingCost(double weight)
        {
            return weight * 5.50;
        }

        public string GetName()
        {
            return "UPS";
        }
    }
}

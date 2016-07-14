using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge02_SolidShippingContainer.ShippingMethods
{
    public class FedEx : IShippingMethod
    {
        public double CalculateShippingCost(double weight)
        {
            return weight * 7.25;
        }

        public string GetName()
        {
            return "FedEx";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STG.CodeChallenge2.OrderManagement.Interfaces
{
    using OrderData;

    public abstract class CostComponent
    {
        public IShippingCost ShippingCost { get; set; }

        /// <summary>
        /// Calculates the cost of a component of the order price, e.g., product cost, tax, shipping, etc.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public abstract decimal CalculateCostComponent(Order order);
    }

}

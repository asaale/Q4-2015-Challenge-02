using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STG.CodeChallenge2.OrderManagement.Lib
{
    using Interfaces;
    using OrderData;

    public class UspsShippingCost : IShippingCost
    {
        /// <summary>
        /// An implementation of IShippingCost for calculating USPS shipping cost
        /// </summary>
        public decimal CalculateShippingCost(Order order, bool updateOrder = true)
        {
            decimal shippingCost = 0.0M;
            if (order != null && order.Cost != null)
            {
                // TODO: make the rate configurable or encapsulated
                shippingCost = order.Cost.EffectivePrice * order.Quantity * 0.4M;
                if (updateOrder)
                {
                    order.Cost.ShippingCost = shippingCost;
                }
            }

            return shippingCost;
        }
    }
}

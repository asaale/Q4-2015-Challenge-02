using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STG.CodeChallenge2.OrderManagement.Lib
{
    using Interfaces;
    using OrderData;

    public class FedExShippingCost : IShippingCost
    {
        /// <summary>
        /// An implementation of IShippingCost for calculating FedEx shipping cost
        /// </summary>
        public decimal CalculateShippingCost(Order order, bool updateOrder = true)
        {
            decimal shippingCost = 0.0M;
            if (order != null && order.Cost != null)
            {
                // TODO: make the rate configurable or encapsulated
                shippingCost = Convert.ToDecimal(order.Weight) * 0.2M;
                if (updateOrder)
                {
                    order.Cost.ShippingCost = shippingCost;
                }
            }

            return shippingCost;
        }
    }
}

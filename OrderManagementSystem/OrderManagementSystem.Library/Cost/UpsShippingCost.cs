using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STG.CodeChallenge2.OrderManagement.Lib
{
    using Interfaces;
    using OrderData;

    public class UpsShippingCost : IShippingCost
    {
        /// <summary>
        /// An implementation of IShippingCost for calculating UPS shipping cost
        /// </summary>
        public decimal CalculateShippingCost(Order order, bool updateOrder = true)
        {
            decimal shippingCost = 0.0M;
            if (order != null && order.Cost != null)
            {
                // TODO: make the rate configurable or encapsulated
                const decimal minimumShipCost = 5.5M;
                shippingCost = Convert.ToDecimal(order.Weight) * 0.3M;
                if (shippingCost < minimumShipCost)
                {
                    shippingCost = minimumShipCost;
                }
                if (updateOrder)
                {
                    order.Cost.ShippingCost = shippingCost;
                }
            }

            return shippingCost;
        }
    }
}

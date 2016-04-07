using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STG.CodeChallenge2.OrderManagement.Lib
{
    using Interfaces;
    using OrderData;

    public class DhlShippingCost : IShippingCost
    {
        /// <summary>
        /// An implementation of IShippingCost for calculating DHL shipping cost
        /// </summary>
        /// <param name="order"></param>
        /// <param name="updateOrder"></param>
        /// <returns></returns>
        public decimal CalculateShippingCost(Order order, bool updateOrder = true)
        {
            decimal shippingCost = 0.0M;

            if (order != null && order.Cost != null)
            {
                // TODO: make the rate configurable or encapsulated
                const decimal minimumShipCost = 2.5M;
                shippingCost = order.Cost.EffectivePrice * order.Quantity * 0.1M;
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

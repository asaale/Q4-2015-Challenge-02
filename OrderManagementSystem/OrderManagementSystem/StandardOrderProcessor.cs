using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace STG.CodeChallenge2.OrderManagement
{
    using Interfaces;
    using Lib;
    using OrderData;
    using Cost;

    public class StandardOrderProcessor : OrderProcessor
    {
        /// <summary>
        /// Implementation of the Factory Method pattern for creation of a shipping cost object
        /// </summary>
        /// <returns></returns>
        protected override IShippingCost CreateShippingCostCalculator(IOrderConfig orderConfig)
        {
            //switch(orderConfig.Data.ToString().ToUpper())
            //{
            //    case "DHL":
            //        return new DhlShippingCost();
            //    case "FEDEX":
            //        return new FedExShippingCost();
            //    case "UPS":
            //        return new UpsShippingCost();
            //    case "USPS":
            //        return new UspsShippingCost();
            //    default:
            //        // TODO: return "unknown" shipping cost type
            //        return null;
            //}

            try
            {
                Assembly asm = Assembly.Load("OrderManagement.Lib");
                Type shipType = asm.GetType(string.Format("{0}shippingcost", orderConfig.Data.ToString().ToLower()), true, true);
                IShippingCost obj = Activator.CreateInstance(shipType) as IShippingCost;
                return obj;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }

            return null;

        }

        /// <summary>
        /// Implementation of the CostComponent class's method for calculating the product price component
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public override decimal CalculateCostComponent(Order order)
        {
            return CalculateTotalPrice(order);
        }

        private decimal CalculateTotalPrice(Order order)
        {
            decimal totalPrice = 0.0M;
            if (order != null)
            {
                totalPrice = order.Quantity * order.Cost.EffectivePrice;
            }

            return totalPrice;
        }
    }
}

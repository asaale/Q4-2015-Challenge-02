using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STG.CodeChallenge2.OrderManagement
{
    using Interfaces;
    using OrderData;

    public abstract class BaseOrderManager : OrderManager
    {
        /// <summary>
        /// When set to a class implementing OrderProcessor, is used to do work related
        /// to the processing phase of order-handling workflow.
        /// </summary>
        protected OrderProcessor _orderProcessor;

        /// <summary>
        /// Factory Method pattern
        /// </summary>
        /// <returns></returns>
        protected abstract OrderProcessor CreateOrderProcessor();

        /// <summary>
        /// A hook to do any appropriate work immediately prior to the Process() method.
        /// </summary>
        protected override void PreProcessOrder()
        {
            base.PreProcessOrder();

            _orderProcessor = CreateOrderProcessor();
        }

        /// <summary>
        /// Receives an order as the first phase in the order-handling workflow.
        /// </summary>
        /// <returns></returns>
        protected override object ReceiveOrder()
        {
            // STUB

            // TODO: Order type should be abstract and we should employ a factory to instantiate the desired subclass.

            return new Order
            {
                ID = "123456",
                Description = "Top quality widget.",
                SKU = "999ABC",
                Quantity = 10,
                Weight = 13.5,
                Cost = new OrderData.Cost
                {
                    DiscountRate = 0.15M,
                    ListPrice = 1.09M
                }
            };
        }

        /// <summary>
        /// Does work associated with the process phase of an order-handling workflow.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override object ProcessOrder(object order, object config)
        {
            Order thisOrder = order as Order;
            return _orderProcessor.Process(thisOrder, config as IOrderConfig);
        }

        /// <summary>
        /// Does the work associated with shipping an order.
        /// </summary>
        /// <param name="order"></param>
        protected override void ShipOrder(object order, object config)
        {
            // STUB

            Order thisOrder = order as Order;
            if (thisOrder != null)
            {
                Console.WriteLine("Shipping Order #" + thisOrder.ID + ":");
                Console.WriteLine("Quantity: " + thisOrder.Quantity);
                Console.WriteLine("Item: " + thisOrder.Description);
                Console.WriteLine("Cost:");
                Console.WriteLine("\tProduct: " + thisOrder.Cost.EffectivePrice);
                Console.WriteLine("\tTax: " + thisOrder.Cost.TaxAmount);
                Console.WriteLine("\tShipping: " + thisOrder.Cost.ShippingCost);
                Console.WriteLine("\tTOTAL: " + thisOrder.Cost.Total);
                Console.WriteLine();
                Console.WriteLine("Press any key ...");
                Console.ReadKey();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STG.CodeChallenge2.OrderManagement
{
    using Interfaces;
    using OrderData;
    using Cost;

    public abstract class OrderProcessor : CostComponent
    {        
        public object Process(Order order, IOrderConfig orderConfig)
        {
            ShippingCost = CreateShippingCostCalculator(orderConfig);  // Factory Method pattern

            // Decorator pattern - set up the types cost components to be calculated, in the desired order.
            CostComponent costComponent = new ShippingCostElement(this);
            costComponent = new IncomeTaxCostElement(costComponent);
            order.Cost.Total = costComponent.CalculateCostComponent(order);

            return order;
        }

        protected abstract IShippingCost CreateShippingCostCalculator(IOrderConfig orderConfig);
    }
}

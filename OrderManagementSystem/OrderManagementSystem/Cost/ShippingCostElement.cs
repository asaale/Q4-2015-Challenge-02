using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STG.CodeChallenge2.OrderManagement.Cost
{
    using Interfaces;
    using OrderData;

    public class ShippingCostElement : CostElementDecorator
    {
        public ShippingCostElement(CostComponent costComponent)
        {
            CostComponent = costComponent;
            ShippingCost = costComponent.ShippingCost;
        }

        public override decimal CalculateCostComponent(Order order)
        {
            return CostComponent.CalculateCostComponent(order) + ShippingCost.CalculateShippingCost(order);
        }
    }
}

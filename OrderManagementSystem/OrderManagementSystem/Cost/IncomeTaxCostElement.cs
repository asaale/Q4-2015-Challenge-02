using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STG.CodeChallenge2.OrderManagement.Cost
{
    using Interfaces;
    using OrderData;

    public class IncomeTaxCostElement : CostElementDecorator
    {
        private decimal _taxRate = 0.06M;   // TODO: Make this configurable

        public IncomeTaxCostElement(CostComponent costComponent)
        {
            CostComponent = costComponent;
            ShippingCost = costComponent.ShippingCost;
        }

        public override decimal CalculateCostComponent(Order order)
        {
            decimal taxAmount = _taxRate * order.Cost.EffectivePrice * order.Quantity;

            order.Cost.TaxAmount = taxAmount;
            order.Cost.TaxRate = _taxRate;

            return taxAmount + CostComponent.CalculateCostComponent(order);
        }

    }
}

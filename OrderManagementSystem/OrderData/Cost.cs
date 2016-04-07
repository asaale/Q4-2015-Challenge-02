using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STG.CodeChallenge2.OrderManagement.OrderData
{
    public class Cost
    {
        public decimal ListPrice { get; set; }

        public decimal DiscountRate { get; set; }

        private decimal _effectivePrice = 0.0M;
        public decimal EffectivePrice
        {
            get
            {
                if (_effectivePrice == 0.0M)
                {
                    return ListPrice * (1.0M - DiscountRate);
                }
                else
                {
                    return _effectivePrice;
                }
            }

            set
            {
                _effectivePrice = value;
            }
        }
        
        public decimal TaxAmount { get; set; }

        public decimal TaxRate { get; set; }

        public decimal ShippingCost { get; set; }

        public decimal Total { get; set; }
        
    }
}

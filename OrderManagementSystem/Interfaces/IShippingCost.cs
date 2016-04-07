using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STG.CodeChallenge2.OrderManagement.Interfaces
{
    using OrderData;

    public interface IShippingCost
    {
        decimal CalculateShippingCost(Order order, bool updateOrder = true);
    }
}

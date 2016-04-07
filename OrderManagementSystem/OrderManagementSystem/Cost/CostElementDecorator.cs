using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STG.CodeChallenge2.OrderManagement.Cost
{
    using Interfaces;
    using OrderData;

    /// <summary>
    /// This is the base Decorator Pattern class
    /// </summary>
    public abstract class CostElementDecorator : CostComponent
    {
        public CostComponent CostComponent { get; set; }        
    }
}

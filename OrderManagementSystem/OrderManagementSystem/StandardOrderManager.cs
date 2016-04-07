using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STG.CodeChallenge2.OrderManagement
{
    public class StandardOrderManager : BaseOrderManager
    {
        /// <summary>
        /// Implementation of the Factory Method pattern to create the desired type of OrderProcessor.
        /// </summary>
        /// <returns></returns>
        protected override OrderProcessor CreateOrderProcessor()
        {
            // STUB

            // TODO:  Determine the type of order processor to create based on args or config

            return new StandardOrderProcessor();
        }
    }
}

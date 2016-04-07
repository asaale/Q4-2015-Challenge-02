using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STG.CodeChallenge2.OrderManagement
{
    public abstract class OrderManager
    {
        /// <summary>
        /// This is the TEMPLATE METHOD pattern
        /// </summary>
        public void Run(object config)
        {
            object order = ReceiveOrder();
            PreProcessOrder();
            order = ProcessOrder(order, config);
            ShipOrder(order, config);
        }

        protected abstract object ReceiveOrder();

        protected abstract object ProcessOrder(object order, object config);

        protected abstract void ShipOrder(object order, object config);

        // A hook to do thing before processing begins
        protected virtual void PreProcessOrder()
        {
            // no default implementation
        }
    }
}

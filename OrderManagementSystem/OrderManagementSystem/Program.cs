using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STG.CodeChallenge2.OrderManagement
{
    using Lib;

    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Initialize the orderMgr by parsing the args and loading the requested
            // type of OrderManager via reflection
            OrderManager orderMgr = new StandardOrderManager();
            object config = ParseArgs(args);
            orderMgr.Run(config);
        }

        private static object ParseArgs(string[] args)
        {
            if (args.Length > 0)
            {
                return new OrderConfig() { Data = args[0] };
            }
            else
            {
                return null;
            }

        }
    }
}

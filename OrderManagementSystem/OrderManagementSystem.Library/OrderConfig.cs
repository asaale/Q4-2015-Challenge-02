using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STG.CodeChallenge2.OrderManagement.Lib
{
    using Interfaces;

    public class OrderConfig : IOrderConfig
    {
        public object Data { get; set; }
    }
}

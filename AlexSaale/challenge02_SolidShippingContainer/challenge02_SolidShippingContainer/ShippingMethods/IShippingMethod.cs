﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge02_SolidShippingContainer.ShippingMethods
{
    public interface IShippingMethod
    {
        double CalculateShippingCost(double weight);
        string GetName();
    }
}

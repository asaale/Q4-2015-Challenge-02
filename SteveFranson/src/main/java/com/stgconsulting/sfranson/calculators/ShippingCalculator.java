package com.stgconsulting.sfranson.calculators;

import com.stgconsulting.sfranson.Order;

public interface ShippingCalculator {
    // Main calculator method
    double calculateShipping(Order order);

    // Shipping method code
    String shippingMethod();


}

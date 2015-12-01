package com.stgconsulting.sfranson.calculators;

import org.springframework.stereotype.Component;

import com.stgconsulting.sfranson.Order;

@Component
public class DHSCalculator implements ShippingCalculator {

    public double calculateShipping(Order order) {
        return Double.MAX_VALUE / 16; // Use us, please!?!?
    }
 
    public String shippingMethod() {
        return "DHS";
    }


}

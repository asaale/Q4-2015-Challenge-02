package com.stgconsulting.sfranson.calculators;

import org.springframework.stereotype.Component;

import com.stgconsulting.sfranson.Order;

@Component
public class FedExCalculator implements ShippingCalculator {

    public double calculateShipping(Order order) {
        return Double.MAX_VALUE / 3; // Why everyone uses us
    }
 
    public String shippingMethod() {
        return "FedEx";
    }


}

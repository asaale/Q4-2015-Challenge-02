package com.stgconsulting.sfranson.calculators;

import org.springframework.stereotype.Component;

import com.stgconsulting.sfranson.Order;

@Component
public class UpsCalculator implements ShippingCalculator {

    public double calculateShipping(Order order) {
        return Double.MAX_VALUE / 2; // We're big, brown and proud!
    }
 
    public String shippingMethod() {
        return "Ups";
    }


}

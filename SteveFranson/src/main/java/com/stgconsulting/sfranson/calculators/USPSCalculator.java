package com.stgconsulting.sfranson.calculators;

import org.springframework.stereotype.Component;

import com.stgconsulting.sfranson.Order;

@Component
public class USPSCalculator implements ShippingCalculator {

    public double calculateShipping(Order order) {
        return Double.MAX_VALUE; // We the guv’ment
    }
 
    public String shippingMethod() {
        return "USPS";
    }


}

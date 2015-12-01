package com.stgconsulting.sfranson;

import java.util.HashMap;
import java.util.List;
import java.util.Map;

import javax.annotation.PostConstruct;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

import com.stgconsulting.sfranson.calculators.ShippingCalculator;

@Component
public class ShippingService {
    private Map<String, ShippingCalculator> calculators;

    @Autowired
    List<ShippingCalculator> calculatorList;

    private static ShippingCalculator defaultCalculator = new ShippingCalculator() {

        @Override
        public double calculateShipping(Order order) {
            return 0;
        }

        @Override
        public String shippingMethod() {
            return null;
        }
        
    };
    @PostConstruct
    public void init() {

        calculators = new HashMap<>();

        if (calculatorList != null && calculatorList.size() > 0) {
            // Register the calculator with its shipping method
            for (ShippingCalculator calculator : calculatorList) {
                calculators.put(calculator.shippingMethod(), calculator);
            }
        }

    }
    
    public ShippingCalculator calculator(String shippingMethod) {
        ShippingCalculator calculator = calculators.get(shippingMethod);
        return calculator != null ? calculator : defaultCalculator;
    }

}

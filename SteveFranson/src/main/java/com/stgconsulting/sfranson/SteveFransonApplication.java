package com.stgconsulting.sfranson;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import com.stgconsulting.sfranson.calculators.ShippingCalculator;

@SpringBootApplication
public class SteveFransonApplication implements CommandLineRunner {

    @Autowired
    ShippingService shippingService;

    @Autowired
    static SteveFransonApplication app;

    public static void main(String[] args) {
        SpringApplication.run(SteveFransonApplication.class, args);

    }

    public double CalculateShippingCost(Order order) {

        ShippingCalculator calc = shippingService.calculator(order.getShippingMethod());

        double result = calc.calculateShipping(order);

        return result;
    }

    @Override
    public void run(String... args) throws Exception {
        String[] methods = { "FedEx", "Ups", "USPS", "DHS", null };

        for (String method : methods) {
            Order order = new Order(method);

            double shipping = CalculateShippingCost(order);
            System.out.println("Shipping cost for " + order.getShippingMethod() + " = " + shipping);
        }
    }

}

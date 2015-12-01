package com.stgconsulting.sfranson;

public class Order {

    private String shippingMethod;

    public Order(String shippingMethod) {
        this.shippingMethod = shippingMethod;
    }

    /**
     * @return the shippingMethod
     */
    public String getShippingMethod() {
        return shippingMethod;
    }

    /**
     * @param shippingMethod the shippingMethod to set
     */
    public void setShippingMethod(String shippingMethod) {
        this.shippingMethod = shippingMethod;
    }
}

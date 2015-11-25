/**
 * Challenge #2 (due 11/30/2015): SOLID Shipping Calculator
 *
 * @author Ray Hunter ray.hunter@stgconsulting.com
 */
class Challenge02App {

    /**
     * Based on the Order ShippingMethod (String)
     *
     * @param order
     * @return double shipping cost
     */
    static double CalculateShippingCost(Order order) {
        // using an enum for handling the shipping cost
        return ShippingTypeEnum.getShippingTypeEnum(order.ShippingMethod).value;
    }

}

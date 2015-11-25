/**
 * Main Groovy Script
 *
 * @author Ray Hunter ray.hunter@stgconsulting.com
 */

// create the application
app = new Challenge02App();

// this is the output string format
String format = 'ShippingType: %1$s\t cost: $%2$s';

// create order with UPS shipping type
upsOrder = new Order();
upsOrder.ShippingMethod = "UPS";
println sprintf(format, [upsOrder.ShippingMethod, app.CalculateShippingCost(upsOrder)])

// create order with FedEx shipping type
fedexOrder = new Order();
fedexOrder.ShippingMethod = "FedEx";
println sprintf(format, [fedexOrder.ShippingMethod, app.CalculateShippingCost(fedexOrder)])

// create order with USPS shipping type
uspsOrder = new Order();
uspsOrder.ShippingMethod = "USPS";
println sprintf(format, [uspsOrder.ShippingMethod, app.CalculateShippingCost(uspsOrder)])

// create order with DHL shipping type
dhlOrder = new Order();
dhlOrder.ShippingMethod = "DHL";
println sprintf(format, [dhlOrder.ShippingMethod, app.CalculateShippingCost(dhlOrder)])

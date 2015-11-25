/**
 * Main Groovy Script
 *
 * @author Ray Hunter ray.hunter@stgconsulting.com
 */

app = new Challenge02App();

String format = 'ShippingType: %1$s\t cost: $%2$s';

upsOrder = new Order();
upsOrder.ShippingMethod = "UPS";
println sprintf(format, [upsOrder.ShippingMethod, app.CalculateShippingCost(upsOrder)])

fedexOrder = new Order();
fedexOrder.ShippingMethod = "FedEx";
println sprintf(format, [fedexOrder.ShippingMethod, app.CalculateShippingCost(fedexOrder)])

uspsOrder = new Order();
uspsOrder.ShippingMethod = "USPS";
println sprintf(format, [uspsOrder.ShippingMethod, app.CalculateShippingCost(uspsOrder)])

dhlOrder = new Order();
dhlOrder.ShippingMethod = "DHL";
println sprintf(format, [dhlOrder.ShippingMethod, app.CalculateShippingCost(dhlOrder)])

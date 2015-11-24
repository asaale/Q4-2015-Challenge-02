class Order():
	shippingMethod = 'FedEx'

#	public double CalculateShippingCost(Order order) {
#switch (order.ShippingMethod) {
#case “UPS”: return CalculateUpsShipping();
#case “FedEx”: return CalculateFedExShipping();
#case “USPS”: return CalculateFedExShipping()
def CalculateUpsShipping():
	return 10;
	
def CalculateFedExShipping():
	return 20;
	
def CalculateUspsShipping():
	return 30;
	
def CalculateDhlShipping():
	return 40;

shipping = {
	'UPS' : CalculateUpsShipping,
	'FedEx' : CalculateFedExShipping,
	'USPS' : CalculateUspsShipping,
	'DHL' : CalculateDhlShipping
}

def CalculateShippingCost(order):
	return shipping[order.shippingMethod]()
	
if __name__ == '__main__':
	order = Order()
	print(CalculateShippingCost(order))
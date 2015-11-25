package shipping;

import java.util.List;

public class FedexShippingMethod implements ShippingMethod {

	private static double GROUND_COST_PER_POUND = 2.2;
	
	@Override
	public double calculateShippingCost(Order order) {
		List<OrderItem> items = order.getItems();
		
		double totalWeight = 0;
		
		for (OrderItem item : items) {
			if(item.getWeight() < 1) {
				totalWeight += 1;
			} else {
				totalWeight += item.getWeight();
			}
		}
		
		return totalWeight * GROUND_COST_PER_POUND;
	}
}

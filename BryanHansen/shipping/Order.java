package shipping;

import java.util.ArrayList;
import java.util.List;

public class Order {

	private List<OrderItem> items = new ArrayList<>();
	private ShippingMethod shippingMethod;
	
	public ShippingMethod getShippingMethod() {
		return shippingMethod;
	}

	public List<OrderItem> getItems() {
		return items;
	}

	public void add(OrderItem item) {
		items.add(item);
	}

	public void setShippingMethod(ShippingMethod shippingMethod) {
		this.shippingMethod = shippingMethod;
	}
	
	public double calculateShippingCost() {
		return shippingMethod.calculateShippingCost(this);
	}
}

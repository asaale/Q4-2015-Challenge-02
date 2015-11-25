package shipping;

public class ShippingDemo {

	public static void main(String[] args) {
		Order order = new Order();
		
		OrderItem item = new OrderItem();
		item.setDesc("iPod shuffle 2 gig");
		item.setQuantity(1);
		item.setWeight(.2);
		
		order.add(item);
		
		item = new OrderItem();
		item.setDesc("Samsung TV 4K");
		item.setQuantity(1);
		item.setWeight(48);
		
		order.add(item);
		
		ShippingMethod shippingMethod = new UpsShippingMethod();
		
		order.setShippingMethod(shippingMethod);
		
		System.out.println(order.calculateShippingCost());
		
		shippingMethod = new DhlShippingMethod();
		
		order.setShippingMethod(shippingMethod);
		
		System.out.println(order.calculateShippingCost());
	}
}

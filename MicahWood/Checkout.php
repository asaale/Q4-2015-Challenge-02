<?php

class Checkout {
  public function calculateShippingCost(Order $order) {
    // switch (order.ShippingMethod) {
    //     case "UPS": return CalculateUpsShipping();
    //     case "FedEx": return CalculateFedExShipping();
    //     case "USPS": return CalculateUspsShipping();
    // }
    return $order->calculateShipping();
  }
}

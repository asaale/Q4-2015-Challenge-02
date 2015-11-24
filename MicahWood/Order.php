<?php

class Order {
  /**
   * @var Shipping
   */
  private $shippingMethod;

  function __construct(Shipping $shipping) {
    $this->shippingMethod = $shipping;
  }

  public function calculateShipping()
  {
    return $this->shippingMethod->cost();
  }

  public function shippingMethod()
  {
    return $this->shippingMethod->name();
  }
}

<?php

class ShippingMethodFactory {

  public static function fromForm(array $formData)
  {
    $shippingClass = $formData['shipping_method'] . 'Shipping';

    if (! class_exists($shippingClass)) {
      throw new Exception($shippingClass . ' has not yet been implemented');
    }

    return new $shippingClass;
  }
}

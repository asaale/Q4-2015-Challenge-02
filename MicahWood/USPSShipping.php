<?php

class USPSShipping implements Shipping {
  public function name()
  {
    return 'USPS';
  }
  public function cost()
  {
    return 50;
  }
}

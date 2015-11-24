<?php

class UPSShipping implements Shipping {
  public function name()
  {
    return 'UPS';
  }
  public function cost()
  {
    return 20;
  }
}

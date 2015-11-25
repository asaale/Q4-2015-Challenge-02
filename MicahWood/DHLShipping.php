<?php

class DHLShipping implements Shipping {
  public function name()
  {
    return 'DHL';
  }
  public function cost()
  {
    return 10;
  }
}

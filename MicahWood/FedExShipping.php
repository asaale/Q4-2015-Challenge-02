<?php

class FedExShipping implements Shipping {
  public function name()
  {
    return 'FedEx';
  }
  public function cost()
  {
    return 15;
  }
}

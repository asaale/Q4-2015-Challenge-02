<?php

require 'Checkout.php';
require 'Order.php';
require 'ShippingMethodFactory.php';
require 'Shipping.php';
require 'UPSShipping.php';
require 'USPSShipping.php';
require 'FedExShipping.php';
require 'DHLShipping.php';

// Simulate getting the Shipping method from a form
$_POST['shipping_method'] = isset($argv[1]) ? $argv[1] : 'DHL';

$order = new Order(ShippingMethodFactory::fromForm($_POST));
$shippingCost = (new Checkout)->calculateShippingCost($order);

echo $order->shippingMethod() . ' Shipping Cost $' . $shippingCost;

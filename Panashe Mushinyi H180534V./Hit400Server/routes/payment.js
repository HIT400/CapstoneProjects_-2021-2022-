const router = require('express').Router();
const moment = require('moment');
const stripe = require('stripe')(process.env.STRIPE_SECRET_KEY);
const verifyToken = require('../middlewares/verify-token');
const Order = require('../models/order');
const User = require('../models/User');

const SHIPMENT = {
  normal: {
    price: 13.98,
    days: 7,
  },
  fast: {
    price: 49.98,
    days: 3,
  },
};

function shipmentPrice(shipmentOption) {
  const estimated = moment()
    .add(shipmentOption.days, 'd')
    .format('dddd MMMM Do');

  return { estimated, price: shipmentOption.price };
}

router.post('/shipment', (req, res) => {
  let shipment;
  if (req.body.shipment === 'normal') {
    shipment = shipmentPrice(SHIPMENT.normal);
  } else {
    shipment = shipmentPrice(SHIPMENT.fast);
  }

  res.json({ success: true, shipment: shipment });
});

/* payment */
router.post('/payment', verifyToken, (req, res) => {
  try {
    const totalPrice = Math.round(req.body.totalPrice * 100);
    stripe.customers
      .create({
        email: req.decoded.email,
      })
      .then((customer) => {
        return stripe.customers.createSource(customer.id, {
          source: 'tok_visa',
        });
      })
      .then((source) => {
        return stripe.charges.create({
          amount: totalPrice,
          currency: 'usd',
          customer: source.customer,
        });
      })
      .then(async (charge) => {
        const order = new Order();
        const cart = req.body.cart;

        cart.map((product) => {
          order.products.push({
            productID: product._id,
            quantity: parseInt(product.quantity),
            price: product.price,
          });
        });
        order.owner = req.decoded._id;
        order.estimatedDelivery = req.body.estimatedDelivery;
        await order.save();

        res.json({
          success: true,
          message: 'successfully made a payment',
        });
      });
  } catch (err) {
    res.status(500).json({
      success: false,
      message: err.message,
    });
  }
});

// put request - update basic user
router.put('/payment/basic/:id', verifyToken, async (req, res) => {
  try {
    const user = await User.findOneAndUpdate(
      { _id: req.params.id },
      {
        $set: {
          paymentmade: true,
        },
      },
      { upsert: true }
    );

    res.json({
      success: true,
      user: user,
    });
  } catch (err) {
    res.status(500).json({
      success: false,
      message: err.message,
    });
  }
});

module.exports = router;

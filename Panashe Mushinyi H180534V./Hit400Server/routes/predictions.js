const router = require('express').Router();
const Prediction = require('../models/predictions');
const axios = require('axios').default;

router.post('/predictions', async (req, res) => {
  try {
    const pred = new Prediction();
    pred.rainfall = req.body.rainfall;
    pred.temperature = req.body.temperature;
    pred.humidity = req.body.humidity;
    pred.prediction = req.body.outbreak;
    pred.date = new Date(Date.now()).toString().slice(0, 15);

    await pred.save();
    res.json({
      success: true,
      message: 'successfully saved',
    });
  } catch (err) {
    console.log(err);
    res.status(500).json({
      success: false,
      message: err.message,
    });
  }
});

router.get('/getPredictions', async (req, res) => {
  try {
    const result = await Prediction.find();
    res.json({
      success: true,
      items: result,
    });
  } catch (error) {
    res.status(500).json({
      success: false,
      message: error.message,
    });
  }
});

module.exports = router;

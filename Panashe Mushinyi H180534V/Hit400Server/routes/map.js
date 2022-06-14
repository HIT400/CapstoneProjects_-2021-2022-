const router = require('express').Router();
const User = require('../models/User');
const verifyToken = require('../middlewares/verify-token');

router.put('/map', verifyToken, async (req, res) => {
  console.log(req.body);
  try {
    const user = await User.findOne({ _id: req.decoded._id });
    user.Latitude = req.body.Latitude;
    user.Longitude = req.body.Longitude;

    await user.save();
    res.json({
      success: true,
      message: 'saved successfully',
    });
  } catch (err) {
    res.json({
      success: false,
      message: err.message,
    });
    console.log(err);
  }
});

module.exports = router;

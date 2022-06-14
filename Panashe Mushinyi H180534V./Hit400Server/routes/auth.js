const router = require('express').Router();
const User = require('../models/User');
const verifyToken = require('../middlewares/verify-token');

const jwt = require('jsonwebtoken');

/* signup Route */
router.post('/auth/signup', async (req, res) => {
  const response = User.findOne({ Username: req.body.username });
  if (response.Username) {
    console.log('user exists');
  } else {
    console.log('user doest exists create');
    console.log('Creating new user......');
    try {
      const newUser = new User();
      console.log(req.body.username);
      newUser.Username = req.body.username;
      newUser.Password = req.body.password;
      await newUser.save();

      const token = jwt.sign(newUser.toJSON(), process.env.SECRET, {
        expiresIn: 604800, // 1  week
      });

      res.json({
        success: true,
        token: token,
        message: 'sucessfully created a new user',
      });
    } catch (err) {
      res.status(500).json({
        success: false,
        message: err.message,
      });
    }
  }
});

/* profile route */
router.get('/auth/user', verifyToken, async (req, res) => {
  try {
    const foundUser = await User.findOne({ _id: req.decoded._id });
    if (foundUser) {
      res.json({
        success: true,
        user: foundUser,
      });
    }
  } catch (err) {
    res.status(500).json({
      success: false,
      message: err.message,
    });
  }
});

/* login route */
router.post('/auth/login', async (req, res) => {
  console.log(req.body.username);
  try {
    const foundUser = await User.findOne({ Username: req.body.username });
    console.log(foundUser);
    if (!foundUser) {
      res.status(403).json({
        success: false,
        message: 'Authentication failed, User not found',
      });
    } else {
      if (foundUser.comparePassword(req.body.password)) {
        const token = jwt.sign(foundUser.toJSON(), process.env.SECRET, {
          expiresIn: 604800, // 1 week
        });
        res.json({
          success: true,
          token: token,
        });
      } else {
        res.status(403).json({
          success: false,
          message: 'Authentication failed, Wrong password!',
        });
      }
    }
  } catch (err) {
    console.log(err);
    res.status(500).json({
      success: false,
      message: err.message,
    });
  }
});

module.exports = router;

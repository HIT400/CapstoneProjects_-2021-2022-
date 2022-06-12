const router = require('express').Router()
const Address = require('../models/address')
const User = require('../models/user')
const verifyToken = require('../middlewares/verify-token')
const axios = require('axios')

/* create an address */
router.post('/addresses', verifyToken, async (req, res) => {
  try {
    const address = new Address()
    address.user = req.decoded._id
    address.fullName = req.body.fullName
    address.country = req.body.country
    address.zipCode = req.body.zipCode
    address.securityCode = req.body.securityCode
    address.city = req.body.city
    address.state = req.body.state
    address.streetAddress = req.body.streetAddress
    address.phoneNumber = req.body.phoneNumber
    address.deliverInstructions = req.body.deliverInstructions

    await address.save()

    res.json({
      success: true,
      message: 'successfully added an address'
    })
  } catch (err) {
    res.status(500).json({
      success: false,
      message: err.message
    })
  }
})
/* get all addresses */

router.get('/addresses', verifyToken, async (req, res) => {
  try {
    const addresses = await Address.find({ user: req.decoded._id })

    res.json({
      success: true,
      addresses: addresses
    })
  } catch (err) {
    res.status(500).json({
      success: false,
      message: err.message
    })
  }
})

/* GET single address */

router.get('/addresses/:id', verifyToken, async (req, res) => {
  try {
    const address = await Address.findOne({ _id: req.params.id })

    res.json({
      success: true,
      address: address
    })
  } catch (err) {
    res.status(500).json({
      success: false,
      message: err.message
    })
  }
})

/* get list of countries */
/* i am calling an external api without cors policy so i decided to call it in the server not frontend for security purposes */
router.get('/countries', async (req, res) => {
  try {
    const response = await axios.get('https://restcountries.eu/rest/v2/all')

    res.json(response.data)
  } catch (err) {
    res.status(500).json({
      success: false,
      message: err.message
    })
  }
})

/* edit addresses */
router.put('/addresses/:id', verifyToken, async (req, res) => {
  try {
    const foundAddress = await Address.findOne({ _id: req.params.id })
    if (foundAddress) {
      if (req.body.fullName) foundAddress.fullName = req.body.fullName
      if (req.body.country) foundAddress.country = req.body.country
      if (req.body.zipCode) foundAddress.zipCode = req.body.zipCode
      if (req.body.securityCode) foundAddress.securityCode = req.body.securityCode
      if (req.body.city) foundAddress.city = req.body.city
      if (req.body.state) foundAddress.state = req.body.state
      if (req.body.streetAddress) foundAddress.streetAddress = req.body.streetAddress
      if (req.body.phoneNumber) foundAddress.phoneNumber = req.body.phoneNumber
      if (req.body.deliverInstructions) foundAddress.deliverInstructions = req.body.deliverInstructions

      await foundAddress.save()
      res.json({
        success: true,
        message: 'Successfully updated the address'
      })
    }
  } catch (err) {
    res.status(500).json({
      success: false,
      message: err.message
    })
  }
})
/* delete  ad address */

router.delete('/addresses/:id', verifyToken, async (req, res) => {
  try {
    const deletedAddress = await Address.remove({ user: req.decoded._id, _id: req.params.id })
    if (deletedAddress) {
      res.json({
        success: true,
        message: 'Address has been deleted'
      })
    }
  } catch (err) {
    res.status(500).json({
      success: false,
      message: err.message
    })
  }
})

/* set an address default  */

router.put('/addresses/set/default', verifyToken, async (req, res) => {
  try {
    const doc = await User.findOneAndUpdate({ _id: req.decoded._id }, { $set: { address: req.body.id } })
    if (doc) {
      res.json({
        success: true,
        message: 'Successfully set address as default'
      })
    }
  } catch (err) {
    res.status(500).json({
      success: false,
      message: err.message
    })
  }
})

module.exports = router

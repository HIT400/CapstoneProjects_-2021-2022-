const router = require('express').Router()
const Review = require('../models/review')
const Product = require('../models/product')
const verifyToken = require('../middlewares/verify-token')

const cloudinary = require('cloudinary').v2
const multer = require('multer')
const storage = multer.diskStorage({
  destination: function (req, file, cb) {
    cb(null, 'uploads/')
  },
  filename: function (req, file, cb) {
    console.log(file)
    cb(null, file.originalname)
  }
})

// cloudinary configuration
cloudinary.config({
  cloud_name: process.env.CLOUD_NAME,
  api_key: process.env.API_KEY,
  api_secret: process.env.API_SECRET
})

router.post('/reviews/:productID', verifyToken, async (req, res) => {
  const upload = multer({ storage }).single('photo')
  upload(req, res, function (err) {
    if (err) {
      return res.send(err)
    }
    console.log('file uploaded to server')

    const path = req.file.path
    const uniqueFilename = new Date().toISOString()

    try {
      cloudinary.uploader.upload(
        path, { public_id: `users/${uniqueFilename}`, tags: 'user' }, // directory and tags are optional
        async function (err, image) {
          // note if there is an error we need to unlink the image from the server
          // Also use try catch here

          if (err) return res.send(err)
          console.log('file uploaded to Cloudinary')
          // remove file from server
          const fs = require('fs')
          fs.unlinkSync(path)
          // return image details
          const url = image.secure_url
          const id = req.params.productID

          const review = new Review()
          review.rating = req.body.headline
          review.body = req.body.body
          review.rating = req.body.rating
          review.user = req.decoded._id
          review.productID = id
          review.photo = url

          await Product.update({
            $push: { reviews: review._id }
          })

          const savedReview = await review.save()

          if (savedReview) {
            res.json({
              success: true,
              message: 'Successfully added Review'
            })
          }
        })
    } catch (error) {
      const fs = require('fs')
      fs.unlinkSync(path)
      res.status(500).json({
        success: false,
        message: err.message
      })
    }
  })
})

router.get('/reviews/:productID', async (req, res) => {
  try {
    const productReviews = await Review.find({
      productID: req.params.productID
    }).populate('user productID').exec()
    console.log(productReviews)
    res.json({
      success: true,
      reviews: productReviews
    })
  } catch (err) {
    res.status(500).json({
      success: false,
      message: err.message
    })
  }
})

module.exports = router

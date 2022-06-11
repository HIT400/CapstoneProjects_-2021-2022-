const router = require('express').Router()
const Owner = require('../models/owner')
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

// post api
router.post('/owners', async (req, res) => {
  const upload = multer({
    storage
  }).single('photo')
  upload(req, res, function (err) {
    if (err) {
      return res.send(err)
    }
    console.log('file uploaded to server')

    const path = req.file.path
    const uniqueFilename = new Date().toISOString()
    try {
      cloudinary.uploader.upload(
        path, {
          public_id: `owner/${uniqueFilename}`,
          tags: 'owner'
        }, // directory and tags are optional
        function (err, image) {
          // note if there is an error we need to unlink the image from the server
          if (err) return res.send(err)
          console.log('file uploaded to Cloudinary')
          // remove file from server
          const fs = require('fs')
          fs.unlinkSync(path)
          // return image details
          const url = image.secure_url
          const owner = new Owner()
          owner.name = req.body.name
          owner.about = req.body.about
          owner.photo = url
          owner.save()

          res.json({
            success: true,
            message: 'Successfully created a new owner'
          })
        })
    } catch (err) {
      res.status(500).json({
        success: false,
        message: err.message
      })
    }
  })
})

// get request

router.get('/owners', async (req, res) => {
  try {
    const owners = await Owner.find()
    res.json({
      success: true,
      owners: owners
    })
  } catch (err) {
    res.status(500).json({
      success: false,
      message: err.message
    })
  }
})

module.exports = router

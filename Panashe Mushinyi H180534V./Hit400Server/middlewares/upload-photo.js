// not working for NOW!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//! !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//! !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

const cloudinary = require('cloudinary').v2
const { CloudinaryStorage } = require('multer-storage-cloudinary')
const multer = require('multer')

// cloudinary configuration
cloudinary.config({
  cloud_name: 'hit200',
  api_key: '885267476682458',
  api_secret: 'kHOHdl1wlc6SO2JRH6XLG9FbYbw'
})

function upload (image) {
  const data = {
    photo: image
  }

  // upload image here
  cloudinary.uploader.upload(data.photo)
    .then((result) => {
      response.status(200).send({
        message: 'success',
        result
      })
    }).catch((error) => {
      response.status(500).send({
        message: 'failure',
        error
      })
    })
}

module.exports = upload

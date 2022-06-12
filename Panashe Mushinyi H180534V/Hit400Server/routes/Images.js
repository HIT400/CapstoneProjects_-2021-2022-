const router = require('express').Router()
const Product = require('../models/products')
const cloudinary = require('cloudinary').v2
const multer = require('multer')

const storage = multer.diskStorage({
    destination: function(req, file, cb) {
        cb(null, 'uploads/')
    },
    filename: function(req, file, cb) {
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

// put request - update product
router.put('/gallery/:id', async(req, res) => {
    const product = await Product.find({ _id: req.params.id })
    if (product[0].gallery = [] || product[0].gallery.length < 5) {
        const upload = multer({ storage }).single('gallery')
        upload(req, res, function(err) {
            if (err) {
                return res.send(err)
            }
            console.log('file uploaded to server')

            const path = req.file.path
            const uniqueFilename = new Date().toISOString()

            cloudinary.uploader.upload(
                path, { public_id: `gallery/${uniqueFilename}`, tags: 'gallery' }, // directory and tags are optional
                async function(err, image) {
                    // note if there is an error we need to unlink the image from the server
                    if (err) return res.send(err)
                    console.log('file uploaded to Cloudinary')
                        // remove file from server
                    const fs = require('fs')
                    fs.unlinkSync(path)
                        // return image details
                    const url = image.secure_url
                    const product = await Product.findOneAndUpdate({ _id: req.params.id }, {
                        $push: {
                            gallery: url
                        }
                    }, { new: true })

                    res.json({
                        success: true,
                        updatedProduct: product
                    })
                })
        })
    }
    if (product[0].gallery.length === 5) {
        res.json({
            success: 'limit',
            message: 'upload limit reached'
        })
    }
})

// delete gallery images
router.delete('/gallery/:name/:id', async(req, res) => {
    try {
        const deletedProduct = await Product.findByIdAndUpdate(req.params.id, {
            $pull: {
                'gallery[]': req.params.name
            }

        })

        if (deletedProduct) {
            res.json({
                success: true,
                message: 'successfully deleted '
            })
        }
    } catch (err) {
        res.json({
            success: false,
            message: err
        })
    }
})

//update product lead image
router.put("/image/product/:id", async(req, res) => {
    try {


        const upload = multer({ storage }).single('product')
        upload(req, res, function(err) {
            if (err) {
                return res.send(err)
            }
            console.log('file uploaded to server')

            const path = req.file.path
            const uniqueFilename = new Date().toISOString()

            cloudinary.uploader.upload(
                path, { public_id: `product/${uniqueFilename}`, tags: 'product' }, // directory and tags are optional
                async function(err, image) {
                    // note if there is an error we need to unlink the image from the server
                    if (err) return res.send(err)
                    console.log('file uploaded to Cloudinary')
                        // remove file from server
                    const fs = require('fs')
                    fs.unlinkSync(path)
                        // return image details
                    const url = image.secure_url
                    const product = await Product.findOneAndUpdate({ _id: req.params.id }, {
                        $set: {
                            photo: url
                        }
                    }, { new: true })

                    res.json({
                        success: true,
                        updatedProduct: product
                    })
                })
        })

    } catch (err) {
        res.json({
            success: false,
            message: err
        })
    }

})

// delete gallery images
router.post('/gallery/:name/:id', async(req, res) => {
    try {
        const link = req.params.name.replace(/=/gi, "/")
        console.log(link)
        const deletedProduct = await Product.findByIdAndUpdate(req.params.id, {
            $pull: {
                gallery: link
            }

        })
        console.log(deletedProduct)
        if (deletedProduct) {
            res.json({
                success: true,
                message: 'successfully deleted '
            })
        }
    } catch (err) {
        res.json({
            success: false,
            message: err
        })
    }
})
module.exports = router
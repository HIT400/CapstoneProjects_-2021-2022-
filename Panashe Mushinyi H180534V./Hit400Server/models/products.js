const mongoose = require('mongoose')
const Schema = mongoose.Schema

const ProductSchema = new Schema({
    category: String,
    owner: {
        type: Schema.Types.ObjectId,
        ref: 'Store'
    },
    name: String,
    description: String,
    imageUrl: String,
    price: Number,
    model: String,
    size: String,
    gallery: {
        type: Array,
        default: []
    },
    date: {
        type: String
    },
    rating: {
        type: Number,
        default: 0
    },
    rates_no: {
        type: Number,
        default: 0
    },
    user_rating: {
        type: Number,
        default: 0
    },
    persons: {
        type: Array
    }


}, {

})

module.exports = mongoose.model('Product', ProductSchema)
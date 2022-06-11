const mongoose = require('mongoose')

const category = mongoose.Schema({
  name: String,
  image: String
})

module.exports = mongoose.model('Categories', category)

const mongoose = require('mongoose')
const Schema = mongoose.Schema

const AccessSchema = new Schema({
  accesscode: {
    type: String,
    unique: true,
    required: true
  }

})

module.exports = mongoose.model('Access', AccessSchema)

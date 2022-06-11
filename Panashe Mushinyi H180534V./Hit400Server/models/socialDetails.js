const mongoose = require('mongoose')
const Schema = mongoose.Schema

const SocialSchema = new Schema({
  Email1: String,
  Email2: String,
  Facebook: String,
  Twitter: String,
  Whatsapp: String,
  Phone: String,
  Other: String

})

module.exports = mongoose.model('Social', SocialSchema)

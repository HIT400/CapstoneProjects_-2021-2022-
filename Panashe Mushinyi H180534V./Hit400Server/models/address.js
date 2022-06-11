const mongoose = require('mongoose');
const Schema = mongoose.Schema;

const AddressSchema = new Schema({
  country: String,
  fullName: String,
  streetAddress: String,
  city: String,
  state: String,
  zipCode: Number,
  phoneNumber: String,
  securityCode: String,
  user: { type: Schema.Types.ObjectId, ref: 'User' },
});

module.exports = mongoose.model('Address', AddressSchema);

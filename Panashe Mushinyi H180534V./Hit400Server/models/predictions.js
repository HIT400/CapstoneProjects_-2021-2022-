const mongoose = require('mongoose');
const Schema = mongoose.Schema;

const PredictionSchema = new Schema({
  rainfall: String,
  temperature: String,
  humidity: Number,
  prediction: String,
  date: String,
});

module.exports = mongoose.model('Prediction', PredictionSchema);

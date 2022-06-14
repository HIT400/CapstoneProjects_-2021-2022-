const mongoose = require('mongoose')
const Schema = mongoose.Schema

const ReportSchema = new Schema({
    type: String,
    title: String,
    description: String,
    email: String
})

module.exports = mongoose.model('Report', ReportSchema)
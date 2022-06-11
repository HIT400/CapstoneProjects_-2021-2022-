const mongoose = require('mongoose')
const Schema = mongoose.Schema

const SettingsSchema = new Schema({
    isChecked: Boolean
})

module.exports = mongoose.model('Settings', SettingsSchema)
const mongoose = require('mongoose');
const Schema = mongoose.Schema;
const bcrypt = require('bcrypt-nodejs');

const UserSchema = new Schema({
  Username: String,
  Password: {
    type: String,
  },
});

// encrypting before saving
UserSchema.pre('save', function (next) {
  const user = this;
  if (this.isModified('Password') || this.isNew) {
    bcrypt.genSalt(10, function (err, salt) {
      if (err) {
        return next(err);
      }
      bcrypt.hash(user.Password, salt, null, function (err, hash) {
        if (err) {
          return next(err);
        }

        user.Password = hash;
        next();
      });
    });
  } else {
    return next();
  }
});

UserSchema.methods.comparePassword = function (Password, next) {
  // no arrow function coz we want to access the user using this;
  const user = this;
  return bcrypt.compareSync(Password, user.Password);
};

module.exports = mongoose.model('User', UserSchema);

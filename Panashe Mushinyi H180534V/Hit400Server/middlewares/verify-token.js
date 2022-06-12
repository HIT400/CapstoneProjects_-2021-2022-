const jwt = require('jsonwebtoken');

module.exports = function (req, res, next) {
  let token = req.headers['token'] || req.headers.authorization;
  const checkBearer = 'Bearer '; // space after bearer is important becoz mostly fontend inserts a bearer when retriving the token

  if (token) {
    if (token.startsWith(checkBearer)) {
      token = token.slice(checkBearer.length, token.length);
    }

    jwt.verify(token, process.env.SECRET, (err, decoded) => {
      if (err) {
        res.json({
          success: false,
          message: 'Failed to authenticate',
        });
      } else {
        req.decoded = decoded;
        next();
      }
    });
  } else {
    res.json({
      sucess: false,
      message: 'No token Provided',
    });
  }
};

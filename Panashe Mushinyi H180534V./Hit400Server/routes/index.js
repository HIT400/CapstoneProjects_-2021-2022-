const router = require('express').Router()

router.get('/', (req, res) => {
    res.render('Hi wellcome guys')
})

module.exports = router
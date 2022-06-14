const router = require('express').Router();
const Settings = require('../models/settings');

router.put('/theme', async(req, res) => {
    try {
        const foundUser = await User.findOne({ _id: req.decoded._id })

        if (foundUser) {
            if (req.body.isChecked) foundUser.isChecked = req.body.isChecked

            const response = await foundUser.save()
            console.log(response)
            res.json({
                success: true,
                message: 'Successfully updated'
            })
        }

    } catch (err) {
        res.json({
            success: false,
            message: err.message
        })
    }
})

module.exports = router;
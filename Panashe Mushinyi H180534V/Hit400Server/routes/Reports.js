const router = require("express").Router();
const Report = require('../models/Report');

//post report
router.post('/report', async(req, res) => {
    try {
        const report = new Report();
        report.type = req.body.type;
        report.title = req.body.title;
        report.description = req.body.description;
        report.email = req.body.email;

        await report.save()

        res.json({
            success: true,
            Report: report
        })

    } catch (err) {
        console.log(err)
        res.json({
            success: false,
            message: err.message
        })

    }
})


//get all reports
router.get('/report', async(req, res) => {
    try {
        const Report = await Report.find()
        res.json({
            success: true,
            Report: Report
        })
    } catch (err) {
        res.json({
            success: false,
            message: err.message
        })
    }

})

module.exports = router;
const router = require('express').Router();
const { fromString } = require('uuidv4');
const verifyToken = require('../middlewares/verify-token');

const axios = require('axios');

const Apply = require('../models/applybusiness');

router.post('/patient/add', verifyToken, async (req, res) => {
  try {
    const apply = new Apply();
    apply.firstName = req.body.firstName;
    apply.lastName = req.body.lastName;
    apply.age = req.body.age;
    apply.period = req.body.period;
    apply.gender = req.body.gender;
    apply.emailAddress = req.body.emailAddress;
    apply.mobileNumber = req.body.mobileNumber;
    apply.streetAddress = req.body.streetAddress;
    apply.city = req.body.city;
    apply.state = req.body.state;
    apply.postalCode = req.body.postalCode;
    apply.pregnant = req.body.pregnant;
    apply.admitted = req.body.admitted;
    apply.travelled = req.body.travelled;
    apply.visitedCountry = req.body.visitedCountry;
    apply.returnDate = req.body.returnDate;
    apply.duration = req.body.duration;
    apply.durationUnit = req.body.durationUnit;
    apply.visitor = req.body.visitor;
    apply.reasonForTravel = req.body.reasonForTravel;
    apply.chemoprophylaxis = req.body.chemoprophylaxis;
    apply.drugsChemoprophylaxis = req.body.drugsChemoprophylaxis;
    apply.hadMalaria = req.body.hadMalaria;
    apply.illnessDate = req.body.illnessDate;
    apply.speciesDisease = req.body.speciesDisease;
    apply.fever = req.body.fever;
    apply.flu = req.body.flu;
    apply.shakingChills = req.body.shakingChills;
    apply.Nausea = req.body.Nausea;
    apply.vomiting = req.body.vomiting;
    apply.headache = req.body.headache;
    apply.musclePain = req.body.musclePain;
    apply.diarrhea = req.body.diarrhea;
    apply.tiredness = req.body.tiredness;
    apply.comments = req.body.comments;
    apply.deduced = req.body.deduced;
    apply.Facility = req.body.Facility;

    apply.date = new Date(Date.now()).toString().slice(0, 15);

    await apply.save();
    res.json({
      success: true,
      message: 'successfully saved',
    });
  } catch (err) {
    console.log(err);
    res.status(500).json({
      success: false,
      message: err.message,
    });
  }
});

//get 10 latest records
router.get('/latestTen', async (req, res) => {
  try {
    const apply = await Apply.find().sort().limit(10);
    res.json({
      success: true,
      apply: apply,
    });
  } catch (err) {
    res.status(500).json({
      success: false,
      message: err.message,
    });
  }
});

//count items
router.get('/count', async (req, res) => {
  try {
    const critical = await Apply.find({ deduced: 'Critical' }).count();
    const mild = await Apply.find({ deduced: 'Mild' }).count();
    const total = mild + critical;

    res.json({
      success: true,
      count: [
        {
          name: 'Critical',
          amount: critical,
        },
        {
          name: 'Mild',
          amount: mild,
        },
        {
          name: 'Total',
          amount: total,
        },
      ],
    });
  } catch (err) {
    res.status(500).json({
      success: false,
      message: err.message,
    });
  }
});

//group by date
router.get('/byDate', async (req, res) => {
  try {
    const byDate = await Apply.aggregate([
      { $group: { _id: '$date', count: { $sum: 1 } } },
    ]).limit(30);
    console.log(byDate);
    res.json({
      success: true,
      items: byDate,
    });
  } catch (err) {
    res.status(500).json({
      success: false,
      message: err.message,
    });
  }
});

//group by date
router.get('/FacilityData', async (req, res) => {
  try {
    const FacilityData = await Apply.aggregate([
      {
        $group: {
          _id: { Facility: '$Facility', deduced: '$deduced' },
          count: { $sum: 1 },
        },
      },
    ]).limit(30);

    console.log(FacilityData);
    res.json({
      success: true,
      items: FacilityData,
    });
  } catch (err) {
    res.status(500).json({
      success: false,
      message: err.message,
    });
  }
});

//search by firstname
router.get('/search/:query', async (req, res) => {
  try {
    console.log(req.params.query);
    const result = await Apply.find({
      firstName: { $regex: req.params.query, $options: 'si' },
    });
    console.log(result);
    res.json({
      success: true,
      items: result,
    });
  } catch (error) {
    res.status(500).json({
      success: false,
      message: error.message,
    });
  }
});

router.get('/getCases', async (req, res) => {
  try {
    console.log(req.params.query);
    const result = await Apply.find();
    res.json({
      success: true,
      items: result,
    });
  } catch (error) {
    res.status(500).json({
      success: false,
      message: error.message,
    });
  }
});

router.get('/apply/:id', async (req, res) => {
  try {
    const apply = await Apply.findOne({ _id: req.params.id });
    res.json({
      success: true,
      apply: apply,
    });
  } catch (err) {
    res.status(500).json({
      success: false,
      message: err.message,
    });
  }
});

module.exports = router;

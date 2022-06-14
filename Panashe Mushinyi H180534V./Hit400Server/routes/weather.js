const axios = require('axios').default;
const router = require('express').Router();

const fetchdata =
  'http://api.weatherapi.com/v1/current.json?key=dea4f6e58a564d6ba20192803210611&q=chipinge&aqi=no';

// get request
router.get('/weather', async (req, res) => {
  axios
    .get(fetchdata)
    .then((result) => {
      console.log(result);
      const data = {
        humidity: result.data.current.humidity,
        precipitation: result.data.current.precip_mm,
        temperature: result.data.current.temp_c,
        last_updated: result.data.current.last_updated,
      };
      console.log(data);
      res.json({
        success: true,
        data,
      });
    })
    .catch((error) => {
      console.error('error: ', error);
    });
});
router.get('/predict', async (req, res) => {
  fetch(fetchdata, { method: 'GET', compress: true })
    .then((res) => {
      res.json();
      //predict
      const predictionEngineUrl = '';
      const data = {};
      const result = fetch(predictionEngineUrl, {
        method: 'POST',
        body: JSON.stringify(data),
      });
      return result;
    })
    .then((json) =>
      res.json({
        success: true,
        access: access,
      })
    )
    .catch((error) => {
      res.status(500).json({
        success: false,
        message: err.message,
      });
    });
});

module.exports = router;

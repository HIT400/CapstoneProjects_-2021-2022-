const express = require('express');
const morgan = require('morgan');
const bodyParser = require('body-parser');
const mongoose = require('mongoose');
const dotenv = require('dotenv');
const cors = require('cors');

dotenv.config();

const app = express();

mongoose.connect(
  process.env.DATABASE,
  {
    useCreateIndex: true,
    useNewUrlParser: true,
    useUnifiedTopology: true,
  },
  (err) => {
    if (err) {
      console.log(err);
    } else {
      console.log('connected to mongo db');
    }
  }
);
// middlwware
app.use(cors());
app.use(morgan('dev'));
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: false }));

const applyBusiness = require('./routes/applybusiness');
const weather = require('./routes/weather');
const authRoute = require('./routes/auth');
const paymentRoute = require('./routes/payment');
const ProductRoute = require('./routes/products');
const GalleryRoute = require('./routes/Images');
const ReportRoute = require('./routes/Reports');
const mapRoute = require('./routes/map');
const PredRoute = require('./routes/predictions');
const SettingsRoute = require('./routes/settings');
const CategoryRoute = require('./routes/category');
const index = require('./routes/index');

app.use('/', index);
app.use('/api', applyBusiness);
app.use('/api', weather);
app.use('/api', authRoute);
app.use('/api', paymentRoute);
app.use('/api', ProductRoute);
app.use('/api', GalleryRoute);
app.use('/api', ReportRoute);
app.use('/api', mapRoute);
app.use('/api', PredRoute);
app.use('/api', SettingsRoute);
app.use('/api', CategoryRoute);

const port = process.env.PORT || 9000;
app.listen(port, (err) => {
  if (err) {
    console.log(err);
  } else {
    console.log('connected on port', port);
  }
});

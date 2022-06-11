import axios from 'axios';
import {baseUrl, secondaryUrl} from '../config';

export const QrcodeImage = async token => {
  console.log('image download hit');
  const response = await axios({
    url: `${baseUrl}/general/self-register-qr`,
    method: 'get',
    headers: {
      formToken: token,
    },
  });

  if (response.status === 200) {
    return response.data;
  } else {
    return 'FAILED TO CREATE PERSON';
  }
};

export const QrcodePdf = async token => {
  console.log('pdf download hit');
  const response = await axios({
    url: `${secondaryUrl}/myform/qrcode/pdf`,
    method: 'get',
    headers: {
      formToken: token,
    },
  });

  if (response.status === 200) {
    return response.data;
  } else {
    return 'FAILED TO CREATE PERSON';
  }
};

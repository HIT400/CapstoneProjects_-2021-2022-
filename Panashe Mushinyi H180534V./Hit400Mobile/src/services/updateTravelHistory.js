import axios from 'axios';
import {secondaryUrl} from '../config';

export default async (details, token) => {
  console.log('hit');
  console.log(details);
  const response = await axios({
    url: `${secondaryUrl}/myform/travelHistory`,
    method: 'post',
    data: details,
    headers: {
      'Content-Type': 'application/json',
      formToken: token,
    },
  });

  if (response.status === 200) {
    return response.data;
  } else {
    return 'FAILED TO CREATE PERSON';
  }
};

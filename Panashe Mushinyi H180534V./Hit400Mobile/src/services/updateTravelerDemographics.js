import axios from 'axios';
import {secondaryUrl} from '../config';

export default async (details, token) => {
  const response = await axios({
    url: `${secondaryUrl}/myform/traveller`,
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

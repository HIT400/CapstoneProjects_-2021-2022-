import axios from 'axios';
import {baseUrl} from '../config';

export default async credentials => {
  console.log(credentials);
  const response = await axios.post(`${baseUrl}/api/auth/login`, credentials);
  console.log(response);

  if (response.status === 200) {
    console.log(response.data);
    return response.data.data;
  } else {
    return 'FAILED TO CREATE PERSON';
  }
};

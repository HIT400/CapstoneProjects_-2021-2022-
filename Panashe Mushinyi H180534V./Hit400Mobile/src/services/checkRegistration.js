import axios from 'axios';
import {baseUrl} from '../config';

export default async personalDetails => {
  const {firstName, lastName} = personalDetails;

  try {
    const response = await axios.get(
      `${baseUrl}/general/is-registered?firstName=${firstName}&lastName=${lastName}`,
    );
    console.log('response', response);
    if (response.status === 200 && response.data.success) {
      return response.data.data;
    }
  } catch (error) {
    console.error(error);
    if (error.response.status === 404) {
      return null;
    } else {
      return null;
    }
  }
};

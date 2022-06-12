import AsyncStorage from '@react-native-async-storage/async-storage';
import axios from 'axios';
import {baseUrl} from '../config';

export default async () => {
  try {
    const response = await axios.get(`${baseUrl}/api/count`);
    console.log(response.data.count);
    return response.data.count;
  } catch (error) {
    console.error(error);
    return {
      error: true,
    };
  }
};

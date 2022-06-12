import AsyncStorage from '@react-native-async-storage/async-storage';
import axios from 'axios';
import {baseUrl} from '../config';

export default async () => {
  try {
    const response = await axios.get(`${baseUrl}/api/weather`);
    console.log(response.data.data);
    return response.data.data;
  } catch (error) {
    console.error(error);
    return {
      error: true,
    };
  }
};

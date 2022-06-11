import AsyncStorage from '@react-native-async-storage/async-storage';
import axios from 'axios';
import {baseUrl} from '../config';

export default async () => {
  try {
    const response = await axios.get(`${baseUrl}/api/byDate`);
    return response.data.items;
  } catch (error) {
    console.error(error);
    return {
      error: true,
    };
  }
};

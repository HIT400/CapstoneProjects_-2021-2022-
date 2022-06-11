import AsyncStorage from '@react-native-async-storage/async-storage';
import axios from 'axios';
import {baseUrl} from '../config';

export default async Data => {
  console.log('running');
  try {
    const response = await axios.post(`${baseUrl}/api/predictions`, Data);
    console.log(response.data);
    return response.data;
  } catch (error) {
    console.error(error);
    return {
      error: true,
    };
  }
};

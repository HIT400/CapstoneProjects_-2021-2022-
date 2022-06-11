import AsyncStorage from '@react-native-async-storage/async-storage';
import axios from 'axios';
import {baseUrl} from '../config';

export default async data => {
  try {
    console.log('this was called');
    const response = await axios.post(
      'https://hit400prediction-api.herokuapp.com/predict',
      data,
    );
    console.log(response.data);
    return response.data;
  } catch (error) {
    console.error(error);
    return {
      error: true,
    };
  }
};

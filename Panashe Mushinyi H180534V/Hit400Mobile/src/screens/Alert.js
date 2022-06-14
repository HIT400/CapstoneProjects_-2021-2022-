/* eslint-disable react-native/no-inline-styles */
import React, {Component, useEffect, useState} from 'react';
import {TouchableOpacity, Dimensions} from 'react-native';
import {
  View,
  Button,
  Stack,
  Center,
  Select,
  Spinner,
  Text,
  CheckIcon,
  useToast,
  VStack,
  HStack,
  ScrollView,
  Box,
  Divider,
  NativeBaseProvider,
} from 'native-base';
import {} from 'react-native';
import Icon from 'react-native-vector-icons/AntDesign';
import {Header} from '../components';
import {styles} from '../styles';
import AsyncStorage from '@react-native-async-storage/async-storage';
import DataTable, {COL_TYPES} from 'react-native-datatable-component';
import {getPredict, getPredictions, getPredictionsData} from '../services';
let height = Dimensions.get('window').height;
let width = Dimensions.get('window').width;

export default function Main({navigation, route}) {
  const [cases, setCases] = useState([]);
  const [CasesDataLoading, setCasesDataLoading] = useState();
  const [outbreak, setOutbreak] = useState();
  const [loading, setLoading] = useState(false);
  const toast = useToast();

  //load alert and save to local state from Main Screen.

  useEffect(() => {
    getPredictionsData()
      .then(data => {
        console.log(data);
        setCases(data);
        setCasesDataLoading(false);
      })
      .catch(error => {
        console.log(error);
        setCasesDataLoading(false);
      });
  }, []);
  async function predict() {
    setLoading(true);
    const data = await AsyncStorage.getItem('climaticData');
    const datatojson = JSON.parse(data);
    const NEW_DATA = {
      Rainfall: datatojson.precipitation,
      Min_Humidity: datatojson.humidity - 10 > 0 ? datatojson.humidity - 10 : 0,
      Max_Humidity: datatojson.humidity,
      Min_Temperature:
        datatojson.temperature - 10 > 0 ? datatojson.temperature - 10 : 0,
      Max_Temperature: datatojson.temperature,
    };
    getPredict(NEW_DATA)
      .then(async dt => {
        setOutbreak(dt.Outbreak);
        const dat = {
          rainfall: datatojson.precipitation,
          temperature: datatojson.temperature,
          humidity: datatojson.humidity,
          outbreak: dt.Outbreak,
        };

        await getPredictions(dat);
        setLoading(false);
      })
      .catch(error => {
        console.log(error);
        setLoading(false);
      });
  }
  useEffect(() => {
    predict();
  }, []);

  return (
    <NativeBaseProvider>
      <View>
        <Header />
      </View>
      {loading === true ? (
        <View
          bg="white"
          rounded="md"
          p={4}
          m={2}
          borderWidth={1}
          style={{
            display: 'flex',
            flexDirection: 'column',
            justifyContent: 'center',
            alignContent: 'center',
            alignItems: 'center',
            borderColor: 'red',
          }}
          borderColor="#efefef">
          <Spinner color="#d75369" size={30} />
          <Text>Running Predictions ..</Text>
        </View>
      ) : (
        <View
          bg="white"
          rounded="md"
          p={4}
          m={2}
          borderWidth={1}
          style={{
            display: 'flex',
            flexDirection: 'column',
            justifyContent: 'center',
            alignContent: 'center',
            alignItems: 'center',
            borderColor: 'red',
          }}
          borderColor="#efefef">
          <Icon name={'warning'} color={'red'} size={24} />
          <Text
            style={{
              marginTop: 10,
              marginBottom: 10,
              paddingTop: 10,
              paddingHorizontal: 10,
              fontWeight: '500',
              fontSize: 20,
              color: '#454b58',
              fontFamily: 'Rubik-Regular',
            }}>
            Current Prediction
          </Text>
          <Text
            style={{
              marginTop: 10,
              marginBottom: 10,
              paddingTop: 10,
              paddingHorizontal: 10,
              fontWeight: '500',
              fontSize: 20,
              color: 'red',
              fontFamily: 'Rubik-Regular',
            }}>
            {outbreak?.toString() === 'true'
              ? 'Outbreak Detected'
              : 'No Outbreak Detected'}
          </Text>
        </View>
      )}
      <View style={{backgroundColor: 'white'}}>
        <Text
          style={{
            marginTop: 10,
            marginBottom: 10,
            paddingTop: 10,
            paddingHorizontal: 10,
            fontWeight: '500',
            fontSize: 20,
            color: '#454b58',
            fontFamily: 'Rubik-Light',
          }}>
          Previous Predictions
        </Text>
      </View>
      <View
        horizontal={true}
        showsHorizontalScrollIndicator={false}
        style={{backgroundColor: '#ffffff', height: height, width: width}}>
        {CasesDataLoading === true ? (
          <Center h={height}>
            <Spinner color="#d75369" size={30} />
          </Center>
        ) : (
          <DataTable
            data={cases}
            colNames={[
              'humidity',
              'rainfall',
              'temperature',
              'prediction',
              'date',
            ]} //List of Strings
            colSettings={[
              {name: 'humidity', type: COL_TYPES.STRING},
              {name: 'rainfall', type: COL_TYPES.STRING},
              {name: 'temperature', type: COL_TYPES.STRING},
              {name: 'prediction', type: COL_TYPES.STRING},
              {name: 'date', type: COL_TYPES.STRING},
            ]} //List of Objects
            noOfPages={1} //number
            backgroundColor={'transparent'} //Table Background Color
          />
        )}
      </View>
    </NativeBaseProvider>
  );
}

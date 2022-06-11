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
import {Header} from '../components';
import {styles} from '../styles';
import AsyncStorage from '@react-native-async-storage/async-storage';
import DataTable, {COL_TYPES} from 'react-native-datatable-component';
import {getCasesList} from '../services';
let height = Dimensions.get('window').height;
let width = Dimensions.get('window').width;

export default function Main({navigation, route}) {
  const [cases, setCases] = useState([]);
  const [CasesDataLoading, setCasesDataLoading] = useState(true);
  const toast = useToast();

  useEffect(() => {
    getCasesList()
      .then(data => {
        setCases(data);
        setCasesDataLoading(false);
      })
      .catch(error => {
        console.log(error);
        setCasesDataLoading(false);
      });
  }, []);

  return (
    <NativeBaseProvider>
      <View>
        <Header />
      </View>
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
          Cases List
        </Text>
      </View>
      <ScrollView
        horizontal={true}
        showsHorizontalScrollIndicator={false}
        style={{backgroundColor: '#ffffff', height: height}}>
        {CasesDataLoading === true ? (
          <Center h={height / 2} w={width}>
            <Spinner color="#d75369" size={30} />
          </Center>
        ) : (
          <DataTable
            data={cases}
            colNames={[
              'firstName',
              'lastName',
              'deduced',
              'age',
              'gender',
              'Facility',
              'date',
            ]} //List of Strings
            colSettings={[
              {name: 'firstName', type: COL_TYPES.STRING},
              {name: 'lastName', type: COL_TYPES.STRING},
              {name: 'deduced', type: COL_TYPES.STRING},
              {name: 'age', type: COL_TYPES.STRING},
              {name: 'gender', type: COL_TYPES.STRING},
              {name: 'Facility', type: COL_TYPES.STRING},
              {name: 'date', type: COL_TYPES.STRING},
            ]} //List of Objects
            noOfPages={1} //number
            backgroundColor={'transparent'} //Table Background Color
          />
        )}
      </ScrollView>
    </NativeBaseProvider>
  );
}

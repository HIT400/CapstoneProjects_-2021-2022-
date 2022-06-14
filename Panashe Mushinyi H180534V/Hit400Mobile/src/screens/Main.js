/* eslint-disable react-native/no-inline-styles */
import React, {Component, useEffect, useState} from 'react';
import {TouchableOpacity, Dimensions} from 'react-native';
import {
  View,
  Button,
  Stack,
  Center,
  Select,
  Text,
  CheckIcon,
  useToast,
  VStack,
  Spinner,
  HStack,
  ScrollView,
  Box,
  Divider,
  NativeBaseProvider,
} from 'native-base';
import {} from 'react-native';
import {Header} from '../components';
import AsyncStorage from '@react-native-async-storage/async-storage';
import {getClimateReadings, getCasesData, getChartData} from '../services';
import {
  LineChart,
  BarChart,
  PieChart,
  ProgressChart,
  ContributionGraph,
  StackedBarChart,
} from 'react-native-chart-kit';
let height = Dimensions.get('window').height;
let width = Dimensions.get('window').width;

export default function Main({navigation, route}) {
  const [ClimaticDataLoading, setClimaticDataLoading] = useState(true);
  const [CasesDataLoading, setCasesDataLoading] = useState(true);
  const [ChartDataLoading, setChartDataLoading] = useState(true);
  const [chartData, setChartData] = useState([]);
  const [ClimaticData, setClimaticData] = useState({
    temperature: 0,
    humidity: 0,
    precipitation: 0,
    last_updated: '',
  });
  const [CasesData, setCasesData] = useState({
    critical: 0,
    mild: 0,
    total: 0,
  });

  /*   const [ClimaticDataLoading, setClimaticDataLoading] = useState(true);
  const [ClimaticData, setClimaticData] = useState({}); */

  const data = {
    labels: [
      1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21,
      22, 23, 24, 25, 26, 27, 28, 29, 30,
    ],
    datasets: [
      {
        data: chartData,
        color: (opacity = 1) => `rgba(134, 65, 244, ${opacity})`, // optional
        strokeWidth: 2, // optional
      },
    ],
    legend: ['cases'], // optional
  };

  /*  const chartConfig = {
    backgroundGradientFrom: '#fff',
    backgroundGradientFromOpacity: 0,
    backgroundGradientTo: '#fff',
    backgroundGradientToOpacity: 0.5,
    color: (opacity = 1) => `rgba(255, 255, 255, ${opacity})`,
    strokeWidth: 2, // optional, default 3
    barPercentage: 0.5,
    useShadowColorFromDataset: false, // optional
    style: {
      borderRadius: 16,
    },
    propsForDots: {
      r: '6',
      strokeWidth: '2',
      stroke: '#fff',
    },
  }; */
  const chartConfig = {
    backgroundGradientFrom: '#fff',
    backgroundGradientFromOpacity: 0,
    backgroundGradientTo: '#fff',
    backgroundGradientToOpacity: 0.5,
    color: (opacity = 1) => `rgba(0, 0, 0, ${opacity})`,
    strokeWidth: 2, // optional, default 3
    barPercentage: 0.5,
    useShadowColorFromDataset: false,
    style: {
      borderRadius: 16,
    },
    propsForDots: {
      r: '6',
      strokeWidth: '2',
      stroke: '#fff',
    }, // optional
  };

  useEffect(() => {
    getClimateReadings()
      .then(async climateReadings => {
        setClimaticData(climateReadings);
        await AsyncStorage.setItem(
          'climaticData',
          JSON.stringify(climateReadings),
        );
        setClimaticDataLoading(false);
      })
      .catch(error => {
        console.log(error);
        setClimaticDataLoading(false);
      });
  }, []);
  useEffect(() => {
    getChartData()
      .then(res => {
        const temp = [];
        res.forEach(item => {
          temp.push(item.count);
        });

        const remaining = 30 - temp.length;
        const tempdata = temp.concat(Array(remaining).fill(0));
        setChartData(tempdata);
        setChartDataLoading(false);
      })
      .catch(error => {
        console.log(error);
        setChartDataLoading(false);
      });
  }, []);

  useEffect(() => {
    console.log('called');
    getCasesData()
      .then(Readings => {
        console.log(Readings, 'reading fetched');
        const critical = Readings[0].amount;
        const mild = Readings[1].amount;
        const total = Readings[2].amount;
        /* const severe = Readings[3].amount; */
        setCasesData({
          critical,
          mild,
          total,
        });
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
      <ScrollView style={{backgroundColor: 'white', height: height}}>
        <View>
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
            Active Cases
          </Text>
        </View>
        <View
          bg="white"
          rounded="md"
          p={3}
          m={2}
          borderWidth={1}
          borderColor="#efefef">
          <HStack space={3} justifyContent="center">
            <View h="20" w="165" bg="transparent" rounded="md" px={5} py={2}>
              <View
                style={{
                  display: 'flex',
                  flexDirection: 'row',
                  alignItems: 'center',
                }}>
                <Text style={{fontFamily: 'Rubik-Light'}} color={'#444556'}>
                  Critical
                </Text>
              </View>
              {CasesDataLoading === true ? (
                <Spinner color="#e19969" />
              ) : (
                <Text
                  style={{fontFamily: 'Rubik-Regular'}}
                  color="#e19969"
                  fontSize={30}>
                  {CasesData.critical}
                </Text>
              )}
            </View>
            <View h="20" w="165" bg="transparent" rounded="md" px={5} py={2}>
              <View
                style={{
                  display: 'flex',
                  flexDirection: 'row',
                  alignItems: 'center',
                }}>
                <Text style={{fontFamily: 'Rubik-Light'}} color={'#444556'}>
                  Mild
                </Text>
              </View>
              {CasesDataLoading === true ? (
                <Spinner color="#76da7b" />
              ) : (
                <Text
                  style={{fontFamily: 'Rubik-Regular'}}
                  color="#76da7b"
                  fontSize={30}>
                  {CasesData.mild}
                </Text>
              )}
            </View>
          </HStack>
          <HStack space={3} justifyContent="center" mt={1}>
            <View h="20" w="165" bg="transparent" rounded="md" px={5} py={2}>
              <View
                style={{
                  display: 'flex',
                  flexDirection: 'row',
                  alignItems: 'center',
                }}>
                <Text style={{fontFamily: 'Rubik-Light'}} color={'#444556'}>
                  Severe
                </Text>
              </View>
              {CasesDataLoading === true ? (
                <Spinner color="#5db17c" />
              ) : (
                <Text
                  style={{fontFamily: 'Rubik-Regular'}}
                  color="#e8564b"
                  fontSize={30}>
                  0
                </Text>
              )}
            </View>
            <View h="20" w="165" bg="transparent" rounded="md" px={5} py={2}>
              <View
                style={{
                  display: 'flex',
                  flexDirection: 'row',
                  alignItems: 'center',
                }}>
                <Text style={{fontFamily: 'Rubik-Light'}} color={'#444556'}>
                  Total
                </Text>
              </View>
              {CasesDataLoading === true ? (
                <Spinner color="#544b8b" />
              ) : (
                <Text
                  style={{fontFamily: 'Rubik-Regular'}}
                  color="#544b8b"
                  fontSize={30}>
                  {CasesData.total}
                </Text>
              )}
            </View>
          </HStack>
        </View>
        <View>
          <View>
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
              Climatic Info This Week
            </Text>
            <Text
              style={{
                marginTop: 2,
                marginBottom: 2,
                paddingTop: 2,
                paddingHorizontal: 10,
                fontWeight: '500',
                fontSize: 12,
                color: 'blue',
                fontFamily: 'Rubik-Regular',
              }}>
              Last Updated at : {ClimaticData.last_updated}
            </Text>
          </View>
          <View>
            <HStack space={3} justifyContent="center">
              <Center
                h="120"
                w="105"
                bg="#ffffff"
                rounded="md"
                borderWidth={1}
                borderColor="#efefef">
                {ClimaticDataLoading === true ? (
                  <Spinner color="#e19969" />
                ) : (
                  <>
                    <Text
                      color="#e19969"
                      style={{fontFamily: 'Rubik-Regular'}}
                      fontSize={30}>
                      {ClimaticData?.precipitation}
                    </Text>
                    <Text
                      color="#e19969"
                      style={{fontFamily: 'Rubik-Italic'}}
                      fontSize={10}>
                      mm
                    </Text>
                  </>
                )}

                <Text
                  style={{fontFamily: 'Rubik-Light'}}
                  color={'#444556'}
                  fontSize={15}>
                  Rainfall
                </Text>
              </Center>
              <Center
                h="120"
                w="105"
                bg="#ffffff"
                rounded="md"
                borderWidth={1}
                borderColor="#efefef">
                {ClimaticDataLoading === true ? (
                  <Spinner color="#5db17c" />
                ) : (
                  <>
                    <Text
                      color="#5db17c"
                      style={{fontFamily: 'Rubik-Regular'}}
                      fontSize={30}>
                      {ClimaticData?.humidity}
                    </Text>
                    <Text
                      color="#cd5454"
                      style={{fontFamily: 'Rubik-Regular'}}
                      fontSize={10}></Text>
                  </>
                )}
                <Text
                  style={{fontFamily: 'Rubik-Light'}}
                  color={'#444556'}
                  fontSize={15}>
                  Humidity
                </Text>
              </Center>
              <Center
                h="120"
                w="105"
                bg="#ffffff"
                rounded="md"
                borderWidth={1}
                borderColor="#efefef">
                {ClimaticDataLoading === true ? (
                  <Spinner color="#cd5454" />
                ) : (
                  <>
                    <Text
                      color="#cd5454"
                      style={{fontFamily: 'Rubik-Regular'}}
                      fontSize={30}>
                      {ClimaticData?.temperature}
                    </Text>
                    <Text
                      color="#cd5454"
                      style={{fontFamily: 'Rubik-Italic'}}
                      fontSize={10}>
                      °C
                    </Text>
                  </>
                )}
                <Text
                  style={{fontFamily: 'Rubik-Light'}}
                  color={'#444556'}
                  fontSize={15}>
                  Temperature
                </Text>
              </Center>
            </HStack>
          </View>
        </View>
        <Text
          style={{
            marginTop: 10,
            paddingTop: 10,
            paddingHorizontal: 10,
            fontWeight: '500',
            fontSize: 20,
            color: '#454b58',
            fontFamily: 'Rubik-Light',
          }}>
          The Last 30 Days
        </Text>
        <ScrollView horizontal={true} rounded="md" p={0} m={2} mt={5}>
          <BarChart
            data={data}
            width={width * 3}
            height={220}
            yAxisLabel=""
            chartConfig={chartConfig}
            verticalLabelRotation={30}
          />
        </ScrollView>
      </ScrollView>
    </NativeBaseProvider>
  );
}

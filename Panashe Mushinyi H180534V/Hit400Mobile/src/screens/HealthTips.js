/* eslint-disable react-native/no-inline-styles */
import React from 'react';
import {StyleSheet, Image, TouchableOpacity, ScrollView} from 'react-native';
import {View, Text, HStack} from 'native-base';

import {symptoms, measures} from '../assets';

export default ({route, navigation}) => {
  return (
    <ScrollView>
      <Text
        style={{
          marginTop: 30,
          marginBottom: 30,
          paddingTop: 10,
          paddingHorizontal: 8,
          fontWeight: '500',
          fontSize: 25,
          color: '#d75369',
          fontFamily: 'Rubik-Black',
        }}>
        Health Tips
      </Text>
      <View>
        <TouchableOpacity
          style={styles.container}
          onPress={() => {
            navigation.navigate('Symptoms');
          }}>
          <Image style={styles.img} source={symptoms} />
          <View style={{marginLeft: 30}}>
            <Text
              style={(styles.text, {fontFamily: 'Rubik-Medium', fontSize: 15})}>
              Symptoms
            </Text>
            <Text
              style={{width: 200, color: '#a7aab3', fontFamily: 'Rubik-Light'}}>
              Malaria affects people in different ways.
            </Text>
          </View>
        </TouchableOpacity>
        <TouchableOpacity
          style={styles.container}
          onPress={() => {
            navigation.navigate('PreventativeMeasures');
          }}>
          <Image style={styles.img} source={measures} />
          <View style={{marginLeft: 30}}>
            <Text
              style={(styles.text, {fontFamily: 'Rubik-Medium', fontSize: 15})}>
              Preventative Measures
            </Text>
            <Text
              style={{width: 200, color: '#a7aab3', fontFamily: 'Rubik-Light'}}>
              Check how to prevent infection and stay safe.
            </Text>
          </View>
        </TouchableOpacity>
      </View>
      <View>
        <Text
          style={{
            marginTop: 30,
            marginBottom: 30,
            paddingTop: 10,
            paddingHorizontal: 8,
            fontWeight: '500',
            fontSize: 25,
            color: '#d75369',
            fontFamily: 'Rubik-Black',
          }}>
          Web References
        </Text>
      </View>
      <HStack space={3} justifyContent="center" mt={10}>
        <TouchableOpacity
          onPress={() => {
            navigation.navigate('References', {
              uri: 'https://my.clevelandclinic.org/health/diseases/15014-malaria',
            });
          }}>
          <View
            h="40"
            w="165"
            bg="white"
            rounded="md"
            shadow={1}
            p={3}
            style={{
              display: 'flex',
              flexDirection: 'row',
              alignItems: 'center',
            }}>
            <Text
              style={{
                fontFamily: 'Rubik-Regular',
                fontSize: 20,
                textAlign: 'center',
                width: '100%',
              }}
              color={'#a7aab3'}>
              CleveLand Clinic{' '}
            </Text>
          </View>
        </TouchableOpacity>
        <TouchableOpacity
          onPress={() => {
            navigation.navigate('References', {
              uri: 'https://www.medicalnewstoday.com/articles/150670#Symptoms',
            });
          }}>
          <View
            h="40"
            w="165"
            bg="white"
            rounded="md"
            shadow={1}
            p={3}
            style={{
              display: 'flex',
              flexDirection: 'row',
              alignItems: 'center',
            }}>
            <Text
              style={{
                fontFamily: 'Rubik-Regular',
                fontSize: 20,
                textAlign: 'center',
                width: '100%',
              }}
              color={'#a7aab3'}>
              Medical News Today
            </Text>
          </View>
        </TouchableOpacity>
      </HStack>
      <HStack space={3} justifyContent="center" mt={10} mb={10}>
        <TouchableOpacity
          onPress={() => {
            navigation.navigate('References', {
              uri: 'https://stanfordhealthcare.org/medical-conditions/primary-care/malaria/treatments/prevention.html',
            });
          }}>
          <View
            h="40"
            w="165"
            bg="white"
            rounded="md"
            shadow={1}
            p={3}
            style={{
              display: 'flex',
              flexDirection: 'row',
              alignItems: 'center',
            }}>
            <Text
              style={{
                fontFamily: 'Rubik-Regular',
                fontSize: 20,
                textAlign: 'center',
                width: '100%',
              }}
              color={'#a7aab3'}>
              stanford healthcare
            </Text>
          </View>
        </TouchableOpacity>
        <TouchableOpacity
          onPress={() => {
            navigation.navigate('References', {
              uri: 'https://www.who.int/news-room/fact-sheets/detail/malaria',
            });
          }}>
          <View
            h="40"
            w="165"
            bg="white"
            rounded="md"
            shadow={1}
            p={3}
            style={{
              display: 'flex',
              flexDirection: 'row',
              alignItems: 'center',
            }}>
            <Text
              style={{
                fontFamily: 'Rubik-Regular',
                fontSize: 20,
                textAlign: 'center',
                width: '100%',
              }}
              color={'#a7aab3'}>
              World Health Org
            </Text>
          </View>
        </TouchableOpacity>
      </HStack>
    </ScrollView>
  );
};

const styles = StyleSheet.create({
  container: {
    padding: 15,
    marginTop: 10,
    backgroundColor: 'white',
    marginHorizontal: 8,
    alignItems: 'flex-start',
    borderWidth: 1,
    borderColor: '#f5f5f9',
    borderRadius: 10,
    display: 'flex',
    flexDirection: 'row',
    alignContent: 'flex-start',
    justifyContent: 'flex-start',
  },
  text: {
    color: '#4f603c',
    fontSize: 15,
    fontWeight: '500',
  },
  img: {
    height: 70,
    width: 70,
  },
});

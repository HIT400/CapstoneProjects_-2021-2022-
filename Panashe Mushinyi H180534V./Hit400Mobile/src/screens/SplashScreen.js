/* eslint-disable react-native/no-inline-styles */
import React, {Component} from 'react';
import {
  View,
  Text,
  TouchableOpacity,
  ScrollView,
  StyleSheet,
} from 'react-native';
import {Dimensions} from 'react-native';

let height = Dimensions.get('window').height;
let width = Dimensions.get('window').width;
import {assessment, tips} from '../assets';
export default function SplashScreen({navigation}) {
  return (
    <ScrollView contentContainerStyle={{}}>
      <View
        style={{
          height: height,
          backgroundColor: 'white',
        }}>
        <View style={{flex: 1, justifyContent: 'space-between'}}>
          <View
            style={{
              display: 'flex',
              flexDirection: 'column',
              alignContent: 'center',
              alignItems: 'center',
            }}>
            <Text
              style={{
                fontSize: 35,
                marginTop: 200,
                textAlign: 'center',
                textTransform: 'capitalize',
                paddingHorizontal: 2,
                color: '#d75369',
                fontFamily: 'RubikMoonrocks',
              }}>
              Malaria Tracker
            </Text>
          </View>

          <View
            style={{
              display: 'flex',
              flexDirection: 'row',
              width: width,
              marginTop: 300,
              paddingHorizontal: 20,
            }}>
            <TouchableOpacity
              style={{
                //backgroundColor: '#4caf4f',
                padding: 3,
                width: 150,
                flexGrow: 1,
                borderRadius: 30,
                backgroundColor: '#d75369',
                marginBottom: 30,
                marginHorizontal: 10,
                height: 50,
                display: 'flex',
                flexDirection: 'row',
                alignItems: 'center',
                justifyContent: 'center',
              }}
              onPress={() => navigation.navigate('DashboardLogin')}>
              <Text
                style={{
                  color: '#FFF',
                  fontFamily: 'DMSans',
                  fontWeight: '900',
                  fontSize: 18,
                  paddingVertical: 5,
                }}>
                Continue
              </Text>
            </TouchableOpacity>
          </View>
          <View
            style={{
              display: 'flex',
              flexDirection: 'row',
              width: width,
            }}>
            <TouchableOpacity
              style={{
                //backgroundColor: '#4caf4f',
                padding: 6,
                borderRadius: 10,
                backgroundColor: 'transparent',
                marginBottom: 30,
                flexGrow: 1,
                height: 50,
                display: 'flex',
                flexDirection: 'row',
                alignItems: 'center',
                justifyContent: 'center',
              }}
              onPress={() => navigation.navigate('Typeform')}>
              <Text
                style={{
                  color: '#d75369',
                  fontFamily: 'DMSans',
                  fontWeight: '900',
                  fontSize: 18,
                  paddingVertical: 5,
                }}>
                Self Assessment
              </Text>
            </TouchableOpacity>
            <TouchableOpacity
              style={{
                //backgroundColor: '#4caf4f',
                padding: 6,
                borderRadius: 10,
                backgroundColor: 'transparent',
                marginBottom: 30,
                flexGrow: 1,
                height: 50,
                display: 'flex',
                flexDirection: 'row',
                alignItems: 'center',
                justifyContent: 'center',
              }}
              onPress={() => navigation.navigate('ChatLogin')}>
              <Text
                style={{
                  color: '#d75369',
                  fontFamily: 'DMSans',
                  fontWeight: '900',
                  fontSize: 18,
                  paddingVertical: 5,
                }}>
                Chat
              </Text>
            </TouchableOpacity>
            <TouchableOpacity
              style={{
                //backgroundColor: '#4caf4f',
                padding: 6,
                borderRadius: 10,
                backgroundColor: 'transparent',
                marginBottom: 30,
                flexGrow: 1,
                height: 50,
                display: 'flex',
                flexDirection: 'row',
                alignItems: 'center',
                justifyContent: 'center',
              }}
              onPress={() => navigation.navigate('HealthTips')}>
              <Text
                style={{
                  color: '#d75369',
                  fontFamily: 'DMSans',
                  fontWeight: '900',
                  fontSize: 18,
                  paddingVertical: 5,
                }}>
                Health Tips
              </Text>
            </TouchableOpacity>
          </View>
        </View>
      </View>
    </ScrollView>
  );
}
const styles = StyleSheet.create({
  img: {
    height: 50,
    width: 50,
  },
});

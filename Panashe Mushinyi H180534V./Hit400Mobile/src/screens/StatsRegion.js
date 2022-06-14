/* eslint-disable react-native/no-inline-styles */
import React, {useRef, useState} from 'react';
import {SafeAreaView, View, Dimensions} from 'react-native';
import {Center, Stack, Input, Text, Button, Checkbox} from 'native-base';
import {List} from '../constants';
let height = Dimensions.get('window').height;
let width = Dimensions.get('window').width;

export default ({route, navigation}) => {
  return (
    <View>
      <Text
        style={{
          marginTop: 30,
          marginBottom: 30,
          paddingTop: 10,
          paddingHorizontal: 8,
          fontWeight: '500',
          fontSize: 20,
          color: '#454b58',
        }}>
        Choose Region
      </Text>
      <List navigation={navigation} />
    </View>
  );
};

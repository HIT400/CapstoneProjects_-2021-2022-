import React, {Component, useEffect, useState} from 'react';
import {TouchableOpacity, Dimensions, StyleSheet} from 'react-native';
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
  HStack,
  ScrollView,
  Box,
  Divider,
  NativeBaseProvider,
} from 'native-base';
const logo = require('../assets/logo.png');

const {width} = Dimensions.get('window');

export default function Header() {
  return (
    <View
      bg={'gray.50'}
      borderBottomWidth={1}
      borderColor={'gray.300'}
      style={{
        display: 'flex',
        flexDirection: 'row',
        alignContent: 'center',
        height: 60,
        alignItems: 'center',
        justifyContent: 'space-between',
      }}>
      <Text
        style={{
          fontSize: 25,
          paddingHorizontal: 10,
          paddingTop: 10,
          textAlign: 'center',
          color: '#d75369',
          fontFamily: 'RubikMoonrocks',
        }}>
        Malaria Tracker
      </Text>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    backgroundColor: '#4caf4f',
    paddingVertical: 10,
  },
  imageStyles: {
    height: 130,
    width: 100,
  },
  imageContainer: {
    flexDirection: 'row',
    justifyContent: 'center',
  },
});

/**
 * Sample React Native App
 * https://github.com/facebook/react-native
 *
 * @format
 * @flow strict-local
 */

import React, {useEffect} from 'react';
import {ApplicationStack} from './src/navigation';
import {Text} from 'react-native';
import {NativeBaseProvider, Box, extendTheme} from 'native-base';
import SplashScreen from 'react-native-splash-screen';
import GlobalFont from 'react-native-global-font';
import AsyncStorage from '@react-native-async-storage/async-storage';
import {CometChat} from '@cometchat-pro/react-native-chat';

export default function App() {
  useEffect(() => {
    SplashScreen.hide();
  }, []);

  return (
    <NativeBaseProvider>
      <ApplicationStack />
    </NativeBaseProvider>
  );
}

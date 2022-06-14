/**
 * @format
 */

import 'react-native-gesture-handler';
import {AppRegistry} from 'react-native';
import App from './App';
import {name as appName} from './app.json';
import {CometChat} from '@cometchat-pro/react-native-chat';

const appID = '210925413cd0b693';
const appKey = '5d590a5266da3aaed03fcca3afc7ec430191210c';
const region = 'us';
const appSetting = new CometChat.AppSettingsBuilder()
  .subscribePresenceForAllUsers()
  .setRegion(region)
  .build();
CometChat.init(appID, appSetting).then(
  () => {
    console.log('Initialization completed successfully');
    // You can now call login function.
  },
  error => {
    console.log('Initialization failed with error:', error);
    // Check the reason for error and take appropriate action.
  },
);

AppRegistry.registerComponent(appName, () => App);

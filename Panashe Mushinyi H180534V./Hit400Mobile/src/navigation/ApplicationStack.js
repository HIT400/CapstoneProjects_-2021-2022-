import React from 'react';
import {NavigationContainer} from '@react-navigation/native';
import {createStackNavigator} from '@react-navigation/stack';
import Tabs from './TabsNavigation';
import {
  SplashScreen,
  Symptoms,
  Typeform,
  HealthTips,
  CometChatUIView,
  ChatLogin,
  PreventativeMeasures,
  References,
  DashboardLogin,
} from '../screens';
import {CometChatMessages} from '../Chat/cometchat-pro-react-native-ui-kit';

const Stack = createStackNavigator();

export default () => {
  return (
    <NavigationContainer>
      {/*       <Tabs name="Main" component={Main} /> */}
      <Stack.Navigator initialRouteName="SplashScreen">
        <Stack.Screen
          name="Typeform"
          component={Typeform}
          options={{headerShown: false}}
        />
        <Stack.Screen
          name="HealthTips"
          component={HealthTips}
          options={{headerShown: false}}
        />
        <Stack.Screen
          name="CometChatUIView"
          component={CometChatUIView}
          options={{headerShown: false}}
        />
        <Stack.Screen
          name="ChatLogin"
          component={ChatLogin}
          options={{headerShown: false}}
        />
        <Stack.Screen
          name="DashboardLogin"
          component={DashboardLogin}
          options={{headerShown: false}}
        />
        <Stack.Screen
          name="Symptoms"
          component={Symptoms}
          options={{headerShown: false}}
        />
        <Stack.Screen
          name="References"
          component={References}
          options={{headerShown: false}}
        />
        <Stack.Screen
          name="PreventativeMeasures"
          component={PreventativeMeasures}
          options={{headerShown: false}}
        />
        <Stack.Screen
          name="SplashScreen"
          component={SplashScreen}
          options={{headerShown: false}}
        />
        <Stack.Screen
          name="Main"
          component={Tabs}
          options={{headerShown: false}}
        />
        <Stack.Screen
          name="CometChatMessages"
          component={CometChatMessages}
          options={{headerShown: false}}
        />
      </Stack.Navigator>
    </NavigationContainer>
  );
};

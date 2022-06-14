import React from 'react';
import {NavigationContainer} from '@react-navigation/native';
import {createStackNavigator} from '@react-navigation/stack';
import {StatsScreen, StatsRegion} from '../screens';

const Stack = createStackNavigator();

export default () => {
  return (
    <Stack.Navigator initialRouteName="StatsRegion">
      <Stack.Screen
        name="StatsScreen"
        component={StatsScreen}
        options={{headerShown: false}}
      />
      <Stack.Screen
        name="StatsRegion"
        component={StatsRegion}
        options={{headerShown: false}}
      />
    </Stack.Navigator>
  );
};

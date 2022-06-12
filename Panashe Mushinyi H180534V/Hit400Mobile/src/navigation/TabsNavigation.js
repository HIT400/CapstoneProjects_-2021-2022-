import React from 'react';
import {createBottomTabNavigator} from '@react-navigation/bottom-tabs';
import {Main, Stream, StatsScreen, Alert} from '../screens';
import Stats from './statsStack';
import Icon from 'react-native-vector-icons/AntDesign';
const screenOptions = (route, color) => {
  let iconName;

  switch (route.name) {
    case 'Home':
      iconName = 'home';
      break;
    case 'Statistics':
      iconName = 'piechart';
      break;
    case 'Cases':
      iconName = 'user';
      break;
    case 'Alerts':
      iconName = 'warning';
      break;
    default:
      break;
  }

  return <Icon name={iconName} color={color} size={24} />;
};

const Tab = createBottomTabNavigator();

const Tabs = () => {
  return (
    <Tab.Navigator
      screenOptions={({route}) => ({
        tabBarIcon: ({color}) => screenOptions(route, color),
        tabBarActiveTintColor: '#d75369',
        tabBarInactiveTintColor: '#595957',
        tabBarStyle: {
          borderTopColor: '#66666666',
          backgroundColor: '#f0f1f0',
          elevation: 0,
          padding: 2,
          height: 60,
        },
        tabBarLabelStyle: {
          fontSize: 15,
          fontWeight: '600',
          fontFamily: 'DMSans',
        },
      })}>
      <Tab.Screen options={{headerShown: false}} name="Home" component={Main} />
      <Tab.Screen
        options={{headerShown: false}}
        name="Statistics"
        component={StatsScreen}
      />
      <Tab.Screen
        options={{headerShown: false}}
        name="Cases"
        component={Stream}
      />
      <Tab.Screen
        options={{headerShown: false}}
        name="Alerts"
        component={Alert}
      />
    </Tab.Navigator>
  );
};
export default Tabs;

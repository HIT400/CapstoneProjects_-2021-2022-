import React, {Component} from 'react';
import {Text, View, TouchableOpacity, StyleSheet} from 'react-native';
import Icon from 'react-native-vector-icons/FontAwesome';

export default function List(props) {
  state = {
    names: [
      {
        id: 0,
        name: 'Chimanimani',
      },
      {
        id: 1,
        name: 'Mutare',
      },
      {
        id: 2,
        name: 'Harare',
      },
      {
        id: 3,
        name: 'Bulawayo',
      },
      {
        id: 4,
        name: 'Chipinge',
      },
      {
        id: 5,
        name: 'Masvingo',
      },
    ],
  };
  alertItemName = item => {
    alert(item.name);
  };

  return (
    <View>
      {state.names.map((item, index) => (
        <TouchableOpacity
          key={item.id}
          style={styles.container}
          onPress={() => props.navigation.navigate('StatsScreen')}>
          <Text style={styles.text}>{item.name}</Text>
          <Icon name="angle-right" size={20} color="black"></Icon>
        </TouchableOpacity>
      ))}
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    padding: 15,
    marginTop: 10,
    backgroundColor: 'white',
    marginHorizontal: 8,
    alignItems: 'center',
    borderWidth: 1,
    borderColor: '#f5f5f9',
    borderRadius: 10,
    display: 'flex',
    flexDirection: 'row',
    alignContent: 'center',
    justifyContent: 'space-between',
  },
  text: {
    color: '#4f603c',
  },
});

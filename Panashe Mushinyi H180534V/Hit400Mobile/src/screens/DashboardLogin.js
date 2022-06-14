/* eslint-disable react-native/no-inline-styles */
import React, {useState} from 'react';
import {Spinner, Center, Input} from 'native-base';
import Icon from 'react-native-vector-icons/AntDesign';
import {
  Dimensions,
  View,
  Text,
  TouchableOpacity,
  TextInput,
  ScrollView,
} from 'react-native';
import {styles} from '../styles';
import {login} from '../services';

let height = Dimensions.get('window').height;
let width = Dimensions.get('window').width;
export default function SplashScreen({navigation}) {
  const [username, setUsername] = useState(null);
  const [password, setPassword] = useState(null);
  const [show, setShow] = React.useState(false);
  const [loading, setLoading] = useState(false);

  function loginFunc() {
    setLoading(true);
    const data = {
      username,
      password,
    };
    login(data)
      .then(res => {
        console.log(res);
        setLoading(false);
        navigation.navigate('Main');
      })
      .catch(error => {
        setLoading(false);
        console.log(error);
      });
  }

  return (
    <ScrollView contentContainerStyle={{}}>
      {loading === true ? (
        <Center h={height}>
          <Spinner color="#d75369" size={30} />
        </Center>
      ) : (
        <View
          style={{
            height: height,
            backgroundColor: 'white',
          }}>
          <View style={{justifyContent: 'space-between'}}>
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
                  marginTop: 50,
                  textAlign: 'center',
                  textTransform: 'capitalize',
                  paddingHorizontal: 2,
                  color: '#d75369',
                  fontFamily: 'RubikMoonrocks',
                }}>
                Dashboard Login
              </Text>
            </View>
            <View
              style={{
                display: 'flex',
                flexDirection: 'column',
                width: width,
                marginTop: 300,
                paddingHorizontal: 20,
              }}>
              <Input
                placeholderTextColor="#d75369"
                w={{
                  base: '100%',
                  md: '100%',
                }}
                mb={4}
                style={styles.textInput}
                variant="rounded"
                placeholder="Username"
                onChangeText={text => setUsername(text)}
              />
              <Input
                placeholderTextColor="#d75369"
                w={{
                  base: '100%',
                  md: '100%',
                }}
                mb={4}
                variant="rounded"
                type={show ? 'text' : 'password'}
                InputRightElement={
                  <Icon
                    name={show ? 'eye' : 'eyeo'}
                    size={20}
                    color="grey"
                    onPress={() => setShow(!show)}
                  />
                }
                placeholder="Password"
                onChangeText={text => setPassword(text)}
              />

              <TouchableOpacity
                style={{
                  padding: 3,
                  flexGrow: 1,
                  borderRadius: 30,
                  backgroundColor: '#d75369',
                  height: 50,
                  display: 'flex',
                  flexDirection: 'row',
                  alignItems: 'center',
                  justifyContent: 'center',
                }}
                onPress={() => {
                  if (password == null || username == null) {
                    return;
                  }
                  loginFunc();
                }}>
                <Text
                  style={{
                    color: '#FFF',
                    fontFamily: 'Rubik-Medium',
                    fontSize: 18,
                    paddingVertical: 5,
                  }}>
                  Login
                </Text>
              </TouchableOpacity>
            </View>
          </View>
        </View>
      )}
    </ScrollView>
  );
}

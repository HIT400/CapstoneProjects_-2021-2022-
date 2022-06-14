/* eslint-disable react-native/no-inline-styles */
import React, {useEffect, useState} from 'react';
import {HStack, Spinner, Heading, Input} from 'native-base';
import {
  Dimensions,
  View,
  Text,
  TouchableOpacity,
  TextInput,
  ScrollView,
} from 'react-native';
import {styles} from '../styles';
import {CometChat} from '@cometchat-pro/react-native-chat';

let height = Dimensions.get('window').height;
let width = Dimensions.get('window').width;
export default function SplashScreen({navigation}) {
  const [id, setID] = useState('');
  const [lastname, setLastName] = useState('');
  const [firstname, setFirstName] = useState('');
  const [loading, setLoading] = useState(false);
  const [key, setKey] = useState('5d590a5266da3aaed03fcca3afc7ec430191210c');

  function sendHi() {
    let receiverID = 'chi-health';
    let messageText = 'Hi, i need your help.';
    let receiverType = CometChat.RECEIVER_TYPE.USER;
    let textMessage = new CometChat.TextMessage(
      receiverID,
      messageText,
      receiverType,
    );

    CometChat.sendMessage(textMessage).then(
      message => {
        console.log('Message sent successfully:', message);
      },
      error => {
        console.log('Message sending failed with error:', error);
      },
    );
  }

  useEffect(() => {
    CometChat.getLoggedinUser().then(user => {
      if (!user) {
        setLoading(false);
        return;
      } else {
        setLoading(false);
        navigation.navigate('CometChatUIView');
      }
    });
  });

  function createUser() {
    var name = lastname + firstname;
    var user = new CometChat.User(id);
    user.setName(name);
    CometChat.createUser(user, key).then(
      async users => {
        console.log('user created', users);
        await loginToChat();
      },
      error => {
        console.log('error', error);
      },
    );
  }

  function loginToChat() {
    CometChat.getLoggedinUser().then(
      async user => {
        if (!user) {
          CometChat.login(id, key).then(
            async users => {
              console.log('Login Successful:', {users});
              await sendHi();

              navigation.navigate('CometChatUIView');
            },
            async error => {
              console.log('Login failed with exception:', {error});
              console.log(error.code);
              if (error.code === 'ERR_UID_NOT_FOUND') {
                await createUser();
              }
            },
          );
        } else {
          await sendHi();

          navigation.navigate('CometChatUIView');
        }
      },
      error => {
        console.log('Something went wrong', error);
      },
    );
  }

  return (
    <ScrollView contentContainerStyle={{}}>
      {loading === true ? (
        <HStack space={2} justifyContent="center">
          <Spinner accessibilityLabel="Loading posts" />
          <Heading color="primary.500" fontSize="md">
            Checking User
          </Heading>
        </HStack>
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
                Login To Chat
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
                placeholder="Firstname"
                onChangeText={text => setFirstName(text)}
              />
              <Input
                placeholderTextColor="#d75369"
                w={{
                  base: '100%',
                  md: '100%',
                }}
                mb={4}
                style={styles.textInput}
                variant="rounded"
                placeholder="Lastname"
                onChangeText={text => setLastName(text)}
              />
              <Input
                placeholderTextColor="#d75369"
                w={{
                  base: '100%',
                  md: '100%',
                }}
                mb={4}
                style={styles.textInput}
                variant="rounded"
                placeholder="National ID"
                onChangeText={text => setID(text)}
              />
              <TouchableOpacity
                style={{
                  //backgroundColor: '#4caf4f',
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
                onPress={() => loginToChat()}>
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
          </View>
        </View>
      )}
    </ScrollView>
  );
}

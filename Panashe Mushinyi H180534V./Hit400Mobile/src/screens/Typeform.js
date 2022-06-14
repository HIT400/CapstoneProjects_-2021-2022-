/* eslint-disable react-native/no-inline-styles */
import React, {useRef, useState} from 'react';
import {SafeAreaView, View, Dimensions, StyleSheet} from 'react-native';
import {Center, Stack, Input, Text, Checkbox, Modal, Button} from 'native-base';
import Wizard from 'react-native-wizard';
import Icon from 'react-native-vector-icons/FontAwesome';
import DatePicker from 'react-native-date-picker';
import {NativeFormsModal} from 'native-forms';
import {SimpleSurvey} from 'react-native-simple-survey';
let height = Dimensions.get('window').height;
let width = Dimensions.get('window').width;

export default () => {
  const [showModal, setShowModal] = useState(false);
  const [Textt, setText] = useState('');
  const [hasForm, showForm] = useState(false);
  return (
    <View style={styles.container}>
      <Button
        onPress={() => showForm(true)}
        rounded={10}
        px={10}
        py={10}
        bgColor={'#d75369'}>
        <Text fontSize={20} color={'white'} fontWeight={700}>
          Start Self Assessment
        </Text>
      </Button>
      <NativeFormsModal
        visible={hasForm}
        form="https://form.nativeforms.com/ZBHdy1jZm8kZtFFZZ1Db"
        onClose={() => showForm(false)}
        onSend={Data => {
          const data = Data.formData['Select Symptoms'].split(',');
          const sickdays =
            Data.formData['How long have you been feeling this way?'];
          if (data.length >= 3 && Number(sickdays) >= 3) {
            setText('We advice you to see a doctor concerning your symptoms.');
          } else {
            setText(
              'From the assessment you seem to be safe From Malaria.If this persists, see a doctor',
            );
          }
          setShowModal(true);
        }}
      />
      <Center>
        <Modal isOpen={showModal} onClose={() => setShowModal(false)}>
          <Modal.Content maxWidth="400px">
            <Modal.CloseButton />
            <Modal.Header>
              <Text
                style={{
                  fontSize: 20,
                  textAlign: 'center',
                  textTransform: 'capitalize',
                  paddingHorizontal: 2,

                  fontFamily: 'DMSans',
                }}>
                Result
              </Text>
            </Modal.Header>
            <Modal.Body h={200}>
              <Text
                style={{
                  fontSize: 15,
                  textAlign: 'center',
                  textTransform: 'capitalize',
                  paddingHorizontal: 2,
                  fontFamily: 'DMSans',
                }}>
                {Textt}
              </Text>
            </Modal.Body>
          </Modal.Content>
        </Modal>
      </Center>
    </View>
  );
};
const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
});

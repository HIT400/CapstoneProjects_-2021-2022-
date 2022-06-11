/* eslint-disable react-native/no-inline-styles */
import React, {useState} from 'react';
import {
  Thumbnail,
  List,
  ListItem,
  Separator,
  Center,
  Button,
  Modal,
  HStack,
  View,
  Text,
} from 'native-base';
import {
  TouchableOpacity,
  Image,
  ScrollView,
  ImageBackground,
  StyleSheet,
} from 'react-native';

export default function Symptoms() {
  const [showModal, setShowModal] = useState(false);
  const [modelData, setModelData] = useState('');

  return (
    <ScrollView>
      <HStack space={3} justifyContent="center" mt={10}>
        <TouchableOpacity
          onPress={() => {
            setShowModal(true);
            setModelData({
              title: 'Headaches',
              data: 'Headaches are a very common condition that most people will experience many times during their lives. The main symptom of a headache is a pain in your head or face. This can be throbbing, constant, sharp or dull. Headaches can be treated with medication, stress management and biofeedback.',
            });
          }}>
          <View
            h="40"
            w="150"
            bg="white"
            rounded="md"
            shadow={1}
            p={3}
            style={{
              display: 'flex',
              flexDirection: 'row',
              justifyContent: 'center',
              alignItems: 'center',
            }}>
            <Text
              style={{
                fontWeight: '500',
                fontSize: 20,
                color: '#a7aab3',
                fontFamily: 'Rubik-Bold',
              }}
              color={'#c3c7ce'}>
              Headaches
            </Text>
          </View>
        </TouchableOpacity>
        <TouchableOpacity
          onPress={() => {
            setShowModal(true);
            setModelData({
              title: 'Fever',
              data: "What is a fever? A fever is a higher-than-normal body temperature.It’s a sign of your body's natural fight against infection. For adults, a fever is when your temperature is higher than 100.4°F. For kids, a fever is when their temperature is higher than 100.4°F (measured rectally); 99.5°F (measured orally); or 99°F (measured under the arm). The average normal body temperature is 98.6° Fahrenheit (or 37° Celsius). When you or your child’s temperature rises a few degrees above normal, it’s a sign that the body is healthy and fighting infection. In most cases, that’s a good thing. But when a fever rises above 102°F it should be treated at home and, if necessary, by your healthcare provider if the fever doesn’t go down after a few days.",
            });
          }}>
          <View
            h="40"
            w="150"
            bg="white"
            rounded="md"
            shadow={1}
            p={3}
            style={{
              display: 'flex',
              flexDirection: 'row',
              justifyContent: 'center',
              alignItems: 'center',
            }}>
            <Text
              style={{
                fontWeight: '500',
                fontSize: 20,
                color: '#a7aab3',
                fontFamily: 'Rubik-Bold',
              }}
              color={'#c3c7ce'}>
              Fever
            </Text>
          </View>
        </TouchableOpacity>
      </HStack>
      <HStack space={3} justifyContent="center" mt={4}>
        <TouchableOpacity
          onPress={() => {
            setShowModal(true);
            setModelData({
              title: 'Fatigue',
              data: 'Fatigue is more than being tired or sleepy. People who have fatigue feel so drained that their exhaustion interrupts their daily life. Many conditions and medications can cause overwhelming tiredness. An unhealthy diet, lack of sleep and too little or too much physical activity can also lead to fatigue.',
            });
          }}>
          <View
            h="40"
            w="150"
            bg="white"
            rounded="md"
            shadow={1}
            p={3}
            style={{
              display: 'flex',
              flexDirection: 'row',
              justifyContent: 'center',
              alignItems: 'center',
            }}>
            <Text
              style={{
                fontWeight: '500',
                fontSize: 20,
                color: '#a7aab3',
                fontFamily: 'Rubik-Bold',
              }}
              color={'#c3c7ce'}>
              Fatigue
            </Text>
          </View>
        </TouchableOpacity>
        <TouchableOpacity
          onPress={() => {
            setShowModal(true);
            setModelData({
              title: 'Chest Pain',
              data: 'Always take chest pain seriously. It’s a symptom of a heart attack, but could also indicate digestive problems, lung problems, stress and anxiety. Prevent chest pain by eating healthy, managing health conditions and exercising.',
            });
          }}>
          <View
            h="40"
            w="150"
            bg="white"
            rounded="md"
            shadow={1}
            p={3}
            style={{
              display: 'flex',
              flexDirection: 'row',
              justifyContent: 'center',
              alignItems: 'center',
            }}>
            <Text
              style={{
                fontWeight: '500',
                fontSize: 20,
                color: '#a7aab3',
                fontFamily: 'Rubik-Bold',
              }}
              color={'#c3c7ce'}>
              Chest Pain
            </Text>
          </View>
        </TouchableOpacity>
      </HStack>
      <HStack space={3} justifyContent="center" mt={4}>
        <TouchableOpacity
          onPress={() => {
            setShowModal(true);
            setModelData({
              title: 'Cough',
              data: 'A cough is a reflex reaction designed to keep your airways clear. You may be coughing because of another condition, like asthma or a respiratory infection, or because you have swallowing difficulties. Your healthcare provider can help you figure out what’s going on.',
            });
          }}>
          <View
            h="40"
            w="150"
            bg="white"
            rounded="md"
            shadow={1}
            p={3}
            style={{
              display: 'flex',
              flexDirection: 'row',
              justifyContent: 'center',
              alignItems: 'center',
            }}>
            <Text
              style={{
                fontWeight: '500',
                fontSize: 20,
                color: '#a7aab3',
                fontFamily: 'Rubik-Bold',
              }}
              color={'#c3c7ce'}>
              Cough
            </Text>
          </View>
        </TouchableOpacity>
        <TouchableOpacity
          onPress={() => {
            setShowModal(true);
            setModelData({
              title: 'Diarrhea',
              data: 'Diarrhea is very common, happening in most people a few times each year. When you have diarrhea, your stool will be loose and watery. In most cases, the cause is unknown and it goes away on its own after a few days. Diarrhea can be caused by bacteria. Dehydration is a dangerous side effect of diarrhea.',
            });
          }}>
          <View
            h="40"
            w="150"
            bg="white"
            rounded="md"
            shadow={1}
            p={3}
            style={{
              display: 'flex',
              flexDirection: 'row',
              justifyContent: 'center',
              alignItems: 'center',
            }}>
            <Text
              style={{
                fontWeight: '500',
                fontSize: 20,
                color: '#a7aab3',
                fontFamily: 'Rubik-Bold',
              }}
              color={'#c3c7ce'}>
              Diarrhea
            </Text>
          </View>
        </TouchableOpacity>
      </HStack>
      <HStack space={3} mb={10} justifyContent="center" mt={4}>
        <TouchableOpacity
          onPress={() => {
            setShowModal(true);
            setModelData({
              title: 'Nausea & Vomiting',
              data: 'Nausea and vomiting are symptoms of many different conditions, including early pregnancy, concussions and the stomach flu. Happening in both adults and children, there are many ways to relieve nausea. Drinking ice-cold beverages and eating light, bland foods can help.',
            });
          }}>
          <View
            h="40"
            w="150"
            bg="white"
            rounded="md"
            shadow={1}
            p={3}
            style={{
              display: 'flex',
              flexDirection: 'row',
              justifyContent: 'center',
              alignItems: 'center',
            }}>
            <Text
              style={{
                fontWeight: '500',
                fontSize: 20,
                color: '#a7aab3',
                fontFamily: 'Rubik-Bold',
              }}
              color={'#c3c7ce'}>
              Nausea & Vomiting
            </Text>
          </View>
        </TouchableOpacity>
        <TouchableOpacity
          onPress={() => {
            setShowModal(true);
            setModelData({
              title: 'Anemia',
              data: 'Anemia occurs when there are not enough healthy red blood cells to carry oxygen to your body’s organs. As a result, it’s common to feel cold and symptoms of tiredness or weakness. There are many different types of anemia, but the most common type is iron-deficiency anemia. You can begin to ease symptoms of this type of anemia by adding iron to your diet.',
            });
          }}>
          <View
            h="40"
            w="150"
            bg="white"
            rounded="md"
            shadow={1}
            p={3}
            style={{
              display: 'flex',
              flexDirection: 'row',
              justifyContent: 'center',
              alignItems: 'center',
            }}>
            <Text
              style={{
                fontWeight: '500',
                fontSize: 20,
                color: '#a7aab3',
                fontFamily: 'Rubik-Bold',
              }}
              color={'#c3c7ce'}>
              Anemia
            </Text>
          </View>
        </TouchableOpacity>
      </HStack>
      <HStack space={3} mb={10} justifyContent="center" mt={4}>
        <TouchableOpacity
          onPress={() => {
            setShowModal(true);
            setModelData({
              title: 'jaundice',
              data: 'Jaundice is a condition in which the skin, sclera (whites of the eyes) and mucous membranes turn yellow. This yellow color is caused by a high level of bilirubin, a yellow-orange bile pigment. Bile is fluid secreted by the liver. Bilirubin is formed from the breakdown of red blood cells.',
            });
          }}>
          <View
            h="40"
            w="150"
            bg="white"
            rounded="md"
            shadow={1}
            p={3}
            style={{
              display: 'flex',
              flexDirection: 'row',
              justifyContent: 'center',
              alignItems: 'center',
            }}>
            <Text
              style={{
                fontWeight: '500',
                fontSize: 20,
                color: '#a7aab3',
                fontFamily: 'Rubik-Bold',
              }}
              color={'#c3c7ce'}>
              jaundice
            </Text>
          </View>
        </TouchableOpacity>
      </HStack>
      <Center>
        <Modal
          isOpen={showModal}
          size={'xl'}
          onClose={() => setShowModal(false)}
          _backdrop={'black'}>
          <Modal.Content H="900">
            <Modal.CloseButton />
            <Modal.Header>
              <Text
                style={{
                  fontWeight: '500',
                  fontSize: 20,
                  color: '#a7aab3',
                  fontFamily: 'Rubik-Bold',
                }}>
                {modelData.title}
              </Text>
            </Modal.Header>
            <Modal.Body>
              <Text
                style={{
                  fontWeight: '500',
                  fontSize: 15,
                  color: '#454b58',
                  fontFamily: 'Rubik-Regular',
                }}>
                {modelData.data}
              </Text>
            </Modal.Body>
          </Modal.Content>
        </Modal>
      </Center>
    </ScrollView>
  );
}

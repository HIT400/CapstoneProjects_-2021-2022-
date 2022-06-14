/* eslint-disable react-native/no-inline-styles */
import React, {useState, useEffect} from 'react';
import {
  SafeAreaView,
  Dimensions,
  ScrollView,
  Image,
  Platform,
  StyleSheet,
} from 'react-native';
import {
  Center,
  Stack,
  View,
  Input,
  Text,
  Button,
  Checkbox,
  VStack,
  HStack,
  Modal,
} from 'native-base';

import MapboxGL from '@react-native-mapbox-gl/maps';
import {getFacilityData} from '../services';
import {featureCollection, point, feature, lineString} from '@turf/helpers';

const shape = featureCollection([
  point([32.624139, -20.195672], {
    data: 10,
    hospital: 'Chipinge District Hospital',
  }),
  point([32.616671, -20.18453], {
    data: 20,
    hospital: 'Chipinge Clinic',
  }),
  point([32.775822, -20.370828], {
    data: 30,
    hospital: 'Mt Selinda Mission Hospital',
  }),
]);

const groupBy = key => array =>
  array.reduce((objectsByKeyValue, obj) => {
    const newKey = key.split('.');
    const value = obj[newKey[0]][newKey[1]];
    const newObj = {
      count: obj.count,
      deduced: obj._id.deduced,
    };

    objectsByKeyValue[value] = (objectsByKeyValue[value] || []).concat(newObj);
    return objectsByKeyValue;
  }, {});

export default ({route, navigation}) => {
  const [showModal, setShowModal] = useState(false);
  const [modalData, setModalData] = useState([]);
  const [modalTitle, setModalTitle] = useState();
  const [FacilityData, setFacilityData] = useState();
  const [FacilityDataLoading, setFacilityDataLoading] = useState();

  useEffect(() => {
    getFacilityData()
      .then(data => {
        const groupByBrand = groupBy('_id.Facility');
        setFacilityData(
          JSON.stringify(
            {
              Data: groupByBrand(data),
            },
            null,
            2,
          ),
        );
        console.log(FacilityData);
        setFacilityDataLoading(false);
      })
      .catch(error => {
        console.log(error);
        setFacilityDataLoading(false);
      });
  }, []);

  function onSourceLayerPress(e) {
    const feature1 = e.features;
    const data = feature1[0].properties;
    console.log(
      'You pressed a layer here is your feature',
      feature1[0].properties,
    );
    if (data.hospital === undefined) {
      return;
    }

    setModalTitle(data.hospital);

    let itemList = [];
    console.log(JSON.parse(FacilityData).Data[data.hospital]);

    JSON.parse(FacilityData).Data[data.hospital].forEach((item, index) => {
      itemList.push(
        <HStack key={index} alignItems="center" justifyContent="space-between">
          <Text
            style={{
              marginTop: 10,
              paddingTop: 10,
              paddingHorizontal: 10,
              fontWeight: '500',
              fontSize: 15,
              color: '#454b58',
              fontFamily: 'Rubik-Regular',
            }}>
            {item.deduced}
          </Text>
          <Text color="blueGray.400">{item.count}</Text>
        </HStack>,
      );
    });
    setModalData(itemList);
    console.log(modalData);
    setShowModal(true);
  }
  MapboxGL.setAccessToken(
    'pk.eyJ1IjoiZW1hY2xpYW0iLCJhIjoiY2wxNHRpcGNiMGR1dzNla2FndWVpdmJxbyJ9.wnxGUxO6rO3CoGaKyuXbVA',
  );
  const [coordinates] = useState([-79.999732, 40.4374]);
  return (
    <ScrollView>
      <Text
        style={{
          marginTop: 20,
          marginBottom: 20,
          paddingTop: 10,
          paddingHorizontal: 8,
          fontWeight: '500',
          fontSize: 20,
          color: '#454b58',
          fontFamily: 'Rubik-Regular',
        }}>
        Statistics by hospital
      </Text>
      <View style={{height: 400}}>
        <View style={styles.page}>
          <View style={styles.container}>
            <Modal
              isOpen={showModal}
              onClose={() => setShowModal(false)}
              size="lg">
              <Modal.Content maxWidth="350">
                <Modal.CloseButton />
                <Modal.Header>{modalTitle}</Modal.Header>
                <Modal.Body>
                  <VStack space={3}>{modalData}</VStack>
                </Modal.Body>
              </Modal.Content>
            </Modal>
            <MapboxGL.MapView
              style={{flex: 1}}
              styleURL={
                'https://tiles.riserapp.com/styles/klokantech-basic/style.json'
              }>
              <MapboxGL.Camera
                centerCoordinate={[31.053028, -17.824858]}
                zoomLevel={5}
              />
              <MapboxGL.ShapeSource
                shape={shape}
                onPress={onSourceLayerPress}
                cluster
                clusterRadius={50}
                clusterMaxZoom={14}>
                <MapboxGL.CircleLayer
                  id="circles"
                  style={{
                    circleColor: 'red',
                    circleRadius: 20,
                  }}
                />
                {true && (
                  <MapboxGL.SymbolLayer
                    id="pointCount"
                    style={{
                      textField: '.',
                      textColor: 'red',
                      textSize: 16,
                      textFont: ['Noto Sans Regular'],
                    }}
                  />
                )}
              </MapboxGL.ShapeSource>
            </MapboxGL.MapView>
          </View>
        </View>
      </View>
      <View bg="white" rounded="md" shadow={3} p={3} m={2}>
        <Text
          style={{
            marginTop: 10,
            marginBottom: 10,
            paddingTop: 10,
            paddingHorizontal: 0,
            fontSize: 25,
            color: '#454b58',
            fontFamily: 'Rubik-Black',
          }}>
          Hospitals
        </Text>
        <Text
          style={{
            marginTop: 10,
            paddingTop: 10,
            paddingHorizontal: 10,
            fontWeight: '500',
            fontSize: 15,
            color: '#454b58',
            fontFamily: 'Rubik-Light',
          }}>
          Chipinge District Hospital
        </Text>
        <Text
          style={{
            marginTop: 10,
            paddingTop: 10,
            paddingHorizontal: 10,
            fontWeight: '500',
            fontSize: 15,
            color: '#454b58',
            fontFamily: 'Rubik-Light',
          }}>
          Chipinge Clinic
        </Text>
        <Text
          style={{
            marginTop: 10,
            paddingTop: 10,
            paddingHorizontal: 10,
            fontWeight: '500',
            fontSize: 15,
            color: '#454b58',
            fontFamily: 'Rubik-Light',
          }}>
          Mt Selinda Mission Hospital
        </Text>
      </View>
    </ScrollView>
  );
};

const styles = StyleSheet.create({
  page: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: '#F5FCFF',
  },
  container: {
    height: '100%',
    width: '100%',
    backgroundColor: 'blue',
  },
  map: {
    flex: 1,
  },
});

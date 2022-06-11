import React, {useEffect, useState} from 'react';
import {
  Thumbnail,
  List,
  ListItem,
  Separator,
  Center,
  Box,
  Button,
  Modal,
  HStack,
  View,
  Progress,
  Text,
} from 'native-base';
import {
  TouchableOpacity,
  Image,
  ScrollView,
  ImageBackground,
  StyleSheet,
} from 'react-native';
import {WebView} from 'react-native-webview';

export default function PreventativeMeasures({route, navigation}) {
  const [progressLoading, setProgressLoading] = useState();
  const [loading, setLoading] = useState();

  useEffect(() => {
    setLoading(progressLoading);
  }, [progressLoading]);

  return (
    <>
      {Math.floor(loading * 100) < 100 ? (
        <Center w="100%">
          <Box w="90%" py={2} maxW="400">
            <Progress
              _filledTrack={{bg: '#d75369'}}
              value={Math.floor(loading * 100)}
              mx="4"
            />
          </Box>
        </Center>
      ) : null}
      <WebView
        onLoadProgress={({nativeEvent}) => {
          setProgressLoading(nativeEvent.progress);
        }}
        source={{
          uri: route.params.uri,
        }}
      />
    </>
  );
}

import 'package:flutter/material.dart';
import 'metadata.dart';

class GetMetaData extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: LocationApp(),
    );
  }
}

class LocationApp extends StatefulWidget {
  @override
  _LocationAppState createState() => _LocationAppState();
}

class _LocationAppState extends State<LocationApp> {
  var locationMessage;
  var time;
  var brand, device;
  var deviceInfo;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Flex"),
        backgroundColor: Colors.purple,
      ),
      body: Center(
        child: Container(
          color: Colors.grey[250],
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.center,
            children: [
              Icon(
                Icons.approval,
                size: 46,
                color: Colors.blue,
              ),
              SizedBox(
                height: 10,
              ),
              Text(
                'User Information',
                style: TextStyle(fontSize: 26, fontWeight: FontWeight.bold),
              ),
              SizedBox(height: 20),
              TextButton(
                style: ButtonStyle(backgroundColor: MaterialStateProperty.all(Colors.blue[800])),
                onPressed: () async {
                  locationMessage = await Metadata().getCurrentLocation();
                  time = Metadata().getTime();
                  deviceInfo = await Metadata().getDeviceInfo();

                  setState(() {});
                },
                child: Text(
                  'Get Information',
                  style: TextStyle(color: Colors.white),
                ),
              ),
              Center(
                child: Text('LOCATION: $locationMessage \n\n'
                    'TIME: $time \n\n'
                    'DETAILS: $deviceInfo'),
              ),
            ],
          ),
        ),
      ),
    );
  }
}

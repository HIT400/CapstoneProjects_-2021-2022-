// ignore_for_file: deprecated_member_use

import 'dart:convert';
import 'package:flex/constants/api.dart';
import 'package:flex/screens/authentication/authentication.dart';
import 'package:flutter/material.dart';
import 'package:hive/hive.dart';
import 'package:path_provider/path_provider.dart';
import 'package:http/http.dart' as http;
import 'package:toast/toast.dart';

class OfflineAccess extends StatefulWidget {
  const OfflineAccess({Key key}) : super(key: key);

  @override
  _OfflineAccessState createState() => _OfflineAccessState();
}

class _OfflineAccessState extends State<OfflineAccess> {
  Box _box;
  List data = [];

  Future openBox() async {
    var dir = await getApplicationDocumentsDirectory();
    Hive.init(dir.path);
    _box = await Hive.openBox('data');
  }

  Future<bool> getAllData() async {
    await openBox();

    var url = ApiConnect.getAssessmentUrl + "1/";

    var authToken = await AuthenticationController().retrieveAuthToken();
    try {
      var response = await http.get(url, headers: {
        'Authorization': "Token " + authToken,
      });

      var _jsonData = jsonDecode(response.body);

      await putData(_jsonData);
    } catch (socketException) {
      print("No Internet");
    }

    var myMap = _box.toMap().values.toList();

    if (myMap.isEmpty) {
      data.add("empty");
    } else {
      data = myMap;
    }

    return Future.value(true);
  }

  Future<void> refreshData() async {
    var url = ApiConnect.getAssessmentUrl + "1/";

    var authToken = await AuthenticationController().retrieveAuthToken();
    try {
      var response = await http.get(url, headers: {
        'Authorization': "Token " + authToken,
      });
      var _jsonData = jsonDecode(response.body);
      setState(() {});

      await putData(_jsonData);
    } catch (socketException) {
      Toast.show("No Internet", context,
          duration: Toast.LENGTH_LONG, gravity: Toast.BOTTOM);
    }
  }

  Future putData(data) async {
    _box.clear();

    data.forEach((item) {
      _box.add(item);
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        brightness: Brightness.dark,
        automaticallyImplyLeading: false,
        title: Image.asset(
          'images/flex_logo.png',
          fit: BoxFit.cover,
          height: 30,
        ),
        actions: [
          Padding(
            padding: const EdgeInsets.all(10.0),
            child: Icon(Icons.person_outline),
          ),
          Padding(
            padding: const EdgeInsets.all(10.0),
            child: Icon(Icons.search),
          ),
        ],
      ),
      
      body: Center(
        child: FutureBuilder(
          future: getAllData(),
          builder: (context, snapshot) {
            if (snapshot.hasData) {
              if (data.contains("empty")) {
                return Text("No Data");
              } else {
                return RefreshIndicator(
                  onRefresh: refreshData,
                  child: ListView.builder(
                      itemCount: data.length,
                      itemBuilder: (context, index) {
                        return Card(
                          child: Padding(
                            padding:
                                const EdgeInsets.only(top: 8.0, bottom: 8.0),
                            child: ListTile(
                              contentPadding: EdgeInsets.zero,
                              title: Row(
                                mainAxisAlignment: MainAxisAlignment.start,
                                children: [
                                  Container(
                                    margin: EdgeInsets.only(left: 10),
                                    height: 60,
                                    width: 60,
                                    decoration: BoxDecoration(
                                      borderRadius: BorderRadius.circular(30),
                                      color: Colors.purple[200],
                                    ),
                                    child: Center(
                                      child: Icon(
                                        Icons.assessment_outlined,
                                        size: 35,
                                        color: Colors.white,
                                      ),
                                    ),
                                  ),
                                  SizedBox(
                                    width: 20,
                                  ),
                                  Expanded(
                                    child: Column(
                                      crossAxisAlignment:
                                          CrossAxisAlignment.start,
                                      children: [
                                        Text(
                                          data[index]['description'],
                                          style: TextStyle(
                                              fontSize: 17,
                                              fontWeight: FontWeight.w300),
                                        ),
                                        SizedBox(
                                          height: 5,
                                        ),
                                        Text(
                                          data[index]['name'] +
                                              " - " +
                                              data[index]['last_modified'],
                                          style: TextStyle(
                                              color: Colors.grey, fontSize: 15),
                                        ),
                                        Row(
                                          mainAxisAlignment:
                                              MainAxisAlignment.spaceBetween,
                                          children: [
                                            Text(
                                              "Published",
                                              style: TextStyle(
                                                  color: Colors.grey,
                                                  fontSize: 15),
                                            ),
                                            Switch(
                                              onChanged: null,
                                              value: data[index]['published'],
                                              activeColor: Colors.purple[600],
                                              activeTrackColor:
                                                  Colors.purple[600],
                                              inactiveTrackColor:
                                                  Colors.purple.withOpacity(0.5),
                                              inactiveThumbColor:
                                                  Colors.white,
                                              focusColor: Colors.purple[400]
                                                  .withOpacity(0.5),

                                              // ...
                                            ),
                                          ],
                                        )
                                      ],
                                    ),
                                  )
                                ],
                              ),
                            ),
                          ),
                        );
                      }),
                );
              }
            } else {
              return CircularProgressIndicator();
            }
          },
        ),
      ),
      floatingActionButton: FloatingActionButton(
        child: Icon(Icons.add),
        backgroundColor: Colors.pinkAccent[200],
        onPressed: () {
          Navigator.of(context).pushNamed('/camera');
        },
      ),
    );
  }
}

// ignore_for_file: deprecated_member_use

import 'dart:convert';
import 'package:flex/constants/routing_constants.dart';
import 'package:flex/models/assessment_template_model.dart';
import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;

Future<AssessmentTemplateModel> fetchAssement() async {
  var url = "http://127.0.0.1:8000/flexio/assessments/2/";

  var response = await http.get(url, headers: {
    'Authorization': 'Token d57fced7f50f3d333872fb37524d7713ac14d5ea',
  });

  if (response.statusCode == 200)
    return AssessmentTemplateModel.fromJson(json.decode(response.body));

  throw new Exception('unable to fetch assessments');
}

class ListViewPage extends StatefulWidget {
  @override
  _ListViewPageState createState() => _ListViewPageState();
}

class _ListViewPageState extends State<ListViewPage> {
  Future<AssessmentTemplateModel> _revisions;
  bool isLoading = false;
  String userToken = "Token 6e5923caae67cab418f374acee29ac3901255350";

  @override
  void initState() {
    super.initState();
    _revisions = fetchAssement();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        brightness: Brightness.dark,
        centerTitle: true,
        title: Text(
          "Revisions",
          textAlign: TextAlign.center,
        ),
      ),
      body: getBody(),
      floatingActionButton: FloatingActionButton(
        child: Icon(Icons.add),
        onPressed: () {
          Navigator.of(context).pushNamed(RoutingConstants.modelSelection);
        },
      ),
    );
  }

  Widget getBody() {
    return Center(
      child: FutureBuilder(
          future: _revisions,
          builder: (context, snapshot) {
            // Decode the JSON
            var assessments = json.decode(snapshot.data.toString());
            return ListView.builder(
                itemCount: assessments == null ? 0 : assessments.length,
                itemBuilder: (context, index) {
                  return getCard(assessments[index]);
                });
          }),
    );
  }

  Widget getCard(item) {
    return Card(
      child: Padding(
        padding: const EdgeInsets.only(top: 8.0, bottom: 8.0),
        child: ListTile(
          contentPadding: EdgeInsets.zero,
          title: Row(
            mainAxisAlignment: MainAxisAlignment.start,
            children: [
              Container(
                height: 60,
                width: 60,
                decoration: BoxDecoration(
                  borderRadius: BorderRadius.circular(30),
                ),
                child: Center(
                  child: Icon(
                    Icons.list,
                    size: 30,
                  ),
                ),
              ),
              SizedBox(
                width: 20,
              ),
              Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Text(
                    item.name,
                    style: TextStyle(fontSize: 17, fontWeight: FontWeight.w300),
                  ),
                  SizedBox(
                    height: 10,
                  ),
                  Text(
                    item.description + " - " + item.lastModified,
                    style: TextStyle(color: Colors.grey, fontSize: 15),
                  ),
                ],
              )
            ],
          ),
        ),
      ),
    );
  }
}

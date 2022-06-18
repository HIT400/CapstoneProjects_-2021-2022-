import 'package:flex/models/assessment_model.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

import 'assessment_provider.dart';

class ProviderExample extends StatefulWidget {
  ProviderExample({Key key}) : super(key: key);

  @override
  _ProviderExampleState createState() => _ProviderExampleState();
}

class _ProviderExampleState extends State<ProviderExample> {
  String initialDefaultValue = "Initial Value";

  @override
  void initState() {
    Provider.of<Assessment>(context, listen: false).assessmentModel =
        new AssessmentModel(createdBy: "FlexUser");
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Center(
        child: Container(
          child: Column(
            mainAxisAlignment: MainAxisAlignment.center,
            crossAxisAlignment: CrossAxisAlignment.center,
            children: [
              ElevatedButton(
                  onPressed: () => {setNewModelValue()},
                  child: Text("Add model")),
              ElevatedButton(
                  onPressed: () => {clearModel()}, child: Text("Remove model")),
              // Consumer will rebuild the child widget wwhen notifyListeners is called
              Consumer<Assessment>(builder: (context, assessment, child) {
                return Text(assessment?.assessmentModel?.createdBy ??
                    initialDefaultValue);
              }),
            ],
          ),
        ),
      ),
    );
  }

  void setNewModelValue() {
    Provider.of<Assessment>(context, listen: false).assessmentModel =
        new AssessmentModel(createdBy: "FlexUser-2");
  }

  void clearModel() {
    //Use provider of when the date does not affect UI
    Provider.of<Assessment>(context, listen: false).clearAssessment();
  }
}

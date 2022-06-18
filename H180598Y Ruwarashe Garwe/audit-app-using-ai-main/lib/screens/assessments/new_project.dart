import 'package:flex/providers/project_provider.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter_easyloading/flutter_easyloading.dart';
import 'package:provider/provider.dart';
import '../components/flex_buttons.dart';
import 'floor_plan/show_floor_plan.dart';

class BuildNewProject extends StatefulWidget {
  const BuildNewProject({Key key}) : super(key: key);

  @override
  _BuildNewProjectState createState() => _BuildNewProjectState();
}

class _BuildNewProjectState extends State<BuildNewProject> {
  bool _switchValue = false;
  final projectName = TextEditingController();
  final projectInfo = TextEditingController();
  var _formKey = GlobalKey<FormState>();
  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      child: Container(
        decoration: BoxDecoration(),
        padding: MediaQuery.of(context).viewInsets,
        child: Form(
          key: _formKey,
          child: Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Center(
                    child: Container(
                      padding: EdgeInsets.only(left: 120),
                      child: Text(
                        'New Project',
                        style: TextStyle(
                            fontWeight: FontWeight.bold, fontSize: 16),
                      ),
                    ),
                  ),
                  IconButton(
                    color: Theme.of(context).primaryColor,
                    onPressed: () {
                      Navigator.pop(context);
                    },
                    icon: Icon(Icons.cancel_outlined),
                  ),
                ],
              ),
              Divider(
                color: Colors.transparent,
              ),
              buildTextField(
                  hintText: 'Audit',
                  labelText: 'Project Name',
                  controller: projectName,
                  context: context),
              buildTextField(
                  hintText: 'Fire Audit',
                  labelText: 'Project Info',
                  controller: projectInfo,
                  context: context),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                children: [
                  Text('Do you want to add floor plan?'),
                  SizedBox(
                    width: 20,
                  ),
                  Transform.scale(
                    scale: 0.6,
                    child: CupertinoSwitch(
                      activeColor: Theme.of(context).primaryColor,
                      value: _switchValue,
                      onChanged: (bool value) {
                        setState(() {
                          _switchValue = value;
                        });
                      },
                    ),
                  ),
                ],
              ),
              SizedBox(
                height: 20,
              ),
              Padding(
                padding: const EdgeInsets.all(16.0),
                child: Row(
                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                  children: [
                    Container(
                      width: 150,
                      height: 50,
                      child: DefaultFlexButton(
                        displayText: 'CANCEL',
                        fillcolor: false,
                        press: () {
                          Navigator.pop(context);
                        },
                      ),
                    ),
                    Container(
                      width: 150,
                      height: 50,
                      child: DefaultFlexButton(
                        displayText: 'CREATE',
                        fillcolor: true,
                        press: () {
                          if (!_formKey.currentState.validate()) return;

                          if (_formKey.currentState.validate()) {
                            EasyLoading.show(
                              status: 'loading...',
                            );
                            try {
                              insertAudit(context);

                              EasyLoading.showSuccess("Success");

                              Navigator.pop(context);

                              Navigator.push(
                                context,
                                MaterialPageRoute(
                                  builder: (BuildContext context) =>
                                      ShowFloorPlan(
                                    switchvalue: _switchValue,
                                  ),
                                ),
                              );
                            } on Exception catch (e) {
                              EasyLoading.showError(e.toString());
                            }
                          }
                        },
                      ),
                    ),
                  ],
                ),
              ),
              Divider(
                color: Colors.transparent,
              ),
            ],
          ),
        ),
      ),
    );
  }

  Future insertAudit(BuildContext context) async {
    var projectProvider = Provider.of<Project>(context, listen: false);

    var assessmentModel = projectProvider.project;
    assessmentModel.description = projectName.text;
    assessmentModel.createdBy = "Blessing";
    assessmentModel.dateCompleted = DateTime.now().toString();
    assessmentModel.organisationId = "SASRIA";
    projectProvider.saveProject(assessmentModel);
  }

  Widget buildTextField(
      {String hintText,
      String labelText,
      TextEditingController controller,
      BuildContext context}) {
    return Padding(
      padding: const EdgeInsets.all(15.0),
      child: TextFormField(
        controller: controller,
        decoration: InputDecoration(
          enabledBorder: OutlineInputBorder(
            borderRadius: BorderRadius.all(Radius.circular(10.0)),
          ),
          focusedBorder: OutlineInputBorder(
            borderRadius: BorderRadius.all(Radius.circular(10.0)),
          ),
          contentPadding: EdgeInsets.all(20),
          hintText: hintText,
          labelText: labelText,
          border: OutlineInputBorder(),
        ),
        validator: (value) {
          if (value.isEmpty) {
            return 'This is a field cannot be empty';
          }
          return null;
        },
      ),
    );
  }
}

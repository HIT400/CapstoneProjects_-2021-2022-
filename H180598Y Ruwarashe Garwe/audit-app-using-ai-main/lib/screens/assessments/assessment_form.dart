import 'dart:convert';
import 'package:flex/constants/routing_constants.dart';
import 'package:flex/models/assessment_model.dart';
import 'package:flex/models/assessment_template_model.dart';
import 'package:flex/providers/project_provider.dart';
import 'package:flex/screens/assessments/assessment.controller.dart';
import 'package:flex/screens/components/flex_buttons.dart';
import 'package:flex/screens/components/flex_expanded_rounded.dart';
import 'package:flex/screens/components/flex_text_form_field.dart';
import 'package:flex/screens/image_picker/image.controller.dart';
import 'package:flex/providers/app_state.dart';
import 'package:flex/themes/style.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:image_picker/image_picker.dart';
import 'dart:io';
import 'package:provider/provider.dart';
import 'package:toast/toast.dart';

class AssessmentForm extends StatefulWidget {
  @override
  _AssessmentFormState createState() => _AssessmentFormState();
}

class _AssessmentFormState extends State<AssessmentForm> {
  var _formKey = GlobalKey<FormState>();
  bool isDate, _completed = true;
  Future<File> file;
  String base64Image;
  File tmpFile;
  AssessmentTemplateModel _selectedAssesmentTemplate;
  AssessmentModel assessmentModel = new AssessmentModel();

  List<AssessmentTemplateModel> _assessmentTemplates =
      <AssessmentTemplateModel>[];

  @override
  void didChangeDependencies() {
    super.didChangeDependencies();
    _selectedAssesmentTemplate =
        Provider.of<Project>(context, listen: false).template;
    _assessmentTemplates =
        Provider.of<AppState>(context, listen: false).assessmentTemplates;
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      resizeToAvoidBottomInset: false,
      backgroundColor: Colors.grey.shade100,
      body: Padding(
        padding:
            EdgeInsets.only(bottom: MediaQuery.of(context).viewInsets.bottom),
        child: SingleChildScrollView(
          child: Container(
            height: MediaQuery.of(context).size.height,
            width: MediaQuery.of(context).size.width,
            decoration: BoxDecoration(
              image: DecorationImage(
                image: AssetImage("images/R.jpg"),
                fit: BoxFit.cover,
              ),
            ),
            child: Column(
              mainAxisAlignment: MainAxisAlignment.start,
              children: [
                Container(
                  height: MediaQuery.of(context).size.height,
                  width: MediaQuery.of(context).size.width,
                  padding: EdgeInsets.only(
                    top: 10,
                  ),
                  color: Colors.deepPurple.withOpacity(.3),
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.center,
                    children: [
                      SizedBox(
                        height: 30,
                      ),
                      RichText(
                        text: TextSpan(
                          text: "CREATE",
                          style: TextStyle(
                            fontSize: 25,
                            letterSpacing: 2,
                            color: Colors.white,
                          ),
                          children: [
                            TextSpan(
                              text: " ASSESSMENT",
                              style: TextStyle(
                                fontSize: 25,
                                letterSpacing: 2,
                                color: Colors.white,
                              ),
                            ),
                          ],
                        ),
                      ),
                      FlexRoundedExpanded(
                        child: Form(
                          key: _formKey,
                          child: Padding(
                            padding: EdgeInsets.all(5.0),
                            child: ListView(
                              children: <Widget>[
                                FlexTextFormField(
                                  labelText: "Createdby",
                                  enabled: true,
                                  validator: (String value) {
                                    return isValueEmpty(value);
                                  },
                                  onSaved: (value) {
                                    assessmentModel.createdBy = value;
                                  },
                                ),
                                FlexTextFormField(
                                    labelText: "Organization",
                                    enabled: true,
                                    validator: (String value) {
                                      return isValueEmpty(value);
                                    },
                                    onSaved: (value) {
                                      assessmentModel.organisationId = value;
                                    }),
                                FlexTextFormField(
                                    labelText: "Description",
                                    validator: (String value) {
                                      return isValueEmpty(value);
                                    },
                                    onSaved: (value) {
                                      assessmentModel.description = value;
                                    }),
                                Row(
                                  mainAxisAlignment:
                                      MainAxisAlignment.spaceBetween,
                                  children: [
                                    buildCheckBox(
                                      labelText: "Report Available",
                                      value: _completed,
                                      onchanged: (value) {
                                        setState(() {
                                          _completed = !_completed;
                                        });
                                      },
                                    ),
                                  ],
                                ),
                                Divider(
                                    thickness: 2.0,
                                    color: appTheme().primaryColor),
                                Padding(
                                  padding: const EdgeInsets.all(8.0),
                                  child: Text(
                                    "Please select template",
                                    style: TextStyle(
                                        fontSize: 18,
                                        fontWeight: FontWeight.bold),
                                  ),
                                ),
                                Padding(
                                  padding: const EdgeInsets.all(8.0),
                                  child: FutureBuilder(
                                    future: getFakeAssessmentTemplates(),
                                    builder: (context, snapshot) {
                                      return templatesDropdown();
                                    },
                                  ),
                                ),
                                FlexTextFormField(
                                    labelText: "Name",
                                    enabled: true,
                                    initialValue:
                                        _selectedAssesmentTemplate?.name,
                                    validator: (String value) {
                                      return isValueEmpty(value);
                                    },
                                    onSaved: (value) {
                                      assessmentModel.assessmentTemplate.name =
                                          value;
                                    }),
                                FlexTextFormField(
                                    labelText: "Description",
                                    enabled: true,
                                    validator: (String value) {
                                      return isValueEmpty(value);
                                    },
                                    initialValue:
                                        _selectedAssesmentTemplate == null
                                            ? ""
                                            : _selectedAssesmentTemplate
                                                ?.description,
                                    onSaved: (value) {
                                      assessmentModel.assessmentTemplate
                                          .description = value;
                                    }),
                                FlexTextFormField(
                                    labelText: "Organization",
                                    enabled: true,
                                    initialValue:
                                        _selectedAssesmentTemplate == null
                                            ? ""
                                            : _selectedAssesmentTemplate
                                                ?.organization
                                                .toString(),
                                    validator: (String value) {
                                      return isValueEmpty(value);
                                    },
                                    onSaved: (value) {
                                      assessmentModel
                                          .assessmentTemplate
                                          .organization
                                          .name = "int.tryParse(value)";
                                    }),
                                // FlexTextFormField(
                                //     labelText: "Revision number",
                                //     enabled: false,
                                //     initialValue:
                                //         _selectedAssesmentTemplate == null
                                //             ? "1"
                                //             : _selectedAssesmentTemplate
                                //                 ?.revisionNumber
                                //                 .toString(),
                                //     onSaved: (value) {
                                //       assessmentModel.assessmentTemplate
                                //           .revisionNumber = int.tryParse(value);
                                //     }),
                                FlexTextFormField(
                                    hintText: "2020-08-24",
                                    labelText: "Last Date Modified",
                                    initialValue:
                                        _selectedAssesmentTemplate == null
                                            ? ""
                                            : _selectedAssesmentTemplate
                                                ?.lastModified,
                                    enabled: false,
                                    onSaved: (value) {
                                      assessmentModel.assessmentTemplate
                                          .description = value;
                                    }),
                                Padding(
                                  padding: const EdgeInsets.all(8.0),
                                  child: Text(
                                    "Data Fields",
                                    style: TextStyle(
                                        fontSize: 16,
                                        fontWeight: FontWeight.bold),
                                  ),
                                ),
                                Column(
                                  children: _buildTemplateDataFields(
                                      _selectedAssesmentTemplate
                                          ?.section[0].fields),
                                ),
                                Divider(
                                  color: Colors.transparent,
                                ),
                                Padding(
                                  padding: const EdgeInsets.only(
                                      bottom: 16.0, left: 8, right: 8),
                                  child: Row(
                                    mainAxisAlignment:
                                        MainAxisAlignment.spaceBetween,
                                    children: [
                                      Container(
                                        width: 150.0,
                                        height: 50.0,
                                        child: DefaultFlexButton(
                                            displayText: "Cancel",
                                            fillcolor: false,
                                            press: () =>
                                                {Navigator.pop(context)}),
                                      ),
                                      Container(
                                        width: 150.0,
                                        height: 50.0,
                                        child: DefaultFlexButton(
                                          displayText: "Create",
                                          fillcolor: true,
                                          press: () {
                                            if (_formKey.currentState
                                                .validate()) {
                                              _formKey.currentState.save();
                                              setState(
                                                () {
                                                  print(jsonEncode(
                                                      this.assessmentModel));
                                                  Navigator.pushNamed(
                                                      context,
                                                      RoutingConstants
                                                          .floorPlan);
                                                  // print(jsonEncode());
                                                },
                                              );
                                              postAssessment();
                                            }
                                          },
                                        ),
                                      ),
                                    ],
                                  ),
                                ),
                              ],
                            ),
                          ),
                        ),
                      ),
                    ],
                  ),
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }

  String isValueEmpty(String value) {
    if (value.isEmpty) return "Can not be empty";
    return null;
  }

  List<Widget> _buildTemplateDataFields(List<Fields> datafields) {
    List<Widget> fieldWidgets = [];

    datafields?.forEach(
      (element) {
        var question = element.prompt;
        switch (element?.dataType) {
          case 1: //shorttext
            fieldWidgets.add(FlexTextFormField(labelText: question));
            break;
          case 2: //longtext
            fieldWidgets.add(FlexTextFormField(labelText: question));
            break;
          case 3: //date
            fieldWidgets.add(FlexTextFormField(labelText: question));
            break;
          case 4: //datetime
            fieldWidgets.add(FlexTextFormField(labelText: question));
            break;
          case 5: //integer
            fieldWidgets.add(FlexTextFormField(labelText: question));
            break;
          case 6: //float
            fieldWidgets.add(FlexTextFormField(labelText: question));
            break;
          case 7: //image
            fieldWidgets.add(_imageField(question));
            break;
          case 8: //boolean
            fieldWidgets.add(
              buildCheckBox(
                labelText: question,
                value: _completed,
                onchanged: (value) {
                  setState(
                    () {
                      _completed = !_completed;
                    },
                  );
                },
              ),
            );
            break;
        }
      },
    );

    return fieldWidgets;
  }

  Column _imageField(labelText) {
    return Column(
      mainAxisSize: MainAxisSize.min,
      crossAxisAlignment: CrossAxisAlignment.stretch,
      children: <Widget>[
        OutlinedButton(
          onPressed: chooseImage,
          child: Text(labelText),
        ),
        SizedBox(
          width: 20,
        ),
        showImage(),
        SizedBox(
          height: 20.0,
        ),
        SizedBox(
          height: 20.0,
        ),
      ],
    );
  }

  Container templatesDropdown() {
    return Container(
      padding: EdgeInsets.only(left: 8.0, right: 8.0),
      decoration: BoxDecoration(
          border: Border.all(color: Colors.grey),
          borderRadius: BorderRadius.circular(10.0)),
      child: DropdownButton<AssessmentTemplateModel>(
        hint: Text("Select template"),
        value: _selectedAssesmentTemplate,
        isExpanded: true,
        icon: Icon(Icons.keyboard_arrow_down, size: 22),
        underline: SizedBox(),
        items: _assessmentTemplates.map((AssessmentTemplateModel template) {
          return new DropdownMenuItem<AssessmentTemplateModel>(
            value: template,
            child: new Text(template.name),
          );
        }).toList(),
        onChanged: (value) {
          //Do something with this value
          setState(() {
            _selectedAssesmentTemplate = value;
            assessmentModel.assessmentTemplate = _selectedAssesmentTemplate;
          });
        },
      ),
    );
  }

  Widget showImage() {
    return FutureBuilder<File>(
      future: file,
      builder: (BuildContext context, AsyncSnapshot<File> snapshot) {
        if (snapshot.connectionState == ConnectionState.done &&
            null != snapshot.data) {
          tmpFile = snapshot.data;
          base64Image = base64Encode(snapshot.data.readAsBytesSync());
          return Flexible(
            child: Image.file(
              snapshot.data,
              fit: BoxFit.fill,
            ),
          );
        } else if (null != snapshot.error) {
          return const Text(
            'Error Picking Image',
            textAlign: TextAlign.center,
          );
        } else {
          return const Text(
            'No Image Selected',
            textAlign: TextAlign.center,
          );
        }
      },
    );
  }

  chooseImage() {
    setState(() {
      file = FlexImageController.getImage(ImageSource.gallery);
    });
  }

  Future<void> getFakeAssessmentTemplates() async {
    if (_assessmentTemplates.isNotEmpty) return;
    var templates =
        Provider.of<AppState>(context, listen: false).assessmentTemplates;

    List<dynamic> data = templates;

    setState(() {
      data.forEach((element) {
        _assessmentTemplates.add(AssessmentTemplateModel.fromJson(element));
      });
    });
  }

  void postAssessment() async {
    var _postAssessment = await AssessmentController().upload(assessmentModel);

    if (!_postAssessment) {
      Toast.show("Assessment creation failed", context,
          duration: Toast.LENGTH_LONG, gravity: Toast.BOTTOM);
    } else {
      Toast.show("Assessment created successfully", context,
          duration: Toast.LENGTH_LONG, gravity: Toast.BOTTOM);
    }
  }

  Row buildCheckBox({String labelText, Function onchanged, bool value}) {
// Pass onchanged as null for disabling button
    return Row(
      children: [
        Checkbox(
            value: value,
            activeColor: appTheme().primaryColor,
            onChanged: onchanged),
        Text(labelText, style: TextStyle(fontSize: 12))
      ],
    );
  }
}

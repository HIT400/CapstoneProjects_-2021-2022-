import 'package:flex/constants/routing_constants.dart';
import 'package:flex/models/assessment_model.dart';
import 'package:flex/models/assessment_template_model.dart';
import 'package:flex/models/inventory.dart';
import 'package:flex/models/section_model.dart';
import 'package:flex/providers/project_provider.dart';
import 'package:flex/screens/assessments/form.dart';
import 'package:flex/screens/components/flex_add_item_widget.dart';
import 'package:flex/screens/components/flex_buttons.dart';
import 'package:flex/screens/components/flex_dashboard_text.dart';
import 'package:flex/screens/components/flex_expanded_rounded.dart';
import 'package:flex/screens/components/flex_listed_inventory.dart';
import 'package:flex/screens/components/flex_outlined_button.dart';
// import 'package:flex/screens/components/flex_text_form_field.dart';
import 'package:flex/screens/image_picker/image.controller.dart';
import 'package:flex/themes/style.dart';
import 'dart:convert';
import 'dart:io';
import 'package:flutter/material.dart';
import 'package:flutter_easyloading/flutter_easyloading.dart';
import 'package:image_picker/image_picker.dart';
import 'package:provider/provider.dart';
import 'flex_camera_preview.dart';

class FlexCameraDetection extends StatefulWidget {
  const FlexCameraDetection({Key key}) : super(key: key);

  @override
  _FlexCameraDetectionState createState() => _FlexCameraDetectionState();
}

class _FlexCameraDetectionState extends State<FlexCameraDetection> {
  List<Items> _items = [];
  List _sections = [];
  Section currentSection;
  int currentIndex = 0;
  bool activeSection = false;
  Future<File> file;
  bool _completed = true;
  String base64Image;
  File tmpFile;
  final _formKey = GlobalKey<FormState>();
  var _sectionFieldsMap = Map();
  List<Fields> _rawSection = [];
  AssessmentModel model = new AssessmentModel();

  @override
  void initState() {
    super.initState();
    setState(() {
      currentSection = Provider.of<Project>(context, listen: false).sections[0];
    });
  }

  // Future<void> fetchAppState() async {
  //   _sections = Provider.of<Project>(context, listen: false).sections;
  //   setState(() {
  //     index = Provider.of<AppState>(context, listen: false).index;

  //     if (_sections.isNotEmpty) {
  //       _items = _sections[index].inventory;
  //     }
  //   });
  // }

  TextEditingController itemDescriptionController = new TextEditingController();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Color(0XFFEFF0F2),
      extendBodyBehindAppBar: true,
      bottomNavigationBar: BottomAppBar(
        elevation: 0.0,
        child: Container(
          height: 60,
          width: MediaQuery.of(context).size.width,
          child: Padding(
            padding: const EdgeInsets.all(10.0),
            child: Row(
              mainAxisAlignment: MainAxisAlignment.spaceBetween,
              children: [
                Transform.scale(
                  scale: 0.75,
                  child: DefaultFlexOutlinedButton(
                    displayText: 'SAVE & END',
                    fillcolor: false,
                    press: () {
                      Provider.of<Project>(context, listen: false)
                          .saveProject(model);
                      EasyLoading.show(status: 'Loading..');
                      Navigator.pushNamed(context, RoutingConstants.home);
                      EasyLoading.dismiss();
                    },
                  ),
                ),
                Transform.scale(
                  scale: 0.75,
                  child: DefaultFlexOutlinedButton(
                    displayText: 'SAVE & PAUSE',
                    fillcolor: false,
                    press: () {
                      // EasyLoading.show();
                      Provider.of<Project>(context, listen: false)
                          .saveProject(model);
                      // EasyLoading.dismiss();
                    },
                  ),
                ),
                Transform.scale(
                  scale: 1.1,
                  child: Expanded(
                    flex: 1,
                    child: Container(
                      height: 40,
                      width: 100,
                      child: DefaultFlexButton(
                        displayText: 'CONTINUE',
                        fillcolor: true,
                        press: () {
                          EasyLoading.show();
                          Navigator.pushNamed(
                              context, RoutingConstants.flexCameraDetection);
                          EasyLoading.dismiss();
                        },
                      ),
                    ),
                  ),
                ),
              ],
            ),
          ),
        ),
      ),
      body: SingleChildScrollView(
        child: Container(
          height: MediaQuery.of(context).size.height,
          width: MediaQuery.of(context).size.width,
          decoration: BoxDecoration(
            image: DecorationImage(
              image: AssetImage("images/R.jpg"),
              fit: BoxFit.cover,
            ),
          ),
          child: Expanded(
            flex: 1,
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
                          text: "SECTION",
                          style: TextStyle(
                            fontSize: 20,
                            letterSpacing: 2,
                            color: Colors.white,
                          ),
                          children: [
                            TextSpan(
                              text: " AUDIT",
                              style: TextStyle(
                                fontSize: 20,
                                letterSpacing: 2,
                                color: Colors.white,
                              ),
                            ),
                          ],
                        ),
                      ),
                      FlexRoundedExpanded(
                        child: ListView(
                          padding: EdgeInsets.only(top: 0),
                          children: [
                            Row(
                              children: [
                                DefaultFlexOutlinedButton(
                                  fillcolor: false,
                                  displayText: "BACK",
                                  press: () {
                                    Navigator.pop(context);
                                  },
                                ),
                              ],
                            ),
                            Container(
                              height: 50,
                              child: Consumer<Project>(
                                builder: (context, project, child) {
                                  _sections = project.sections;
                                  currentSection = _sections[0];
                                  return ListView.builder(
                                    scrollDirection: Axis.horizontal,
                                    itemCount: _sections.length,
                                    itemBuilder:
                                        (BuildContext context, int index) {
                                      return Padding(
                                        padding: const EdgeInsets.all(4.0),
                                        child: TextButton(
                                          child: Text(
                                            _sections[index].sectionName,
                                            style: TextStyle(
                                              color: Colors.white,
                                              fontWeight: FontWeight.bold,
                                            ),
                                          ),
                                          style: TextButton.styleFrom(
                                            primary: Colors.white,
                                            backgroundColor: Theme.of(context)
                                                .primaryColor
                                                .withOpacity(0.8),
                                            onSurface: Colors.grey,
                                          ),
                                          onPressed: () {
                                            setState(() {
                                              //   activeSection = !activeSection;
                                              // _rawSection.toSet().toList();
                                              // Provider.of<Project>(context,
                                              //         listen: false)
                                              //     .sections[currentIndex]
                                              //     .fields = _rawSection;

                                              currentIndex = index;
                                              currentSection = _sections[index];
                                            });
                                          },
                                        ),
                                      );
                                    },
                                  );
                                },
                              ),
                            ),
                            Center(
                              child: Container(
                                margin: EdgeInsets.only(top: 20),
                                height: 300,
                                width: MediaQuery.of(context).size.width,
                                decoration: BoxDecoration(
                                  color: Colors.white,
                                  boxShadow: [
                                    BoxShadow(
                                      color: Colors.grey.withOpacity(0.5),
                                      spreadRadius: 5,
                                      blurRadius: 7,
                                      offset: Offset(0, 3),
                                    ),
                                  ],
                                ),
                                child: FlexCameraPreview(),
                              ),
                            ),
                            Row(
                              mainAxisAlignment: MainAxisAlignment.start,
                              children: [
                                Padding(
                                  padding: const EdgeInsets.only(top: 30.0),
                                  child: FlexDashboardTitle(
                                    color: Colors.black,
                                    title: "Listed Inventory",
                                  ),
                                ),
                              ],
                            ),
                            Expanded(
                              child: Consumer<Project>(
                                  builder: (context, project, child) {
                                if (project.sections[currentIndex].inventory !=
                                    null) {
                                  _items = project
                                      .sections[currentIndex].inventory.items;
                                }
                                return Column(
                                  children: buildInventoryList(_items),
                                );
                              }),
                            ),
                            Padding(
                              padding:
                                  const EdgeInsets.only(top: 8.0, bottom: 8.0),
                              child: FlexAddItemWidget(
                                text: "Add Item",
                                press: () {
                                  showDialog(
                                    useSafeArea: true,
                                    context: context,
                                    builder: (BuildContext context) {
                                      return buildAlertDialog();
                                    },
                                  );
                                },
                              ),
                            ),
                            Form(
                              key: _formKey,
                              child:
                                  Column(children: _buildTemplateDataFields()),
                            ),
                            SizedBox(
                              height: 20,
                            ),
                            Padding(
                              padding:
                                  const EdgeInsets.only(top: 10, bottom: 10),
                              child: Row(
                                mainAxisAlignment:
                                    MainAxisAlignment.spaceBetween,
                                children: [
                                  Transform.scale(
                                    scale: 0.75,
                                    child: DefaultFlexOutlinedButton(
                                      displayText: 'SAVE & END',
                                      fillcolor: false,
                                      press: () {
                                        Provider.of<Project>(context,
                                                listen: false)
                                            .saveProject(model);
                                        EasyLoading.show(status: 'Loading..');
                                        Navigator.pushNamed(
                                            context, RoutingConstants.home);
                                        EasyLoading.dismiss();
                                      },
                                    ),
                                  ),
                                  Transform.scale(
                                    scale: 0.75,
                                    child: DefaultFlexOutlinedButton(
                                      displayText: 'SAVE & PAUSE',
                                      fillcolor: false,
                                      press: () {
                                        Provider.of<Project>(context,
                                                listen: false)
                                            .saveProject(model);
                                      },
                                    ),
                                  ),
                                  Container(
                                    height: 40,
                                    width: 110,
                                    child: DefaultFlexButton(
                                      displayText: 'PUBLISH',
                                      fillcolor: true,
                                      press: () {
                                        if (_formKey.currentState.validate()) {
                                          _formKey.currentState.save();
                                          _rawSection.toSet().toList();
                                          Provider.of<Project>(context,
                                                  listen: false)
                                              .sections[currentIndex]
                                              .fields = _rawSection;
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

  void saveSectionFields() {
    _rawSection.toSet().toList();
    Provider.of<Project>(context, listen: false).sections[currentIndex].fields =
        _rawSection;
  }

  void pushItem() {
    EasyLoading.show(status: 'Loading');
    var inventory = Provider.of<Project>(context, listen: false);
    inventory.addInventory(
        Items(
          itemName: itemDescriptionController.text,
        ),
        currentIndex);
    itemDescriptionController.clear();
    Navigator.pop(context);
    EasyLoading.dismiss();
  }

  TextField buildInputField(String label, TextEditingController controller) {
    return TextField(
      controller: controller,
      decoration: InputDecoration(
        focusColor: Colors.blueAccent,
        labelStyle: TextStyle(color: Colors.blueAccent),
        labelText: label,
      ),
    );
  }

  AlertDialog buildAlertDialog() {
    return AlertDialog(
      title: Text('Add Item'),
      content: Container(
        width: MediaQuery.of(context).size.width,
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            TextField(
              onChanged: (value) {},
              controller: itemDescriptionController,
              decoration: InputDecoration(hintText: "Item name"),
            ),
            SizedBox(
              height: 20,
            ),
            Row(
              mainAxisSize: MainAxisSize.max,
              mainAxisAlignment: MainAxisAlignment.spaceBetween,
              children: [
                Container(
                  width: 100,
                  child: DefaultFlexButton(
                    fillcolor: true,
                    displayText: "CANCEL",
                    press: () {
                      Navigator.pop(context);
                    },
                  ),
                ),
                Container(
                  width: 100,
                  child: DefaultFlexButton(
                    fillcolor: false,
                    displayText: "ADD ITEM",
                    press: pushItem,
                  ),
                ),
              ],
            ),
          ],
        ),
      ),
    );
  }

  List<Widget> buildInventoryList(dynamic inventory) {
    // ideally items are our lis of inventories
    if (_items == null || _items.isEmpty) return [const Text("No inventory")];

    return _items
        .map(
          (e) => FlexListedInventory(
            leading: Text(
              (_items.indexOf(e) + 1).toString(),
            ),
            title: e.itemName,
          ),
        )
        .toList();
  }

  List<Widget> _buildTemplateDataFields() {
    List<Widget> fieldWidgets = [];
    var datafields = currentSection.fields;

    if (datafields.isEmpty) return [];
    List<TextEditingController> controllers =
        List.generate(datafields.length, (index) => TextEditingController());
    datafields?.forEach(
      (field) {
        var question = field.prompt;
        switch (field?.dataType) {
          case 1: //shorttext
            // fieldWidgets.add(FlexTextFormField(
            //     labelText: question,
            //     onSaved: (value) {
            //       _rawSection.add(Fields(prompt: question, answer: value));
            //     }));
            fieldWidgets.add(
              FlexDatafieldInput(
                field: field,
                controller: controllers[datafields.indexOf(field)],
              ),
            );
            break;
          case 2: //longtext
            // fieldWidgets.add(
            //   FlexTextFormField(
            //     labelText: question,
            //     onSaved: (value) {
            //       _rawSection.add(Fields(prompt: question, answer: value));
            //     },
            //   ),
            // );

            fieldWidgets.add(
              FlexDatafieldInput(
                field: field,
                controller: controllers[datafields.indexOf(field)],
              ),
            );
            break;
          case 3: //date
            // fieldWidgets.add(FlexTextFormField(
            //     labelText: question,
            //     onSaved: (value) {
            //       _rawSection.add(Fields(prompt: question, answer: value));
            //     }));
            // break;
            fieldWidgets.add(
              FlexDatafieldInput(
                field: field,
                controller: controllers[datafields.indexOf(field)],
              ),
            );
            break;

          case 4: //datetime
            // fieldWidgets.add(FlexTextFormField(
            //     labelText: question,
            //     onSaved: (value) {
            //       _rawSection.add(Fields(prompt: question, answer: value));
            //     }));

            fieldWidgets.add(
              FlexDatafieldInput(
                field: field,
                controller: controllers[datafields.indexOf(field)],
              ),
            );
            break;
          case 5: //integer
            // fieldWidgets.add(FlexTextFormField(
            //     labelText: question,
            //     onSaved: (value) {
            //       _rawSection.add(Fields(prompt: question, answer: value));
            //     }));

            fieldWidgets.add(
              FlexDatafieldInput(
                field: field,
                controller: controllers[datafields.indexOf(field)],
              ),
            );
            break;
          case 6: //float
            // fieldWidgets.add(FlexTextFormField(
            //     labelText: question,
            //     onSaved: (value) {
            //       _sectionFieldsMap[question] = value;
            //     }));

            fieldWidgets.add(
              FlexDatafieldInput(
                field: field,
                controller: controllers[datafields.indexOf(field)],
              ),
            );
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

  chooseImage() {
    setState(() {
      file = FlexImageController.getImage(ImageSource.gallery);
    });
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

class FlexDatafieldInput extends StatefulWidget {
  final Fields field;
  final TextEditingController controller;
  const FlexDatafieldInput(
      {Key key, @required this.field, @required this.controller})
      : super(key: key);

  @override
  _FlexDatafieldInputState createState() => _FlexDatafieldInputState();
}

class _FlexDatafieldInputState extends State<FlexDatafieldInput> {
  var visible = false;
  @override
  Widget build(BuildContext context) {
    return Container(
      child: Column(
        children: [
          FlexTextFormField(
            labelText: widget.field.prompt,
            controller: widget.controller,
            onEditingComplete: () {
              if ("yes" == widget.controller.text) {
                setState(() {
                  visible = true;
                });
              } else {
                setState(() {
                  visible = false;
                });
              }
            },
          ),
          Visibility(
            visible: visible,
            child: FlexTextFormField(
              labelText: widget.field.prompt,
            ),
          ),
        ],
      ),
    );
  }
}

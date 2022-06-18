import 'dart:convert';
import 'dart:io';
import 'package:flex/constants/routing_constants.dart';
import 'package:flex/models/assessment_model.dart';
import 'package:flex/models/inventory.dart';
import 'package:flex/models/section_model.dart';
import 'package:flex/providers/project_provider.dart';
import 'package:flex/screens/components/flex_add_item_widget.dart';
import 'package:flex/screens/components/flex_buttons.dart';
import 'package:flex/screens/components/flex_dashboard_text.dart';
import 'package:flex/screens/components/flex_expanded_rounded.dart';
import 'package:flex/screens/components/flex_listed_inventory.dart';
import 'package:flex/screens/components/flex_outlined_button.dart';
import 'package:flex/screens/image_picker/image.controller.dart';
import 'package:flex/providers/app_state.dart';
import 'package:flex/themes/style.dart';
import 'package:flutter/material.dart';
import 'package:flutter_easyloading/flutter_easyloading.dart';
import 'package:image_picker/image_picker.dart';
import 'package:provider/provider.dart';
import 'flex_gesture_drag.dart';

class ShowFloorPlan extends StatefulWidget {
  ShowFloorPlan({Key key, this.switchvalue}) : super(key: key);
  final bool switchvalue;

  @override
  _ShowFloorPlanState createState() => _ShowFloorPlanState();
}

class _ShowFloorPlanState extends State<ShowFloorPlan> {
  Future<File> imagefile;
  String status = '';
  String base64Image;
  File tmpFile;
  bool press = false;
  var downloadImg;

  chooseImage() {
    setState(() {
      press = true;
      imagefile = FlexImageController.getImage(ImageSource.camera);
    });
  }

  static TextEditingController controller = new TextEditingController();
  var data;
  int index = 0;
  Offset position;
  bool isVisible = false;
  AssessmentModel model = new AssessmentModel();
  Inventory inventory;

  load() async {
    data = jsonDecode(
        await DefaultAssetBundle.of(context).loadString("assets/data.json"));
  }

  Future<void> addSpace() async {
    setState(() {
      Provider.of<AppState>(context, listen: false)
          .appendSection(new Section(sectionName: controller.text));
      // Provider.of<Project>(context, listen: false)
      //     .addInventory(Items(itemName: ), index);
      position = Offset(0.0, 0.0);
      Navigator.pop(context);
      controller.clear();
    });
  }

  void copySection(int space) {
    setState(() {
      Provider.of<AppState>(context, listen: false).copySection(space);
    });
  }

  cameraPlan() {
    return Stack(children: [
      showImage(),
      FlexDraggableMarker(),
      Positioned(
        bottom: 0,
        right: 0,
        child: Transform.scale(
          scale: 0.6,
          child: buildFloatingActionButton(Icons.camera,
              Theme.of(context).primaryColor, chooseImage, "Image"),
        ),
      )
    ]);
  }

  downloadPlan() {
    return Stack(children: [
      downloadImg = Image.asset('images/bg1.jpg'),
      FlexDraggableMarker(),
    ]);
  }

  @override
  Widget build(BuildContext context) {
    // AssessmentModel model;

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
      body: Container(
        height: MediaQuery.of(context).size.height,
        width: MediaQuery.of(context).size.width,
        decoration: BoxDecoration(
            image: DecorationImage(
                image: AssetImage("images/R.jpg"), fit: BoxFit.cover)),
        child: Column(
          mainAxisAlignment: MainAxisAlignment.start,
          children: [
            Expanded(
              flex: 1,
              child: Container(
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
                          text: "PIN &",
                          style: TextStyle(
                            fontSize: 25,
                            letterSpacing: 2,
                            color: Colors.white,
                          ),
                          children: [
                            TextSpan(
                              text: " NAME ROOMS",
                              style: TextStyle(
                                fontSize: 25,
                                letterSpacing: 2,
                                color: Colors.white,
                              ),
                            )
                          ]),
                    ),
                    FlexRoundedExpanded(
                      child: Stack(
                        children: [
                          ListView(
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
                              FlexAddItemWidget(
                                text: 'Add & Name Rooms',
                                press: () {
                                  // imagefile != null
                                  //     ? showDialog(
                                  //         useSafeArea: true,
                                  //         context: context,
                                  //         builder: (BuildContext context) {
                                  //           return buildAlertDialog();
                                  //         },
                                  //       )
                                  //     : Container();
                                  showDialog(
                                    useSafeArea: true,
                                    context: context,
                                    builder: (BuildContext context) {
                                      return buildAlertDialog();
                                    },
                                  );
                                },
                              ),
                              // Center(
                              //   child: Container(
                              //     margin: EdgeInsets.only(top: 20),
                              //     height: 300,
                              //     width: MediaQuery.of(context).size.width,
                              //     decoration: BoxDecoration(
                              //       color: Colors.white,
                              //       boxShadow: [
                              //         BoxShadow(
                              //           color: Colors.grey.withOpacity(0.5),
                              //           spreadRadius: 5,
                              //           blurRadius: 7,
                              //           offset: Offset(0, 3),
                              //         ),
                              //       ],
                              //     ),
                              //     child: Visibility(
                              //       visible: widget.switchvalue,
                              //       child: downloadPlan(),
                              //       replacement: cameraPlan(),
                              //     ),
                              //   ),
                              // ),
                              Row(
                                mainAxisAlignment: MainAxisAlignment.start,
                                children: [
                                  Padding(
                                    padding: const EdgeInsets.only(top: 10.0),
                                    child: FlexDashboardTitle(
                                        color: Colors.black,
                                        title: "Listed Sections"),
                                  ),
                                ],
                              ),
                              Expanded(
                                child: Column(
                                  children: buildSectionList(),
                                ),
                              ),
                            ],
                          ),
                        ],
                      ),
                    ),
                  ],
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }

  FloatingActionButton buildFloatingActionButton(
      IconData icon, Color color, dynamic onPressed, String hero) {
    return FloatingActionButton(
      child: Icon(icon),
      heroTag: hero,
      backgroundColor: color,
      onPressed: onPressed,
    );
  }

  showImage() {
    //We should look into having one method through the app which handles taking an image
    return FutureBuilder<File>(
      future: imagefile,
      builder: (BuildContext context, AsyncSnapshot<File> snapshot) {
        if (snapshot.connectionState == ConnectionState.done &&
            null != snapshot.data) {
          tmpFile = snapshot.data;
          base64Image = base64Encode(snapshot.data.readAsBytesSync());
          return Image.file(
            snapshot.data,
            color: Colors.transparent,
            colorBlendMode: BlendMode.darken,
            width: MediaQuery.of(context).size.width,
            fit: BoxFit.fill,
          );
        }

        if (snapshot.error != null) {
          return const Text(
            'Error Picking Image',
            textAlign: TextAlign.center,
          );
        } else {
          return Center(
              child: Text(
            'Please select an Image for floor plan.',
            textAlign: TextAlign.center,
          ));
        }
      },
    );
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
      title: Text('Add Space'),
      content: Container(
        width: MediaQuery.of(context).size.width,
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            TextField(
              onChanged: (value) {},
              controller: controller,
              decoration: InputDecoration(hintText: "Section Name"),
            ),
            SizedBox(
              height: 20,
            ),
            Row(
              mainAxisSize: MainAxisSize.max,
              mainAxisAlignment: MainAxisAlignment.spaceBetween,
              children: [
                DefaultFlexButton(
                  fillcolor: true,
                  displayText: "CANCEL ",
                  press: () {
                    Navigator.pop(context);
                  },
                ),
                DefaultFlexButton(
                  fillcolor: false,
                  displayText: "ADD ",
                  press: addSpace,
                ),
              ],
            ),
          ],
        ),
      ),
    );
  }

  List<Widget> buildSectionList() {
    var _spaces = Provider.of<Project>(context, listen: false).sections;

    if (_spaces.isEmpty) return [const Text("Inventory")];

    return _spaces
        .map((e) => FlexListedInventory(
              onCopyPress: () => copySection(_spaces.indexOf(e)),
              leading: Icon(
                Icons.height,
                color: appTheme().textTheme.bodyText1.color,
              ),
              title: e.sectionName.toString(),
            ))
        .toList();
  }
}

class FlexDraggableMarker extends StatefulWidget {
  const FlexDraggableMarker({
    Key key,
  }) : super(key: key);

  @override
  _FlexDraggableMarkerState createState() => _FlexDraggableMarkerState();
}

class _FlexDraggableMarkerState extends State<FlexDraggableMarker> {
  int index;
  double dy = 0.0;
  List<Section> markers;

  @override
  Widget build(BuildContext context) {
    return FutureBuilder(
        future: fetchAppState(),
        builder: (context, snapshot) {
          return Stack(
            children: buildMarker(markers),
          );
        });
  }

  Future<void> fetchAppState() async {
    markers = Provider.of<Project>(context, listen: false).sections;
    setState(() {
      markers = markers;
      index = Provider.of<AppState>(context, listen: false).index;
    });
  }

  List<Widget> buildMarker(List<Section> markers) {
    List<Widget> points = [];

    for (var marker in markers) {
      if (points.isNotEmpty) dy += 30.0;
      points.add(FlexGestureDrag(
        icon: Icons.place,
        iconColor: Colors.red,
        title: marker.sectionName,
        // position: Offset(0.0, 0.0),
      ));
    }
    return points;
  }
}

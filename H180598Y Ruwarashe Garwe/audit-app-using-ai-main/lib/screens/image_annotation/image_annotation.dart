// ignore_for_file: deprecated_member_use

import 'dart:convert';
import 'dart:io';
import 'dart:ui';
import 'package:animated_floatactionbuttons/animated_floatactionbuttons.dart';
import 'package:flex/models/draw_model.dart.dart';
import 'package:flex/screens/image_annotation/painter.dart';
import 'package:flex/screens/image_picker/image.controller.dart';
import 'package:flutter/material.dart';
import 'package:flutter/rendering.dart';
import 'package:flutter/services.dart';
import 'package:image_picker/image_picker.dart';
import 'package:rxdart/rxdart.dart';

class Draw extends StatefulWidget {
  const Draw({Key key}) : super(key: key);
  @override
  _DrawState createState() => _DrawState();
}

class _DrawState extends State<Draw> {
  List<TouchPoints> pointList = [];
  final pointStream = BehaviorSubject<List<TouchPoints>>();
  GlobalKey key = GlobalKey();
  GlobalKey myKey = GlobalKey();
  GlobalKey repaintBoundaryKey = GlobalKey();

  bool isDate;
  Future<File> imagefile;
  String status = '';
  String base64Image;
  File tmpFile;
  String errorMessage = 'Error Uploading Image';

  var _strokeWidth = 1.0;
  var _strokeColor = Colors.purpleAccent;
  @override
  void initState() {
    WidgetsBinding.instance.addPostFrameCallback(
        (_) => null);
        // replace null with this 
        // ImageAnnotationController().save(repaintBoundaryKey)
    super.initState();
  }

  @override
  void dispose() {
    pointStream.close();
    super.dispose();
  }

  chooseImage() {
    setState(() {
      imagefile = FlexImageController.getImage(ImageSource.camera);
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      key: key,
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
      body: GestureDetector(
        onPanStart: (details) {
          setDrawPoints(details, imagefile);
        },
        onPanUpdate: (details) {
          setDrawPoints(details, imagefile);
        },
        onPanEnd: (details) {
          pointList.add(null);
          pointStream.add(pointList);
        },
        child: Center(
          child: RepaintBoundary(
            key: repaintBoundaryKey,
            child: Stack(
              alignment: Alignment.center,
              children: <Widget>[
                showImage(),
                Container(
                  height: MediaQuery.of(context).size.height,
                  width: MediaQuery.of(context).size.width,
                  child: StreamBuilder<List<TouchPoints>>(
                      stream: pointStream.stream,
                      builder: (context, snapshot) {
                        return CustomPaint(
                          painter: DrawingPainter(snapshot.data ?? []),
                        );
                      }),
                )
              ],
            ),
          ),
        ),
      ),
      floatingActionButton: AnimatedFloatingActionButton(
        colorStartAnimation: Colors.purpleAccent,
        colorEndAnimation: Colors.purpleAccent,
        animatedIconData: AnimatedIcons.menu_arrow,
        fabButtons: [
          FloatingActionButton(
            child: Icon(Icons.image_outlined),
            heroTag: "Save",
            backgroundColor: Colors.grey,
            onPressed: () {
              // ImageAnnotationController().save(repaintBoundaryKey);
            },
          ),
          buildFloatingActionButton(
              Icons.brush_outlined, Colors.pinkAccent, pickStroke, "Stroke"),
          buildFloatingActionButton(
              Icons.format_paint_outlined, Colors.blueGrey, pickColor, "Color"),
          buildFloatingActionButton(
              Icons.camera, Colors.blueAccent, chooseImage, "Image"),
        ],
      ),
    );
  }

  void setDrawPoints(dynamic details, Future<File> imagefile) {
    if (imagefile == null) return;
    RenderBox renderBox = key.currentContext.findRenderObject();

    pointList.add(TouchPoints(
        points: renderBox.localToGlobal(details.localPosition),
        paint: startPainting()));
    pointStream.add(pointList);
  }

  Paint startPainting() {
    Paint paint = Paint()
      ..color = _strokeColor
      ..strokeCap = StrokeCap.round
      ..strokeWidth = _strokeWidth;
    return paint;
  }

  Widget showImage() {
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
            fit: BoxFit.contain,
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
            'Please select an Image.',
            textAlign: TextAlign.center,
          ));
        }
      },
    );
  }

  Future<void> pickStroke() async {
    return showDialog<void>(
      context: (context),
      barrierDismissible: true,
      builder: (BuildContext context) {
        return ClipOval(
          child: AlertDialog(
            actions: <Widget>[
              buildTextButton(Icons.clear, 24, _strokeWidth),
              buildTextButton(Icons.brush, 24, 5.0),
              buildTextButton(Icons.brush, 40, 10.0),
              buildTextButton(Icons.brush, 60, 15.0),
            ],
          ),
        );
      },
    );
  }

  Future<void> pickColor() async {
    return showDialog<void>(
      context: (context),
      barrierDismissible: true,
      builder: (BuildContext context) {
        return ClipOval(
          child: AlertDialog(
            actions: <Widget>[
              buildColorTextButton(Icons.clear, _strokeColor),
              buildColorTextButton(Icons.colorize, Colors.blueAccent),
              buildColorTextButton(Icons.colorize, Colors.pinkAccent),
              buildColorTextButton(Icons.colorize, Colors.purpleAccent),
            ],
          ),
        );
      },
    );
  }

  TextButton buildTextButton(IconData icon, double size, double strokeWidth) {
    return TextButton(
      onPressed: () {
        setState(() {
          _strokeWidth = strokeWidth;
        });
        Navigator.of(context).pop();
      },
      child: Icon(
        icon,
        size: size,
      ),
    );
  }

  TextButton buildColorTextButton(IconData icon, Color color) {
    return TextButton(
      onPressed: () {
        setState(() {
          _strokeColor = color;
        });
        Navigator.of(context).pop();
      },
      child: Icon(
        icon,
        size: 40,
        color: color,
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
}

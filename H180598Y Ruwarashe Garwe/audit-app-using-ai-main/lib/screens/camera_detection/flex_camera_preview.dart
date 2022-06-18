import 'package:camera/camera.dart';
import 'package:flex/screens/image_detection/model_selection.dart';
import 'package:flutter/material.dart';
import 'package:flex/main.dart' as main;

class FlexCameraPreview extends StatefulWidget {

  const FlexCameraPreview({Key key}) : super(key: key);

  @override
  _FlexCameraPreviewState createState() => _FlexCameraPreviewState();
}

class _FlexCameraPreviewState extends State<FlexCameraPreview> {
  CameraController controller;

  @override
  Widget build(BuildContext context) {
    var size = MediaQuery.of(context).size.width;
    return ClipRect(
      child: OverflowBox(
        alignment: Alignment.center,
        child: FittedBox(
          fit: BoxFit.fitWidth,
          child: Container(
            width: size,
            height: size / 0.7534,
            child: ModelSelection(main.cameras),
          ),
        ),
      ),
    );
  }
}

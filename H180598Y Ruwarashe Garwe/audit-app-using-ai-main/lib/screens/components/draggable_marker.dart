import 'package:flex/screens/components/flex_marker.dart';
import 'package:flutter/material.dart';

class DraggableWidget extends StatefulWidget {
  @override
  _DraggableWidgetState createState() => _DraggableWidgetState();
}

class _DraggableWidgetState extends State<DraggableWidget> {
  Offset position;

  @override
  void initState() {
    super.initState();
    position = Offset(0.0, 0.0);
  }

  @override
  Widget build(BuildContext context) {
    return Stack(
      children: <Widget>[
        Positioned(
          left: position.dx,
          top: position.dy,
          child: Draggable(
            child: FlexMarker(
              text: 'hello',
              color: Colors.green,
            ),
            feedback: FlexMarker(
              text: 'hello',
            ),
            onDraggableCanceled: (Velocity velocity, Offset offset) {
              setState(() => position = offset);
            },
          ),
        ),
      ],
    );
  }
}

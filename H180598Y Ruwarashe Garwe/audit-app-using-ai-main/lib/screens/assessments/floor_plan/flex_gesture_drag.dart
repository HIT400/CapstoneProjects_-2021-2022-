import 'package:flutter/material.dart';

class FlexGestureDrag extends StatefulWidget {
  Offset position;
  final Color iconColor;
  final IconData icon;
  final String title;
  FlexGestureDrag(
      {Key key,
      this.position,
      @required this.icon,
      this.iconColor,
      @required this.title})
      : super(key: key);

  @override
  _FlexGestureDragState createState() => _FlexGestureDragState();
}

class _FlexGestureDragState extends State<FlexGestureDrag> {
  Offset defaultPosition;

  @override
  Widget build(BuildContext context) {
    if (widget.position == null) {
      defaultPosition = Offset(0.0, 0.0);
    } else {
      defaultPosition = widget.position;
    }

    return GestureDetector(
      child: Stack(
        children: [
          Positioned(
            top: defaultPosition.dy,
            left: defaultPosition.dx,
            child: Align(
              alignment: Alignment.bottomLeft,
              child: Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                mainAxisSize: MainAxisSize.min,
                children: [
                  Icon(
                    widget.icon,
                    size: 35,
                    color: widget.iconColor,
                  ),
                  Text(widget.title),
                ],
              ),
            ),
          ),
        ],
      ),
      onVerticalDragUpdate: (DragUpdateDetails drag) {
        setState(() {
          widget.position = drag.localPosition;
        });
      },
    );
  }
}

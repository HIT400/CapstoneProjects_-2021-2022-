import 'package:flutter/material.dart';

class FlexMarker extends StatelessWidget {
  final MaterialColor color;
  final String text;

  const FlexMarker({
    Key key,
    this.color,
    this.text,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Container(
      child: Row(
        crossAxisAlignment: CrossAxisAlignment.end,
        children: [
          Icon(
            Icons.place,
            color: color,
          ),
          Text(text),
        ],
      ),
    );
  }

  
}

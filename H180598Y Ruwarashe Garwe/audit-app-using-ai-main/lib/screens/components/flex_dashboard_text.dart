import 'package:flutter/material.dart';

class FlexDashboardTitle extends StatelessWidget {
  final String title;
  final Color color;
  const FlexDashboardTitle({Key key, this.color, this.title}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.only(top: 8, bottom: 0),
      child: Text(
        this.title,
        style: TextStyle(
            fontWeight: FontWeight.bold, fontSize: 15, color: this.color),
      ),
    );
  }
}

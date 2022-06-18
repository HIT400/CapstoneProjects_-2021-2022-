import 'package:flutter/material.dart';

class FlexIconButton extends StatelessWidget {
  final IconData icon;
  final Color iconColor;
  final Color borderColor;
  final double scaleFactor;
  final Function press;

  const FlexIconButton(
      {Key key,
      this.borderColor,
      this.icon,
      this.iconColor,
      this.scaleFactor,
      this.press})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    return GestureDetector(
      child: Container(
        margin: EdgeInsets.all(3.0),
        padding: EdgeInsets.all(scaleFactor != null ? scaleFactor / 10 : 3),
        height: scaleFactor ?? 35,
        width: scaleFactor ?? 35,
        child: Icon(
          this.icon,
          size: scaleFactor != null ? scaleFactor / 2 : 35 / 2,
          color: this.iconColor,
        ),
        decoration: BoxDecoration(
          borderRadius: BorderRadius.circular(25),
          border: Border.all(color: this.borderColor, width: 2),
        ),
      ),
      onTap: press,
    );
  }
}

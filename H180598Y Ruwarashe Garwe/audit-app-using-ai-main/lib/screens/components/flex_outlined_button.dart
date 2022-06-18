import 'package:flutter/material.dart';
import 'package:flutter/widgets.dart';

class DefaultFlexOutlinedButton extends StatelessWidget {
  final String displayText;
  final bool fillcolor;
  final Function press;
  static const circularRadius = 0.0;
  const DefaultFlexOutlinedButton(
      {Key key, this.displayText, this.fillcolor, this.press})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    return DecoratedBox(
      decoration: BoxDecoration(
        border: Border(
          bottom: BorderSide(
            width: 2,
            color: fillcolor ? Colors.white : Theme.of(context).primaryColor,
          ),
        ),
      ),
      child: TextButton(
        style: TextButton.styleFrom(
          minimumSize: Size.zero,
          alignment: Alignment.bottomLeft,
          padding: EdgeInsets.all(0),
        ),
        onPressed: press,
        child: Align(
          alignment: Alignment.center,
          child: Text(
            displayText,
            textAlign: TextAlign.start,
            style: TextStyle(
              fontWeight: FontWeight.bold,
              color: fillcolor ? Colors.white : Theme.of(context).primaryColor,
            ),
          ),
        ),
      ),
    );
  }
}

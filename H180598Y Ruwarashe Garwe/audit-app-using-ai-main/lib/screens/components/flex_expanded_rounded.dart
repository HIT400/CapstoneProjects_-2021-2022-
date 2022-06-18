import 'package:flutter/material.dart';

class FlexRoundedExpanded extends StatelessWidget {
  final Widget child;
  const FlexRoundedExpanded({Key key, this.child}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Expanded(
      flex: 1,
      child: Container(
        padding: EdgeInsets.symmetric(horizontal: 20),
        margin: EdgeInsets.only(top: 20),
        width: MediaQuery.of(context).size.width,
        height: MediaQuery.of(context).size.height,
        decoration: BoxDecoration(
          color: Colors.white,
          borderRadius: BorderRadius.only(
            topLeft: Radius.circular(30),
            topRight: Radius.circular(30),
          ),
        ),
        child: child != null
            ? child
            : Center(
                child: Text("children not set"),
              ),
      ),
    );
  }
}

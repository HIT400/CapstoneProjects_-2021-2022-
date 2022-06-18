import 'package:flutter/material.dart';
import 'package:flutter/services.dart';

class DefaultFlexAppBar extends StatelessWidget {
  const DefaultFlexAppBar({Key key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return AppBar(
      systemOverlayStyle: SystemUiOverlayStyle.light,
      // ignore: deprecated_member_use
      brightness: Brightness.dark,
      automaticallyImplyLeading: false,
      backgroundColor: Colors.transparent,
      elevation: 0,
      // centerTitle: true,
      title: Image.asset(
        'images/flex_logo.png',
        fit: BoxFit.cover,
        height: 30,
      ),
    );
  }
}

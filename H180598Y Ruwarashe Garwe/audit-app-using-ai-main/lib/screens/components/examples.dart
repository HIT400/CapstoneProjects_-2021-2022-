import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class Examples extends StatefulWidget {
  const Examples({Key key}) : super(key: key);

  @override
  _ExamplesState createState() => _ExamplesState();
}

class _ExamplesState extends State<Examples> {
  @override
  Widget build(BuildContext context) {
    setState(() {});
    return MaterialApp(
      home: Scaffold(
        resizeToAvoidBottomInset: true,
        body: Center(
          child: ElevatedButton(
            child: const Text('SHOW BOTTOM SHEET'),
            onPressed: () {
              // NewProject().displayBottomPopUp(context, () => {});
            },
          ),
        ),
      ),
    );
  }
}

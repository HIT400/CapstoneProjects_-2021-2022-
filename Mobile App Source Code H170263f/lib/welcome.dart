import 'package:flutter/material.dart';
import 'chat.dart';
import 'reg.dart';

class WelcomeScreen extends StatefulWidget {
  static const String id = 'welcome_screen';
  @override
  _WelcomeScreenState createState() => _WelcomeScreenState();
}

class _WelcomeScreenState extends State<WelcomeScreen> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Padding(
        padding: EdgeInsets.symmetric(horizontal: 24.0),
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          crossAxisAlignment: CrossAxisAlignment.stretch,
          children: <Widget>[
            Row(
              children: <Widget>[
                Hero(
                  tag: 'logo',
                  child: Container(
                    // child: Image.asset('images/logo.png'),
                    height: 60.0,
                  ),
                ),
              ],
            ),
            SizedBox(
              height: 48.0,
            ),
            TextButton(
              child: Text('Chat Screen'),
              onPressed: () {
                Navigator.pushNamed(context, Chat.id);
              },
            ),
            TextButton(
                child: Text('Registration'),
                onPressed: () {
                  Navigator.pushNamed(context, Registration.id);
                }),
          ],
        ),
      ),
    );
  }
}

import 'package:flex/screens/components/app_bar.dart';
import 'package:flutter/material.dart';

class Settings extends StatefulWidget {
  const Settings({Key key}) : super(key: key);

  @override
  _SettingsState createState() => _SettingsState();
}

class _SettingsState extends State<Settings> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      extendBodyBehindAppBar: true,
      appBar: PreferredSize(
        preferredSize: Size.fromHeight(60),
        child: DefaultFlexAppBar(),
      ),
      body: Column(
        children: [
          Container(
            height: 250,
            width: MediaQuery.of(context).size.width,
            decoration: BoxDecoration(
                color: Colors.amber,
                image: DecorationImage(
                    image: AssetImage("images/bg1.jpg"), fit: BoxFit.cover)),
            child: Container(
              padding: EdgeInsets.only(top: 90, left: 20),
              color: Colors.deepPurple.withOpacity(.3),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.center,
                children: [
                  SizedBox(
                    height: 120,
                  ),
                  RichText(
                    text: TextSpan(
                      text: "SETTINGS",
                      style: TextStyle(
                        fontSize: 25,
                        letterSpacing: 2,
                        color: Colors.white70,
                      ),
                      children: [
                        TextSpan(
                          text: " ",
                          style: TextStyle(
                            fontSize: 25,
                            letterSpacing: 2,
                            color: Colors.white70,
                          ),
                        )
                      ],
                    ),
                  ),
                  SizedBox(
                    height: 5,
                  ),
                ],
              ),
            ),
          ),
        ],
      ),
    );
  }
}

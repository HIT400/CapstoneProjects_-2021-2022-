import 'package:flutter/material.dart';
import 'package:flutter/widgets.dart';

import 'authentication/login.dart';
import 'dashboard/flex_basic_dashboard.dart';
import 'image_annotation/image_annotation.dart';
import 'image_detection/capturing_metadata/example_get_metadata.dart';
import 'image_picker/image_picker.dart';

class SideBar extends StatefulWidget {
  const SideBar({Key key}) : super(key: key);

  @override
  _SideBarState createState() => _SideBarState();
}

class _SideBarState extends State<SideBar> {
  Widget currentScreen = FlexBasicDashboard();
  final PageStorageBucket bucket = PageStorageBucket();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: PageStorage(bucket: bucket, child: currentScreen),
      drawer: ClipRRect(
        borderRadius: BorderRadius.only(
            topRight: Radius.circular(20.0),
            bottomRight: Radius.circular(20.0)),
        child: Drawer(
          child: Column(
            children: [
              Container(
                height: 115.0,
                width: 100.0,
                decoration: BoxDecoration(
                  color: Theme.of(context).primaryColor,
                  image: DecorationImage(
                    image: AssetImage('images/flex_logo.png'),
                  ),
                ),
              ),
              Divider(),
              Column(children: [
                buildSideBar(
                    Icons.book_outlined, 'Audit', FlexBasicDashboard()),
                buildSideBar(
                    Icons.subscriptions_outlined, 'Subscriptions', Draw()),
                buildSideBar(Icons.person_outline, 'Profile', MyPage()),
                buildSideBar(
                    Icons.settings_outlined, 'Settings', GetMetaData()),
                buildSideBar(
                    Icons.exit_to_app_outlined, 'Logout', LoginSignupScreen()),
              ])
            ],
          ),
        ),
      ),
    );
  }

  buildSideBar(IconData icon, String text, dynamic screen) {
    return Container(
      child: Column(
        mainAxisAlignment: MainAxisAlignment.spaceAround,
        children: [
          GestureDetector(
            onTap: () {
              setState(() {
                currentScreen = screen;
              });
            },
            child: Row(
              children: [
                VerticalDivider(
                  color: Colors.transparent,
                ),
                Icon(
                  icon,
                  color: Theme.of(context).primaryColor,
                ),
                VerticalDivider(color: Colors.transparent),
                Text(
                  text,
                )
              ],
            ),
          ),
          Divider(
            color: Colors.transparent,
          )
        ],
      ),
    );
  }
}

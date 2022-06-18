import 'dart:async';

import 'package:flex/constants/routing_constants.dart';
import 'package:flex/screens/components/flex_buttons.dart';
import 'package:flex/providers/app_state.dart';
import 'package:flutter/material.dart';
import 'package:flex/screens/authentication/authentication.dart';
import 'package:flutter_easyloading/flutter_easyloading.dart';
import 'package:provider/provider.dart';

class LoginSignupScreen extends StatefulWidget {
  @override
  _LoginSignupScreenState createState() => _LoginSignupScreenState();
}

class _LoginSignupScreenState extends State<LoginSignupScreen> {
  bool isSignupScreen = false;

  final username = TextEditingController();
  final password = TextEditingController();
  var _futureLogin;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Container(
        decoration: BoxDecoration(
          image: DecorationImage(
            image: AssetImage('images/R.jpg'),
            fit: BoxFit.cover,
          ),
        ),
        child: Stack(
          children: [
            Positioned(
              top: 100,
              right: 0,
              left: 0,
              child: Container(
                height: 50,
                width: 80,
                child: Image.asset('images/flex_logo.png'),
              ),
            ),
            buildBottomHalfContainer(true),
            AnimatedPositioned(
              duration: Duration(milliseconds: 700),
              curve: Curves.bounceInOut,
              top: 210,
              child: AnimatedContainer(
                duration: Duration(milliseconds: 700),
                curve: Curves.bounceInOut,
                height: 260,
                padding: EdgeInsets.all(20),
                width: MediaQuery.of(context).size.width - 40,
                margin: EdgeInsets.symmetric(horizontal: 20),
                decoration: BoxDecoration(
                    color: Colors.white,
                    borderRadius: BorderRadius.circular(15),
                    boxShadow: [
                      BoxShadow(
                          color: Colors.black.withOpacity(0.3),
                          blurRadius: 15,
                          spreadRadius: 5),
                    ]),
                child: SingleChildScrollView(
                  child: Column(
                    children: [buildSigninSection()],
                  ),
                ),
              ),
            ),
            buildBottomHalfContainer(false),
            Positioned(
              top: 505,
              left: 135,
              child: TextButton(
                onPressed: () {
                  Navigator.of(context).pushNamed(RoutingConstants.dashboard);
                },
                child: Text("Request Access",
                    style: TextStyle(
                        fontSize: 15,
                        color: Colors.white,
                        fontWeight: FontWeight.bold)),
              ),
            )
          ],
        ),
      ),
    );
  }

  Container buildSigninSection() {
    return Container(
      margin: EdgeInsets.only(top: 20),
      child: Column(
        children: [
          Text(
            "LOGIN",
            textAlign: TextAlign.left,
            style: TextStyle(fontWeight: FontWeight.bold),
          ),
          SizedBox(height: 10),
          buildTextField("FlexUser", 'Username', false, true, username),
          buildTextField("*********", 'Password', true, false, password),
        ],
      ),
    );
  }

  Widget buildBottomHalfContainer(bool showShadow) {
    return AnimatedPositioned(
      duration: Duration(milliseconds: 700),
      curve: Curves.bounceInOut,
      top: 440,
      right: 0,
      left: 0,
      child: Center(
        child: Container(
          height: 50,
          width: 140,
          decoration: BoxDecoration(
              color: Colors.white,
              borderRadius: BorderRadius.circular(80),
              boxShadow: [
                if (showShadow)
                  BoxShadow(
                    color: Colors.black.withOpacity(.3),
                    spreadRadius: 1.5,
                    blurRadius: 10,
                  )
              ]),
          child: !showShadow
              ? Container(
                  decoration: BoxDecoration(
                      borderRadius: BorderRadius.circular(80),
                      boxShadow: [
                        BoxShadow(
                            color: Colors.black.withOpacity(.3),
                            spreadRadius: 1,
                            blurRadius: 2,
                            offset: Offset(0, 1))
                      ]),
                  child: DefaultFlexButton(
                    displayText: 'LOGIN',
                    fillcolor: true,
                    press: () {
                      setState(() {
                        login();
                      });
                    },
                  ),
                )
              : Center(),
        ),
      ),
    );
  }

  void initStorage() {
    Provider.of<AppState>(context, listen: false).getCompletedAudits();
    Provider.of<AppState>(context, listen: false).getRecentAudits();
  }

  Future login() async {
    await EasyLoading.show(
      status: 'loading...',
    );

    _futureLogin =
        await AuthenticationController().logIn(username.text, password.text);

    if (!!_futureLogin) {
      await EasyLoading.showError('Invalid', duration: Duration(seconds: 2));
    } else {
      await EasyLoading.showSuccess("Success", duration: Duration(seconds: 2));
      initStorage();
      Navigator.of(context).pushReplacementNamed(RoutingConstants.home);
    }

    EasyLoading.dismiss();
  }

  Widget buildTextField(String hintText, String labelText, bool isPassword,
      bool isEmail, TextEditingController controller) {
    return Padding(
      padding: const EdgeInsets.only(bottom: 8.0),
      child: TextField(
        controller: controller,
        obscureText: isPassword,
        keyboardType: isEmail ? TextInputType.emailAddress : TextInputType.text,
        decoration: InputDecoration(
          contentPadding: EdgeInsets.all(10),
          hintText: hintText,
          labelText: labelText,
        ),
      ),
    );
  }
}

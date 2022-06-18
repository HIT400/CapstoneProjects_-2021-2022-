import 'package:flex/constants/routing_constants.dart';
import 'package:flex/models/onboarding_content.dart';
import 'package:flex/screens/components/flex_buttons.dart';
import 'package:flutter/material.dart';

class Onboarding extends StatefulWidget {
  @override
  _OnboardingState createState() => _OnboardingState();
}

class _OnboardingState extends State<Onboarding> {
  int currentIndex = 0;
  PageController _controller;

  @override
  void initState() {
    _controller = PageController(initialPage: 0);
    super.initState();
  }

  @override
  void dispose() {
    _controller.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Column(
        children: [
          Expanded(
            child: PageView.builder(
              controller: _controller,
              itemCount: contents.length,
              onPageChanged: (int index) {
                setState(() {
                  currentIndex = index;
                });
              },
              itemBuilder: (_, i) {
                return Column(
                  children: [
                    Expanded(
                      flex: 5,
                      child: Container(
                        color: Colors.white,
                        height: MediaQuery.of(context).size.height / 1.8,
                        width: 600.0,
                        child: ClipPath(
                          // clipper: CurvedCustomClipper(contents[i].curveLeft),
                          child: Image.asset(
                            contents[i].image,
                            fit: BoxFit.fill,
                          ),
                        ),
                      ),
                    ),
                    // Spacer(
                    //   flex: 1,
                    // ),
                    Row(
                      children: [
                        Padding(
                          padding:
                              const EdgeInsets.fromLTRB(40.0, 20.0, 40.0, 0.0),
                          child: Text(
                            contents[i].title,
                            textAlign: TextAlign.left,
                            style: TextStyle(
                                fontSize: 20,
                                fontWeight: FontWeight.bold,
                                fontStyle: FontStyle.normal),
                          ),
                        ),
                      ],
                    ),
                    Padding(
                      padding:
                          const EdgeInsets.fromLTRB(40.0, 20.0, 40.0, 20.0),
                      child: Text(
                        contents[i].description,
                        textAlign: TextAlign.left,
                        style: TextStyle(
                          fontSize: 12,
                          color: Colors.grey,
                        ),
                      ),
                    ),
                  ],
                );
              },
            ),
          ),
          Padding(
            padding: const EdgeInsets.fromLTRB(40.0, 0.0, 40.0, 0.0),
            child: Container(
              child: Row(
                mainAxisAlignment: MainAxisAlignment.start,
                children: List.generate(
                  contents.length,
                  (index) => buildDot(index, context),
                ),
              ),
            ),
          ),
          Row(
            children: [
              Expanded( flex: 1,
                child: Container(
                  height: 50,
                  width: 150,
                  margin: EdgeInsets.fromLTRB(40.0, 60.0, 0.0, 40.0),
                  child: DefaultFlexButton(
                      displayText: 'SKIP',
                      fillcolor: true,
                      press: () => {
                            Navigator.of(context).pushReplacementNamed(RoutingConstants.login)
                          }),
                ),
              ),
              SizedBox(width: 24),
              Expanded( flex: 1,
                child: Container(
                  height: 50,
                  width: 150,
                  margin: EdgeInsets.fromLTRB(0.0, 60.0, 40.0, 40.0),
                  child: DefaultFlexButton(
                    fillcolor: false,
                    displayText: 'NEXT',
                    press: () => {
                      if (currentIndex == contents.length - 1)
                        Navigator.of(context).pushReplacementNamed(RoutingConstants.login),
                      _controller.nextPage(
                        duration: Duration(milliseconds: 100),
                        curve: Curves.bounceIn,
                      )
                    },
                  ),
                ),
              )
            ],
          )
        ],
      ),
    );
  }

  Container buildDot(int index, BuildContext context) {
    return Container(
      height: 10,
      width: currentIndex == index ? 25 : 10,
      margin: EdgeInsets.only(right: 5),
      decoration: BoxDecoration(
        borderRadius: BorderRadius.circular(20),
        color: Theme.of(context).primaryColor,
      ),
    );
  }
}

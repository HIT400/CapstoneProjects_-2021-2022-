import 'package:flex/screens/assessments/floor_plan/show_floor_plan.dart';
import 'package:flex/screens/components/app_bar.dart';
import 'package:flex/screens/components/flex_expanded_rounded.dart';
import 'package:flutter/material.dart';

class Map extends StatefulWidget {
  const Map({Key key}) : super(key: key);

  @override
  _MapState createState() => _MapState();
}

class _MapState extends State<Map> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Color(0XFFEFF0F2),
      extendBodyBehindAppBar: true,
      appBar: PreferredSize(
        preferredSize: const Size(double.infinity, kToolbarHeight),
        child: DefaultFlexAppBar(),
      ),
      body: Stack(
        clipBehavior: Clip.none,
        children: <Widget>[
          Container(
            height: MediaQuery.of(context).size.width / 2,
            width: MediaQuery.of(context).size.width,
            decoration: BoxDecoration(
              image: DecorationImage(
                  image: AssetImage("images/R.jpg"), fit: BoxFit.cover),
            ),
          ),
          SizedBox.expand(
            child: DraggableScrollableSheet(
              initialChildSize: 0.75,
              maxChildSize: 0.97,
              minChildSize: 0.75,
              builder:
                  (BuildContext context, ScrollController scrollController) {
                return FlexRoundedExpanded(
                  child: ListView(
                    children: [
                      Container(
                        child: Center(
                          child: Container(
                            margin: EdgeInsets.only(top: 20),
                            height: MediaQuery.of(context).size.width - 128,
                            width: MediaQuery.of(context).size.width,
                            decoration: BoxDecoration(
                              color: Colors.white,
                              boxShadow: [
                                BoxShadow(
                                  color: Colors.grey.withOpacity(0.5),
                                  spreadRadius: 5,
                                  blurRadius: 7,
                                  offset: Offset(0, 3),
                                ),
                              ],
                            ),
                            child: FlexDraggableMarker(),
                          ),
                        ),
                      ),
                      Container(
                        child: Center(
                          child: Container(
                            margin: EdgeInsets.only(top: 20),
                            height: MediaQuery.of(context).size.width - 128,
                            width: MediaQuery.of(context).size.width,
                            decoration: BoxDecoration(
                              color: Colors.white,
                              boxShadow: [
                                BoxShadow(
                                  color: Colors.grey.withOpacity(0.5),
                                  spreadRadius: 5,
                                  blurRadius: 7,
                                  offset: Offset(0, 3),
                                ),
                              ],
                            ),
                            child: FlexDraggableMarker(),
                          ),
                        ),
                      ),
                    ],
                  ),
                );
              },
            ),
          ),
        ],
      ),
    );
  }
}

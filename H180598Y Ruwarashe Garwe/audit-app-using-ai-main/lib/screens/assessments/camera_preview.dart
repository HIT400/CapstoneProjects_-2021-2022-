import 'package:flutter/material.dart';
import 'package:flutter/services.dart';

class CameraWindow extends StatefulWidget {
  @override
  _CameraWindowState createState() => _CameraWindowState();
}

class _CameraWindowState extends State<CameraWindow> {
  @override
  void initState() {
    super.initState();
    SystemChrome.setPreferredOrientations([
      DeviceOrientation.landscapeRight,
      DeviceOrientation.landscapeLeft,
    ]);
  }

  @override
  void dispose() {
    super.dispose();
    SystemChrome.setPreferredOrientations([
      DeviceOrientation.landscapeRight,
      DeviceOrientation.landscapeLeft,
      DeviceOrientation.portraitUp,
      DeviceOrientation.portraitDown,
    ]);
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Colors.transparent,
      body: Container(
        padding: EdgeInsets.all(5.0),
        width: MediaQuery.of(context).size.width,
        height: MediaQuery.of(context).size.height,
        child: Stack(
          alignment: Alignment.bottomCenter,
          children: <Widget>[
            Positioned(
              top: 0,
              right: 0,
              child: Container(
                height: 60,
                width: 60,
                child: Icon(
                  Icons.menu,
                  size: 40,
                  color: Color(0xFFFF4C99),
                ),
              ),
            ),
            Positioned(
                width: 100,
                left: 0,
                top: 0,
                child: Container(
                  padding: EdgeInsets.only(top: 50, left: 0),
                  child: Column(
                    mainAxisAlignment: MainAxisAlignment.center,
                    children: <Widget>[
                      buildActionButtonColumn("MAP", false),
                      buildActionButtonColumn("Inspect", false),
                      buildActionButtonColumn("Camera", true),
                    ],
                  ),
                )),
            Positioned(
                left: 100,
                top: 0,
                child: Container(
                  padding: EdgeInsets.only(top: 15.0),
                  height: 60,
                  width: 60,
                  child: Center(
                    child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: <Widget>[
                          Row(
                            mainAxisAlignment: MainAxisAlignment.start,
                            children: <Widget>[
                              new Text("Progress:",
                                  style: TextStyle(
                                      color: Color(0xFFFF28FF),
                                      fontWeight: FontWeight.w900,
                                      fontSize: 12)),
                            ],
                          ),
                          Row(
                            mainAxisAlignment: MainAxisAlignment.start,
                            children: [
                              Text("Steps:",
                                  style: TextStyle(
                                      color: Color(0xFFFF28FF),
                                      fontWeight: FontWeight.w900,
                                      fontSize: 12))
                            ],
                          ),
                        ]),
                  ),
                ))
          ],
        ),
      ),
      floatingActionButton: FloatingActionButton(
        backgroundColor: Color(0xFFFF4C99),
        child: Icon(Icons.settings),
        onPressed: () {},
        mini: false,
      ),
    );
  }

  Widget buildActionButtonColumn(String text, bool isSelected) {
    return GestureDetector(
      onTap: () {
        setState(() {
          isSelected = !isSelected;
        });
      },
      child: Container(
        margin: EdgeInsets.only(bottom: 0),
        height: 70,
        width: 60,
        decoration: BoxDecoration(
          border: Border.all(color: Color(0xFF000000)),
          color:
              isSelected ? Color(0xFFFF28FF) : Color(0xFFFF28FF).withAlpha(100),
          borderRadius: BorderRadius.only(
            topLeft: Radius.circular(12),
            bottomRight: Radius.circular(12),
          ),
        ),
        child: Center(
          child: Text(
            text,
            style: TextStyle(fontSize: 10, fontWeight: FontWeight.bold),
          ),
        ),
      ),
    );
  }
}

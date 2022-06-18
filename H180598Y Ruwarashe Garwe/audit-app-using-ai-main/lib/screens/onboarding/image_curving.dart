import 'package:flutter/rendering.dart';

// Drawing or Render starts from top left as (0.0, 0.0)
// x-axis: width increases right side
// y-axis height increases downwards
class CurvedCustomClipper extends CustomClipper<Path> {
  bool _curveLeft;
  CurvedCustomClipper(bool curveLeft) {
    _curveLeft = curveLeft;
  }

  @override
  Path getClip(Size size) {
    if (_curveLeft) {
      var secondControlPoint = new Offset(size.width - 350, size.height);
      var secondEndPoint = new Offset(size.width, size.height - 120);
      var path = Path()
        ..lineTo(size.width - 355, size.height - 40)
        ..quadraticBezierTo(secondControlPoint.dx, secondControlPoint.dy,
            secondEndPoint.dx, secondEndPoint.dy)
        ..lineTo(size.width, 0.0)
        ..close();
      return path;
    }

    return Path()
      ..lineTo(size.width + 10, 0.0)
      ..lineTo(size.width - 50, size.height - 50)
      ..lineTo(0.0, size.height - 95)
      ..close();
  }

  @override
  bool shouldReclip(covariant CustomClipper<Path> oldClipper) {
    return true;
  }
}

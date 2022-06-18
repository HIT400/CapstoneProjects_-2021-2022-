import 'dart:ui';
import 'package:flex/models/draw_model.dart.dart';
import 'package:flutter/material.dart';

class DrawingPainter extends CustomPainter {
  final List<TouchPoints> drawPoints;

  DrawingPainter(this.drawPoints);

  @override
  void paint(Canvas canvas, Size size) {
    for (var i = 0; i < (drawPoints.length - 1); i++) {
      if (drawPoints[i] == null) continue;

      if (drawPoints[i + 1] != null) {
        // Drawing line when two consecutive points are available
        canvas.drawLine(drawPoints[i].points, drawPoints[i + 1].points,
            drawPoints[i].paint);
      } else {
        List<Offset> offsetList = [drawPoints[i].points];
        canvas.drawPoints(PointMode.points, offsetList, drawPoints[i].paint);
      }
    }
  }

  @override
  bool shouldRepaint(covariant CustomPainter oldDelegate) {
    // throw UnimplementedError();
    return true;
  }
}

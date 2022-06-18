// import 'dart:typed_data';
// import 'package:flutter/cupertino.dart';
// import 'package:flutter/rendering.dart';
// import 'package:image_gallery_saver/image_gallery_saver.dart';
// import 'dart:ui' as ui;
// import 'package:permission_handler/permission_handler.dart';

// class ImageAnnotationController {
//   Future<void> save(GlobalKey repaintBoundaryKey) async {
//     final RenderRepaintBoundary boundary = repaintBoundaryKey.currentContext
//         .findRenderObject() as RenderRepaintBoundary;
//     ui.Image image = await boundary.toImage();
//     ByteData byteData = await image.toByteData(format: ui.ImageByteFormat.png);
//     Uint8List uint8list = byteData.buffer.asUint8List();

//     if (!(await Permission.storage.status.isGranted))
//       Permission.storage.request();

//     final result = ImageGallerySaver.saveImage(Uint8List.fromList(uint8list),
//         quality: 60, name: "saved_" + DateTime.now().toString());
//     print(result);
//   }
// }

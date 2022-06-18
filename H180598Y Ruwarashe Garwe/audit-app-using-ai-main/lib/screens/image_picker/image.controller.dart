import 'dart:io';

import 'package:image_picker/image_picker.dart';

class FlexImageController {
  static Future<File> getImage(ImageSource source) async {
    var selectedFile = await ImagePicker().getImage(source: source);
    return File(selectedFile.path);
  }
}

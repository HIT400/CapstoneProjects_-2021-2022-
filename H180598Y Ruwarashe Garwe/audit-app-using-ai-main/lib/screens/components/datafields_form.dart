import 'dart:convert';
import 'dart:io';

import 'package:flex/models/assessment_template_model.dart';
import 'package:flex/screens/image_picker/image.controller.dart';
import 'package:flex/themes/style.dart';
import 'package:flutter/material.dart';
import 'package:image_picker/image_picker.dart';

import 'flex_text_form_field.dart';

class DataFieldsForm extends StatefulWidget {
  final List<Fields> datafields;
  DataFieldsForm({Key key, @required this.datafields}) : super(key: key);

  @override
  _DataFieldsFormState createState() => _DataFieldsFormState();
}

class _DataFieldsFormState extends State<DataFieldsForm> {
  Future<File> file;
  bool _completed = true;
  String base64Image;
  File tmpFile;

  @override
  Widget build(BuildContext context) {
    return Column(children: _buildTemplateDataFields());
  }

  chooseImage() {
    setState(() {
      file = FlexImageController.getImage(ImageSource.gallery);
    });
  }

  List<Widget> _buildTemplateDataFields() {
    List<Widget> fieldWidgets = [];
    var datafields = widget.datafields;
    
    if (datafields.isEmpty) return [];

    datafields?.forEach(
      (element) {
        var question = element.prompt;
        switch (element?.dataType) {
          case 1: //shorttext
            fieldWidgets.add(FlexTextFormField(labelText: question));
            break;
          case 2: //longtext
            fieldWidgets.add(FlexTextFormField(labelText: question));
            break;
          case 3: //date
            fieldWidgets.add(FlexTextFormField(labelText: question));
            break;
          case 4: //datetime
            fieldWidgets.add(FlexTextFormField(labelText: question));
            break;
          case 5: //integer
            fieldWidgets.add(FlexTextFormField(labelText: question));
            break;
          case 6: //float
            fieldWidgets.add(FlexTextFormField(labelText: question));
            break;
          case 7: //image
            fieldWidgets.add(_imageField(question));
            break;
          case 8: //boolean
            fieldWidgets.add(
              buildCheckBox(
                labelText: question,
                value: _completed,
                onchanged: (value) {
                  setState(
                    () {
                      _completed = !_completed;
                    },
                  );
                },
              ),
            );
            break;
        }
      },
    );

    return fieldWidgets;
  }

  Column _imageField(labelText) {
    return Column(
      mainAxisSize: MainAxisSize.min,
      crossAxisAlignment: CrossAxisAlignment.stretch,
      children: <Widget>[
        OutlinedButton(
          onPressed: chooseImage,
          child: Text(labelText),
        ),
        SizedBox(
          width: 20,
        ),
        showImage(),
        SizedBox(
          height: 20.0,
        ),
        SizedBox(
          height: 20.0,
        ),
      ],
    );
  }

  Widget showImage() {
    return FutureBuilder<File>(
      future: file,
      builder: (BuildContext context, AsyncSnapshot<File> snapshot) {
        if (snapshot.connectionState == ConnectionState.done &&
            null != snapshot.data) {
          tmpFile = snapshot.data;
          base64Image = base64Encode(snapshot.data.readAsBytesSync());
          return Flexible(
            child: Image.file(
              snapshot.data,
              fit: BoxFit.fill,
            ),
          );
        } else if (null != snapshot.error) {
          return const Text(
            'Error Picking Image',
            textAlign: TextAlign.center,
          );
        } else {
          return const Text(
            'No Image Selected',
            textAlign: TextAlign.center,
          );
        }
      },
    );
  }

  Row buildCheckBox({String labelText, Function onchanged, bool value}) {
// Pass onchanged as null for disabling button
    return Row(
      children: [
        Checkbox(
            value: value,
            activeColor: appTheme().primaryColor,
            onChanged: onchanged),
        Text(labelText, style: TextStyle(fontSize: 12))
      ],
    );
  }
}

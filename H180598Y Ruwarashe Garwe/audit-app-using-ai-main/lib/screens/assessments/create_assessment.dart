import 'dart:convert';
import 'dart:io';

import 'package:flex/config/pallete.dart';
import 'package:flex/models/assessment_model.dart';
import 'package:flex/screens/assessments/assessment.controller.dart';
import 'package:flex/screens/image_picker/image.controller.dart';
import 'package:flex/validations/create_assessment_validation.dart';
import 'package:flutter/material.dart';
import 'package:image_picker/image_picker.dart';
import 'package:provider/provider.dart';
import 'package:toast/toast.dart';

class CreateAssessment extends StatefulWidget {
  const CreateAssessment({Key key}) : super(key: key);

  @override
  _CreateAssessmentState createState() => _CreateAssessmentState();
}

class _CreateAssessmentState extends State<CreateAssessment> {
  var _postAssessment;
  bool isDate, _reportAvailable = true, _completed = true;
  var assessment;
  Future<File> file;
  String status = '';
  String base64Image;
  File tmpFile;
  String errMessage = 'Error Uploading Image';

  TextEditingController _createdBy = new TextEditingController();
  TextEditingController _description =
      new TextEditingController(text: "hell no");
  TextEditingController _organisationId = new TextEditingController();
  TextEditingController _assessmentTemplateId = new TextEditingController();

  @override
  void initState() {
    super.initState();
  }

  chooseImage() {
    setState(() {
      file = FlexImageController.getImage(ImageSource.gallery);
    });
  }

  void postAssessment() async {
    _postAssessment = await AssessmentController().upload(assessment);

    if (!_postAssessment) {
      Toast.show("Assessment creation failed", context,
          duration: Toast.LENGTH_LONG, gravity: Toast.BOTTOM);
    } else {
      Toast.show("Assessment created successfully", context,
          duration: Toast.LENGTH_LONG, gravity: Toast.BOTTOM);
    }
  }

  @override
  Widget build(BuildContext context) {
    var validationSerice = Provider.of<CreateAssessmentValidator>(context);
    return Scaffold(
      body: Padding(
        padding: const EdgeInsets.all(20.0),
        child: ListView(
          children: <Widget>[
            buildTextField(
                Icons.text_fields_outlined,
                'Created by',
                validationSerice.createdBy.error,
                false,
                this._createdBy,
                validationSerice.onChangedCreatedBy),
            buildTextField(
                Icons.edit_attributes,
                'Description',
                validationSerice.description.error,
                false,
                _description,
                validationSerice.onChangedDecription),
            buildTextField(
                Icons.person_outline_outlined,
                'Assessment Template',
                validationSerice.assessmentTemplateId.error,
                false,
                _assessmentTemplateId,
                validationSerice.onChangedAssessmentTemplateId),
            buildTextField(
                Icons.domain_rounded,
                'Organisation',
                validationSerice.organisationId.error,
                false,
                _organisationId,
                validationSerice.onChangedOrganisation),
            Row(
              mainAxisAlignment: MainAxisAlignment.spaceBetween,
              children: [
                Row(
                  children: [
                    Checkbox(
                      value: _completed,
                      activeColor: Palette.textColor2,
                      onChanged: (value) {
                        setState(() {
                          _completed = !_completed;
                        });
                      },
                    ),
                    Text("Completed",
                        style:
                            TextStyle(fontSize: 12, color: Palette.textColor1))
                  ],
                ),
                Row(
                  children: [
                    Checkbox(
                      value: _reportAvailable,
                      activeColor: Palette.textColor2,
                      onChanged: (value) {
                        setState(() {
                          _reportAvailable = !_reportAvailable;
                        });
                      },
                    ),
                    Text("Report availbale",
                        style:
                            TextStyle(fontSize: 12, color: Palette.textColor1))
                  ],
                ),
              ],
            ),
            Column(
              mainAxisSize: MainAxisSize.min,
              crossAxisAlignment: CrossAxisAlignment.stretch,
              children: <Widget>[
                OutlinedButton(
                  onPressed: chooseImage,
                  child: Text('Choose Image'),
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
            ),
            ElevatedButton(
                child: Text("Submit"),
                onPressed: () {
                  setState(() {
                    assessment = AssessmentModel(
                        // createdBy: int.parse(this._createdBy.text),
                        //organisationId: int.parse(_organisationId.text),
                        // assessmentTemplateId:
                        //     int.parse(_assessmentTemplateId.text),
                        description: _description.text,
                        dateCompleted: "15/07/21",
                        completed: _completed,
                        reportAvailable: _reportAvailable);
                  });
                  postAssessment();
                })
          ],
        ),
      ),
    );
  }

  TextField buildInputField(String label, String errorText, onPressed,
      TextEditingController controller) {
    return TextField(
      controller: controller,
      decoration: InputDecoration(
        focusColor: Colors.blueAccent,
        labelStyle: TextStyle(color: Colors.blueAccent),
        labelText: label,
        errorText: errorText,
      ),
      onChanged: onPressed,
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

  Widget buildTextField(IconData icon, String hintText, String errorText,
      bool isDate, TextEditingController controller, onChanged) {
    return Padding(
      padding: const EdgeInsets.only(bottom: 8.0, top: 8.0),
      child: TextField(
        controller: controller,
        obscureText: false,
        keyboardType: isDate ? TextInputType.datetime : TextInputType.text,
        decoration: InputDecoration(
          prefixIcon: Icon(
            icon,
            color: Palette.iconColor,
          ),
          enabledBorder: OutlineInputBorder(
            borderSide: BorderSide(color: Palette.textColor1),
            borderRadius: BorderRadius.all(Radius.circular(15.0)),
          ),
          focusedBorder: OutlineInputBorder(
            borderSide: BorderSide(color: Palette.textColor1),
            borderRadius: BorderRadius.all(Radius.circular(15.0)),
          ),
          contentPadding: EdgeInsets.all(10),
          hintText: hintText,
          hintStyle: TextStyle(fontSize: 14, color: Palette.textColor1),
          errorText: errorText,
          errorBorder: OutlineInputBorder(
            borderSide: BorderSide(color: Colors.red[500]),
            borderRadius: BorderRadius.all(Radius.circular(15.0)),
          ),
          focusedErrorBorder: OutlineInputBorder(
            borderSide: BorderSide(color: Colors.red[500]),
            borderRadius: BorderRadius.all(Radius.circular(15.0)),
          ),
        ),
        onChanged: onChanged,
      ),
    );
  }
}

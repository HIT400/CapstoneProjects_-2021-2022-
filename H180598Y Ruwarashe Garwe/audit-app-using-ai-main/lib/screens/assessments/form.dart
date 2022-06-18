import 'package:flex/models/assessment_template_model.dart';
import 'package:flex/models/section_model.dart';
import 'package:flex/providers/app_state.dart';
import 'package:flex/themes/style.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:provider/provider.dart';

class FlexForm extends StatefulWidget {
  const FlexForm({Key key}) : super(key: key);

  @override
  _FlexFormState createState() => _FlexFormState();
}

class _FlexFormState extends State<FlexForm> {
  List<TextEditingController> controllers;
  List<bool> visibles;
  List<Section> sections = <Section>[];

  List<AssessmentTemplateModel> assessmentTemplates = [];
  void initState() {
    super.initState();
  }

  void didChangeDependencies() {
    super.didChangeDependencies();
    xxx();
    // sections = assessmentTemplates[0].section;

    // controllers = List.generate(
    //     sections[0].fields.length, (index) => TextEditingController());
    // visibles = List.generate(sections[0].fields.length, (index) => false);
  }

  Future<void> xxx() async {
    await Provider.of<AppState>(context).getCompletedAudits();

    sections = Provider.of<AppState>(context).assessmentTemplates[0].section;
  }

  @override
  Widget build(BuildContext context) {
    GlobalKey<FormState> _formKey;
    return Scaffold(
      appBar: AppBar(
        title: Text("Form"),
      ),
      body: Container(
        // get list of sections
        // extract data fields
        // for each datafield build a ui item with input and follops
        // add visibility widget to hide the follow up
        // (un)hide follow up accordingly
        child: Form(
          key: _formKey,
          child: FutureBuilder(
            future: xxx(),
            builder: (context, snapshot) {
              return Column(
                children: buildDataFields,
              );
            },
          ),
        ),
      ),
    );
  }

  List<Widget> get buildDataFields {
    return List.generate(
      sections[0].fields.length,
      (index) => Column(
        children: [
          FlexTextFormField(
            labelText: sections[0].fields[index].prompt,
            controller: controllers[index],
            onEditingComplete: () {
              if (sections[0]
                      .fields[index]
                      .followUpQuestion
                      .followUp[0]
                      .triggerAnswer ==
                  controllers[index].text) {
                setState(() {
                  visibles[index] = true;
                });
              } else {
                setState(() {
                  visibles[index] = false;
                });
              }
            },
          ),
          Visibility(
            visible: visibles[index],
            child: FlexTextFormField(
              labelText:
                  sections[0].fields[index].followUpQuestion.followUp[0].prompt,
            ),
          ),
        ],
      ),
    ).toList();
  }
}

class FlexDataFields extends StatefulWidget {
  final Fields datafiled;
  const FlexDataFields({Key key, @required this.datafiled}) : super(key: key);

  @override
  _FlexDataFieldsState createState() => _FlexDataFieldsState();
}

class _FlexDataFieldsState extends State<FlexDataFields> {
  TextEditingController controller = new TextEditingController();

  @override
  Widget build(BuildContext context) {
    return Container(
      // list to data field.follow_up
      child: Column(
        children: [
          buildInputField(widget.datafiled.prompt, controller),
          Visibility(
              visible:
                  widget.datafiled.followUpQuestion.followUp[0].triggerAnswer ==
                      controller.text,
              child: buildFollowUpInputField(
                  widget.datafiled.followUpQuestion.followUp[0].prompt,
                  controller))
        ],
      ),
    );
  }

  TextField buildInputField(String label, TextEditingController controller) {
    return TextField(
      controller: controller,
      decoration: InputDecoration(
        focusColor: Colors.blueGrey,
        labelStyle: TextStyle(color: Colors.blueGrey),
        labelText: label,
      ),
      onEditingComplete: () {
        setState(() {});
      },
    );
  }

  TextField buildFollowUpInputField(
      String label, TextEditingController controller) {
    return TextField(
      controller: controller,
      decoration: InputDecoration(
        focusColor: Colors.purpleAccent.shade100,
        labelStyle: TextStyle(color: Colors.purpleAccent.shade100),
        labelText: label,
      ),
    );
  }
}

class FlexTextFormField extends StatefulWidget {
  final Key key;
  final String hintText;
  final String labelText;
  final String initialValue;
  final bool enabled;
  final Function validator;
  final Function onEditingComplete;
  final Function onSaved;
  final bool isPassword;
  final bool isEmail;
  final TextEditingController controller;

  FlexTextFormField({
    this.initialValue,
    this.hintText,
    this.validator,
    this.onSaved,
    this.onEditingComplete,
    this.isPassword = false,
    this.isEmail = false,
    this.labelText,
    this.enabled = true,
    this.key,
    this.controller,
  });

  @override
  _FlexTextFormFieldState createState() => _FlexTextFormFieldState();
}

class _FlexTextFormFieldState extends State<FlexTextFormField> {
  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: EdgeInsets.all(8.0),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Text(widget.labelText),
          Divider(color: Colors.transparent),
          TextFormField(
            // key attribute is used to compare existing instance of a widget to new instance
            // and decide what to do next: create new state or use existing state, build new sub-tree or reuse existing
            //By making a Key of the reactive data (coming from api or somewhere), the form field will change every time the Key changes.
            key: Key(widget.initialValue),
            // initialValue: widget.initialValue ?? "",
            controller: widget.controller,
            decoration: InputDecoration(
              enabled: widget.enabled,
              filled: true,
              border: OutlineInputBorder(
                  borderRadius: BorderRadius.all(Radius.circular(10.0))),
              focusedBorder: OutlineInputBorder(
                borderRadius: BorderRadius.all(Radius.circular(10.0)),
                borderSide: BorderSide(color: appTheme().primaryColor),
              ),
              contentPadding: EdgeInsets.all(10.0),
              hintText: widget.hintText,
            ),
            obscureText: widget.isPassword ? true : false,
            validator: widget.validator,
            onSaved: widget.onSaved,
            onEditingComplete: widget.onEditingComplete,
            keyboardType: widget.isEmail
                ? TextInputType.emailAddress
                : TextInputType.text,
          ),
          Divider(
            color: Colors.transparent,
          )
        ],
      ),
    );
  }
}

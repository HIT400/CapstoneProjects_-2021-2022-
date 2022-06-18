import 'package:flex/themes/style.dart';
import 'package:flutter/material.dart';

class FlexTextFormField extends StatefulWidget {
  final Key key;
  final String hintText;
  final String labelText;
  final String initialValue;
  final bool enabled;
  final Function validator;
  final Function onSaved;
  final bool isPassword;
  final bool isEmail;

  FlexTextFormField({
    this.initialValue,
    this.hintText,
    this.validator,
    this.onSaved,
    this.isPassword = false,
    this.isEmail = false,
    this.labelText,
    this.enabled = true,
    this.key,
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
          Divider(
            color: Colors.transparent,
          ),
          TextFormField(
            // key attribute is used to compare existing instance of a widget to new instance
            // and decide what to do next: create new state or use existing state, build new sub-tree or reuse existing
            //By making a Key of the reactive data (coming from api or somewhere), the form field will change every time the Key changes.
            key: Key(widget.initialValue),
            initialValue: widget.initialValue ?? "",
            decoration: InputDecoration(
              enabled: widget.enabled,
              filled: true,
              border: OutlineInputBorder(
                  borderRadius: BorderRadius.all(Radius.circular(6.0))),
              focusedBorder: OutlineInputBorder(
                borderRadius: BorderRadius.all(Radius.circular(6.0)),
                borderSide: BorderSide(color: appTheme().primaryColor),
              ),
              contentPadding: EdgeInsets.all(10.0),
              hintText: widget.hintText,
            ),
            obscureText: widget.isPassword ? true : false,
            validator: widget.validator,
            onSaved: widget.onSaved,
            keyboardType: widget.isEmail
                ? TextInputType.emailAddress
                : TextInputType.text,
          ),
        ],
      ),
    );
  }
}

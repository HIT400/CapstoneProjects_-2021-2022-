import 'package:flex/models/inventory.dart';
import 'package:flex/providers/project_provider.dart';
import 'package:flex/screens/components/flex_buttons.dart';
import 'package:flex/screens/components/flex_switch.dart';
import 'package:flex/themes/style.dart';
import 'package:flutter/material.dart';
import 'dart:math' as math;

import 'package:provider/provider.dart';

class BindingBox extends StatelessWidget {
  final List<dynamic> results;
  final int previewH;
  final int previewW;
  final double screenH;
  final double screenW;
  final BuildContext context;

  BindingBox(
    this.results,
    this.previewH,
    this.previewW,
    this.screenH,
    this.screenW,
    this.context,
  );

  @override
  Widget build(BuildContext context) {
    List<Widget> _renderBox() {
      return results.map((re) {
        var _x = re["rect"]["x"];
        var _w = re["rect"]["w"];
        var _y = re["rect"]["y"];
        var _h = re["rect"]["h"];
        var scaleW, scaleH, x, y, w, h;

        if (screenH / screenW > previewH / previewW) {
          scaleW = screenH / previewH * previewW;
          scaleH = screenH;
          var difW = (scaleW - screenW) / scaleW;
          x = (_x - difW / 2) * scaleW;
          w = _w * scaleW;
          if (_x < difW / 2) w -= (difW / 2 - _x) * scaleW;
          y = _y * scaleH;
          h = _h * scaleH;
        } else {
          scaleH = screenW / previewW * previewH;
          scaleW = screenW;
          var difH = (scaleH - screenH) / scaleH;
          x = _x * scaleW;
          w = _w * scaleW;
          y = (_y - difH / 2) * scaleH;
          h = _h * scaleH;
          if (_y < difH / 2) h -= (difH / 2 - _y) * scaleH;
        }

        return Positioned(
          left: math.max(0, x),
          top: math.max(0, y),
          width: w,
          height: h,
          child: GestureDetector(
            onTap: () => showDialog(
              context: context,
              builder: (_) => new AlertDialog(
                insetPadding: EdgeInsets.symmetric(horizontal: 16),
                contentPadding: EdgeInsets.zero,
                clipBehavior: Clip.antiAliasWithSaveLayer,
                shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.all(Radius.circular(10.0))),
                content: Builder(
                  builder: (context) {
                    return buildNewProject(
                        "${re["detectedClass"]} (${(re["confidenceInClass"] * 100).toStringAsFixed(0)}% positive)?",
                        "${re["detectedClass"]}");
                  },
                ),
              ),
            ),
            child: Container(
              padding: EdgeInsets.only(top: 5.0, left: 5.0),
              decoration: BoxDecoration(
                border: Border.all(
                  color: appTheme().primaryColor,
                  width: 3.0,
                ),
              ),
              child: Text(
                "${re["detectedClass"]} ${(re["confidenceInClass"] * 100).toStringAsFixed(0)}%",
                style: TextStyle(
                  color: appTheme().primaryColor,
                  fontSize: 14.0,
                  fontWeight: FontWeight.bold,
                ),
              ),
            ),
          ),
        );
      }).toList();
    }

    return Stack(
      children: _renderBox(),
    );
  }

  Widget buildTextField(
      {String hintText, String labelText, TextEditingController controller}) {
    return AnimatedPadding(
      padding: EdgeInsets.only(
          bottom: MediaQuery.of(this.context).viewInsets.bottom),
      duration: Duration(milliseconds: 10),
      child: Padding(
        padding: const EdgeInsets.symmetric(vertical: 15.0),
        child: TextFormField(
          enabled: false,
          readOnly: true,
          decoration: InputDecoration(
            enabledBorder: OutlineInputBorder(
              borderRadius: BorderRadius.all(Radius.circular(10.0)),
            ),
            focusedBorder: OutlineInputBorder(
              borderRadius: BorderRadius.all(Radius.circular(10.0)),
            ),
            contentPadding: EdgeInsets.all(20),
            hintText: hintText,
            labelText: labelText,
            border: OutlineInputBorder(),
          ),
          validator: (value) {
            if (value.isEmpty) {
              return 'Field empty';
            }
            return null;
          },
        ),
      ),
    );
  }

  buildNewProject(String re, String reConfidence) {
    bool switchValue = false;
    int index;
    // Inventory inventory;

    return Container(
      width: MediaQuery.of(context).size.width,
      decoration: BoxDecoration(),
      padding: EdgeInsets.all(20),
      child: Column(
        mainAxisSize: MainAxisSize.min,
        children: [
          Row(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: [
              Container(
                padding: EdgeInsets.only(left: 120),
                child: Text(
                  'Confirm Item',
                  style: TextStyle(fontWeight: FontWeight.bold, fontSize: 16),
                ),
              ),
              IconButton(
                color: Theme.of(this.context).primaryColor,
                onPressed: () {
                  Navigator.pop(this.context);
                },
                icon: Icon(Icons.cancel_outlined),
              ),
            ],
          ),
          Divider(
            color: Colors.transparent,
          ),
          Row(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: [
              Text("Is this a " + reConfidence + "?"),
              SizedBox(
                width: 20,
              ),
              Transform.scale(
                scale: 1,
                child: BottomSheetSwitch(
                  switchValue: switchValue,
                ),
              ),
            ],
          ),
          Divider(
            color: Colors.transparent,
          ),
          Row(
            mainAxisAlignment: MainAxisAlignment.start,
            children: [
              Text("Define item"),
            ],
          ),
          Divider(
            color: Colors.transparent,
          ),
          buildTextField(hintText: re, labelText: re),
          // buildTextField(hintText: 'Fire Audit', labelText: 'Not Listed?'),
          SizedBox(
            height: 20,
          ),
          Row(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: [
              Container(
                width: 120,
                height: 45,
                child: DefaultFlexButton(
                    displayText: 'CANCEL',
                    fillcolor: false,
                    press: () {
                      Navigator.pop(this.context);
                    }),
              ),
              Container(
                  width: 120,
                  height: 45,
                  child: DefaultFlexButton(
                    displayText: 'SUBMIT',
                    fillcolor: true,
                    press: () {
                      // var inventory =
                      //     Provider.of<AppState>(context, listen: false);
                      // inventory.appendInventory(
                      //     new Inventory(name: reConfidence),
                      //     Provider.of<AppState>(context, listen: false).index);
                      // Navigator.of(context).pop();
                      Provider.of<Project>(context, listen: false).addInventory(
                          Items(
                              itemName: 'specs', description: 'blue', count: 1),
                          index);
                      Navigator.of(context).pop();
                    },
                  ))
            ],
          ),
        ],
      ),
    );
  }
}

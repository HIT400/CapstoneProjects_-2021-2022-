import 'package:flex/models/assessment_template_model.dart';
import 'package:flex/providers/project_provider.dart';
import 'package:flex/screens/assessments/new_project.dart';
import 'package:flex/storage/audit_storage.dart';
import 'package:flutter/material.dart';
import 'package:flutter_easyloading/flutter_easyloading.dart';
import 'package:provider/provider.dart';

class FlexDefaultCard extends StatefulWidget {
  final String title;
  final AssessmentTemplateModel template;
  FlexDefaultCard({
    Key key,
    @required this.title,
    @required this.context,
    @required this.template,
  }) : super(key: key);

  final BuildContext context;

  @override
  State<FlexDefaultCard> createState() => _FlexDefaultCardState();
}

class _FlexDefaultCardState extends State<FlexDefaultCard> {
  final AuditDao helper = new AuditDao();

  @override
  Widget build(BuildContext context) {
    return GestureDetector(
      onTap: () {
        EasyLoading.show(status: 'Loading');
        Provider.of<Project>(context, listen: false)
            .addTemplate(widget.template);
        EasyLoading.showSuccess('Success');

        Navigator.pop(context);

        showModalBottomSheet(
          isScrollControlled: true,
          shape: RoundedRectangleBorder(
            borderRadius: BorderRadius.vertical(
              top: Radius.circular(20.0),
            ),
          ),
          context: context,
          builder: (context) {
            return BuildNewProject();
          },
        );
      },
      child: FittedBox(
        child: Card(
          margin: EdgeInsets.symmetric(horizontal: 16),
          child: Container(
            padding: EdgeInsets.symmetric(
              vertical: 16,
              horizontal: 32,
            ),
            child: Column(
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
                Icon(
                  Icons.folder,
                  color: Colors.black,
                  size: 40,
                ),
                Text(
                  widget.title,
                  style: TextStyle(
                    fontWeight: FontWeight.bold,
                    color: Colors.black,
                  ),
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}

import 'dart:convert';
import 'package:flex/models/assessment_template_model.dart';
import 'package:flex/screens/dashboard/flex_basic_dashboard.dart';
import 'package:flex/screens/profile/profile.dart';
import 'package:flex/screens/settings/settings.dart';
import 'package:flex/providers/app_state.dart';
import 'package:flex/screens/subscriptions/subscriptions.dart';
import 'package:flex/storage/audit_storage.dart';
import 'package:flex/themes/style.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'components/flex_template_card.dart';

class Home extends StatefulWidget {
  @override
  State<StatefulWidget> createState() => HomeState();
}

class HomeState extends State<Home> {
  int currentTab = 0;
  List<AssessmentTemplateModel> assessmentTemplates = [];
  AuditDao helper = new AuditDao();

  final List<Widget> screen = [
    FlexBasicDashboard(),
    Subscriptions(),
    Settings(),
    Profile(),
  ];

  @override
  void initState() {
    super.initState();
  }

  @override
  void didChangeDependencies() {
    super.didChangeDependencies();

    getAssessmentAsync();
    helper.getAllaudits();

    Provider.of<AppState>(context, listen: false).getCompletedAudits();
    Provider.of<AppState>(context, listen: false).getRecentAudits();
  }

  Future getAssessmentAsync() async {
    await Provider.of<AppState>(context, listen: false).getTemplates();
    setState(() {
      assessmentTemplates =
          Provider.of<AppState>(context, listen: false).assessmentTemplates;
      print(jsonEncode(assessmentTemplates));
    });
  }

  Widget currentScreen = FlexBasicDashboard();

  final PageStorageBucket bucket = PageStorageBucket();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: PageStorage(
        child: currentScreen,
        bucket: bucket,
      ),
      floatingActionButtonLocation: FloatingActionButtonLocation.centerDocked,
      floatingActionButton: FloatingActionButton(
        backgroundColor: appTheme().primaryColor,
        onPressed: () => setState(() {
          showDialog(
            barrierColor: Color(0XFF2D3543).withOpacity(.9),
            barrierDismissible: true,
            context: context,
            builder: (BuildContext context) {
              return AlertDialog(
                backgroundColor: Colors.transparent,
                contentPadding: EdgeInsets.zero,
                elevation: 0.0,
                content: Column(
                  mainAxisAlignment: MainAxisAlignment.end,
                  children: [
                    Text(
                      "CREATE A NEW AUDIT",
                      style: TextStyle(
                          color: Colors.white,
                          fontSize: 20,
                          fontWeight: FontWeight.bold),
                      textAlign: TextAlign.center,
                    ),
                    SizedBox(
                      height: 60,
                    ),
                    Container(
                      width: MediaQuery.of(context).size.width,
                      height: 100,
                      child: ListView(
                        scrollDirection: Axis.horizontal,
                        children: buildTemplateCards(assessmentTemplates),
                      ),
                    ),
                    SizedBox(
                      height: 120,
                    ),
                  ],
                ),
              );
            },
          );
        }),
        child: Container(
          margin: EdgeInsets.all(15.0),
          child: Icon(Icons.add),
        ),
        elevation: 2.0,
      ),
      bottomNavigationBar: BottomAppBar(
        shape: CircularNotchedRectangle(),
        notchMargin: 4.0,
        child: Container(
          height: 80,
          width: MediaQuery.of(context).size.width,
          child: FittedBox(
            child: Row(
              mainAxisAlignment: MainAxisAlignment.spaceBetween,
              children: [
                Row(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    navigationButton(
                        'Home', Icons.layers_outlined, FlexBasicDashboard(), 1),
                    navigationButton(
                        'Subscriptions', Icons.support, Subscriptions(), 2),
                  ],
                ),
                Row(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    navigationButton(
                        'Settings', Icons.extension_outlined, Settings(), 3),
                    navigationButton(
                        'Profile', Icons.person_outlined, Profile(), 4)
                  ],
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }

  MaterialButton navigationButton(String text, IconData icon, screen, int tab) {
    return MaterialButton(
      minWidth: 35,
      child: Column(mainAxisAlignment: MainAxisAlignment.center, children: [
        Icon(
          icon,
          size: 35.0,
          color:
              currentTab == tab ? appTheme().primaryColor : Color(0xFFEDEDED),
        ),
        Text(
          text,
          style: TextStyle(
            color:
                currentTab == tab ? appTheme().primaryColor : Color(0xFFCFCFCF),
          ),
        ),
      ]),
      onPressed: () => setState(() {
        currentScreen = screen;
        currentTab = tab;
      }),
    );
  }

  List<Widget> buildTemplateCards(List<AssessmentTemplateModel> templates) {
    return templates
        .map(
          (_template) => FlexDefaultCard(
            title: _template.name,
            context: context,
            template: _template,
          ),
        )
        .toList();
  }
}

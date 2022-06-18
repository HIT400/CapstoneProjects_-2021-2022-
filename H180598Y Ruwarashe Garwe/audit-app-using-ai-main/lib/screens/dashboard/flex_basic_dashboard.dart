// ignore_for_file: deprecated_member_use

import 'package:flex/constants/routing_constants.dart';
import 'package:flex/models/assessment_model.dart';
import 'package:flex/providers/project_provider.dart';
import 'package:flex/screens/assessments/assessment_form.dart';
import 'package:flex/screens/authentication/login.dart';
import 'package:flex/screens/components/flex_basic_card.dart';
import 'package:flex/screens/components/flex_dashboard_text.dart';
import 'package:flex/providers/app_state.dart';
import 'package:flex/screens/image_annotation/image_annotation.dart';
import 'package:flex/screens/image_detection/capturing_metadata/example_get_metadata.dart';
import 'package:flex/screens/image_picker/image_picker.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:provider/provider.dart';

import '../side_bar.dart';

class FlexBasicDashboard extends StatefulWidget {
  const FlexBasicDashboard({Key key}) : super(key: key);

  @override
  _FlexBasicDashboardState createState() => _FlexBasicDashboardState();
}

class _FlexBasicDashboardState extends State<FlexBasicDashboard> {
  bool isLoading = false;
  AssessmentModel selectedProject;
  Widget currentScreen = FlexBasicDashboard();
  final PageStorageBucket bucket = PageStorageBucket();

  @override
  void initState() {
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Color(0XFFEFF0F2),
      extendBodyBehindAppBar: true,
      drawer: ClipRRect(
        borderRadius: BorderRadius.only(
            topRight: Radius.circular(20.0),
            bottomRight: Radius.circular(20.0)),
        child: Drawer(
          child: Column(
            children: [
              Container(
                height: 115.0,
                width: 100.0,
                decoration: BoxDecoration(
                  color: Theme.of(context).primaryColor,
                  image: DecorationImage(
                    image: AssetImage('images/flex_logo.png'),
                  ),
                ),
              ),
              Divider(),
              Column(children: [
                buildSideBar(
                    Icons.book_outlined, 'Audit', FlexBasicDashboard()),
                buildSideBar(
                    Icons.subscriptions_outlined, 'Subscriptions', Draw()),
                buildSideBar(Icons.person_outline, 'Profile', MyPage()),
                buildSideBar(
                    Icons.settings_outlined, 'Settings', GetMetaData()),
                buildSideBar(
                    Icons.exit_to_app_outlined, 'Logout', LoginSignupScreen()),
              ])
            ],
          ),
        ),
      ),
      appBar: AppBar(
        systemOverlayStyle: SystemUiOverlayStyle.light,
        brightness: Brightness.dark,
        automaticallyImplyLeading: false,
        backgroundColor: Colors.transparent,
        elevation: 0,
        title: Image.asset(
          'images/flex_logo.png',
          fit: BoxFit.cover,
          height: 30,
        ),
        actions: [
          Padding(
            padding: const EdgeInsets.all(10.0),
            child: Icon(Icons.search),
          ),
          Padding(
            padding: const EdgeInsets.all(10.0),
            child: Icon(Icons.menu),
          ),
        ],
      ),
      body: Column(
        mainAxisAlignment: MainAxisAlignment.start,
        children: [
          Container(
            height: MediaQuery.of(context).size.height / 3,
            width: MediaQuery.of(context).size.width,
            decoration: BoxDecoration(
                image: DecorationImage(
                    image: AssetImage("images/bg1.jpg"), fit: BoxFit.cover)),
            child: Container(
              padding: EdgeInsets.only(top: 90, left: 20),
              color: Colors.deepPurple.withOpacity(.3),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.center,
                children: [
                  SizedBox(
                    height: 100,
                  ),
                  RichText(
                    text: TextSpan(
                        text: "AUDIT",
                        style: TextStyle(
                          fontSize: 25,
                          letterSpacing: 2,
                          color: Colors.white70,
                        ),
                        children: [
                          TextSpan(
                            text: " SUMMARY",
                            style: TextStyle(
                              fontSize: 25,
                              letterSpacing: 2,
                              color: Colors.white70,
                            ),
                          )
                        ]),
                  ),
                  SizedBox(
                    height: 5,
                  ),
                ],
              ),
            ),
          ),
          Expanded(
            flex: 1,
            child: Container(
              padding: EdgeInsets.symmetric(horizontal: 20),
              child: ListView(
                padding: EdgeInsets.only(top: 5),
                children: [
                  Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      //Code smell below
                      //We should have a list here and loop that
                      //We create seperate file as onboarding content that is what we populate
                      //DRY DRY DRY
                      FlexDashboardTitle(
                        title: "Recent Audits",
                        color: Colors.black,
                      ),
                      Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: generateRecentAudits,
                      ),
                      FlexDashboardTitle(
                        title: "Completed Audits",
                        color: Colors.black,
                      ),
                      Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: generateCompletedAudits,
                      ),
                      FlexDashboardTitle(
                        title: "Open Audits",
                        color: Colors.black,
                      ),
                      FlexBasicCard(
                        morePress: () => {print("more pressed")},
                        editPress: () => {
                          Provider.of<Project>(context)
                              .readSelectedProject(selectedProject)
                        },
                        deletePress: () => {
                          // execute remove from db query
                          // Notify listeners
                          // Rerun a get request
                        },
                        icon: Icons.folder,
                        hasBadge: false,
                        title: "Dunkled Simrac",
                      ),
                    ],
                  ),
                ],
              ),
            ),
          ),
        ],
      ),
    );
  }

  List<Widget> get generateRecentAudits {
    List<dynamic> _recentAudits =
        Provider.of<AppState>(context, listen: true).recentAudits;

    if (_recentAudits.isEmpty) {
      return [
        FlexBasicCard(
          icon: Icons.folder,
          hasBadge: false,
          title: "No recent audits available",
          morePress: () => {print("more pressed")},
          editPress: () => {print("edit pressed")},
          deletePress: () => {print("edit pressed")},
        )
      ];
    }
    return _recentAudits
        .map(
          (assessmentModel) => FlexBasicCard(
            morePress: () => {print("more pressed")},
            editPress: () {
              Provider.of<Project>(context, listen: false)
                  .readSelectedProject(assessmentModel);
              setState(() {});
              Navigator.pushNamed(context, RoutingConstants.floorPlan);
            },
            deletePress: () {
              Provider.of<Project>(context, listen: false)
                  .removeProject(assessmentModel);
              _recentAudits.remove(assessmentModel);
              setState(() {});
            },
            icon: Icons.folder,
            hasBadge: false,
            title: assessmentModel.description,
          ),
        )
        .toList();
  }

  List<Widget> get generateCompletedAudits {
    List<dynamic> _completedAudits =
        Provider.of<AppState>(context, listen: false).completedAudits;

    if (_completedAudits.isEmpty) {
      return [
        FlexBasicCard(
          icon: Icons.folder,
          hasBadge: false,
          title: "No completed audits available",
          morePress: () => {print("more pressed")},
          editPress: () => {print("edit pressed")},
          deletePress: () => {print("edit pressed")},
        )
      ];
    }

    return _completedAudits
        .map(
          (assessmentModel) => FlexBasicCard(
            morePress: () => {print("more pressed")},
            editPress: () {
              Provider.of<Project>(context, listen: false)
                  .readSelectedProject(assessmentModel);
              Navigator.pushNamed(context, RoutingConstants.floorPlan);
            },
            deletePress: () => {
              Provider.of<Project>(context, listen: false)
                  .removeProject(assessmentModel)
            },
            icon: Icons.folder,
            hasBadge: false,
            title: assessmentModel.description ?? "Malcolm",
          ),
        )
        .toList();
  }

  buildSideBar(IconData icon, String text, dynamic screen) {
    return Container(
      child: Column(
        mainAxisAlignment: MainAxisAlignment.spaceAround,
        children: [
          GestureDetector(
            onTap: () {
              setState(() {
                currentScreen = screen;
              });
            },
            child: Row(
              children: [
                VerticalDivider(
                  color: Colors.transparent,
                ),
                Icon(
                  icon,
                  color: Theme.of(context).primaryColor,
                ),
                VerticalDivider(color: Colors.transparent),
                Text(
                  text,
                )
              ],
            ),
          ),
          Divider(
            color: Colors.transparent,
          )
        ],
      ),
    );
  }
}

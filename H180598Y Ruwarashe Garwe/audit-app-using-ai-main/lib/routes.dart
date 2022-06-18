import 'package:flex/main.dart';
import 'package:flex/screens/assessments/create_assessment.dart';
import 'package:flex/screens/assessments/floor_plan/map.dart';
import 'package:flex/screens/assessments/form.dart';
import 'package:flex/screens/camera_detection/camera_detection.dart';
import 'package:flex/screens/dashboard/flex_basic_dashboard.dart';
import 'package:flex/screens/profile/profile.dart';
import 'package:flex/screens/settings/settings.dart';
import 'package:flex/screens/subscriptions/subscriptions.dart';
import 'package:flutter/material.dart';
import 'constants/routing_constants.dart';
import 'screens/assessments/assessment_form.dart';
import 'screens/assessments/create_assessment.dart';
import 'screens/assessments/floor_plan/show_floor_plan.dart';
import 'screens/dashboard/flex_basic_dashboard.dart';
import 'screens/authentication/login.dart';
import 'screens/image_annotation/image_annotation.dart';
import 'screens/assessments/revisions.dart';
import 'screens/assessments/hive_test.dart';
import 'screens/image_detection/capturing_metadata/example_get_metadata.dart';
import 'screens/image_detection/model_selection.dart';
import 'screens/onboarding/onboarding.dart';
import 'screens/bottom_navigation_bar.dart';

class RouteGenerator {
  // ignore: missing_return
  static Route<dynamic> generateRoute(RouteSettings settings) {
    switch (settings.name) {
      case RoutingConstants.onboarding:
        return navigateToPage(Onboarding());
      case RoutingConstants.form:
        return navigateToPage(AssessmentForm());
      case RoutingConstants.home:
        return navigateToPage(Home());
      case RoutingConstants.login:
        return navigateToPage(LoginSignupScreen());
      case RoutingConstants.revisions:
        return navigateToPage(ListViewPage());
      case RoutingConstants.offline:
        return navigateToPage(OfflineAccess());
      case RoutingConstants.newAssessment:
        return navigateToPage(CreateAssessment());
      case RoutingConstants.draw:
        return navigateToPage(Draw());
      case RoutingConstants.exampleGetMetaData:
        return navigateToPage(GetMetaData());
      case RoutingConstants.loginSignupScreen:
        return navigateToPage(LoginSignupScreen());
      case RoutingConstants.flexDashboard:
        return navigateToPage(FlexBasicDashboard());
      case RoutingConstants.modelSelection:
        return navigateToPage(ModelSelection(cameras));
      case RoutingConstants.flexCameraDetection:
        return navigateToPage(FlexCameraDetection());
      case RoutingConstants.floorPlan:
        return navigateToPage(ShowFloorPlan());
      case RoutingConstants.map:
        return navigateToPage(Map());
      case RoutingConstants.subscriptions:
        return navigateToPage(Subscriptions());
      case RoutingConstants.profile:
        return navigateToPage(Profile());
      case RoutingConstants.settings:
        return navigateToPage(Settings());
      case RoutingConstants.test_form:
        return navigateToPage(FlexForm());
    }
  }

  static MaterialPageRoute<dynamic> navigateToPage(dynamic page) =>
      MaterialPageRoute(builder: (_) => page);
}

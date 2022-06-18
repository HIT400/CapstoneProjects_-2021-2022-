import 'package:flex/models/assessment_model.dart';
import 'package:flex/services/assessment.service.dart';
import 'package:flutter/services.dart';

class AssessmentController {
  Future<bool> upload(AssessmentModel assessment) async {
    var response = await AssessmentAPIService().upload(assessment.toJson());

    if (response.statusCode == 200) return true;

    return false;
  }

  getAssessments() {}

  static getFakeAssessmentTemplate() async {
    final String response =
        await rootBundle.loadString('assets/assessment_template.json');
    return response;
  }

  static Future<String> getAssessmentTemplate() async {
    var response = await AssessmentAPIService.get();
    return response.body;
  }
}

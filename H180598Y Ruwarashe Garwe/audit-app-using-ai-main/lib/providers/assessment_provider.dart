import 'package:flex/models/assessment_model.dart';
import 'package:flutter/material.dart';

class Assessment with ChangeNotifier {
  AssessmentModel _assessmentModel;
  AssessmentModel get assessmentModel => _assessmentModel;

  set assessmentModel(AssessmentModel assessmentModel) {
    this._assessmentModel = assessmentModel;
    notifyListeners();
  }

  void clearAssessment() {
    this._assessmentModel = new AssessmentModel();
    notifyListeners();
  }
}

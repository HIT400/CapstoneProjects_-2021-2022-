import 'package:flex/validations/validation_controller.dart';
import 'package:flutter/material.dart';

class CreateAssessmentValidator with ChangeNotifier {
  ValidationController _description = ValidationController(null, null);
  ValidationController _organisationId = ValidationController(null, null);
  ValidationController _createdBy = ValidationController(null, null);
  ValidationController _assessmentTemplateId = ValidationController(null, null);

  ValidationController get description => _description;
  ValidationController get createdBy => _createdBy;
  ValidationController get assessmentTemplateId => _assessmentTemplateId;
  ValidationController get organisationId => _organisationId;

  void onChangedDecription(String value) {
    if (value.length >= 3)
      _description = ValidationController(value, null);
    else
      _description =
          ValidationController(null, "must be at least 3 characters");

    notifyListeners();
  }

  void onChangedAssessmentTemplateId(String value) {
    try {
      int.parse(value);
      if (int.parse(value) >= 0)
        _assessmentTemplateId = ValidationController(value, null);
      else
        _assessmentTemplateId = ValidationController(null, "must not be negative");
    } catch (error) {
      _assessmentTemplateId = ValidationController(null, "not valid int");
    }
    notifyListeners();
  }

  void onChangedOrganisation(String value) {
    try {
      int.parse(value);
      if (int.parse(value) >= 0)
        _organisationId = ValidationController(value, null);
      else
        _organisationId = ValidationController(null, "must not be negative");
    } catch (error) {
      _organisationId = ValidationController(null, "not valid int");
    }
    notifyListeners();
  }

  void onChangedCreatedBy(String value) {
    try {
      int.parse(value);
      if (int.parse(value) >= 0)
        _createdBy = ValidationController(value, null);
      else
        _createdBy = ValidationController(null, "must not be negative");
    } catch (error) {
      _createdBy = ValidationController(null, "not a valid int");
    }
    notifyListeners();
  }
}

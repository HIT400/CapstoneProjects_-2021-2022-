import 'package:flex/models/assessment_model.dart';
import 'package:flex/models/assessment_template_model.dart';
import 'package:flex/models/inventory.dart';
import 'package:flex/models/section_model.dart';
import 'package:flex/screens/assessments/assessment.controller.dart';
import 'package:flex/storage/audit_storage.dart';
import 'package:flutter/material.dart';
import 'package:uuid/uuid.dart';

class Project with ChangeNotifier {
  AuditDao helper = new AuditDao();
  AssessmentModel _project = new AssessmentModel();
  AssessmentModel get project => _project;
  AssessmentTemplateModel get template => _project.assessmentTemplate;
  List<Section> get sections => template.section;
  List<Items> items;

  addSection(Section section) {
    template.section.add(section);
    notifyListeners();
  }

  void saveProject(AssessmentModel model) {
    var uuid = Uuid().v1();
    model.id = uuid;
    model.completed = false;
    _project = model;
    helper.insertAudits(model);
    notifyListeners();
  }

  void removeProject(AssessmentModel model) {
    _project = model;
    helper.delete(model);
    helper.getAllaudits();
    notifyListeners();
  }

  void updateProject(AssessmentModel model) {
    _project = model;
    helper.updateAudits(model);
    notifyListeners();
  }

  void readSelectedProject(AssessmentModel selectedProject) {
    _project = selectedProject;
    addTemplate(selectedProject.assessmentTemplate);
    notifyListeners();
  }

  void addTemplate(AssessmentTemplateModel template) {
    _project.assessmentTemplate = template;
    notifyListeners();
  }

  void addInventory(Items items, int index) {
    if (sections[index].inventory == null) {
      sections[index].inventory = Inventory(items: []);
    }
    sections[index].inventory.items.add(items);
    notifyListeners();
  }

  void removeInventory(Inventory inventory, int index) {
    // _sections[index].inventory.add(inventory);
    notifyListeners();
  }

  Future<bool> postAssessment() async =>
      await AssessmentController().upload(_project);
}

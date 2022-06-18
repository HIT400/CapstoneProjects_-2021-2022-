import 'dart:convert';
import 'package:flex/models/assessment_model.dart';
import 'package:flex/models/assessment_template_model.dart';
import 'package:flex/models/inventory.dart';
import 'package:flex/models/section_model.dart';
import 'package:flex/storage/audit_storage.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';

class AppState with ChangeNotifier {
  var _storage = new FlutterSecureStorage();

  int _index = 0;
  int get index => _index;

  List<AssessmentTemplateModel> _assessmentTemplates = [];
  List<AssessmentTemplateModel> get assessmentTemplates => _assessmentTemplates;

// NB: This list is only updated when the audit is posted to the server
  List<AssessmentModel> _completedAudits = [];
  List<AssessmentModel> get completedAudits => _completedAudits;

  List<AssessmentModel> _recentAudits = [];
  List<AssessmentModel> get recentAudits => _recentAudits;

  AssessmentModel _audit;
  AssessmentModel get audit => _audit;

  AssessmentTemplateModel _selectedTemplate;
  AssessmentTemplateModel get selectedTemplate => _selectedTemplate;

  List<Section> _sections = [];
  List<Section> get sections => _sections;

  Future<List<Section>> readJson() async {
    _sections = _selectedTemplate.section;
    return _sections;
  }

  void appendSection(Section sections) {
    _sections.add(sections);
    notifyListeners();
  }

  void copySection(index) {
    _sections.add(sections[index]);
    notifyListeners();
  }

  void appendInventory(Inventory inventory, int index) {
    // _sections[index].inventory.add(inventory);
    notifyListeners();
  }

  void removeInventory(Inventory inventory, int index) {
    // _sections[index].inventory.add(inventory);
    notifyListeners();
  }

  void iterate(int value) {
    _index = value;
    notifyListeners();
  }

  void pickTemplate(int index) {
    try {
      _selectedTemplate = _assessmentTemplates[index];
    } catch (e) {
      print(e.toString());
    }
    notifyListeners();
  }

  bool initializeAudit(AssessmentModel model) {
    try {
      _audit = model;
      _recentAudits.add(_audit);
      notifyListeners();
      return true;
    } catch (e) {
      return false;
    }
  }

  Future<List<AssessmentTemplateModel>> getTemplates() async {
    //final String response = await AssessmentController.getAssessmentTemplate();
    final String response =
        await rootBundle.loadString('assets/assessment_template.json');
    List<dynamic> data = jsonDecode(response);
    if (_assessmentTemplates.isEmpty) {
      data.forEach((element) {
        _assessmentTemplates.add(AssessmentTemplateModel.fromJson(element));
      });
    }
    return _assessmentTemplates;
  }

  Future<List<AssessmentModel>> getCompletedAudits() async {
    var data = await AuditDao().getAllaudits();
    _completedAudits.clear();
    data.forEach((element) {
      if (element.completed == true) _completedAudits.add(element);
    });
    notifyListeners();
    return _completedAudits;
  }

  Future<List<AssessmentModel>> getRecentAudits() async {
    var data = await AuditDao().getAllaudits();
    _recentAudits.clear();
    data.forEach((element) {
      if (element.completed == false) _recentAudits.add(element);
    });
    notifyListeners();
    return _recentAudits;
  }

  void saveProject(String _project) async =>
      await _storage.write(key: 'project', value: _project ?? '[]');

  Future<String> retrieveAuthToken() async => _storage.read(key: 'project');
}

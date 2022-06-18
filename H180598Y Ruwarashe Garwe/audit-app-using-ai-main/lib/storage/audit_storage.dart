import 'package:flex/models/assessment_model.dart';
import 'package:flex/models/assessment_template_model.dart';
import 'package:flex/storage/app_database.dart';
import 'package:sembast/sembast.dart';

class AuditDao {
  static const String table = "audits";
  final _auditFolder = intMapStoreFactory.store(table);

  Future<Database> get _database async => await AppDatabase.instance.database;

  Future insertAudits(AssessmentModel assessment) async {
    try {
      await _auditFolder.add(await _database, assessment.toJson());
    } catch (e) {}
  }

  Future updateAudits(AssessmentModel assessment) async {
    final finder = Finder(filter: Filter.byKey(assessment.id));
    await _auditFolder.update(await _database, assessment.toJson(),
        finder: finder);
  }

  Future delete(AssessmentModel assessment) async {
    final finder = Finder(filter: Filter.equals('id', assessment.id));
    await _auditFolder.delete(await _database, finder: finder);
    
  }

  Future<List<AssessmentModel>> getAllaudits() async {
    final recordSnapshot = await _auditFolder.find(await _database);
    return recordSnapshot.map((snapshot) {
      final AssessmentTemplateModel assessmentTemplate =
          AssessmentTemplateModel.fromJson(
              snapshot.value['assessment_template_Id']);
      final audits = AssessmentModel.fromJson(snapshot.value);
      audits.assessmentTemplate = assessmentTemplate;
      return audits;
    }).toList();
  }
}

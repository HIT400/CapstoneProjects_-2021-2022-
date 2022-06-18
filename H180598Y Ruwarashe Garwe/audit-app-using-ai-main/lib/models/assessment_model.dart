import 'assessment_template_model.dart';

class AssessmentModel {
  String id;
  String createdBy; // string
  String organisationId; // string
  AssessmentTemplateModel assessmentTemplate; //object
  String description;
  String dateCompleted;
  bool completed = false;
  bool reportAvailable;

  AssessmentModel(
      {this.id,
      this.createdBy,
      this.organisationId,
      this.assessmentTemplate,
      this.description,
      this.dateCompleted,
      this.completed,
      this.reportAvailable});

  factory AssessmentModel.fromJson(Map<String, dynamic> json) {
    return AssessmentModel(
      id: json['id'],
      createdBy: json['created_by'],
      organisationId: json['organisation_Id'],
      assessmentTemplate: json['assessment_template'],
      description: json['description'],
      dateCompleted: json['date_completed'],
      completed: json['completed'],
      reportAvailable: json['report_available'],
    );
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['id'] = this.id;
    data['created_by'] = this.createdBy;
    data['organisation_Id'] = this.organisationId;
    data['assessment_template_Id'] = assessmentTemplate?.toJson();
    data['description'] = this.description;
    data['date_completed'] = this.dateCompleted;
    data['completed'] = this.completed;
    data['report_available'] = this.reportAvailable;
    return data;
  }
}

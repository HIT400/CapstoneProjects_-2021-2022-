import 'section_model.dart';

class AssessmentTemplateModel {
  int id;
  String name;
  String description;
  CreatedBy createdBy;
  Organization organization;
  bool published;
  String dateCreated;
  String lastModified;
  List<Section> section;

  AssessmentTemplateModel(
      {this.id,
      this.name,
      this.description,
      this.createdBy,
      this.organization,
      this.published,
      this.dateCreated,
      this.lastModified,
      this.section});

  AssessmentTemplateModel.fromJson(Map<String, dynamic> json) {
    id = json['id'];
    name = json['name'];
    description = json['description'];
    createdBy = json['created_by'] != null
        ? new CreatedBy.fromJson(json['created_by'])
        : null;
    organization = json['organization'] != null
        ? new Organization.fromJson(json['organization'])
        : null;
    published = json['published'];
    dateCreated = json['date_created'];
    lastModified = json['last_modified'];
    if (json['section'] != null) {
      section = <Section>[];
      json['section'].forEach((v) {
        section.add(new Section.fromJson(v));
      });
    }
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['id'] = this.id;
    data['name'] = this.name;
    data['description'] = this.description;
    if (this.createdBy != null) {
      data['created_by'] = this.createdBy.toJson();
    }
    if (this.organization != null) {
      data['organization'] = this.organization.toJson();
    }
    data['published'] = this.published;
    data['date_created'] = this.dateCreated;
    data['last_modified'] = this.lastModified;
    if (this.section != null) {
      data['section'] = this.section.map((v) => v.toJson()).toList();
    }
    return data;
  }
}

class CreatedBy {
  String username;

  CreatedBy({this.username});

  CreatedBy.fromJson(Map<String, dynamic> json) {
    username = json['username'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['username'] = this.username;
    return data;
  }
}

class Organization {
  String name;

  Organization({this.name});

  Organization.fromJson(Map<String, dynamic> json) {
    name = json['name'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['name'] = this.name;
    return data;
  }
}

class Fields {
  String prompt;
  dynamic answer;
  int dataType;
  Null range;
  Null link;
  FollowUpQuestion followUpQuestion;

  Fields(
      {this.prompt,
      this.answer,
      this.dataType,
      this.range,
      this.link,
      this.followUpQuestion});

  Fields.fromJson(Map<String, dynamic> json) {
    prompt = json['prompt'];
    answer = json['answer'];
    dataType = json['data_type'];
    range = json['range'];
    link = json['link'];
    followUpQuestion = json['follow_up_question'] != null
        ? new FollowUpQuestion.fromJson(json['follow_up_question'])
        : null;
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['prompt'] = this.prompt;
    data['answer'] = this.answer;
    data['data_type'] = this.dataType;
    data['range'] = this.range;
    data['link'] = this.link;
    if (this.followUpQuestion != null) {
      data['follow_up_question'] = this.followUpQuestion.toJson();
    }
    return data;
  }
}

class FollowUpQuestion {
  String name;
  List<FollowUp> followUp;

  FollowUpQuestion({this.name, this.followUp});

  FollowUpQuestion.fromJson(Map<String, dynamic> json) {
    name = json['name'];
    if (json['follow_up'] != null) {
      followUp = <FollowUp>[];
      json['follow_up'].forEach((v) {
        followUp.add(new FollowUp.fromJson(v));
      });
    }
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['name'] = this.name;
    if (this.followUp != null) {
      data['follow_up'] = this.followUp.map((v) => v.toJson()).toList();
    }
    return data;
  }
}

class FollowUp {
  String prompt;
  String triggerAnswer;
  int dataType;

  FollowUp({this.prompt, this.triggerAnswer, this.dataType});

  FollowUp.fromJson(Map<String, dynamic> json) {
    prompt = json['prompt'];
    triggerAnswer = json['trigger_answer'];
    dataType = json['data_type'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['prompt'] = this.prompt;
    data['trigger_answer'] = this.triggerAnswer;
    data['data_type'] = this.dataType;
    return data;
  }
}

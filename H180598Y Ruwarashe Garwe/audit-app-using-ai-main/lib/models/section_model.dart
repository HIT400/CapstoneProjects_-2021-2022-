import 'assessment_template_model.dart';
import 'inventory.dart';

class Section {
  int id;
  String sectionName;
  String description;
  Null floorPlan;
  bool repeatable;
  Inventory inventory;
  List<Fields> fields;

  Section(
      {this.id,
      this.sectionName,
      this.description,
      this.floorPlan,
      this.repeatable,
      this.inventory,
      this.fields});

  Section.fromJson(Map<String, dynamic> json) {
    id = json['id'];
    sectionName = json['section_name'];
    description = json['description'];
    floorPlan = json['floor_plan'];
    repeatable = json['repeatable'];
    inventory = json['inventory'];
    if (json['fields'] != null) {
      fields = <Fields>[];
      json['fields'].forEach((v) {
        fields.add(new Fields.fromJson(v));
      });
    }
  }

  get items => null;

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['id'] = this.id;
    data['section_name'] = this.sectionName;
    data['description'] = this.description;
    data['floor_plan'] = this.floorPlan;
    data['repeatable'] = this.repeatable;
    data['inventory'] = this.inventory;
    if (this.fields != null) {
      data['fields'] = this.fields.map((v) => v.toJson()).toList();
    }
    return data;
  }
}

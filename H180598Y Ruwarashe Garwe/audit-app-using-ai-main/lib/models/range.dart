
class Range {
  int id;
  String name;
  String minimum;
  String minimumResponse;
  String maximum;
  String maximumResponse;

  Range(
      {this.id,
      this.name,
      this.minimum,
      this.minimumResponse,
      this.maximum,
      this.maximumResponse});

  Range.fromJson(Map<String, dynamic> json) {
    id = json['id'];
    name = json['name'];
    minimum = json['minimum'];
    minimumResponse = json['minimum_response'];
    maximum = json['maximum'];
    maximumResponse = json['maximum_response'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['id'] = this.id;
    data['name'] = this.name;
    data['minimum'] = this.minimum;
    data['minimum_response'] = this.minimumResponse;
    data['maximum'] = this.maximum;
    data['maximum_response'] = this.maximumResponse;
    return data;
  }
}
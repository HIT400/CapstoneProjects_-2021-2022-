import 'dart:convert';

import 'package:flex/constants/api.dart';
import 'package:flex/models/assessment_template_model.dart';

import 'package:http/http.dart' as http;

Future<List<AssessmentTemplateModel>> fetchAssement(String token) async {
  var url = ApiConnect.baseUrl + "flexio/assessments/2/";

  print("object" + token);
  var response = await http.get(url, headers: {
    'Authorization': token,
  });

  if (response.statusCode == 200) {
    List<AssessmentTemplateModel> assessment = [];
    List<dynamic> assementData = jsonDecode(response.body);
    assementData.forEach((element) {
      assessment.add(AssessmentTemplateModel.fromJson(element));
    });
    return assessment;
  } else {
    throw new Exception('unable to fetch assessments');
  }
}

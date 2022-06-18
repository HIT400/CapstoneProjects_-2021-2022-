import 'package:flex/constants/api.dart';
import 'package:flex/screens/authentication/authentication.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';

class AssessmentAPIService {
  Future<http.Response> upload(Map<String, dynamic> assessmentDetails) async {
    var authToken = await AuthenticationController().retrieveAuthToken();
    final headers = {
      "accept": ApiConnect.acceptType,
      "content-type": ApiConnect.contentType,
      "Authorization": "Token " + authToken,
    };

    return await http.post(ApiConnect.postAssessmentUrl,
        headers: headers, body: json.encode(assessmentDetails));
  }

    static Future<http.Response> get() async {
    var authToken = await AuthenticationController().retrieveAuthToken();
    final headers = {
      "accept": ApiConnect.acceptType,
      "content-type": ApiConnect.contentType,
      "Authorization": "Token " + authToken,
    };

    return await http.get(ApiConnect.getAssessmentUrl + "1/",
        headers: headers);
  }
}

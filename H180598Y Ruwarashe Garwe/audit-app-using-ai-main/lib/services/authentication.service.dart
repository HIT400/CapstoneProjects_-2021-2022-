import 'package:flex/constants/api.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';

class AuthenticationAPIService {
  final headers = {
    "accept": ApiConnect.acceptType,
    "content-type": ApiConnect.contentType
  };

  Future<http.Response> logIn(Map<String, String> loginDetails) async {
    return await http.post(Uri.parse(ApiConnect.authTokenUrl),
        headers: headers, body: json.encode(loginDetails));
  }
}

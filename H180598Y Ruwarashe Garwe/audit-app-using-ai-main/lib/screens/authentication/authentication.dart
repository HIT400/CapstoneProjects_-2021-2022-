import 'dart:convert';
import 'package:flex/services/authentication.service.dart';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';

class AuthenticationController {
  final _storage = new FlutterSecureStorage();

  Future<bool> logIn(String username, String password) async {
    if (username.isEmpty || password.isEmpty) return false;

    var response = await AuthenticationAPIService().logIn({
      "username": username,
      "password": password,
    });

    if (response.statusCode != 200) return false;

    saveAuthToken(json.decode(response.body)['token']);

    return true;
  }

  void saveAuthToken(String token) async =>
      await _storage.write(key: 'userToken', value: token ?? '');

  Future<String> retrieveAuthToken() async => _storage.read(key: 'userToken');

  void deleteAuthToken(String key) async => await _storage.delete(key: key);
}

import 'package:flex/screens/authentication/authentication.dart';
import 'package:flutter_test/flutter_test.dart';

void main() {
  group('Get login token', () {
    test('Invalid username', () async {
      // Arrange
      // Act
      var result = await AuthenticationController().logIn('', 'test-password');
      // Assert
      expect(result, false);
    });

    test('Invalid password', () async {
      // Arrange
      // Act
      var result = await AuthenticationController().logIn('test-user', '');
      // Assert
      expect(result, false);
    });
  });
}

import 'package:firebase_auth/firebase_auth.dart';

class AuthenticationServer {
  final FirebaseAuth _firebaseAuth;
  AuthenticationServer(this._firebaseAuth);

  Stream<User> get authStateChanges => _firebaseAuth.authStateChanges();
  Future<String> signIn({String email, String password}) async {
    try {
      await _firebaseAuth.signInWithEmailAndPassword(
          email: email, password: password);
      return "Success";
    } on FirebaseAuthException catch (e) {
      return e.message;
    }
  }

  Future<String> signUp({String email, String password}) async {
    try {
      await _firebaseAuth.createUserWithEmailAndPassword(
          email: email, password: password);
      return "Success Signup";
    } on FirebaseAuthException catch (e) {
      return e.message;
    }
  }
}

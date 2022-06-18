import 'package:flutter/material.dart';

ThemeData appTheme() {
  const flexPurple = Color(0xFFF72670);

  return ThemeData(
      primaryColor: flexPurple,
      scaffoldBackgroundColor: Colors.white,
      appBarTheme: AppBarTheme(backgroundColor: flexPurple),
      backgroundColor: flexPurple,
      fontFamily: 'Verdana');
}

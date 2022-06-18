class DataValidation {
  bool isDateValid(dateToCheck) {
    if (!dateToCheck || dateToCheck.isEmpty()) return false;
    final now = DateTime.now();
    final convertIputToDate =
        DateTime(dateToCheck.year, dateToCheck.month, dateToCheck.day);
    return convertIputToDate == now;
  }

  bool isIntergerValid() {
    return true;
  }

  bool isShortTextValid() {
    return true;
  }

  bool isLongTextValid() {
    return true;
  }

  bool isImageValid(String image) {
    return true;
  }

  bool isFloatValid() {
    return true;
  }
}

import 'package:flex/models/assessment_model.dart';
import 'package:flex/providers/assessment_provider.dart';
import 'package:flutter_test/flutter_test.dart';

void main() {
  group('Assessment State', () {
    var assessment;

    setUp(() {
      assessment = new Assessment();
    });

    test('When Assessment is Null Expect Model to be null', () {
      // Arrange

      // Act
      assessment.assessmentModel = null;

      // Assert
      expect(assessment.assessmentModel, null);
    });

    test('When Assessment is Valid Expect Model with values', () {
      // Arrange

      // Act
      var result = assessment.assessmentModel =
          new AssessmentModel(createdBy: "FlexUser");

      // Assert
      expect(result.createdBy, assessment.assessmentModel.createdBy);
    });

    test('When Assessment is cleared Expect Asessment Model instance', () {
      // Arrange
      assessment.assessmentModel = AssessmentModel(createdBy: "FlexUser");

      // Act
      assessment.clearAssessment();

      // Assert
      // We could use Instance to compare
      // but Dart doesnt regard instances the same
      expect(assessment.assessmentModel is AssessmentModel, true);
    });
  });
}

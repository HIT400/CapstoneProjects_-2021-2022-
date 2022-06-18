class ApiConnect {
  // static const baseUrl = 'http://ec2-13-244-138-73.af-south-1.compute.amazonaws.com/';
  static const baseUrl = 'http://192.168.40.224:8000/';
  static const authTokenUrl = baseUrl + 'api-token-auth/';
  static const acceptType = 'application/json';
  static const contentType = 'application/json';
  static const getAssessmentUrl = baseUrl + 'flexio/assessments/';
  static const postAssessmentUrl = baseUrl + 'flexio/assessments/upload/';
}

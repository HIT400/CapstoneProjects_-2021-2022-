from django.contrib.auth.models import User
from rest_framework import status
from rest_framework.test import APITestCase
from ..models import Organization, UserProfile

'''class AssessmentsTestCase(APITestCase):

    def setUp(self):
          self.user = User.objects.get_or_create(username='testuser')[0]
          self.organization = Organization.objects.create(id=1, name='test')

          user_profile = UserProfile.objects.create(
              user=self.user, organization=self.organization)

          self.client.force_login(self.user)

      def test_get_organization_assessments_user_belongs_to_organization(self):
          # Act
          response = self.client.get('/flexio/assessments/1/')
          # Assert
          self.assertEqual(response.status_code, status.HTTP_200_OK)

      def test_get_organization_assessments_user_does_not_belongs_to_organization(self):
          # Act
          response = self.client.get('/flexio/assessments/2/')
          # Assert
          self.assertEqual(response.status_code, status.HTTP_401_UNAUTHORIZED)'''

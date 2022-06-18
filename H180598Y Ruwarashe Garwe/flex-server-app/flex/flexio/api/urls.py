from django.urls import path

from .views import (
    AssessmentApiView, DownloadAssessment, uploadAssessment, upload_multiple_images
)


urlpatterns = [
    path('', AssessmentApiView.as_view()),
    path('<int:organization_id>/', AssessmentApiView.as_view()),
    path('uploadmultiple/', upload_multiple_images),
    path('upload/', uploadAssessment),
    path('download/<int:assessment_id>/', DownloadAssessment.as_view()),
]

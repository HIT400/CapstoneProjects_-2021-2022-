import io
import json
import pathlib
from datetime import datetime

from django.conf import settings
from django.conf import settings as st
from django.contrib.auth.models import User
from django.http import FileResponse
from django.http.response import HttpResponse
from django.shortcuts import get_object_or_404
from django.views.decorators.csrf import csrf_exempt
#from PIL import Image
from reportlab.pdfgen import canvas
from rest_framework import permissions, status
from rest_framework.response import Response
from rest_framework.views import APIView

from ..models import (Assessment, AssessmentTemplate, Organization)
from .forms import MultipleImageForm
from .serializers import AssessmentTemplateSerializer


class AssessmentApiView(APIView):
    permission_classes = [permissions.IsAuthenticated]

    def get(self, request, organization_id):
        if self._user_belongs_to_organization(request.user, organization_id):
            serializer = self._organization_assessment_templates(
                organization_id)
            return Response(serializer.data, status=status.HTTP_200_OK)

        return Response('User does not belong to organization', status=status.HTTP_401_UNAUTHORIZED)

    def _user_belongs_to_organization(self, user, organization_id):
        user_profile = user.userprofile

        if user_profile is None:
            return False

        return user_profile.organization.id == organization_id

    def _organization_assessment_templates(self, organization_id):
        assessment_templates = AssessmentTemplate.objects.filter(
            organization=organization_id, published=True)

        return AssessmentTemplateSerializer(assessment_templates, many=True)


@ csrf_exempt
def handle_uploaded_image(image):
    with open(settings.IMG_PATH+image.name, 'wb+') as destination:
        for chunk in image.chunks():
            destination.write(chunk)


@csrf_exempt
def upload_multiple_images(request):
    if request.method == 'POST':
        form = MultipleImageForm(request.POST, request.FILES)
        files = request.FILES.getlist('images')
        if form.is_valid():
            for f in files:
                handle_uploaded_image(f)
            return HttpResponse("Images uploaded successfully")
    return HttpResponse("Images not uploaded!")


@csrf_exempt
def uploadAssessment(request):
    permission_classes = [permissions.IsAuthenticated]

    if request.method != 'POST':
        HttpResponse("Assessment was not uploaded!")

    data = json.loads(request.body)
    user = User.objects.get(id=data["created_by"])
    organization = Organization.objects.get(id=data["organization"])
    edited_template = data["data_fields"]

    assessment = Assessment(created_by=user,
                            description=data["description"],
                            completed=bool(data["completed"]),
                            report_available=bool(
                                data["report_available"]),
                            date_completed=datetime.strptime(
                                data["date_completed"], '%d-%m-%y'),
                            organization=organization,
                            assessment_template=edited_template)

    assessment.save()
    return HttpResponse("Assessment uploaded successfully!")


class DownloadAssessment(APIView):
    permission_classes = [permissions.IsAuthenticated]

    def get(self, request, assessment_id):
        buffer = self._download_assessment_pdf(assessment_id)

        return FileResponse(buffer, as_attachment=True, filename=f'Assessment {assessment_id +1}.pdf')

    def _download_assessment_pdf(self, assessment_id):
        assessment = get_object_or_404(Assessment, id=assessment_id)
        created_by, description, assessment_data, completed, report_available, date_completed, organization = self._set_assessment_fields(
            assessment)

        buffer = io.BytesIO()
        pdf = canvas.Canvas(buffer)

        labels = ["Created By: ", "Organization: ", "Description: ",
                  "Report Available: ", "Completed: ", "Date Completed: "]
        values = [created_by, organization, description,
                  report_available, completed, date_completed]

        self._print_to_pdf(assessment_data, pdf, labels, values, 800, 0, 30, 0)

        self._print_image_to_pdf(pdf, 30)

        pdf.showPage()
        pdf.save()
        buffer.seek(0)
        return buffer

    def _print_image_to_pdf(self, pdf, xValue):
        img = self._get_image("image.png")
        if img != False:
            pdf.drawInlineImage(img, xValue, 100, width=None, height=None)

    def _print_to_pdf(self, assessment_data, pdf, labels, values, maxHeight, heightDecrement, xValue, valuesIndex):
        for label in labels:
            pdf.drawString(xValue, maxHeight - heightDecrement,
                           label+values[valuesIndex])
            heightDecrement += 20
            valuesIndex += 1

        for item in assessment_data:
            pdf.drawString(xValue, maxHeight - heightDecrement,
                           item["prompt"]+" :"+item["data_type"])
            heightDecrement += 20
            valuesIndex += 1

    def _set_assessment_fields(self, assessment):
        created_by = assessment.created_by.username
        description = assessment.description
        assessment_data = assessment.assessment_template["data_fields"]
        completed = str(assessment.completed)
        report_available = str(assessment.report_available)
        date_completed = assessment.date_completed.strftime("%m/%d/%Y")
        organization = assessment.organization.name
        history = assessment.history
        return created_by, description, assessment_data, completed, report_available, date_completed, organization

    #def _get_image(self, fileName):
    #    try:
     #       return Image.open(str(pathlib.Path(__file__).parent.resolve())+"/images/"+fileName)
      #  except:
       #     return False

    def compute_ranges(self, assessmentdata):
        for item in assessmentdata:
            if(item["data_type"] == 5):
                if(item["minimum"] <= item["value"]):
                    print(item["minimum_response"])

                    if(item["maximum"] >= item["value"]):
                        print(item["maximum_response"])

                else:
                    print("Pass")

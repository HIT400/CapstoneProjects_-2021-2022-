from django.urls import path, include

urlpatterns = [
    path('assessments/', include('flexio.api.urls'))
]

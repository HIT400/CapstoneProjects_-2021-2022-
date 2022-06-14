from django.urls import path
from .import views

urlpatterns = [
    path('',views.login_user,name='login'),
    path('logout',views.logout_user,name='logout'),
    path('register',views.user_registration,name='register-user'),
    path('settings',views.settings,name='settings'),

]
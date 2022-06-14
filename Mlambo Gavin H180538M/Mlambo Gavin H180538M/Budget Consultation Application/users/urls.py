from django.urls import path
from .import views

urlpatterns = [
    path('',views.users,name='user-dashboard'),
    path('comment_projects',views.projects,name='projects'),
    path('rates',views.post_tarrif_comments,name='proposed-rates'),
    path('tarrifs',views.tarrifs,name='comments'),
    path('comments/<tarrif_list_id>',views.show_comments,name='user-comments'),
    path('project_comments/<project_list_id>',views.project_comments,name='projects-comments'),
    path('delete_comment/<com_id>',views.delete_comments,name='delete-comment'),
   
    

]
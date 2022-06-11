from unicodedata import name
from django.urls import path
from .import views

urlpatterns = [
    path('',views.dashAdmin,name='admin-dashboard'),
    path('positive_comments',views.positive_comments,name='positive-comments'),
    path('negative_comments',views.negative_comments,name='negative-comments'),
    path('neutral_comments',views.netural_comments,name='negative-comments'),
    path('tarrifs',views.tarrifs,name='admin-tarrifs'),
    path('tarrifs/<tarrifs_id>',views.edit_tarrifs,name='edit-tarrifs'),
    path('comments/<tarrifs_id>',views.comments,name='show-comments'),
    path('delete_tarrifs/<tarrifs_id>',views.delete_tarrifs,name='delete-tarrifs'),
    path('add-tarrif', views.new_tarrif,name='new-tarrif'),
    path('view_users',views.view_users,name='view-users'),
    path('user_comments/<user_id>',views.show_user_comments,name='show-user-comments'),
    #path('edit_user_comments/<user_id>',views.edit_user,name='edit-user'),
    path('delete_user/<user_id>',views.delete_user,name='delete-user'),
    path('add_user',views.add_users,name='add-user'),
    path('edit_user<user_id>',views.edit_user,name='edit-user'),
    path('projects',views.projects,name='show-projects'),

    path('eo_request',views.eo_request,name='eo-request'),
    path('approved/<item_id>',views.approve,name='item-approved'),
    path('debied/<item_id>',views.denied,name='denied-item'),
    
    
]
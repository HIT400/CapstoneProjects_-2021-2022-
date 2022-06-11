from unicodedata import name
from django.urls import path
from requests import request
from .import views

urlpatterns = [
    path('',views.dashboard,name='dashboard'),
    path('request_item',views.itemsave,name='save-item'),
    path('approved_item',views.approved_item,name='approved-item'),
    path('denied_item',views.denied_item,name='denied-item'),
    path('myrequest',views.item_request,name='item-request'),
    path('edit_items/<item_id>', views.edit_items,name='edit-items'),
    path('delete_item/<item_id>',views.delete_item,name='delete-item')    
]
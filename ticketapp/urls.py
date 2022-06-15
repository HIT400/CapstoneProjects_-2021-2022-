from django.urls import path
from . import views

app_name = 'ticketapp'

urlpatterns = [
    path('', views.TicketListView.as_view(), name='ticket-list'),
    path('ticket-detail/<int:pk>/',
         views.TicketDetailView.as_view(), name='ticket-detail'),
    path('create-ticket/', views.TicketCreateView.as_view(), name='create-ticket'),
    path('update-ticket/<int:pk>/',
         views.TicketUpdateView.as_view(), name='update-ticket'),
    path('delete-ticket/<int:pk>/',
         views.TicketDeleteView.as_view(), name='delete-ticket'),
    path('all-tickets/', views.ticket_list, name='all-tickets'),
    path('resolved-tickets/', views.resolved_tickets, name='resolved-tickets'),
    path('unresolved-tickets/', views.unresolved_tickets,
         name='unresolved-tickets'),
    path('urgent-tickets/', views.urgent_ticket_list, name='urgent-tickets'),
    path('mark-resolved/<int:id>',
         views.mark_ticket_as_resolved, name='mark-resolved'),
    path('mark-unresolved/<int:id>',
         views.mark_ticket_as_unresolved, name='mark-unresolved'),
    path('add-comment/<int:ticket_id>/', views.add_comment, name='add-comment'),
    path('search/', views.SearchResultView.as_view(), name='search'),
    path('search-results/', views.StaffSearchResultView.as_view(),
         name='search-results'),
    path('search-all/', views.AllSearchResultView.as_view(), name='search-all'),

    # user statistics page
    path('user-statistics/', views.UserPerformanceListView.as_view(),
         name='user-performance-list'),
    path('user-statistics/user-detail/<str:username>/',
         views.user_performance_details, name='user-performance-detail'),

    path("get-emails/", views.get_emails, name="get-emails"),
]

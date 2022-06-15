from django.contrib import admin
from .models import Ticket, Comment
# Register your models here.


@admin.register(Ticket)
class TicketAdmin(admin.ModelAdmin):
    list_display = (
        'ticket_id',
        'customer_full_name',
        'customer_phone_number',
        'customer_email',
        'ticket_section',
        'urgent_status',
        'completed_status',
        'assigned_to',
        'resolved_by'
    )
    list_filter = (
        'ticket_section',
        'urgent_status',
        'completed_status',
    )

    search_fields = ('customer_full_name',)


admin.site.register(Comment)

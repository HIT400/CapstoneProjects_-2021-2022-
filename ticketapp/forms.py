from django import forms
from django.contrib.auth.models import User
from .models import Ticket


class TicketForm(forms.ModelForm):
    title = forms.CharField(max_length=50, widget=forms.TextInput(
        attrs={'class': 'form-control'}))
    customer_full_name = forms.CharField(
        max_length=200, widget=forms.TextInput(attrs={'class': 'form-control'}))
    customer_phone_number = forms.CharField(
        max_length=20, widget=forms.TextInput(attrs={'class': 'form-control'}))
    customer_email = forms.CharField(
        max_length=40, widget=forms.EmailInput(attrs={'class': 'form-control'}))
    issue_description = forms.CharField(
        max_length=100, widget=forms.Textarea(attrs={'class': 'form-control'}))
    assigned_to = forms.ModelChoiceField(
        queryset=User.objects.all(), empty_label='Select User', widget=forms.Select(attrs={'class': 'form-control'}))

    class Meta:
        model = Ticket
        exclude = ('user', 'ticket_id', 'created_date',
                   'completed_status', 'resolved_by', 'resolved_date')


class TicketUpdateForm(forms.ModelForm):

    TICKET_SECTIONS = (
        ('Software', 'Software'),
        ('Hardware', 'Hardware'),
        ('Applications', 'Applications'),
        ('Infrastructure and Networking', 'Infrastructure and Networking'),
        ('Database Administrator', 'Database Administrator')
    )

    title = forms.CharField(max_length=50, widget=forms.TextInput(
        attrs={'class': 'form-control'}))
    customer_full_name = forms.CharField(
        max_length=200, widget=forms.TextInput(attrs={'class': 'form-control'}))
    customer_phone_number = forms.CharField(
        max_length=20, widget=forms.TextInput(attrs={'class': 'form-control'}))
    customer_email = forms.CharField(
        max_length=40, widget=forms.EmailInput(attrs={'class': 'form-control'}))
    issue_description = forms.CharField(
        max_length=100, widget=forms.Textarea(attrs={'class': 'form-control'}))
    ticket_section = forms.ChoiceField(
        choices=TICKET_SECTIONS, widget=forms.Select(attrs={'class': 'form-control'}))
    assigned_to = forms.ModelChoiceField(
        queryset=User.objects.all(), empty_label='Select User', widget=forms.Select(attrs={'class': 'form-control'}))

    class Meta:
        model = Ticket
        exclude = ('user', 'ticket_id', 'created_date',
                   'resolved_by', 'resolved_date')

from django.db import models
from django.contrib.auth.models import User
from django.forms import PasswordInput
from django.urls import reverse
from django.utils.crypto import get_random_string

# Create your models here.


class Ticket(models.Model):

    TICKET_SECTIONS = (
        ('Software', 'Software'),
        ('Hardware', 'Hardware'),
        ('Applications', 'Applications'),
        ('Infrastructure and Networking', 'Infrastructure and Networking'),
        ('Database Administrator', 'Database Administrator')
    )
    user = models.ForeignKey(User, on_delete=models.CASCADE)
    ticket_id = models.CharField(max_length=8, unique=True, blank=True)
    title = models.CharField(max_length=50)
    customer_full_name = models.CharField(max_length=200)
    customer_phone_number = models.CharField(max_length=20)
    customer_email = models.EmailField(max_length=40)
    issue_description = models.TextField(max_length=1000)
    ticket_section = models.CharField(
        max_length=30, choices=TICKET_SECTIONS, null=True, blank=True)
    urgent_status = models.BooleanField(default=False)
    completed_status = models.BooleanField(default=False)
    assigned_to = models.ForeignKey(
        User, on_delete=models.CASCADE, related_name='assigned_to', null=True, blank=True)
    resolved_by = models.ForeignKey(
        User, on_delete=models.CASCADE, related_name='resolved_by', null=True, blank=True)
    created_date = models.DateTimeField(auto_now_add=True, null=True)
    resolved_date = models.DateTimeField(null=True, blank=True)

    def __str__(self):
        return self.title

    def generate_client_id(self):
        return get_random_string(8, allowed_chars='0123456789abcdefzxyv')

    def get_absolute_url(self):
        return reverse("ticketapp:ticket-detail", kwargs={"pk": self.pk})

    def save(self, *args, **kwargs):
        self.ticket_id = self.generate_client_id()
        super(Ticket, self).save(*args, **kwargs)


class Comment(models.Model):
    ticket = models.OneToOneField(Ticket, on_delete=models.CASCADE)
    user = models.ForeignKey(User, on_delete=models.CASCADE)
    text = models.CharField(max_length=500)
    created_date = models.DateTimeField(null=True, auto_now_add=True)


class EmailDetails(models.Model):
    email = models.EmailField(max_length=254)
    password = models.CharField(max_length=254)

    def __str__(self):
        return self.email

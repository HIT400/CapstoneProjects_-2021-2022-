from django.db import models
from django.contrib.auth.models import User
from django.db.models.deletion import CASCADE, SET_NULL
from simple_history.models import HistoricalRecords
from django.utils.translation import gettext as _


class Organization(models.Model):
    name = models.CharField(max_length=250)
    description = models.CharField(max_length=250)
    owner = models.ForeignKey(User, on_delete=SET_NULL, null=True)
    history = HistoricalRecords()

    def __str__(self):
        return self.name


class DataType(models.Model):
    DATATYPES = (
        (1, _("ShortText")),
        (2, _("LongText")),
        (3, _("Date")),
        (4, _("DateTime")),
        (5, _("Integer")),
        (6, _("Float")),
        (7, _("Image")),
        (8, _("Boolean"))
    )

    data_type = models.PositiveBigIntegerField(
        choices=DATATYPES, default=1, null=True)

    def __str__(self):
        for i in self.DATATYPES:
            if self.data_type == i[0]:
                return i[1]


class AssessmentTemplate(models.Model):
    name = models.CharField(max_length=250)
    description = models.CharField(max_length=250)
    created_by = models.ForeignKey(
        User, on_delete=SET_NULL, null=True, related_name="created_by")
    organization = models.ForeignKey(
        Organization, on_delete=SET_NULL, null=True, related_name="organization")
    date_created = models.DateTimeField(auto_now_add=True)
    last_modified = models.DateTimeField(auto_now=True)
    published = models.BooleanField(default=False)
    history = HistoricalRecords()
    data_fields = models.JSONField(null=True, blank=True, editable=False)
    history = HistoricalRecords()

    def __str__(self):
        return self.name


class Assessment(models.Model):
    created_by = models.ForeignKey(User, on_delete=SET_NULL, null=True)
    description = models.CharField(max_length=250)
    completed = models.BooleanField(default=False)
    report_available = models.BooleanField(default=False)
    date_completed = models.DateField(null=True, blank=True)
    organization = models.ForeignKey(
        Organization, on_delete=SET_NULL, null=True)
    history = HistoricalRecords()
    assessment_template = models.JSONField(
        null=True, blank=True, editable=False)

    def __str__(self):
        return self.description


class PostImage(models.Model):
    assessment = models.ForeignKey(Assessment, default=None,
                                   on_delete=models.CASCADE)
   # image = models.ImageField(null=True)
    latitude = models.FloatField(_('Latitude'), blank=True, null=True)
    longitude = models.FloatField(_('Longitude'), blank=True, null=True)
    device_info = models.TextField(max_length=255, null=True)
    date_time = models.DateTimeField(null=True)


class UserProfile(models.Model):
    user = models.OneToOneField(User, on_delete=CASCADE)
    organization = models.ForeignKey(
        Organization, on_delete=SET_NULL, null=True)
    assessments = models.ManyToManyField(
        Assessment, blank=True)

    def __str__(self):
        return str(self.user.id)


class FollowUpJoin(models.Model):
    name = models.CharField(max_length=250)

    def __str__(self):
        return self.name


class FollowUpQuestion(models.Model):
    prompt = models.CharField(max_length=500)
    trigger_answer = models.CharField(max_length=30, null=True, blank=True)
    data_type = models.ForeignKey(DataType, on_delete=CASCADE, null=True)
    follow_up = models.ForeignKey(
        FollowUpJoin, on_delete=SET_NULL, null=True, related_name='follow_up')

    def __str__(self):
        return self.prompt


class Range(models.Model):
    name = models.CharField(null=True, max_length=250)
    minimum = models.CharField(null=True, max_length=250)
    minimum_response = models.CharField(max_length=250, null=True)
    maximum = models.CharField(null=True, max_length=250)
    maximum_response = models.CharField(max_length=250, null=True)

    def __str__(self):
        return self.name


class Link(models.Model):
    link_name = models.CharField(max_length=250, null=True)
    when_true_response = models.CharField(
        max_length=250, null=True, blank=True)
    when_false_response = models.CharField(
        max_length=250, null=True, blank=True)

    def __str__(self):
        return self.link_name


class InventoryJoin(models.Model):
    name = models.CharField(max_length=250, null=True)

    def __str__(self):
        return self.name


class Inventory(models.Model):
    item_name = models.CharField(max_length=250, null=True)
    description = models.CharField(max_length=250, null=True)
    count = models.PositiveIntegerField(null=True)
    join = models.ForeignKey(
        InventoryJoin, on_delete=SET_NULL, null=True, related_name='inventory')


class Section(models.Model):
    assessment = models.ForeignKey(
        AssessmentTemplate, related_name='section', on_delete=SET_NULL, null=True)
    section_name = models.CharField(max_length=250, null=True)
    description = models.CharField(max_length=250, null=True, blank=True)
    #floor_plan = models.ImageField(null=True, blank=True)
    repeatable = models.BooleanField(null=True)
    inventory = models.ForeignKey(
        InventoryJoin, on_delete=SET_NULL, null=True, related_name='inventory_join', blank=True)
    history = HistoricalRecords()

    def __str__(self):
        return self.section_name


class Field(models.Model):
    section = models.ForeignKey(
        Section, on_delete=SET_NULL, null=True, related_name='fields')
    prompt = models.CharField(max_length=500)
    data_type = models.ForeignKey(DataType, on_delete=CASCADE, null=True)
    range = models.ForeignKey(
        Range, null=True, on_delete=CASCADE, blank=True, related_name='range')
    follow_up_question = models.ForeignKey(
        FollowUpJoin, on_delete=SET_NULL, null=True, blank=True, related_name='follow_up_question')
    link = models.ForeignKey(Link, on_delete=SET_NULL,
                             null=True, blank=True, related_name='link')
    history = HistoricalRecords()

    def __str__(self):
        return self.prompt

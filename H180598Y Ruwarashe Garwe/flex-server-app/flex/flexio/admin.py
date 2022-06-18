from django.db import models
import nested_admin
from django.contrib import admin
from rest_framework.authtoken.admin import TokenAdmin
from .models import DataType, FollowUpJoin, UserProfile, Assessment, AssessmentTemplate, Organization, Field, FollowUpQuestion, PostImage, Link
from simple_history.admin import SimpleHistoryAdmin
from .models import (Assessment, AssessmentTemplate, DataType, Field,
                     FollowUpQuestion, Organization, PostImage,
                     Range, UserProfile, Link, Section, Inventory, InventoryJoin)

admin.site.site_header = "Assessment App"
TokenAdmin.raw_id_fields = ['user']


class PostImageUI(admin.StackedInline):
    model = PostImage
    exclude = ['location', 'device_info',
               'date_time', 'latitude', 'longitude']


class FieldInline(nested_admin.NestedTabularInline):
    model = Field


class InventoryInline(admin.TabularInline):
    model = Inventory





class Follow_Up_Inline(admin.TabularInline):
    model = FollowUpQuestion

class SectionInline(nested_admin.NestedTabularInline):
    model = Section
    inlines = [FieldInline]


class AssessmentUi(SimpleHistoryAdmin):
    list_display = ('created_by',
                    'description', 'date_completed', 'organization')
    fields = ('created_by',
              'description', 'date_completed', 'organization')
    inlines = [PostImageUI]


class ProfileUi(admin.ModelAdmin):
    list_display = ('user', 'organization')


class InventoryUI(admin.ModelAdmin):
    inlines = [InventoryInline]


class OrganizationUi(admin.ModelAdmin):
    list_display = ('name', 'description', 'owner', 'history')


class AssessmentTemplateUi(nested_admin.NestedModelAdmin, SimpleHistoryAdmin):
    list_display = ('name', 'created_by',
                    'organization', 'published', 'date_created', 'last_modified')
    inlines = [SectionInline]


class DataTypeUi(admin.ModelAdmin):
    list_display = ('data_type',)


class FollowUpQuestionUi(admin.ModelAdmin):
    inlines = [Follow_Up_Inline]


admin.site.register(Organization, OrganizationUi)
admin.site.register(UserProfile, ProfileUi)
admin.site.register(Assessment, AssessmentUi)
#admin.site.register(AssessmentTemplate, AssessmentTemplateUi)
#admin.site.register(DataType, DataTypeUi)
#admin.site.register(FollowUpJoin, FollowUpQuestionUi)
#admin.site.register(Range)
#admin.site.register(Link)
#admin.site.register(InventoryJoin, InventoryUI)

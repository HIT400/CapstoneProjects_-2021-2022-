from re import S
from django.contrib.auth.models import User
from rest_framework import serializers
from ..models import AssessmentTemplate, Field, FollowUpJoin, FollowUpQuestion, Link, Organization, Range, Section, Inventory, InventoryJoin


class UserSerializer(serializers.ModelSerializer):
    class Meta:
        model = User
        fields = ['username']


class OrganizationSerializer(serializers.ModelSerializer):
    class Meta:
        model = Organization
        fields = ['name']


class LinkSerializer(serializers.ModelSerializer):
    class Meta:
        model = Link
        fields = ['link_name', 'when_true_response', 'when_false_response']


class RangeSerializer(serializers.ModelSerializer):

    class Meta:
        model = Range
        fields = ['name', 'minimum', 'minimum_response',
                  'maximum', 'maximum_response']


class FollowUpSerializer(serializers.ModelSerializer):

    class Meta:
        model = FollowUpQuestion
        fields = ['prompt', 'trigger_answer', 'data_type']


class FollowUpJoinSerializer(serializers.ModelSerializer):
    follow_up = FollowUpSerializer(many=True)

    class Meta:
        model = FollowUpJoin
        fields = ['name', 'follow_up']


class InventorySerializer(serializers.ModelSerializer):

    class Meta:
        model = Inventory
        fields = ['item_name', 'description', 'count']


class InventoryJoinSerializer(serializers.ModelSerializer):
    inventory = InventorySerializer(many=True)

    class Meta:
        model = InventoryJoin
        fields = ['name', 'inventory']


class FieldsSerializer(serializers.ModelSerializer):
    follow_up_question = FollowUpJoinSerializer(many=False)
    link = LinkSerializer(many=False)
    range = RangeSerializer(many=False)

    class Meta:
        model = Field
        fields = ['prompt', 'data_type', 'range', 'link', 'follow_up_question']


class SectionSerializer(serializers.ModelSerializer):
    inventory = InventoryJoinSerializer(many=False)
    fields = FieldsSerializer(many=True)

    class Meta:
        model = Section
        fields = ['id', 'section_name', 'description',
                  'floor_plan', 'repeatable', 'inventory', 'fields']


class AssessmentTemplateSerializer(serializers.ModelSerializer):
    created_by = UserSerializer(many=False)
    organization = OrganizationSerializer(many=False)
    section = SectionSerializer(many=True)

    class Meta:
        model = AssessmentTemplate
        fields = ['id', 'name', 'description', 'created_by', 'organization',
                  'published', 'date_created', 'last_modified', 'section']

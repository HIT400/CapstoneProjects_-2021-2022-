# Generated by Django 4.0.3 on 2022-04-22 09:42

from django.db import migrations


class Migration(migrations.Migration):

    dependencies = [
        ('users', '0016_rename_rates_projects'),
    ]

    operations = [
        migrations.RenameField(
            model_name='projects',
            old_name='description',
            new_name='name',
        ),
    ]

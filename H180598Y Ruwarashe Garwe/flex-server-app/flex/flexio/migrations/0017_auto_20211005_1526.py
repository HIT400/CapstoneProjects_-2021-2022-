# Generated by Django 3.1.11 on 2021-10-05 13:26

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('flexio', '0016_auto_20211005_1226'),
    ]

    operations = [
        migrations.AlterField(
            model_name='followupquestion',
            name='trigger_answer',
            field=models.CharField(blank=True, max_length=30, null=True),
        ),
    ]

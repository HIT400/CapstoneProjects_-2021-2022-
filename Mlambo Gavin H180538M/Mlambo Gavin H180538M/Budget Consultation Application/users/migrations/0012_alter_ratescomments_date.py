<<<<<<< HEAD
# Generated by Django 4.0.1 on 2022-03-08 19:40

import datetime
from django.db import migrations, models
from django.utils.timezone import utc


class Migration(migrations.Migration):

    dependencies = [
        ('users', '0011_alter_ratescomments_date'),
    ]

    operations = [
        migrations.AlterField(
            model_name='ratescomments',
            name='date',
            field=models.DateTimeField(blank=True, default=datetime.datetime(2022, 3, 8, 19, 40, 53, 341455, tzinfo=utc)),
        ),
    ]
=======
# Generated by Django 4.0.1 on 2022-03-08 19:40

import datetime
from django.db import migrations, models
from django.utils.timezone import utc


class Migration(migrations.Migration):

    dependencies = [
        ('users', '0011_alter_ratescomments_date'),
    ]

    operations = [
        migrations.AlterField(
            model_name='ratescomments',
            name='date',
            field=models.DateTimeField(blank=True, default=datetime.datetime(2022, 3, 8, 19, 40, 53, 341455, tzinfo=utc)),
        ),
    ]
>>>>>>> parent of 5a30ca7... commit message

# Generated by Django 4.0.3 on 2022-04-24 08:11

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('users', '0020_alter_tarrifs_amount'),
    ]

    operations = [
        migrations.AlterField(
            model_name='tarrifs',
            name='amount',
            field=models.FloatField(),
        ),
    ]

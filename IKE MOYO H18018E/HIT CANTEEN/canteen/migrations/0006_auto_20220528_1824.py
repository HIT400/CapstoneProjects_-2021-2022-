# Generated by Django 3.1.1 on 2022-05-28 16:24

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('canteen', '0005_auto_20220512_0242'),
    ]

    operations = [
        migrations.AlterField(
            model_name='offer',
            name='name',
            field=models.CharField(max_length=30, unique=True),
        ),
    ]

# Generated by Django 4.0.1 on 2022-03-08 07:06

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('users', '0005_blockcontacts'),
    ]

    operations = [
        migrations.CreateModel(
            name='RatesComments',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('username', models.CharField(max_length=25, verbose_name='Username')),
                ('rate', models.CharField(max_length=10, verbose_name='Rate Number')),
                ('comment', models.CharField(max_length=500, verbose_name='Comment')),
                ('date', models.DateField()),
            ],
        ),
    ]

# Generated by Django 3.1.11 on 2021-09-16 14:32

from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    dependencies = [
        ('flexio', '0005_auto_20210916_1622'),
    ]

    operations = [
        migrations.AlterField(
            model_name='inventory',
            name='join',
            field=models.ForeignKey(null=True, on_delete=django.db.models.deletion.SET_NULL, related_name='invetory', to='flexio.inventoryjoin'),
        ),
    ]

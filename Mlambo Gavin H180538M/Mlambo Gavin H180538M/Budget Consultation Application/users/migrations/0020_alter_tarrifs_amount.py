<<<<<<< HEAD
# Generated by Django 4.0.3 on 2022-04-24 03:59

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('users', '0019_projects'),
    ]

    operations = [
        migrations.AlterField(
            model_name='tarrifs',
            name='amount',
            field=models.CharField(max_length=10, verbose_name='Price'),
        ),
    ]
=======
# Generated by Django 4.0.3 on 2022-04-24 03:59

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('users', '0019_projects'),
    ]

    operations = [
        migrations.AlterField(
            model_name='tarrifs',
            name='amount',
            field=models.CharField(max_length=10, verbose_name='Price'),
        ),
    ]
>>>>>>> parent of 5a30ca7... commit message

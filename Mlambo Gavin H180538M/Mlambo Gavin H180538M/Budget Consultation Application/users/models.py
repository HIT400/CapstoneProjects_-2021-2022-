from pyexpat import model
from django.db import models
from django.utils import timezone
from django.contrib.auth.models import User

class Projects(models.Model):
    rate_number= models.CharField('Rates',max_length=10)
    name= models.CharField('Description',max_length=200)
    price =models.FloatField()

    def __str__(self):
        return self.name + "" + str(self.price) + " " + self.rate_number 


class UnwantedWords(models.Model):
    #number= models.IntegerField()
    name=models.CharField("Name of word",max_length=100)
    
    def __str__(self):
        return  self.name

class BlockContacts(models.Model):
    username = models.CharField('Username',max_length=25)
    word = models.CharField('Word Used',max_length=25)
    date=models.DateTimeField(default=timezone.now, blank=True)    
    def __str__(self):
        return  self.username + " " + self.word + "  " + str(self.date)

class RatesComments(models.Model):
    username = models.CharField('Username',max_length=25)
    rate =models.CharField('Rate Number',max_length=10)
    comment= models.CharField('Comment', max_length=500)
    grade = models.CharField('Grade',max_length=1,blank=True)
    date=models.DateTimeField("%Y-%m-%d T%H:%M", blank=True)
    
    
    def __str__(self):
        return self.username + "  " + self.comment + " " + str(self.date) 

class Tarrifs(models.Model):
    name=models.CharField("Description",max_length=30)
    tarrif_number = models.CharField("Tarrif Number",max_length=10)
    amount= models.FloatField()
    update_date = models.DateTimeField()
    comment= models.CharField("Reason for Price",max_length=500,blank=True)
    username= models.CharField('Changed by',max_length=25)
    
    def __str__(self):
        return self.name + "  " + str(self.amount) + "   " +  str(self.update_date) + "  "+ self.comment  + self.username
    
class Profile(models.Model):
    user=models.ForeignKey(User, on_delete=models.CASCADE)
    ward = models.CharField("Ward",max_length=2,blank=True)
    

    def __str__(self):
        return str(self.user) + "  " + str(self.ward)

class Price(models.Model):
    description = models.CharField('Description',max_length=25)
    cost = models.FloatField('Cost') 
    def __str__(self):
        return str(self.description) + "  " + str(self.cost)

class RequestItem(models.Model):
    username= models.ForeignKey(User,on_delete=models.CASCADE)
    category = models.CharField('Category',max_length=25)
    description = models.CharField('Description',max_length=25)
    quantity=models.IntegerField('Quantity')
    status = models.CharField('Status',max_length=10)
    date = models.DateTimeField()

    def __str__(self):
        return str(self.description) + "  " + str(self.quantity)

class ViewUser(models.Model):
    id = models.BigIntegerField(primary_key=True)
    user = models.ForeignKey(User,on_delete=models.DO_NOTHING)
    ward = models.ForeignKey(Profile,on_delete=models.DO_NOTHING)

    class Meta:
        managed = False
        db_table = 'users_viewuser'

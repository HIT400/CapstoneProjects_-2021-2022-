from audioop import reverse
import email
import profile
from re import template
from tkinter.tix import MAX
from django.shortcuts import render,redirect
from django.contrib.auth.models import User
from django.urls import reverse_lazy
from django.utils import timezone
from datetime import date, datetime
from django.contrib import messages
from django.db.models import Max
from pymysql import NULL
from django.core.mail import send_mail
from django.core.mail import send_mass_mail
from django.contrib.auth import get_user_model
from django.contrib.auth.views import PasswordChangeView,PasswordResetDoneView
from requests import request



from users.models import Price, UnwantedWords,BlockContacts,RatesComments,Tarrifs,Projects,RequestItem
# Create your views here.

def dashboard(request):
    item_list=Price.objects.all()
    return render(request,'eo_officers/dashboard.html',{'item_list':item_list})

# View your request
def itemsave(request):
    if request.method == 'POST':
        uname = request.user
        cat= request.POST['category']
        desc = request.POST['description']
        quant = request.POST['quantity']
        stat='Pending'
        new_tarif = RequestItem.objects.create(username=uname,category=cat,description=desc,quantity=quant,status=stat,date=datetime.now())
        new_tarif.save() 
        current_list = RequestItem.objects.filter(username=uname)
        return render(request,'eo_officers/dashboard.html',{'current_list':current_list})
    else:       
        return render(request,'eo_officers/dashboard.html')

def denied_item(request):
    uname = request.user
    items = RequestItem.objects.filter(username=uname,status='Denied')
    return render(request,'eo_officers/request.html',{'items':items})

def approved_item(request):
    uname = request.user
    items=  RequestItem.objects.filter(username=uname,status='Approved')
    return render(request,'eo_officers/request.html',{'items':items})

def item_request(request):
    items = RequestItem.objects.filter(username=request.user)
    return render(request,'eo_officers/request.html',{'items':items})

def edit_items(request,item_id):
    if request.method == 'POST':        
        quant= request.POST['quantity']                 
        RequestItem.objects.filter(pk=item_id).update(quantity=quant)
        return redirect('item-request')
    else:
        item=RequestItem.objects.get(pk=item_id)
        return render(request,'eo_officers/edit.html',{'item':item})

def delete_item(request,item_id):
    delete_item = RequestItem.objects.get(pk=item_id)
    delete_item.delete()    
    return redirect('item-request')

def eo_request(request):
    items=RequestItem.objects.filter(status='Pending')
    return render(request,'admindash/projects.html',{'items':items})

# Approve request
def approve(request,item_id):
    stats='Approved'
    RequestItem.objects.filter(pk=item_id).update(status=stats)
    items=RequestItem.objects.get(pk=item_id)
    price_list=Price.objects.filter(description=str(items.description))   
    
    return redirect('eo-request')

# Decline request
def denied(request,item_id):
    stats= 'Denied'
    RequestItem.objects.filter(pk=item_id).update(status=stats)
    return redirect('eo-request')
#Final budget and prices


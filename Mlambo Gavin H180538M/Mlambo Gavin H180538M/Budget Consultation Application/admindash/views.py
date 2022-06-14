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

from users.models import Projects, RatesComments,Tarrifs,Profile,Price,RequestItem

class MyPasswordChangeView(PasswordChangeView):
    template_name='admindash/edit_user.html'
    success_url = reverse_lazy('pass-change-done-view')

class MyPasswordDoneView(PasswordResetDoneView):
    template_name='admindash/users.html'
# Admin Dashboard
def dashAdmin(request):
    users= User.objects.all().count()
    comments = RatesComments.objects.all().count()
    participants = RatesComments.objects.values('username').distinct().count()
    
    return render(request,'admindash/dashboard.html',
                  {'users':users,'comments':comments,
                   'participants':participants})
# Display all tarrifss
def tarrifs(request):    
    tarrif =  Tarrifs.objects.all().order_by('-update_date')
    return render(request,'admindash/tarrifs.html',{'tarrif':tarrif})
# Edit all tarrifs
def edit_tarrifs(request,tarrifs_id):
    if request.method == 'POST':
        price = request.POST['price']
        comments = request.POST['reason']
        edittarrif = Tarrifs.objects.get(pk=tarrifs_id)
        edittarrif.price = price
        print(edittarrif.price)
        Tarrifs.objects.filter(pk=tarrifs_id).update(amount=price,update_date=timezone.now())
        emails(comments)    
        return redirect('admin-tarrifs') 
    else:
        tarrif=Tarrifs.objects.get(pk=tarrifs_id)
        return render(request,'admindash/edit_tarrif.html',{'tarrif':tarrif})
# Show all comments on each tarrif
def comments(request,tarrifs_id):
    rates = Tarrifs.objects.get(pk=tarrifs_id)
    comment_list = RatesComments.objects.filter(rate=rates.tarrif_number )
    rate_name = rates.name
    name = 'All Comments for ' + str(rate_name)
    return render(request,'admindash/comments.html',{'comment_list':comment_list,'name':name})
#Show positive comments
def positive_comments(request):
    comment_list = RatesComments.objects.filter(grade='1') 
    print('The comment list is ' + str(comment_list))    
    name = 'Positive Comments'   
    return render(request,'admindash/comments.html',{'comment_list':comment_list,'name':name})
#Show Negative comments
def negative_comments(request):
    comment_list = RatesComments.objects.filter(grade='0')
    name = 'Negative comments'   
    return render(request,'admindash/comments.html',{'comment_list':comment_list,'name':name })
def netural_comments(request):
    comment_list = RatesComments.objects.filter(grade='0')
    return render(request,'admindash/comments.html',{'comment_list':comment_list})
# Delete  tarrifs
def delete_tarrifs(request,tarrifs_id):
    delete_tarrif = Tarrifs.objects.get(pk=tarrifs_id)
    delete_tarrif.delete()
    return redirect('admin-tarrifs')
# Add new tarrif
def new_tarrif(request):
    if request.method == 'POST':
        names = request.POST['names']
        price= request.POST['price']
        comments = request.POST['reason']
        tarrif = Tarrifs.objects.order_by('-tarrif_number').first()
        
        if tarrif == NULL:
            number_tarrif = 1000
            new_tarif = Tarrifs.objects.create(name=names,tarrif_number=number_tarrif,amount=price,update_date=timezone.now(),comment=comments,username=str(request.user))
        else:
            number_tarrif = int(tarrif.tarrif_number) + 1 
            new_tarif = Tarrifs.objects.create(name=names,tarrif_number=number_tarrif,amount=price,update_date=timezone.now(),comment=comments,username=str(request.user))
        new_tarif.save() 
        #emails(comments)       
        return redirect('admin-tarrifs')

# View all users
def view_users(request):   
    users = Profile.objects.select_related('user').all()
    userz = User.objects.all()
    print(userz)
    return render(request,'admindash/users.html',{'users':users})

# Show all user comments 
def show_user_comments(request,user_id):
    rates= User.objects.get(pk=user_id)
    comment_list=RatesComments.objects.filter(username=rates.username)
    counts=comment_list.count()
    return render(request,'admindash/comments.html',{'comment_list':comment_list,'counts':counts })

# edit userprofile
def edit_user(request,user_id):
    if request.method == 'POST':
        username=request.POST['username']
        name = request.POST['names']
        surname= request.POST['surname']
        email = request.POST['email']
        ward = request.POST['ward']
        password1 = request.POST['password1']
        password2 = request.POST['password2']
        if password1 == password2:            
            User.objects.filter(username=username).update(first_name=name,last_name=surname,email=email,password=password1)
            return redirect('view-users')
        else:
            messages.info(request,'password not matching')
            return redirect('edit-user')
    else:
        print('**************************************************************************')
        user=User.objects.all()
        print('**************************************************************************')
        return render(request,'admindash/edit_user.html',{'user':user})

# delete user profile
def delete_user(request,user_id):
    delete_user = User.objects.get(pk=user_id)
    delete_user.delete()
    return redirect('view-users')

def add_users(request):
    if request.method == 'POST':
        username = request.POST['username']  
        names= request.POST['name'] 
        surname= request.POST['surname']
        ward= request.POST['ward']     
        email = request.POST['emails']
        password1 = request.POST['password1']
        password2 = request.POST['password2']  

        if password1 == password2:
            if User.objects.filter(username=username).exists():
                messages.info(request,'Username taken')
                return redirect('view-users')
            elif User.objects.filter(email=email).exists():
                messages.info(request,'email already taken')
                return redirect('view-users')
            else:
                profile =Profile.objects.create(user=User.objects.create_user(username=username,first_name=names,last_name=surname,password=password1,email=email,is_superuser=True),
                ward=ward)
                subject='Bikita Rural District Consultation Platform'
                messag = f'Hi {username}. Welcome to Bikita Rural District Council Online Budget Platform. You will receive updates on everything that happens on the budget'
                from_email =  'webikita69@gmail.com'
                recipient_list=[email]
                send_mail(subject,messag,from_email,recipient_list,fail_silently=False)
                profile.save()
            
    return redirect('view-users')

def emails(comments):
    subject='Bikita Rural District Consultation Platform'        
    from_email =  'webikita69@gmail.com'       
    recievers = []
    for user in User.objects.all():
        username=user.username
        recievers.append(user.email)         
        print(comments)
        messag = f'Hi { username }. ' + str(comments)       
        send_mail(subject,messag,from_email,recievers,fail_silently=False)
#Show projects
def projects(request):
    proj = Projects.objects.all()
    return render(request,'admindash/projects.html',{'proj':proj})

def eo_request(request):
    items=RequestItem.objects.filter(status='Pending')
    print(items)
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


<<<<<<< HEAD
from email import message
from django.shortcuts import render,redirect
from django.contrib.auth import authenticate,login,logout
from django.contrib.auth.models import User
from django.views.decorators.cache import cache_control
from django.contrib import messages
from django.core.mail import send_mail
from django.conf import settings  as conf_settings
from users.models import Profile

@cache_control(no_cache=True, must_revalidate=True, no_store=True)
def login_user(request):
    if request.method == "POST":
        username = request.POST['username']
        password = request.POST['password']
        user = authenticate(request, username=username, password=password)
        if user is not None:
            login(request, user)            
            if request.user.is_superuser:               
                return redirect('admin-dashboard')
            elif request.user.is_staff:
                return redirect('dashboard')
            else:                
                return redirect('user-dashboard')           
        
        else:
            messages.success(request,("Incorrect login details. Please try  again ... "))
            return redirect('login')
    else:
     return render(request,'login/login.html')
 # logout 

def logout_user(request):
    logout(request)
    return redirect('login')

#Registering form 
def register(request):
    return render(request,'login/register.html')

def user_registration(request):
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
                profile =Profile.objects.create(user=User.objects.create_user(username=username,first_name=names,last_name=surname,password=password1,email=email),
                ward=ward)
                subject='Bikita Rural District Consultation Platform'
                messag = f'Hi {username}. Welcome to Bikita Rural District Council Online Budget Platform. You will receive updates on everything that happens on the budget'
                from_email =  'webikita69@gmail.com'
                recipient_list=[email]
                #send_mail(subject,messag,from_email,recipient_list,fail_silently=False)
                profile.save()            
        return redirect('user-dashboard')    
    else:
        return render(request,'login/login.html')
    
def settings(request):
    use = User.objects.filter(username=request.user)
    print(use)
    return render(request,'settings.html',{'use': use})

# show projects comments
def projects(request):

=======
from email import message
from django.shortcuts import render,redirect
from django.contrib.auth import authenticate,login,logout
from django.contrib.auth.models import User
from django.views.decorators.cache import cache_control
from django.contrib import messages
from django.core.mail import send_mail
from django.conf import settings  as conf_settings
from users.models import Profile

@cache_control(no_cache=True, must_revalidate=True, no_store=True)
def login_user(request):
    if request.method == "POST":
        username = request.POST['username']
        password = request.POST['password']
        user = authenticate(request, username=username, password=password)
        if user is not None:
            login(request, user)            
            if request.user.is_superuser:               
                return redirect('admin-dashboard')
            elif request.user.is_staff:
                return redirect('dashboard')
            else:                
                return redirect('user-dashboard')           
        
        else:
            messages.success(request,("Incorrect login details. Please try  again ... "))
            return redirect('login')
    else:
     return render(request,'login/login.html')
 # logout 

def logout_user(request):
    logout(request)
    return redirect('login')

#Registering form 
def register(request):
    return render(request,'login/register.html')

def user_registration(request):
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
                profile =Profile.objects.create(user=User.objects.create_user(username=username,first_name=names,last_name=surname,password=password1,email=email),
                ward=ward)
                subject='Bikita Rural District Consultation Platform'
                messag = f'Hi {username}. Welcome to Bikita Rural District Council Online Budget Platform. You will receive updates on everything that happens on the budget'
                from_email =  'webikita69@gmail.com'
                recipient_list=[email]
                #send_mail(subject,messag,from_email,recipient_list,fail_silently=False)
                profile.save()            
        return redirect('user-dashboard')    
    else:
        return render(request,'login/login.html')
    
def settings(request):
    use = User.objects.filter(username=request.user)
    print(use)
    return render(request,'settings.html',{'use': use})

# show projects comments
def projects(request):

>>>>>>> parent of 5a30ca7... commit message
    return render(request,'admindash/projects.html')
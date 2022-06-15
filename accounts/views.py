from django.shortcuts import render, redirect
from django.contrib.auth import authenticate, login, logout
from django.contrib import messages
from . forms import SignUpForm

# Create your views here.


def user_login(request):
    '''Log the user into the system'''
    if request.method == 'POST':
        username = request.POST.get('username')
        password = request.POST.get('password')
        user = authenticate(username=username, password=password)

        if user is not None:
            login(request, user)
            return redirect('ticketapp:ticket-list')
        else:
            messages.error(request, 'Invalid Login Credentials')

    return render(request, 'accounts/login.html')


def user_logout(request):
    logout(request)
    return redirect('accounts:login')


def signup(request):
    if request.method == 'POST':

        form = SignUpForm(request.POST)
        raw_password = request.POST['password1']
        password2 = request.POST['password2']

        if raw_password != password2:
            messages.error(request, 'Passwords do not match')
        if form.is_valid():
            form.save()
            username = form.cleaned_data['username']
            raw_password = form.cleaned_data['password1']

            user = authenticate(username=username, password=raw_password)
            login(request, user)
            return redirect('/')

    else:
        form = SignUpForm()
    return render(request, 'accounts/register.html', {'form': form})

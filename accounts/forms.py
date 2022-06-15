from django import forms
from django.contrib.auth.forms import UserCreationForm
from django.contrib.auth.models import User


class SignUpForm(UserCreationForm):
    username = forms.CharField(
        max_length=30, required=True, help_text="Required", widget=forms.TextInput(attrs={'placeholder': 'Username', 'class': 'form-control form-control-user'}))
    first_name = forms.CharField(
        max_length=30, required=False, help_text="Optional", widget=forms.TextInput(attrs={'placeholder': 'First Name', 'class': 'form-control form-control-user'}))
    last_name = forms.CharField(
        max_length=30, required=False, help_text="Optional", widget=forms.TextInput(attrs={'placeholder': 'Last Name', 'class': 'form-control form-control-user'}))
    email = forms.EmailField(
        max_length=254, required=True, help_text="Required", widget=forms.EmailInput(attrs={'placeholder': 'Email Address', 'class': 'form-control form-control-user'}))
    password1 = forms.CharField(
        max_length=254, required=True, help_text="Required", widget=forms.PasswordInput(attrs={'placeholder': 'Password', 'class': 'form-control form-control-user'}))
    password2 = forms.CharField(
        max_length=254, required=True, help_text="Required", widget=forms.PasswordInput(attrs={'placeholder': 'Confirm Password', 'class': 'form-control form-control-user'}))

    class Meta:
        model = User
        fields = ('username', 'first_name', 'last_name',
                  'email', 'password1', 'password2')

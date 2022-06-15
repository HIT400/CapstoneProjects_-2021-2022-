<<<<<<< HEAD
from operator import index
from unicodedata import name
from unittest import result
from xml.dom.minidom import Element
from django.contrib.auth.models import User
#from translate import Translator
import googletrans
from googletrans import *
from django.contrib import messages
from django.shortcuts import redirect, render
from django.utils import timezone
from datetime import date, datetime

from admindash.views import comments
from .models import UnwantedWords,BlockContacts,RatesComments,Tarrifs,Projects


# views for settings 

# User Dashboard view.
def users(request):   
    name = request.user 
    return render(request,'users/dashboard.html',{'name': name })
# Project views page
def projects(request): 
    if request.method == 'POST':
        user= BlockContacts.objects.filter(username=request.user).count()
        if user >= 1:
            print(user)
            messages.success(request,("You have been blocked to use this platform because you have used inapprpriate words"))
            return redirect('proposed-rates')
        else:
            print(user)
            rates = request.POST['rate_number']
            com= request.POST['comment']
            comments = request.POST['comment'].split()               
            x= ' '.join(comments).split()        
            myList =x 
            #print(myList)
            index = 0 
            find=0
            while index < len(myList):
                element=myList[index]
                result = UnwantedWords.objects.filter(name=element).count()
                find = find + result          
                index += 1
            if find >= 1:
                blockContact = BlockContacts.objects.create(username=str(request.user),date=timezone.now())
                blockContact.save()                 
            else:
                trans = translate(com)
                print('The translated is ' + str(trans)) 
                grade=sentiments(trans) 
                var = grade[0]                         
                newComment = RatesComments.objects.create(username = str(request.user),rate= rates ,comment=com,grade=var,date=datetime.now())
                newComment.save()
            return redirect('projects') 
    else:
        projects= Projects.objects.all()   
        return render(request,'users/projects.html',{'projects':projects})
# allcomments views page
def tarrifs(request):
    tarrifs= Tarrifs.objects.all()  
    for com in tarrifs:
        counts = RatesComments.objects.filter(rate=com.tarrif_number) .count() 
        print(counts) 
    projects= Projects.objects.all()
    return render(request,'users/comments.html',{'tarrifs':tarrifs,'projects':projects,'counts':counts})
# Comments Page
def post_tarrif_comments(request):    
    if request.method == 'POST':
        user= BlockContacts.objects.filter(username=request.user).count()
        if user >= 1:
            print(user)
            messages.success(request,("You have been blocked to use this platform because you have used inapprpriate words"))
            return redirect('proposed-rates')
        else:
            print(user)
            rates = request.POST['rate_number']
            com= request.POST['comment']
            comments = request.POST['comment'].split()               
            x= ' '.join(comments).split()        
            myList =x 
            #print(myList)
            index = 0 
            find=0
            while index < len(myList):
                element=myList[index]
                result = UnwantedWords.objects.filter(name=element).count()
                find = find + result          
                index += 1
            if find >= 1:
                blockContact = BlockContacts.objects.create(username=str(request.user),date=timezone.now())
                blockContact.save()                 
            else:
                trans = translate(com)
                print('The translated is ' + str(trans)) 
                grade=sentiments(trans) 
                var = grade[0]                         
                newComment = RatesComments.objects.create(username = str(request.user),rate= rates ,comment=com,grade=var,date=datetime.now())
                newComment.save()
            return redirect('proposed-rates') 
    else:
        rates= Tarrifs.objects.all()        
        return render(request,'users/rates.html',{'rates':rates})

    # Show Comments
def show_comments(request,tarrif_list_id):
    rates = Tarrifs.objects.get(pk=tarrif_list_id)
    comments=RatesComments.objects.filter(rate=rates.tarrif_number , username = request.user)
    counts=comments.count()
    print(counts)    
    return render(request,'users/allcomments.html',{'counts':counts,'rates':rates,'comments':comments})

def project_comments(request,project_list_id):
    rates= Projects.objects.get(pk=project_list_id)
    comments=RatesComments.objects.filter(rate=rates.rate_number,username= request.user)
    counts=comments.count()
    return render(request,'users/allcomments.html',{'rates':rates,'counts':counts,'comments':comments})


# Delete comments
def delete_comments(request,com_id):
    rates_number= RatesComments.objects.get(pk=com_id)
    rates_number.delete()
    findproject=Projects.objects.filter(rate_number = rates_number.rate).count()  
    if findproject > 0:
        rates= Projects.objects.get(rate_number = rates_number.rate)   
    else:
        rates=Tarrifs.objects.get(tarrif_number=rates_number.rate)
    comments=RatesComments.objects.filter(rate=rates_number.rate)
    counts=comments.count()
    return render(request,'users/allcomments.html',{'counts':counts,'rates':rates,'comments':comments})

def translate(comment):
    translator= Translator()
    texts = comment
    translation = translator.translate(texts,dest='en')
    y=(translation.text)     
    return y

def sentiments(comments):
    import numpy as np
    import pandas as pd
    from sklearn.feature_extraction.text import CountVectorizer
    from sklearn.model_selection import train_test_split
    from sklearn.naive_bayes import MultinomialNB

    from sklearn.metrics import recall_score
    from sklearn.metrics import precision_score
    from sklearn.metrics import f1_score
    DATA_JAISON_FILE=r'C:\Users\Gavie\Desktop\Final\BudgetApp\dataset\datz.csv'
    data=pd.read_csv(DATA_JAISON_FILE,encoding= 'unicode_escape')
    data.tail()
    data.shape
    data.sort_index(inplace=True)
    data.tail()
    vectorizer = CountVectorizer(stop_words='english')
    all_features=vectorizer.fit_transform(data.Comment)
    all_features.shape
    vectorizer.vocabulary_
    x_train,x_test,y_train,y_test=train_test_split(all_features,data.Label,test_size=0.2,random_state=88)
    x_train.shape
    x_test.shape
    classifier=MultinomialNB()
    classifier.fit(x_train,y_train)
    nr_correct=(y_test == classifier.predict(x_test)).sum()
    #print(f'{nr_correct} documents classfied correctly')
    nr_incorrect = y_test.size - nr_correct
    #print(f'Number of documents incorrectly classified is {nr_incorrect}')
    fraction_wrong = nr_incorrect/(nr_correct+nr_incorrect)
    #print(f'The (testing) accuracy is {1-fraction_wrong:.2%}')
    classifier.score(x_test,y_test)
    recall_score(y_test,classifier.predict(x_test))
    precision_score(y_test,classifier.predict(x_test))
    f1_score(y_test,classifier.predict(x_test))
    print("The value isssssssss " + str(comments))
    example=[comments]
    doc_term_matrix = vectorizer.transform(example)
    result=classifier.predict(doc_term_matrix)
    print(result)
    return result 


=======
from operator import index
from unicodedata import name
from unittest import result
from xml.dom.minidom import Element
from django.contrib.auth.models import User
#from translate import Translator
import googletrans
from googletrans import *
from django.contrib import messages
from django.shortcuts import redirect, render
from django.utils import timezone
from datetime import date, datetime

from admindash.views import comments
from .models import UnwantedWords,BlockContacts,RatesComments,Tarrifs,Projects


# views for settings 

# User Dashboard view.
def users(request):   
    name = request.user 
    return render(request,'users/dashboard.html',{'name': name })
# Project views page
def projects(request): 
    if request.method == 'POST':
        user= BlockContacts.objects.filter(username=request.user).count()
        if user >= 1:
            print(user)
            messages.success(request,("You have been blocked to use this platform because you have used inapprpriate words"))
            return redirect('proposed-rates')
        else:
            print(user)
            rates = request.POST['rate_number']
            com= request.POST['comment']
            comments = request.POST['comment'].split()               
            x= ' '.join(comments).split()        
            myList =x 
            #print(myList)
            index = 0 
            find=0
            while index < len(myList):
                element=myList[index]
                result = UnwantedWords.objects.filter(name=element).count()
                find = find + result          
                index += 1
            if find >= 1:
                blockContact = BlockContacts.objects.create(username=str(request.user),date=timezone.now())
                blockContact.save()                 
            else:
                trans = translate(com)
                print('The translated is ' + str(trans)) 
                grade=sentiments(trans) 
                var = grade[0]                         
                newComment = RatesComments.objects.create(username = str(request.user),rate= rates ,comment=com,grade=var,date=datetime.now())
                newComment.save()
            return redirect('projects') 
    else:
        projects= Projects.objects.all()   
        return render(request,'users/projects.html',{'projects':projects})
# allcomments views page
def tarrifs(request):
    tarrifs= Tarrifs.objects.all()  
    for com in tarrifs:
        counts = RatesComments.objects.filter(rate=com.tarrif_number) .count() 
        print(counts) 
    projects= Projects.objects.all()
    return render(request,'users/comments.html',{'tarrifs':tarrifs,'projects':projects,'counts':counts})
# Comments Page
def post_tarrif_comments(request):    
    if request.method == 'POST':
        user= BlockContacts.objects.filter(username=request.user).count()
        if user >= 1:
            print(user)
            messages.success(request,("You have been blocked to use this platform because you have used inapprpriate words"))
            return redirect('proposed-rates')
        else:
            print(user)
            rates = request.POST['rate_number']
            com= request.POST['comment']
            comments = request.POST['comment'].split()               
            x= ' '.join(comments).split()        
            myList =x 
            #print(myList)
            index = 0 
            find=0
            while index < len(myList):
                element=myList[index]
                result = UnwantedWords.objects.filter(name=element).count()
                find = find + result          
                index += 1
            if find >= 1:
                blockContact = BlockContacts.objects.create(username=str(request.user),date=timezone.now())
                blockContact.save()                 
            else:
                trans = translate(com)
                print('The translated is ' + str(trans)) 
                grade=sentiments(trans) 
                var = grade[0]                         
                newComment = RatesComments.objects.create(username = str(request.user),rate= rates ,comment=com,grade=var,date=datetime.now())
                newComment.save()
            return redirect('proposed-rates') 
    else:
        rates= Tarrifs.objects.all()        
        return render(request,'users/rates.html',{'rates':rates})

    # Show Comments
def show_comments(request,tarrif_list_id):
    rates = Tarrifs.objects.get(pk=tarrif_list_id)
    comments=RatesComments.objects.filter(rate=rates.tarrif_number , username = request.user)
    counts=comments.count()
    print(counts)    
    return render(request,'users/allcomments.html',{'counts':counts,'rates':rates,'comments':comments})

def project_comments(request,project_list_id):
    rates= Projects.objects.get(pk=project_list_id)
    comments=RatesComments.objects.filter(rate=rates.rate_number,username= request.user)
    counts=comments.count()
    return render(request,'users/allcomments.html',{'rates':rates,'counts':counts,'comments':comments})


# Delete comments
def delete_comments(request,com_id):
    rates_number= RatesComments.objects.get(pk=com_id)
    rates_number.delete()
    findproject=Projects.objects.filter(rate_number = rates_number.rate).count()  
    if findproject > 0:
        rates= Projects.objects.get(rate_number = rates_number.rate)   
    else:
        rates=Tarrifs.objects.get(tarrif_number=rates_number.rate)
    comments=RatesComments.objects.filter(rate=rates_number.rate)
    counts=comments.count()
    return render(request,'users/allcomments.html',{'counts':counts,'rates':rates,'comments':comments})

def translate(comment):
    translator= Translator()
    texts = comment
    translation = translator.translate(texts,dest='en')
    y=(translation.text)     
    return y

def sentiments(comments):
    import numpy as np
    import pandas as pd
    from sklearn.feature_extraction.text import CountVectorizer
    from sklearn.model_selection import train_test_split
    from sklearn.naive_bayes import MultinomialNB

    from sklearn.metrics import recall_score
    from sklearn.metrics import precision_score
    from sklearn.metrics import f1_score
    DATA_JAISON_FILE=r'C:\Users\Gavie\Desktop\Final\BudgetApp\dataset\datz.csv'
    data=pd.read_csv(DATA_JAISON_FILE,encoding= 'unicode_escape')
    data.tail()
    data.shape
    data.sort_index(inplace=True)
    data.tail()
    vectorizer = CountVectorizer(stop_words='english')
    all_features=vectorizer.fit_transform(data.Comment)
    all_features.shape
    vectorizer.vocabulary_
    x_train,x_test,y_train,y_test=train_test_split(all_features,data.Label,test_size=0.2,random_state=88)
    x_train.shape
    x_test.shape
    classifier=MultinomialNB()
    classifier.fit(x_train,y_train)
    nr_correct=(y_test == classifier.predict(x_test)).sum()
    #print(f'{nr_correct} documents classfied correctly')
    nr_incorrect = y_test.size - nr_correct
    #print(f'Number of documents incorrectly classified is {nr_incorrect}')
    fraction_wrong = nr_incorrect/(nr_correct+nr_incorrect)
    #print(f'The (testing) accuracy is {1-fraction_wrong:.2%}')
    classifier.score(x_test,y_test)
    recall_score(y_test,classifier.predict(x_test))
    precision_score(y_test,classifier.predict(x_test))
    f1_score(y_test,classifier.predict(x_test))
    print("The value isssssssss " + str(comments))
    example=[comments]
    doc_term_matrix = vectorizer.transform(example)
    result=classifier.predict(doc_term_matrix)
    print(result)
    return result 


>>>>>>> parent of 5a30ca7... commit message

from django.shortcuts import render, redirect
from django.http import JsonResponse
from django.contrib import messages
from django.contrib.auth.models import auth
from .utils import *
from qrcode import *
import re
import pandas as pd
import matplotlib.pyplot as plt
import io
from django.http import FileResponse



# --------------------------------------------- Views ---------------------------------------------------------------


# Login authentication
def login(request):
    if request.method == 'POST':
        username = request.POST['username']
        password = request.POST['password']

        user = auth.authenticate(username=username, password=password)

        if user is not None:
            auth.login(request, user)
            return redirect('home')
        else:
            messages.info(request, '<div class="alert alert-danger d-flex align-items-center" role="alert"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class="bi bi-exclamation-triangle-fill flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Warning:"><path d="M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z"/></svg><div>Error: Invalid login credentials</div></div>')
            return redirect('login')

    else:
        return render(request, 'login.html')


# User registration
def register(request):
    if request.method == 'POST':
        first_name = request.POST['first_name']
        last_name = request.POST['last_name']
        username = request.POST['username']
        password1 = request.POST['password1']
        password2 = request.POST['password2']
        email = request.POST['email']
        is_student = bool(request.POST.getlist('student'))
        gender = request.POST['gender']

        if password1 == password2:
            if User.objects.filter(username=username).exists():
                messages.info(request, '<div class="alert alert-warning d-flex align-items-center" role="alert"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class="bi bi-exclamation-triangle-fill flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Warning:"><path d="M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z"/></svg><div>Warning: Username already exists</div></div>')
                return redirect('register')
            if not re.match(r'^H(1[5-9]|2[0-2])([0-9]{4})[A-Z]$', username) and is_student:
                messages.info(request, '<div class="alert alert-warning d-flex align-items-center" role="alert"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class="bi bi-exclamation-triangle-fill flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Warning:"><path d="M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z"/></svg><div>Warning: Invalid username format for student</div></div>')
                return redirect('register')
            elif User.objects.filter(email=email).exists():
                messages.info(request, '<div class="alert alert-warning d-flex align-items-center" role="alert"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class="bi bi-exclamation-triangle-fill flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Warning:"><path d="M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z"/></svg><div>Warning: Email already exists</div></div>')
                return redirect('register')
            else:
                customer = Customer.objects.create(user=User.objects.create_user(username=username, password=password1,
                                                                                 email=email, first_name=first_name,
                                                                                 last_name=last_name), gender=gender,
                                                   is_student=is_student, balance=00.00)
                customer.save()
                messages.info(request, '<div class="alert alert-success d-flex align-items-center" role="alert"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class="bi bi-check flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Success:"><path d="M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zm-3.97-3.03a.75.75 0 0 0-1.08.022L7.477 9.417 5.384 7.323a.75.75 0 0 0-1.06 1.06L6.97 11.03a.75.75 0 0 0 1.079-.02l3.992-4.99a.75.75 0 0 0-.01-1.05z"/></svg><div>User account successfully created</div></div>')
                return redirect('login')
        else:
            messages.info(request, '<div class="alert alert-warning d-flex align-items-center" role="alert"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class="bi bi-exclamation-triangle-fill flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Warning:"><path d="M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z"/></svg><div>Passwords not matching...</div></div>')
            return redirect('register')
        return redirect('/')
    else:
        return render(request, 'register.html')


# User logout
def logout(request):
    auth.logout(request)
    return redirect('login')


# Homepage
def home(request):
    # Admin homepage
    if request.user.is_superuser:
        items = OrderItem.objects.order_by('date_added').reverse()[:5]
        totals = ProductTotal.objects.order_by('total_cost').reverse()[:4]
        order_totals = OrderTotal.objects.all()
        new_users = len(User.objects.filter(date_joined__gt=datetime.datetime.today().date()))
        pending_orders = len(Order.objects.filter(complete=True, collected=False))

        today = 0.00
        yesterday = 0.00
        annual = 0.00
        monthly = 0.00

        for order_total in order_totals:
            if order_total.date.year == datetime.datetime.today().year:
                annual += order_total.total_cost
                if order_total.date.month == datetime.datetime.today().month:
                    monthly += order_total.total_cost

        if OrderTotal.objects.filter(date=datetime.datetime.today().date()).exists():
            today = OrderTotal.objects.get(date=datetime.datetime.today().date()).total_cost

        if OrderTotal.objects.filter(date=datetime.datetime.today().date() - datetime.timedelta(days=1)).exists():
            yesterday = OrderTotal.objects.get(date=datetime.datetime.today().date() - datetime.timedelta(days=1)).total_cost

        context = {
            'items': items,
            'totals': totals,
            'today': today,
            'yesterday': yesterday,
            'monthly': monthly,
            'annual': annual,
            'new_users': new_users,
            'pending_orders': pending_orders
        }

        return render(request, 'administrator/index.html', context)
    # Staff homepage
    elif request.user.is_staff:
        return render(request, 'staff/index.html')
    # Customer homepage
    else:
        data = cart_data(request)
        cart_items = data['cart_items']

        recommendations = recommender(request.user.username)
        offers = Offer.objects.all()

        orders = Order.objects.filter(customer=request.user.customer)
        order_items = OrderItem.objects.filter(order__in=orders).distinct('product')[:5]

        is_open = working_hours()

        products = Product.objects.filter(name__in=recommendations.keys())

        context = {
            'products': products,
            'order_items': order_items,
            'is_open': is_open,
            'offers': offers,
            'cart_items': cart_items
        }

        return render(request, 'canteen/index.html', context)


# ---------------------------------------------------- Customer view --------------------------------------------------


# Canteen Menu
def canteen(request):
    data = cart_data(request)
    cart_items = data['cart_items']

    is_open = working_hours()

    products = Product.objects.all()
    categories = Category.objects.all().order_by('name')

    context = {'products': products, 'categories': categories, 'cart_items': cart_items, 'is_open': is_open}

    return render(request, 'canteen/menu.html', context)


# Product comments
def comment_entry(request):
    if request.method == 'POST':
        text = request.POST['comment']
        product_id = request.POST['product_id']

        customer = request.user.customer
        product = Product.objects.get(id=product_id)

        comment = Comment.objects.create(customer=customer, product=product, comment=text)
        comment.save()
        messages.info(request, '<div class="alert alert-success d-flex align-items-center" role="alert"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class="bi bi-check flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Warning:"><path d="M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zm-3.97-3.03a.75.75 0 0 0-1.08.022L7.477 9.417 5.384 7.323a.75.75 0 0 0-1.06 1.06L6.97 11.03a.75.75 0 0 0 1.079-.02l3.992-4.99a.75.75 0 0 0-.01-1.05z"/></svg><div>Comment successfully sent, thank you.</div></div>')

    return redirect('canteen')


# Cart view
def cart(request):
    data = cart_data(request)

    cart_items = data['cart_items']
    order = data['order']
    items = data['items']

    context = {'items': items, 'order': order, 'cart_items': cart_items}
    return render(request, 'canteen/cart.html', context)


# Order checkout
def checkout(request):
    data = cart_data(request)

    cart_items = data['cart_items']
    order = data['order']
    items = data['items']

    for item in items:
        ProductTotal.objects.get_or_create(product=item.product)

    context = {'items': items, 'order': order, 'cart_items': cart_items}
    return render(request, 'canteen/checkout.html', context)


# Update cart item(s)
def update_item(request):
    data = json.loads(request.body)
    product_id = data['product_id']
    action = data['action']

    customer = request.user.customer
    product = Product.objects.get(id=product_id)
    order, created = Order.objects.get_or_create(customer=customer, complete=False)

    order_item, created = OrderItem.objects.get_or_create(order=order, product=product)

    if action == 'add':
        order_item.quantity = (order_item.quantity + 1)
    elif action == 'remove':
        order_item.quantity = (order_item.quantity - 1)

    order_item.save()

    if order_item.quantity <= 0:
        order_item.delete()

    return JsonResponse('Item was added', safe=False)


# Order payment
def process_order(request):
    customer = request.user.customer

    if request.method == 'POST':
        total = float(request.POST['total'])
        order_id = request.POST['order_id']

        if customer.balance >= total:
            transaction_id = datetime.datetime.now().timestamp()
            customer.balance -= total
            customer.amount_spent += total

            order = Order.objects.get(pk=order_id)
            order.date_ordered = datetime.datetime.now()
            order.complete = True
            order.transaction_id = transaction_id
            order.total = total
            order.collect_time = order_due(order)
            order.number = order_counter(order)

            customer.save()
            order.save()

            # Receipt QR generation
            img = make(f'''#{order.number}
{order.date_ordered.date()}
Transaction: {order.transaction_id}
Name: {order.customer.user.first_name} {order.customer.user.last_name}
Username: {order.customer.user.username}
            ''')

            img.save("static/images/test.png")

            # Product totals update
            items = OrderItem.objects.filter(order=order)
            product_totals = ProductTotal.objects.all()

            for item in items:
                for total in product_totals:
                    if item.product == total.product:
                        total.total_cost += item.get_total
                        total.quantity += item.quantity
                    total.save()

            # Order totals update
            if OrderTotal.objects.filter(date=order.date_ordered.date()).exists():
                order_total = OrderTotal.objects.get(date=order.date_ordered.date())
                order_total.total_cost += order.total
                order_total.save()
            else:
                OrderTotal.objects.create(date=order.date_ordered.date(), total_cost=round(order.total, 2))
        else:
            messages.info(request,'<div class="alert alert-danger d-flex align-items-center" role="alert"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class="bi bi-exclamation-triangle-fill flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Warning:"><path d="M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z"/></svg><div>Error: Insufficient Funds</div></div>')
            return redirect('checkout')

        context = {'order': order, 'items': items}

    return render(request, 'canteen/receipt.html', context)


# Order transactions
def orders(request):
    data = cart_data(request)
    cart_items = data['cart_items']

    customer = request.user.customer
    orders = Order.objects.filter(customer=customer).order_by('date_ordered').reverse()
    items = OrderItem.objects.all()

    context = {
        'orders': orders,
        'items': items,
        'cart_items': cart_items
    }

    return render(request, 'canteen/orders.html', context)


# --------------------------------------- Admin view -----------------------------------------------------------------


# Comments view
def customer_feedback(request):
    comments = Comment.objects.all()
    dates = {comment.date_commented.date() for comment in comments}

    return render(request, 'administrator/comments.html', {'comments': comments, 'dates': dates})


# Registered customers list
def customers_list(request):
    orders = Order.objects.all()

    for order in orders:
        if order.complete:
            Customer.objects.filter(pk=order.customer.id).update(spending_score=rfm_score(order.customer.id))

    customers = Customer.objects.order_by('spending_score').reverse()

    return render(request, 'administrator/customers.html', {'customers': customers})


# Customer segmentation
def customer_segmentation(request):
    from sklearn.cluster import KMeans

    customers_df = pd.DataFrame(Customer.objects.all().values())

    X = customers_df.drop(['id', 'user_id', 'gender', 'is_student', 'balance'], axis=1).values

    kmeans = KMeans(n_clusters=4, init='k-means++', random_state=0)
    kmeans.fit(X)
    y_predicted = kmeans.predict(X)

    customers_df['Cluster'] = y_predicted

    kmeans.cluster_centers_

    plt.scatter(X[y_predicted == 0, 0], X[y_predicted == 0, 1], s=100, c='red', label='Cluster 1')
    plt.scatter(X[y_predicted == 1, 0], X[y_predicted == 1, 1], s=100, c='blue', label='Cluster 2')
    plt.scatter(X[y_predicted == 2, 0], X[y_predicted == 2, 1], s=100, c='green', label='Cluster 3')
    plt.scatter(X[y_predicted == 3, 0], X[y_predicted == 3, 1], s=100, c='cyan', label='Cluster 4')

    # plt.scatter(kmeans.cluster_centers_[:, 0], kmeans.cluster_centers_[:, 1], s = 300, c = 'yellow', label = 'Centroids',marker='*')
    plt.title('Clusters of customers')
    plt.xlabel('Amount Spent ($)')
    plt.ylabel('Spending Score')
    plt.scatter(kmeans.cluster_centers_[:, 0], kmeans.cluster_centers_[:, 1], color='purple', marker='*', label='centroid')
    plt.legend()
    plt.tight_layout()
    graph = get_image()

    return render(request, 'administrator/customer_segmentation.html', {'graph': graph})


# Order's history
def orders_history(request):
    orders = Order.objects.filter(complete=True).order_by('number')
    items = OrderItem.objects.filter()

    dates = list({order.date_ordered.date() for order in orders})
    dates.sort()
    dates.reverse()

    context = {
        'orders': orders,
        'items': items,
        'dates': dates
    }

    return render(request, 'administrator/orders.html', context)


# Product quantity charts
def quantity_charts(request):
    context = {}

    if len(OrderItem.objects.all()) > 0:
        products = ProductTotal.objects.all()

        data = {
            'product': [],
            'quantity': []
        }

        for product in products:
            data['product'].append(product.product.name)
            data['quantity'].append(int(product.quantity))

        df = pd.DataFrame(data)
        df2 = df.groupby('product', as_index=False)['quantity'].agg('sum')

        graph = get_simple_plot('bar plot', x=df2['product'], y=df2['quantity'], data=df, name='product', y_label='quantity', title='Products')

        context = {
            'graph': graph,
            'products': products
        }

    return render(request, 'administrator/quantity_charts.html', context)


# Sales charts
def sales_charts(request):
    context = {}

    if len(OrderTotal.objects.all()) > 0:
        sales = pd.DataFrame(OrderTotal.objects.all().values())

        sales2 = sales.groupby('date', as_index=False)['total_cost'].agg('sum')
        graph = get_simple_plot('line plot', x=sales2['date'], y=sales2['total_cost'], data=sales, name='Date', title='Daily Orders', y_label='Total cost')

        context = {
            'graph': graph,
        }

    return render(request, 'administrator/sales_charts.html', context)


# Order forecasting
def order_forecasting(request):
    context = {}

    if request.method == 'POST':
        title = request.POST['title']
        gender = request.POST['gender'].replace(request.POST['gender'], str(['Male', 'Female', 'Other'].index(request.POST['gender'])))
        category = Category.objects.get(name=request.POST['category'])

        is_student = True

        if title == '0':
            is_student = False

        title_dict = {
            '18': '4th year student',
            '19': '3rd year student',
            '20': '2nd year student',
            '21': '1st year student',
            '0': 'Non-student stakeholder',
        }

        if len(Order.objects.all()) > 0:
            orders = Order.objects.filter(complete=True, collected=True).order_by('id')

            data = {
                'username': [],
                'gender': [],
                'is_student': [],
                'category': [],
                'items': []
            }

            for order in orders:
                data['username'].append(order.customer.user.username)
                data['gender'].append(order.customer.gender)
                data['is_student'].append(order.customer.is_student)
                data['category'].append(OrderItem.objects.filter(order=order)[0].product.category.pk)
                data['items'].append([item.product.name for item in OrderItem.objects.filter(order=order)])

            df = pd.DataFrame(data)

            X = df.drop(columns=['items'])
            y = df['items']
            y = y.astype('str')

            X['gender'] = X['gender'].replace('Male', 1)
            X['gender'] = X['gender'].replace('Female', 2)
            X['gender'] = X['gender'].replace('Other', 3)

            for value in X['username'].values:
                if re.match(r'^H(1[5-9]|2[0-2])([0-9]{4})[A-Z]$', value):
                    X['username'] = X['username'].replace(value, int(str(value)[1:3]))
                else:
                    X['username'] = X['username'].replace(value, 0)

            from sklearn.tree import DecisionTreeClassifier
            from sklearn.model_selection import train_test_split
            from sklearn.metrics import accuracy_score

            X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2)

            model = DecisionTreeClassifier()
            model.fit(X_train, y_train)
            predictions = model.predict(X_test)

            # score = accuracy_score(y_test, predictions)
            # print(score)

            x = model.predict([[title, gender, is_student, category.pk]])
            prediction = x[0]

            messages.info(request, f'<div class="alert alert-success d-flex align-items-center" role="alert"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class="bi bi-check flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Success:"><path d="M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zm-3.97-3.03a.75.75 0 0 0-1.08.022L7.477 9.417 5.384 7.323a.75.75 0 0 0-1.06 1.06L6.97 11.03a.75.75 0 0 0 1.079-.02l3.992-4.99a.75.75 0 0 0-.01-1.05z"/></svg><div>A <strong>{title_dict[title]}</strong> is more likely to order <strong>{prediction}</strong> for <strong>{category}</strong></div></div>')
        else:
            messages.info(request, '<div class="alert alert-warning d-flex align-items-center" role="alert"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class="bi bi-exclamation-triangle-fill flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Warning:"><path d="M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z"/></svg><div>Warning: Dataset is empty/div></div>')

        return redirect('order_forecasting')

    categories = Category.objects.all()

    context['categories'] = categories

    return render(request, 'administrator/order_forecasting.html', {'categories': categories})


# Products list
def products_data(request):
    products = Product.objects.all()
    return render(request, 'administrator/products.html', {'products': products})


# Edit existing product
def edit_product(request, product_id):
    if request.method == 'POST':
        price = float(request.POST['price'])
        rating = int(request.POST['rating']) * "*"

        if type(price) is not float:
            messages.info(request, '<div class="alert alert-warning d-flex align-items-center" role="alert"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class="bi bi-exclamation-triangle-fill flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Warning:"><path d="M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z"/></svg><div>Warning: Price should be a number or decimal</div></div>')
            return redirect('edit_product')
        else:
            Product.objects.filter(pk=product_id).update(price=price, rating=rating)
            messages.info(request, f'<div class="alert alert-success d-flex align-items-center" role="alert"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class="bi bi-check flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Success:"><path d="M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zm-3.97-3.03a.75.75 0 0 0-1.08.022L7.477 9.417 5.384 7.323a.75.75 0 0 0-1.06 1.06L6.97 11.03a.75.75 0 0 0 1.079-.02l3.992-4.99a.75.75 0 0 0-.01-1.05z"/></svg><div>Edit successfull</div></div>')
            return redirect('products_data')
    else:
        product = Product.objects.get(pk=product_id)
        return render(request, 'administrator/edit_product.html', {'product': product})


# Add new product
def add_product(request):
    if request.method == 'POST':
        name = request.POST['product']
        price = float(request.POST['price'])
        image = request.FILES['image']
        category = request.POST['category']
        rating = int(request.POST['rating']) * "*"

        if Product.objects.filter(name=name).exists():
            messages.info(request, '<div class="alert alert-warning d-flex align-items-center" role="alert"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class="bi bi-exclamation-triangle-fill flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Warning:"><path d="M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z"/></svg><div>Warning: Product already exists</div></div>')
            return redirect('add_product')
        elif type(price) is not float:
            messages.info(request,'<div class="alert alert-warning d-flex align-items-center" role="alert"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class="bi bi-exclamation-triangle-fill flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Warning:"><path d="M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z"/></svg><div>Warning: Price should be a number or decimal</div></div>')
            return redirect('add_product')
        else:
            product = Product.objects.create(name=name, price=price, image=image, category=Category.objects.get(name=category), rating=rating)
            product.save()
            messages.info(request, f'<div class="alert alert-success d-flex align-items-center" role="alert"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class="bi bi-check flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Success:"><path d="M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zm-3.97-3.03a.75.75 0 0 0-1.08.022L7.477 9.417 5.384 7.323a.75.75 0 0 0-1.06 1.06L6.97 11.03a.75.75 0 0 0 1.079-.02l3.992-4.99a.75.75 0 0 0-.01-1.05z"/></svg><div>Product: <strong>{name}</strong> successfully added</div></div>')
            return redirect('products_data')
    else:
        categories = Category.objects.all()

        context = {
            'categories': categories
        }

    return render(request, 'administrator/add_product.html', context)


# Delete product
def delete_product(request, product_id):
    Product.objects.filter(pk=product_id).delete()
    messages.info(request, f'<div class ="alert alert-success d-flex align-items-center" role="alert"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class ="bi bi-check flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Success:"><path d="M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zm-3.97-3.03a.75.75 0 0 0-1.08.022L7.477 9.417 5.384 7.323a.75.75 0 0 0-1.06 1.06L6.97 11.03a.75.75 0 0 0 1.079-.02l3.992-4.99a.75.75 0 0 0-.01-1.05z"/></svg><div>Delete successful</div></div>')
    return redirect('products_data')


# Product categories
def categories_data(request):
    categories = Category.objects.all()
    return render(request, 'administrator/categories.html', {'categories': categories})


# Add new product category
def add_category(request):
    if request.method == 'POST':
        category_name = request.POST['category']

        if Category.objects.filter(name=category_name).exists():
            messages.info(request, '<div class="alert alert-warning d-flex align-items-center" role="alert"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class="bi bi-exclamation-triangle-fill flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Warning:"><path d="M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z"/></svg><div>Warning: Category already exists</div></div>')
            return redirect('add_category')
        else:
            category = Category.objects.create(name=category_name)
            category.save()
            messages.info(request, f'<div class="alert alert-success d-flex align-items-center" role="alert"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class="bi bi-check flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Success:"><path d="M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zm-3.97-3.03a.75.75 0 0 0-1.08.022L7.477 9.417 5.384 7.323a.75.75 0 0 0-1.06 1.06L6.97 11.03a.75.75 0 0 0 1.079-.02l3.992-4.99a.75.75 0 0 0-.01-1.05z"/></svg><div>Category: <strong>{category_name}</strong> successfully added</div></div>')
            return redirect('categories_data')
    else:
        return render(request, 'administrator/add_category.html')


# Delete category
def delete_category(request, category_id):
    Category.objects.filter(pk=category_id).delete()
    messages.info(request, f'<div class ="alert alert-success d-flex align-items-center" role="alert"> <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class ="bi bi-check flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Success:"><path d="M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zm-3.97-3.03a.75.75 0 0 0-1.08.022L7.477 9.417 5.384 7.323a.75.75 0 0 0-1.06 1.06L6.97 11.03a.75.75 0 0 0 1.079-.02l3.992-4.99a.75.75 0 0 0-.01-1.05z"/></svg><div>Delete successful</div></div>')
    return redirect('categories_data')


# Promotional offers
def offers_data(request):
    offers = Offer.objects.all()
    return render(request, 'administrator/offers.html', {'offers': offers,})


# Add new promotional offer
def add_offer(request):
    if request.method == 'POST':
        product = request.POST['product']
        name = request.POST['name']
        description = request.POST['description']

        if Offer.objects.filter(name=name, product=product).exists():
            messages.info(request, '<div class="alert alert-warning d-flex align-items-center" role="alert"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class="bi bi-exclamation-triangle-fill flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Warning:"><path d="M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z"/></svg><div>Warning: Offer already exists</div></div>')
            return redirect('add_offer')
        else:
            offer = Offer.objects.create(product=Product.objects.get(pk=product), name=name, description=description)
            offer.save()
            messages.info(request, f'<div class="alert alert-success d-flex align-items-center" role="alert"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class="bi bi-check flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Warning:"><path d="M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zm-3.97-3.03a.75.75 0 0 0-1.08.022L7.477 9.417 5.384 7.323a.75.75 0 0 0-1.06 1.06L6.97 11.03a.75.75 0 0 0 1.079-.02l3.992-4.99a.75.75 0 0 0-.01-1.05z"/></svg><div>Offer: <strong>{name}</strong> successfully added</div></div>')
            return redirect('offers_data')
    else:
        products = Product.objects.all()
        return render(request, 'administrator/add_offer.html', {'products': products})


# Delete promotional offer
def delete_offer(request, offer_id):
    Offer.objects.filter(pk=offer_id).delete()
    messages.info(request, f'<div class ="alert alert-success d-flex align-items-center" role="alert"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class ="bi bi-check flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Success:"><path d="M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zm-3.97-3.03a.75.75 0 0 0-1.08.022L7.477 9.417 5.384 7.323a.75.75 0 0 0-1.06 1.06L6.97 11.03a.75.75 0 0 0 1.079-.02l3.992-4.99a.75.75 0 0 0-.01-1.05z"/></svg><div>Delete successful</div></div>')
    return redirect('offers_data')


# Customer wallet deposit
def wallet_deposit(request):
    if request.method == 'POST':
        username = request.POST['username']
        amount = float(request.POST['amount'])

        if User.objects.filter(username=username).exists():
            customer = Customer.objects.get(user=User.objects.get(username=username))
            customer.balance += amount
            customer.save()

            messages.info(request, f'<div class="alert alert-success d-flex align-items-center" role="alert"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class="bi bi-check flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Success:"><path d="M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zm-3.97-3.03a.75.75 0 0 0-1.08.022L7.477 9.417 5.384 7.323a.75.75 0 0 0-1.06 1.06L6.97 11.03a.75.75 0 0 0 1.079-.02l3.992-4.99a.75.75 0 0 0-.01-1.05z"/></svg><div>A top up of $<strong>{amount}</strong> has been successfully added to <strong>{username}</strong> wallet</div></div>')
        else:
            messages.info(request, f'<div class="alert alert-danger d-flex align-items-center" role="alert"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class="bi bi-exclamation-triangle-fill flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Warning:"><path d="M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z"/></svg><div>Error: User <strong>{username}</strong> does not exist</div></div>')
            return redirect('wallet_deposit')

    return render(request, 'administrator/wallet.html')


# Sales forecasting
def sales_forecasting(request):
    order_total_df = pd.DataFrame(OrderTotal.objects.all().values())

    order_total_df['date'] = pd.to_datetime(order_total_df['date'])
    order_total_df['date'] = order_total_df['date'].map(datetime.datetime.toordinal)

    X = order_total_df.drop(columns=['id', 'total_cost'])
    y = order_total_df['total_cost']

    # Splitting the dataset into the Training set and Test set
    from sklearn.model_selection import train_test_split
    X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2, random_state=0)

    # Fitting Multiple Linear Regression to the Training set
    from sklearn.linear_model import LinearRegression
    regressor = LinearRegression()
    regressor.fit(X_train, y_train)

    y_pred = regressor.predict(X_test)

    # Calculating the R squared value
    from sklearn.metrics import r2_score

    if request.method == 'POST':
        date_from = datetime.datetime.strptime(request.POST['date_from'], '%Y-%m-%d').date()
        date_to = datetime.datetime.strptime(request.POST['date_to'], '%Y-%m-%d').date()

        if date_to < date_from:
            messages.info(request, f'<div class="alert alert-danger d-flex align-items-center" role="alert"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class="bi bi-exclamation-triangle-fill flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Warning:"><path d="M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z"/></svg><div>Error: <strong>Date from</strong> should be greater than or equal to <strong>Date to</strong></div></div>')
        else:
            def date_range(start, end):
                delta = end - start  # as timedelta
                prediction = [regressor.predict([[(date_from + datetime.timedelta(days=i)).toordinal()]]) for i in range(delta.days + 1)]
                return prediction

            print(date_range(date_from, date_to))

            total = sum(i for i in date_range(date_from, date_to))

            print(date_to)

            messages.info(request, f'<div class="alert alert-success d-flex align-items-center" role="alert"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class="bi bi-check flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Success:"><path d="M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zm-3.97-3.03a.75.75 0 0 0-1.08.022L7.477 9.417 5.384 7.323a.75.75 0 0 0-1.06 1.06L6.97 11.03a.75.75 0 0 0 1.079-.02l3.992-4.99a.75.75 0 0 0-.01-1.05z"/></svg><div>From <strong>{date_from}</strong> to <strong>{date_to}</strong> is more likely to produce total sales of <strong>${round(total[0], 2)}</strong></div></div>')

        return redirect('sales_forecasting')

    return render(request, 'administrator/sales_forecasting.html')


# --------------------------------------------------------- Staff view -----------------------------------------------


# Order collecting
def order_collect(request):
    if request.method == 'POST':
        order_id = request.POST['order_id']
        Order.objects.filter(pk=order_id).update(collected=True)

    orders = Order.objects.filter(collected=False, complete=True)
    items = OrderItem.objects.all()

    dates = list({order.date_ordered.date() for order in orders})
    dates.sort()
    dates.reverse()

    context = {
        'orders': orders,
        'items': items,
        'dates': dates
    }

    return render(request, 'staff/orders.html', context)


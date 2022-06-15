import base64
import json
import datetime
from .models import *
import matplotlib.pyplot as plt
import seaborn as sns
from io import BytesIO
import numpy as np


# ----------------------------------------------Utility functions-----------------------------------------------


# Cookie cart
def cookie_cart(request):
	try:
		cart = json.loads(request.COOKIES['cart'])
	except:
		cart = {}
		print('CART:', cart)

	items = []
	order = {'get_cart_total': 0, 'get_cart_items': 0}
	cart_items = order['get_cart_items']

	for i in cart:
		try:	
			if cart[i]['quantity'] > 0:
				cart_items += cart[i]['quantity']

				product = Product.objects.get(id=i)
				total = (product.price * cart[i]['quantity'])

				order['get_cart_total'] += total
				order['get_cart_items'] += cart[i]['quantity']

				item = {
					'id': product.id,
					'product': {'id': product.id, 'name': product.name, 'price': product.price, 'imageURL': product.imageURL},
					'quantity': cart[i]['quantity'], 'get_total': total
				}
				items.append(item)
		except:
			pass
			
	return {'cart_items': cart_items, 'order': order, 'items': items}


# Add cart data
def cart_data(request):
	if request.user.is_authenticated:
		customer = request.user.customer
		order, created = Order.objects.get_or_create(customer=customer, complete=False)
		items = order.orderitem_set.all()
		cart_items = order.get_cart_items
	else:
		cookie_data = cookie_cart(request)
		cart_items = cookie_data['cart_items']
		order = cookie_data['order']
		items = cookie_data['items']

	return {'cart_items': cart_items, 'order': order, 'items': items}


# Add due date
def order_due(order):
	# Set initial due date
	due = order.date_ordered + datetime.timedelta(minutes=15)
	previous_order = None

	# Set final due date
	if Order.objects.filter(complete=True).exists():
		orders = Order.objects.filter(complete=True).order_by('pk').reverse()[:1]
		for item in orders:
			previous_order = item
		if order.date_ordered.replace(tzinfo=datetime.timezone.utc) - Order.objects.filter(collect_time=previous_order.collect_time).reverse()[0].date_ordered < datetime.timedelta(minutes=11) and len(Order.objects.filter(collect_time=previous_order.collect_time)) < 15:
			due = previous_order.collect_time

	return due


# Order receipt number generator
def order_counter(order):
	# Set initial receipt number
	number = 1
	previous_order = None

	# Set final receipt
	if Order.objects.filter(complete=True).exists():
		orders = Order.objects.filter(complete=True).order_by('pk').reverse()[:1]
		for item in orders:
			previous_order = item
		if order.date_ordered.date() == previous_order.date_ordered.date():
			number = previous_order.number + 1

	return number


# Canteen working hours
def working_hours():
	# Set Canteen business hours
	open_time = datetime.time(hour=7, minute=45)
	close_time = datetime.time(hour=23, minute=44)
	current_time = datetime.datetime.now().time()

	# Determine if canteen is open or closed
	is_open = open_time <= current_time <= close_time

	return is_open


# Graph image
def get_image():
	# Set graph image to .png format
	buffer = BytesIO()
	plt.savefig(buffer, format='png')
	buffer.seek(0)
	image_png = buffer.getvalue()

	graph = base64.b64encode(image_png)
	graph = graph.decode('utf-8')

	buffer.close()

	return graph


# Graph plot
def get_simple_plot(chart_type, *args, **kwargs):
	# plt.switch_backend('AGG')
	# Set Graph size
	fig = plt.figure(figsize=(12.5, 5))

	# Get function arguments
	x = kwargs.get('x')
	y = kwargs.get('y')
	data = kwargs.get('data')
	name = kwargs.get('name')
	y_label = kwargs.get('y_label')
	title = kwargs.get('title')

	# Set graph labels
	plt.title(title)
	plt.xlabel(name)
	plt.ylabel(y_label)

	# Graph type
	if chart_type == 'line plot':
		plt.plot(x, y)
	elif chart_type == 'bar plot':
		plt.bar(x, y)
	else:
		sns.countplot(name, data=data)

	# Graph layout
	plt.tight_layout()

	# Capture graph on image
	graph = get_image()

	return graph


# Customer spending score
def rfm_score(customer):
	# Get customer order
	orders = Order.objects.filter(customer=customer, complete=True).order_by('date_ordered')

	# Compute rfm score
	recency = (datetime.datetime.today().date() - orders[len(orders)-1].date_ordered.date()).days
	frequency = orders.count()
	monetary = sum(order.total for order in orders)

	score = 0.05 * (0.15 * recency + 0.28 * frequency + 0.57 * monetary)

	return round(score, 2)


# Recency-Frequency-Monetary analysis
def rfm_analysis():
	rfm_df = Customer.objects.all().order_by('spending_score').values()

	rfm_df["Customer_segment"] = np.where(rfm_df['spending_score'] > 4.5, "Top Customers", (np.where(rfm_df['spending_score'] > 4, "High value Customer", (np.where(rfm_df['spending_score'] > 3, "Medium Value Customer", np.where(rfm_df['spending_score'] > 1.6, 'Low Value Customers', 'Lost Customers'))))))

	plt.pie(rfm_df.Customer_segment.value_counts(), labels=rfm_df.Customer_segment.value_counts().index, autopct='%.0f%%')

	plt.show()


# Product recommendation
def recommender(username):
	# Import sklearn library
	from sklearn.metrics.pairwise import cosine_similarity
	import pandas as pd

	# Get orders
	orders = Order.objects.filter(complete=True, collected=True)

	dataset = {}

	# Dictionary with usernames their ordered products and ratings out of 5
	for order in orders:
		if order.customer.user.username in dataset.keys():
			order_items = OrderItem.objects.filter(order=order)
			for item in order_items:
				if item.product.name not in dataset[order.customer.user.username].keys():
					dataset[order.customer.user.username][item.product.name] = len(item.product.rating)
		else:
			dataset[order.customer.user.username] = {}
			order_items = OrderItem.objects.filter(order=order)
			for item in order_items:
				dataset[order.customer.user.username][item.product.name] = len(item.product.rating)

	df = pd.DataFrame(dataset)

	# Create a data frame of this dataset
	dataset_df = pd.DataFrame(dataset)
	dataset_df.fillna("Not Ordered Yet", inplace=True)

	# Custom function to create unique set of orders
	def unique_items():
		unique_items_list = []
		for person in dataset.keys():
			for items in dataset[person]:
				unique_items_list.append(items)
		s = set(unique_items_list)
		unique_items_list = list(s)
		return unique_items_list

	# Custom function to implement cosine similarity between two orders
	def item_similarity(item1, item2):
		both_rated = {}
		for person in dataset.keys():
			if item1 in dataset[person] and item2 in dataset[person]:
				both_rated[person] = [dataset[person][item1], dataset[person][item2]]

		number_of_ratings = len(both_rated)
		if number_of_ratings == 0:
			return 0

		item1_ratings = [
			[dataset[k][item1] for k, v in both_rated.items() if item1 in dataset[k] and item2 in dataset[k]]]
		item2_ratings = [
			[dataset[k][item2] for k, v in both_rated.items() if item1 in dataset[k] and item2 in dataset[k]]]
		cs = cosine_similarity(item1_ratings, item2_ratings)
		return cs[0][0]

	# Custom function to check most similar items
	def most_similar_items(target_item):
		un_lst = unique_items()
		scores = [(item_similarity(target_item, other_item), target_item + " --> " + other_item) for other_item in
				  un_lst if other_item != target_item]
		scores.sort(reverse=True)
		return scores

	# Custom function to filter the seen products and unseen products of the target user
	def target_products_to_users(target_person):
		target_person_product_lst = []
		unique_list = unique_items()
		for products in dataset[target_person]:
			target_person_product_lst.append(products)

		s = set(unique_list)
		recommended_products = list(s.difference(target_person_product_lst))
		a = len(recommended_products)
		if a == 0:
			return 0
		return recommended_products, target_person_product_lst

	def recommendation_phase(target_person):
		if target_products_to_users(target_person=target_person) == 0:
			return -1
		not_ordered_products, ordered_products = target_products_to_users(target_person=target_person)
		seen_ratings = [[dataset[target_person][products], products] for products in dataset[target_person]]
		weighted_avg, weighted_sim = 0, 0
		rankings = []
		for i in not_ordered_products:
			for rate, product in seen_ratings:
				item_sim = item_similarity(i, product)
				weighted_avg += (item_sim * rate)
				weighted_sim += item_sim
			weighted_rank = weighted_avg / weighted_sim
			rankings.append([weighted_rank, i])

		rankings.sort(reverse=True)
		return rankings

	recommendations = {}

	tp = username
	if tp in dataset.keys():
		a = recommendation_phase(tp)
		if a != -1:
			for w, m in a:
				recommendations[m] = w

	return recommendations


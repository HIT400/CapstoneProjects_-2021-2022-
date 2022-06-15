from django.db import models
from django.contrib.auth.models import User


# Models Creation
class Customer(models.Model):
	user = models.OneToOneField(User, on_delete=models.CASCADE)
	is_student = models.BooleanField(default=False)
	gender = models.CharField(max_length=15)
	balance = models.FloatField(default=0.00)
	amount_spent = models.FloatField(default=0.00)
	spending_score = models.FloatField(default=0.00)

	def __str__(self):
		return self.user.first_name


class Category(models.Model):
	name = models.CharField(max_length=20, unique=True)

	def __str__(self):
		return self.name


class Product(models.Model):
	name = models.CharField(max_length=30, unique=True)
	price = models.FloatField()
	category = models.ForeignKey(Category, on_delete=models.CASCADE, null=True)
	image = models.ImageField(upload_to='pics')
	rating = models.CharField(max_length=5)

	def __str__(self):
		return self.name

	@property
	def imageURL(self):
		try:
			url = self.image.url
		except:
			url = ''
		return url


class Order(models.Model):
	customer = models.ForeignKey(Customer, on_delete=models.CASCADE)
	transaction_id = models.TextField(null=True)
	date_ordered = models.DateTimeField(auto_now_add=True)
	complete = models.BooleanField(default=False)
	total = models.FloatField(null=True)
	collect_time = models.DateTimeField(null=True)
	number = models.PositiveIntegerField(null=True)
	collected = models.BooleanField(default=False)

	@property
	def get_cart_total(self):
		orderitems = self.orderitem_set.all()
		self.total = sum([item.get_total for item in orderitems])
		return self.total

	@property
	def get_cart_items(self):
		orderitems = self.orderitem_set.all()
		total = sum([item.quantity for item in orderitems])
		return total


class OrderItem(models.Model):
	product = models.ForeignKey(Product, on_delete=models.CASCADE)
	order = models.ForeignKey(Order, on_delete=models.CASCADE)
	quantity = models.PositiveIntegerField(default=0)
	date_added = models.DateTimeField(auto_now_add=True)

	@property
	def get_total(self):
		total = self.product.price * self.quantity
		return total


class Comment(models.Model):
	customer = models.ForeignKey(Customer, on_delete=models.CASCADE)
	product = models.ForeignKey(Product, on_delete=models.CASCADE)
	comment = models.TextField()
	date_commented = models.DateTimeField(auto_now_add=True)

	def __str__(self):
		return self.comment


class Offer(models.Model):
	product = models.ForeignKey(Product, on_delete=models.CASCADE)
	name = models.CharField(max_length=30, unique=True)
	description = models.TextField()

	def __str__(self):
		return self.name


class ProductTotal(models.Model):
	product = models.ForeignKey(Product, on_delete=models.CASCADE)
	quantity = models.PositiveIntegerField(default=0)
	total_cost = models.FloatField(default=0.00)


class OrderTotal(models.Model):
	date = models.DateField(unique=True)
	total_cost = models.FloatField(default=0.00)


# class MessageRoom(models.Model):
# 	users = models.ManyToManyField(User, through='Message')
#
#
# class Message(models.Model):
# 	room = models.ForeignKey(MessageRoom, on_delete=models.CASCADE)
# 	message = models.TextField()
# 	sender = models.ForeignKey(User, on_delete=models.CASCADE)
# 	recipient = models.ForeignKey(User, on_delete=models.CASCADE)
# 	date = models.DateTimeField(auto_now_add=True)


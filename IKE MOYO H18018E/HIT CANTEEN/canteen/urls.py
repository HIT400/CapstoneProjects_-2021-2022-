from django.urls import path

from . import views

# Canteen URL Configuration
urlpatterns = [
	path('', views.login, name='login'),
	path('home/', views.home, name='home'),
	path('menu/', views.canteen, name='canteen'),
	path('register/', views.register, name='register'),
	path('logout/', views.logout, name='logout'),
	path('cart/', views.cart, name='cart'),
	path('checkout/', views.checkout, name='checkout'),
	path('update_item/', views.update_item, name='update_item'),
	path('process_order/', views.process_order, name='process_order'),
	path('orders/', views.orders, name='orders'),
	path('comment_entry/', views.comment_entry, name='comment_entry'),
	path('customer_feedback/', views.customer_feedback, name='customer_feedback'),
	path('customers_list/', views.customers_list, name='customers_list'),
	path('customer_segmentation/', views.customer_segmentation, name='customer_segmentation'),
	path('orders_history/', views.orders_history, name='orders_history'),
	path('sales_charts/', views.sales_charts, name='sales_charts'),
	path('order_forecasting/', views.order_forecasting, name='order_forecasting'),
	path('sales_forecasting/', views.sales_forecasting, name='sales_forecasting'),
	path('quantity_charts/', views.quantity_charts, name='quantity_charts'),
	path('products/', views.products_data, name='products_data'),
	path('products/add_product/', views.add_product, name='add_product'),
	path('products/edit_product/<product_id>', views.edit_product, name='edit_product'),
	path('products/delete_product/<product_id>', views.delete_product, name='delete_product'),
	path('categories/', views.categories_data, name='categories_data'),
	path('categories/add_category/', views.add_category, name='add_category'),
	path('categories/delete_category/<category_id>', views.delete_category, name='delete_category'),
	path('offers/', views.offers_data, name='offers_data'),
	path('offers/add_offer/', views.add_offer, name='add_offer'),
	path('offers/delete_offer/<offer_id>', views.delete_offer, name='delete_offer'),
	path('wallet_deposit/', views.wallet_deposit, name='wallet_deposit'),
	path('order_collect/', views.order_collect, name='order_collect'),
]


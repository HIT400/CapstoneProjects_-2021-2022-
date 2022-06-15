from django.contrib import admin

from .models import *


# Models Registration
class CustomerAdmin(admin.ModelAdmin):
    list_display = ('user', 'gender', 'is_student', 'balance', 'amount_spent', 'spending_score')


class ProductAdmin(admin.ModelAdmin):
    list_display = ('name', 'price', 'category', 'rating')


class OrderAdmin(admin.ModelAdmin):
    list_display = ('number', 'customer', 'date_ordered', 'complete', 'collect_time', 'total', 'collected')


class OrderItemAdmin(admin.ModelAdmin):
    list_display = ('product', 'order', 'quantity', 'date_added')


class CategoryAdmin(admin.ModelAdmin):
    list_display = ('name',)


class CommentAdmin(admin.ModelAdmin):
    list_display = ('comment', 'date_commented')


class OfferAdmin(admin.ModelAdmin):
    list_display = ('name', 'description')


class ProductTotalAdmin(admin.ModelAdmin):
    list_display = ('product', 'quantity', 'total_cost')


class OrderTotalAdmin(admin.ModelAdmin):
    list_display = ('date', 'total_cost')


admin.site.register(Customer, CustomerAdmin)
admin.site.register(Product, ProductAdmin)
admin.site.register(Order, OrderAdmin)
admin.site.register(OrderItem, OrderItemAdmin)
admin.site.register(Category, CategoryAdmin)
admin.site.register(Comment, CommentAdmin)
admin.site.register(Offer, OfferAdmin)
admin.site.register(ProductTotal, ProductTotalAdmin)
admin.site.register(OrderTotal, OrderTotalAdmin)

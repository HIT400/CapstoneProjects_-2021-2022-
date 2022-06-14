from django.contrib import admin
from .models import Projects
from .models import UnwantedWords
from .models import BlockContacts
from .models import RatesComments
from .models import Tarrifs
from .models import Profile
from .models import ViewUser
from .models import Price
from .models import RequestItem

admin.site.register(Projects)
admin.site.register(UnwantedWords)
admin.site.register(BlockContacts)
admin.site.register(RatesComments)
admin.site.register(Tarrifs)
admin.site.register(Profile)
admin.site.register(ViewUser)
admin.site.register(Price)
admin.site.register(RequestItem)
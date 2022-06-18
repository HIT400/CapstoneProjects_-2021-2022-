.ONESHELL:.
SHELL := /bin/bash

run:
	docker-compose up web

build:
	docker-compose build

shell:
	docker-compose run web python manage.py shell

migrate:
	docker-compose run web python manage.py migrate

makemigrations:
	docker-compose run web python manage.py makemigrations

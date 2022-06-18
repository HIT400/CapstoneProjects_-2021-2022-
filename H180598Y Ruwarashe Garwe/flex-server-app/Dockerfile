FROM python:3.9.0
ENV PYTHONUNBUFFERED=1
WORKDIR /app
COPY Requirements.txt /app/
RUN pip install -r Requirements.txt
COPY ./flex/ /app
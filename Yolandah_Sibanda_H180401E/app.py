from flask import Flask, jsonify, request, render_template, redirect, url_for
from prediction_model import PredictionModel
import pandas as pd
from random import randrange
from forms import OriginalTextForm
from newsapi import NewsApiClient

app = Flask(__name__)

app.config['SECRET_KEY'] = '4c99e0361905b9f941f17729187afdb9'
newsapi = NewsApiClient(api_key='78a7515000574deea08d7797f8fb117b')


@app.route("/", methods=['POST', 'GET'])
def home():
    form = OriginalTextForm()

    if form.generate.data:
        data = pd.read_csv("news_dataset.csv")
        index = randrange(0, len(data)-1, 1)
        original_text = data.loc[index].text
        form.original_text.data = str(original_text)
        return render_template('home.html', form=form, output=False)

    elif form.predict.data:
        if len(str(form.original_text.data)) > 10:
            model = PredictionModel(form.original_text.data)
            result = model.predict()
            articles = []
            if result['prediction'] == 'REAL':
                news = newsapi.get_everything(q=result['original'], language='en')
                print(news)
                if news['status'] == 'ok':
                    articles = news['articles']
            return render_template('home.html', form=form, output=result, articles=articles)

    return render_template('home.html', form=form, output=False)


@app.route('/predict/<original_text>', methods=['POST', 'GET'])
def predict(original_text):
    #text = ' '
    model = PredictionModel(original_text)
    return jsonify(model.predict())


@app.route('/random', methods=['GET'])
def random():
    data = pd.read_csv("random_dataset.csv")
    index = randrange(0, len(data)-1, 1)
    return jsonify({'title': data.loc[index].title, 'text': data.loc[index].text, 'label': str(data.loc[index].label)})


if __name__ == '__main__':
    app.run(debug=True)

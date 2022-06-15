# -*- coding: utf-8 -*-

from flask import Flask, render_template, url_for, request
import tensorflow as tf


import numpy as np


model = tf.keras.models.load_model('heart.h5')

app = Flask(__name__)


@app.route('/')

def home():
    return render_template('index.html')


@app.route('/predict', methods=['POST'])
def predict():
    if request.method == 'POST':
        age = eval(request.form['age'])
        sex = float(request.form['sex'])
        cp = float(request.form['cp'])
        trestbps = float(request.form['trestbps'])
        chol = float(request.form['chol'])
        fbs = float(request.form['fbs'])
        restecg = float(request.form['restecg'])
        thalach = float(request.form['thalach'])
        exang = float(request.form['exang'])
        oldpeak = float(request.form['oldpeak'])
        slope = float(request.form['slope'])
        ca= float(request.form['ca'])
        thal=float(request.form['thal'])

        data = np.array([[age,sex,cp,trestbps,chol,fbs,restecg,thalach,exang,oldpeak,slope,ca,thal]])
        my_prediction = model.predict(data)

        return render_template('result.html', prediction=my_prediction)

if __name__ == '__main__':
    app.run(debug=True)
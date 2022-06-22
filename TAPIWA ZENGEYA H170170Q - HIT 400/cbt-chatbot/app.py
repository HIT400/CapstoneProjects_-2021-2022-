from flask import Flask, render_template, jsonify, request
import os
import processor
os.environ['TF_CPP_MIN_LOG_LEVEL'] = '2'
import nltk
#nltk.download('punkt')
#nltk.download('wordnet')
#nltk.download('omw-1.4')


app = Flask(__name__)

@app.after_request # blueprint can also be app~~
def after_request(response):
    header = response.headers
    header['Access-Control-Allow-Origin'] = '*'
    return response

app.config['SECRET_KEY'] = 'enter-a-very-secretive-key-3479373'


@app.route('/', methods=["GET", "POST"])
def index():
    return render_template('splash.html', **locals())



@app.route('/chatbot', methods=["GET", "POST"])
def chatbotResponse():

    if request.method == 'POST':
        print(request.form)
        the_question = request.form['question']

        response = processor.chatbot_response(the_question)
    print(response)
    return jsonify({"response": response })
    



if __name__ == '__main__':
    app.run()

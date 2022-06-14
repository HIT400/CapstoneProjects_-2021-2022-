<<<<<<< HEAD
import cv2
import numpy as np
import tensorflow as tf
from inference import mappings, remidies

MODEL = tf.keras.models.load_model("vgg19_model.h5")
class DiseaseDiagnosis(object):
    def __init__(self):
        self.class_dict = {
         'Tomato___Bacterial_spot': 0,
         'Tomato___Early_blight': 1,
         'Tomato___Late_blight': 2,
         'Tomato___Leaf_Mold': 3,
         'Tomato___Septoria_leaf_spot': 4,
         'Tomato___Spider_mites Two-spotted_spider_mite': 5,
         'Tomato___Target_Spot': 6,
         'Tomato___Tomato_Yellow_Leaf_Curl_Virus': 7,
         'Tomato___Tomato_mosaic_virus': 8,
         'Tomato___healthy': 9
         }

    def predict(self, model,image):
        return model.predict([image])

    def process_image(self, filepath):
        img_array = cv2.imread(filepath, cv2.IMREAD_COLOR)
        img_array = img_array / 255
        new_array = cv2.resize(img_array, (128, 128))
        return new_array.reshape(-1, 128, 128, 3)

    def prediction_cls(self, prediction):
        for key, clss in self.class_dict.items():
            if np.argmax(prediction) == clss:
                return key

def get_disease_name(file):
    d = DiseaseDiagnosis()
    image = d.process_image(file)
    pred = d.predict(MODEL, image)
    disease = d.prediction_cls(pred)
    #disease = mappings[pred_v]
    return  disease, remidies[disease]
    
=======
import cv2
import numpy as np
import tensorflow as tf
from inference import mappings, remidies

MODEL = tf.keras.models.load_model("vgg19_model.h5")
class DiseaseDiagnosis(object):
    def __init__(self):
        self.class_dict = {
         'Tomato___Bacterial_spot': 0,
         'Tomato___Early_blight': 1,
         'Tomato___Late_blight': 2,
         'Tomato___Leaf_Mold': 3,
         'Tomato___Septoria_leaf_spot': 4,
         'Tomato___Spider_mites Two-spotted_spider_mite': 5,
         'Tomato___Target_Spot': 6,
         'Tomato___Tomato_Yellow_Leaf_Curl_Virus': 7,
         'Tomato___Tomato_mosaic_virus': 8,
         'Tomato___healthy': 9
         }

    def predict(self, model,image):
        return model.predict([image])

    def process_image(self, filepath):
        img_array = cv2.imread(filepath, cv2.IMREAD_COLOR)
        img_array = img_array / 255
        new_array = cv2.resize(img_array, (128, 128))
        return new_array.reshape(-1, 128, 128, 3)

    def prediction_cls(self, prediction):
        for key, clss in self.class_dict.items():
            if np.argmax(prediction) == clss:
                return key

def get_disease_name(file):
    d = DiseaseDiagnosis()
    image = d.process_image(file)
    pred = d.predict(MODEL, image)
    disease = d.prediction_cls(pred)
    #disease = mappings[pred_v]
    return  disease, remidies[disease]
    
>>>>>>> parent of 5a30ca7... commit message
print(get_disease_name("static/uploads/00a7c269-3476-4d25-b744-44d6353cd921___GCREC_Bact.Sp_5807.JPG"))
from cgi import test
from pyexpat import model
import sys
from PyQt5.QtWidgets import QMainWindow, QDialog, QApplication, QPushButton, QLabel, QFileDialog
from PyQt5.QtGui import QPixmap
from PyQt5.uic import loadUi
from PyQt5 import QtWidgets
import json
import numpy as np
import tensorflow as tf
import cv2

model = tf.keras.models.load_model("my_model.h5")
class MainForm(QDialog):
    def __init__(self):
        super(MainForm, self).__init__()
        self.pred = None
        loadUi('Homepage.ui', self) #loading the UI
        self.label = self.findChild(QLabel, "picture_frame") #importing widgets
        self.showimage()
        self.search_bttn.clicked.connect(self.displayMethod) #button events
        self.exit_bttn.clicked.connect(self.exitMethod)
        self.diagnose_bttn.clicked.connect(self.DiseaseDiagnosis)
    
    def showimage(self): # background image display
        pixmap = QPixmap('E:\\JupyterProjects\\crop-disease-diagnosis\\static\images\\background.jpg')
        self.bac_label.setPixmap(pixmap)        
        
    def displayMethod(self): #import image from files
        str = ''
        fname = QFileDialog.getOpenFileName(self, "Open File","E:\\JupyterProjects\\crop-disease-diagnosis\\dataset\\images", "Jpg Files (*.jpg)")
        self.label.setScaledContents(True)
        self.pixmap = QPixmap(fname[0])
        self.label.setPixmap(self.pixmap)
        for i in fname: # converts from tuple to list
            str = str + i + ","
        filepath = str.split(",")
        img_data = cv2.imread(filepath[0], cv2.IMREAD_COLOR)
        new_array = cv2.resize(img_data, (256, 256))
        image = new_array.reshape(-1, 256, 256, 3)/255
        self.pred = np.argmax(model.predict(image))
        
    def exitMethod(self): #exit button
        QApplication.instance().quit()
    
    def DiseaseDiagnosis(self):
        data = str(self.pred)
        with open('mappings.json', 'r') as f:
            mappings = json.load(f)
        with open('remidies.json', 'r') as f:
            remidies = json.load(f)
        with open('chemical.json', 'r') as f:
            chemprev = json.load(f)
            
        d_name = mappings[data]
        display = str(remidies[d_name])
        #self.diagnosis_txtbox.setText("test")
        self.diagnosis_txtbox.setText(mappings[data])
        self.chemicalprev_txtbox.setText(chemprev[data])
        self.preventation_txtbox.setText(display)
         
#main
app = QApplication(sys.argv)
widget = QtWidgets.QStackedWidget()
welcome = MainForm()
widget.addWidget(welcome)
widget.setFixedHeight(621)
widget.setFixedWidth(811)
widget.show()
try:
    sys.exit(app.exec_())
except:
    print("Existing")
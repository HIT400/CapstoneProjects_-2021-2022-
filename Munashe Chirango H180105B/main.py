import sys
import cv2
import numpy as np
from PyQt5.uic import loadUi
from PyQt5 import QtWidgets
from PyQt5.QtWidgets import QApplication, QLabel, QDialog
from PyQt5.QtGui import QPixmap, QImage
from PyQt5.QtCore import pyqtSignal, pyqtSlot, Qt, QThread
import tensorflow as tf
import sqlite3 # used because it is a prototype but in real we use postgresql

class WelcomeScreen(QDialog):
    def __init__(self):
        super(WelcomeScreen, self).__init__()
        loadUi("welcome.ui", self)
        self.adminlogin.clicked.connect(self.gotologin)
        self.studentlogin.clicked.connect(self.gotocamera)
    
    def gotocamera(self):
        camera = VideoStream()
        widget.addWidget(camera)
        widget.setCurrentIndex(widget.currentIndex()+1) 
    
    def gotologin(self):
        login = LoginScreen()
        widget.addWidget(login)
        widget.setCurrentIndex(widget.currentIndex()+1)
              
class LoginScreen(QDialog):
    def __init__(self):
        super(LoginScreen, self).__init__()
        loadUi("Login.ui", self)
        self.password_txtbox.setEchoMode(QtWidgets.QLineEdit.Password)
        self.login.clicked.connect(self.loginfunction)
        self.back_bttn.clicked.connect(self.gotomain)
        authenticate = []
        
    def loginfunction(self):
        username = self.username_txtbox.text()
        password = self.password_txtbox.text()
    
        try:
            if len(username) == 0 or len(password) == 0:
                self.errormessage.setText("Please input all Fields")
                
            else:
                conn = sqlite3.connect("school_data.db")
                cur = conn.cursor()
                query = 'SELECT password FROM login_info WHERE username =\''+ username + "\'"
                cur.execute(query)
                result_pass = cur.fetchone()[0]
                if result_pass == password:
                    mainFrm = MainScreen()
                    widget.addWidget(mainFrm)
                    widget.setCurrentIndex(widget.currentIndex()+1)
                else:
                    self.errormessage.setText("Invalid username or password")            
        except:
            print("Username Not Found")
        
    def gotomain(self):
        welcomeFrm = WelcomeScreen()
        widget.addWidget(welcomeFrm)
        widget.setCurrentIndex(widget.currentIndex()+1)
        
class MainScreen(QDialog):
    def __init__(self):
        super(MainScreen, self).__init__()
        loadUi("main.ui",self)
        self.addstudent_bttn.clicked.connect(self.gotoaddstudent)
        self.studentdata_bttn.clicked.connect(self.gotostudentdata)
        self.financedata_bttn.clicked.connect(self.gotofinancedata)
        self.logout_bttn.clicked.connect(self.gotologout)
        
    def gotoaddstudent(self):
        addstudents = AddStudent()
        widget.addWidget(addstudents)
        widget.setCurrentIndex(widget.currentIndex()+1) 
        
    def gotologout(self):
        Login = LoginScreen()
        widget.addWidget(Login)
        widget.setCurrentIndex(widget.currentIndex()+1) 
        
    def gotostudentdata(self):
        studentdata = StudentData()
        widget.addWidget(studentdata)
        widget.setCurrentIndex(widget.currentIndex()+1) 
        
    def gotofinancedata(self):
        financedata = FinanceData()
        widget.addWidget(financedata)
        widget.setCurrentIndex(widget.currentIndex()+1) 

class StudentData(QDialog):
    def __init__(self):
        super(StudentData, self).__init__()
        loadUi("studentsdata.ui",self)
        self.back_bttn.clicked.connect(self.gotomain)
        self.tableWidget.setColumnWidth(0,200) # sets the space between first column and second in the table
        self.tableWidget.setColumnWidth(1,200) # sets the space between first column and second in the table
        self.tableWidget.setColumnWidth(2,200) # sets the space between first column and second in the table
        self.tableWidget.setColumnWidth(3,200) # sets the space between first column and second in the table
        
        conn = sqlite3.connect("school_data.db")
        cur = conn.cursor()
        sqlquery = "SELECT * FROM student_info"
        
        self.tableWidget.setRowCount(50)
        tablerow = 0
        for row in cur.execute(sqlquery):
            if(len(row)) > 1:
                self.tableWidget.setItem(tablerow, 0, QtWidgets.QTableWidgetItem(row[1]))
                self.tableWidget.setItem(tablerow, 1, QtWidgets.QTableWidgetItem(row[2]))
                self.tableWidget.setItem(tablerow, 2, QtWidgets.QTableWidgetItem(row[3]))
                self.tableWidget.setItem(tablerow, 3, QtWidgets.QTableWidgetItem(row[4]))
                tablerow = tablerow+1
                
    def gotomain(self):
        mainFrm = MainScreen()
        widget.addWidget(mainFrm)
        widget.setCurrentIndex(widget.currentIndex()+1)
         
class FinanceData(QDialog):
    def __init__(self):
        super(FinanceData, self).__init__()
        loadUi("financialdata.ui",self)
        self.back_bttn.clicked.connect(self.gotomain)
        self.tableWidget.setColumnWidth(0,150) # sets the space between first column and second in the table
        self.tableWidget.setColumnWidth(1,150) # sets the space between first column and second in the table
        self.tableWidget.setColumnWidth(2,100) # sets the space between first column and second in the table
        
        conn = sqlite3.connect("school_data.db")
        cur = conn.cursor()
        sqlquery = "SELECT * FROM student_info"
        
        self.tableWidget.setRowCount(50)
        tablerow = 0
        for row in cur.execute(sqlquery):
            if(len(row)) > 1:
                self.tableWidget.setItem(tablerow, 0, QtWidgets.QTableWidgetItem(row[1]))
                self.tableWidget.setItem(tablerow, 1, QtWidgets.QTableWidgetItem(row[2]))
                self.tableWidget.setItem(tablerow, 2, QtWidgets.QTableWidgetItem(row[5]))
                tablerow = tablerow+1
    
    def gotomain(self):
        mainFrm = MainScreen()
        widget.addWidget(mainFrm)
        widget.setCurrentIndex(widget.currentIndex()+1)

class AddStudent(QDialog):
    def __init__(self):
        super(AddStudent, self).__init__()
        loadUi("addstudent.ui",self)
        self.addstudent_bttn.clicked.connect(self.savetodb)
        self.back_bttn.clicked.connect(self.gotomain)
    
    def gotomain(self):
        mainFrm = MainScreen()
        widget.addWidget(mainFrm)
        widget.setCurrentIndex(widget.currentIndex()+1)
        
    def savetodb(self):
        fullname = self.fullname_txtbox.text()
        registration = self.regnumber_txtbox.text()
        dob = self.dob_txtbox.text()
        level = self.level_txtbox.text()
        fees = self.schoolfees_txtbox.text()
        try:
            if len(fullname) == 0 or len(registration) == 0 or len(dob) == 0 or len(level) == 0 or len(fees) == 0:
                self.errorMessage_txtBox.setText("Please input all Fields")
            else:
                conn = sqlite3.connect("school_data.db")
                cur = conn.cursor()
                student_info = [fullname,registration,dob,level,fees]
                cur.execute('INSERT INTO student_info (fullname,regnumber,dob,classlevel,fees) VALUES (?,?,?,?,?)', student_info)   
                conn.commit()
                conn.close()
                self.errorMessage_txtBox.setText("Entry Recorded Successfully")
        except:
            print("Database Unavailable")

class StudentInfo(QDialog):
    def __init__(self, idname):
        super(StudentInfo, self).__init__()
        loadUi("studentinfo.ui",self)
        self.iddata = self.id_label.text()
        self.Logout_bttn.clicked.connect(self.gotomain)
        self.update_bttn.clicked.connect(self.updatedata)
    
    def updatedata(self):
        count = 0
        conn = sqlite3.connect("school_data.db")
        cur = conn.cursor()

        cur.execute(f"SELECT * FROM courses_info WHERE id ='3'")
        courses = cur.fetchone()
        
        cur.execute(f"SELECT * FROM student_info WHERE id ='3'")
        student = cur.fetchone()
        
        if len(courses) == 0:
            print("user not found")
        else:
            for option in courses:
                if option == "true":
                    count = count + 1
                    
        if len(student) == 0:
            print("user not found")
        else:
            fees = int(student[5])
            Level = int(student[4])
        
        conn.commit()
        conn.close()
        
        if self.iddata == "1":
            self.studentname_label.setText("Munashe")
        elif self.iddata == "2":
            self.studentname_label.setText("Vongai")
        elif self.iddata == "3":
            self.studentname_label.setText("Mitchel")
        else:
            self.studentname_label.setText("Student Not Registered")
            
        if Level == 2:
            if count > 6:
                self.level11_txtbox.setText("Pass")
                self.level12_txtbox.setText("Pass")
                self.overalllevel_txtbox.setText("Pass")
            else:
                self.level12_txtbox.setText("Can't Proceed to Part 2")
        elif Level == 3:
            if count > 16:
                self.level11_txtbox.setText("Pass")
                self.level12_txtbox.setText("Pass")
                self.level21_txtbox.setText("Pass")
                self.level22_txtbox.setText("Pass")
                self.overalllevel_txtbox.setText("Pass")
            else:
                self.level11_txtbox.setText("Pass")
                self.level12_txtbox.setText("Fail")
                self.level21_txtbox.setText("Pass")
                self.level22_txtbox.setText("Can't Proceed to Part 3")
                
        if courses[21] == "true": #attachment
            self.level11_txtbox.setText("Pass")
            self.level12_txtbox.setText("Pass")
            self.level21_txtbox.setText("Pass")
            self.level22_txtbox.setText("Pass")
            self.level3_txtbox.setText("Pass")
            self.overalllevel_txtbox.setText("Pass")
        else:
            self.level3_txtbox.setText("Can't Proceed to Part 4")
          
        if fees <= 0:
            self.fees_status.setText(" ")
        else:
            if fees < 10000:
                self.fees_status.setText("Pay your outstanding Balance")
            else:
                self.fees_status.setText("Paid")
                self.overalllevel_txtbox.setText("Able to Register")
        
    def gotomain(self):
        welcomeFrm = WelcomeScreen()
        widget.addWidget(welcomeFrm)
        widget.setCurrentIndex(widget.currentIndex()+1)
    
    def displayInfo(self):
        self.show()
       
class VideoStream(QDialog, QThread):
    ImageUpdate = pyqtSignal(QImage)
    def __init__(self):
        super(VideoStream, self).__init__()
        loadUi("camera.ui",self) 
        self.label = self.findChild(QLabel, "picture_frame") #importing widgets
        self.startcapture_bttn.clicked.connect(self.passingInformation)
        self.stop_bttn.clicked.connect(self.CancelFeed)
        self.back_bttn.clicked.connect(self.gotomain)
        self.idname = "4"
        self.infoWindow = StudentInfo(self.idname)
    def run(self):
        self.ThreadActive = True
        face_classifier = cv2.CascadeClassifier("haarcascade_frontalface_default.xml")
        self.Capture = cv2.VideoCapture(0)
        try:
            while self.ThreadActive:
                ret, frame = self.Capture.read()
                if ret:
                    FlippedImage = cv2.flip(frame, 1)
                    ConvertToQtFormat = QImage(FlippedImage.data, FlippedImage.shape[1], FlippedImage.shape[0], QImage.Format_RGB888)
                    Pic = ConvertToQtFormat.scaled(640, 480, Qt.KeepAspectRatio)
                    self.ImageUpdate.emit(Pic)
                    
                    #gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
                    faces = face_classifier.detectMultiScale(frame, 1.5, 5) 
                    while faces is ():
                        print("waiting")
                        return None
                    for (x, y, w, h) in faces:
                        cropped_face = frame[y:y+h,x:x+w]
                    
                    face = cv2.resize(cropped_face, (50,50)) # 200 , 200
                    face = cv2.cvtColor(face, cv2.COLOR_BGR2GRAY)
                    detect_face = np.array(face)
                    detect_face = detect_face.reshape(-1,50,50,1)
                    model = tf.keras.models.load_model('model/my_model.h5')
                    model_out = model.predict(detect_face)
                    self.ThreadActive = False
                    if np.argmax(model_out) == 3:
                        print("mitchel")
                        self.idname = "1"
                        self.infoWindow.id_label.setText(self.idname)
                    elif np.argmax(model_out) == 1:
                        print("munashe")
                        self.idname = "3"
                        self.infoWindow.id_label.setText(self.idname)
                    elif np.argmax(model_out) == 2:
                        print("Vongai")
                        self.idname = "2"
                        self.infoWindow.id_label.setText(self.idname)
                    else:
                        print("not recognized")
                        self.idname = "0"
                        self.infoWindow.id_label.setText(self.idname)
        except Exception as e:
            print(e)
    
    def stop(self):
        self.ThreadActive = False
        self.Capture.release()
        self.quit()       
        #self.wait() # waits for thread to finish
        
    def data(self):
        self.infoWindow.id_label.setText(self.idname)
        self.hide()
        self.infoWindow.displayInfo()
    
    def passingInformation(self):
        self.Video = VideoStream()
        self.Video.run()
        self.Video.ImageUpdate.connect(self.ImageUpdateSlot)
        self.Video.data()
    
    def CancelFeed(self):
        self.VideoStream.stop()
        
    def ImageUpdateSlot(self, Image):
        self.label.setPixmap(QPixmap.fromImage(Image))
        
    def gotomain(self):
        mainFrm = WelcomeScreen()
        widget.addWidget(mainFrm)
        widget.setCurrentIndex(widget.currentIndex()+1)
#main
app = QApplication(sys.argv)
welcome = WelcomeScreen()
widget = QtWidgets.QStackedWidget()
widget.addWidget(welcome)
widget.setFixedHeight(600)
widget.setFixedWidth(800)
widget.show()
try:
    sys.exit(app.exec_())
except:
    print("Existing")
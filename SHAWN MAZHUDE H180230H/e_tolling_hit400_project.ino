#include <MFRC522.h>
#include <SPI.h>
MFRC522 mfrc522(10, 9); // MFRC522 mfrc522(SS_PIN, RST_PIN)
#include <Servo.h> 
#include <Wire.h> 
#include <LiquidCrystal_I2C.h>
LiquidCrystal_I2C lcd(0x27,16,2);
#include <SoftwareSerial.h>
SoftwareSerial SIM900(2,3);

String VehicleNumber;
Servo myservo; 
#define sensor 8
#define red A0
#define green A1

int ind1; // , locations
int ind2;
int ind3;
int ind4;

String phonenumber;
String AvailableBalance;
String tollname;
String stat;
String database;
String txtmessage;

 
void setup() {
  // put your setup code here, to run once:
  SIM900.begin(9600);
  lcd.init();
  lcd.backlight();
pinMode(sensor,INPUT);
pinMode(green,OUTPUT);
pinMode(red,OUTPUT);
Serial.begin(9600);
SPI.begin();      // Init SPI bus
mfrc522.PCD_Init();   // Init MFRC52
myservo.attach(A2);
  SIM900.println("AT"); //Handshaking with SIM900
  SIM900.println("AT+CMGF=1"); // Configuring TEXT mode
  SIM900.println("AT+CNMI=1,2,0,0,0"); // Decides how newly arrived SMS messages should be handled



 lcd.print("   Shawn.M  ");
 lcd.setCursor(0,1);
 lcd.print("HIT400 PROJECT  ");
 delay(2000);
 lcd.clear();
 
}

void loop() {
  // put your main code here, to run repeatedly:
START:
        if ( ! mfrc522.PICC_IsNewCardPresent()) {
      lcd.setCursor(0,0);
      lcd.print("WAITING FOR CAR");
      digitalWrite(red,LOW);
      digitalWrite(green,LOW);
      return;
    }


    // Select one of the cards
    if ( ! mfrc522.PICC_ReadCardSerial()) {
      
      return;
    }
    //Reading from the card
    String tag = "";
    for (byte j = 0; j < 2; j++)
    {
      tag.concat(String(mfrc522.uid.uidByte[j] < 0x10 ? " 0" : ""));
      tag.concat(String(mfrc522.uid.uidByte[j], DEC));
    }
  
   VehicleNumber = tag.substring(1);
   //Serial.print(VehicleNumber);

lcd.clear();
Serial.print(VehicleNumber + "A"  + "\r\n");
delay(500);

//if(!Serial.available()){
 // return;
 // }
 lcd.print("PLEASE WAIT");
 while(!(Serial.available())){}

while(Serial.available() > 0){
 
  char in = Serial.read();


if(in == 'T'){
  goto START;
  }
 
  if(in == '1'){
lcd.setCursor(0,1);
lcd.print("RECOGNISED      ");
digitalWrite(green,HIGH);
    delay(1000);
lcd.clear();

   while(Serial.available())  {
    char c = Serial.read();
    
    if(c == '\n'){
      ind1 = database.indexOf(',');  //finds location of first ,
      phonenumber = database.substring(0, ind1);   //captures first data String
      ind2 = database.indexOf(',', ind1+1 );   //finds location of second ,
      AvailableBalance = database.substring(ind1+1,ind2);   //captures second data String
      ind3 = database.indexOf(',', ind2+1 );
      tollname = database.substring(ind2+1, ind3);
      ind4 = database.indexOf(',', ind3+1 );
      stat = database.substring(ind3+1); //captures remain part of data after last ,

    if(stat ==  "C"){
    lcd.setCursor(0,0);
    lcd.print("Trans Success");
    lcd.setCursor(0,1);
    lcd.print("Balance:");
    lcd.print(AvailableBalance);
    myservo.write(90);
    while(!digitalRead(sensor));
    delay(2000);
    myservo.write(0);
    txtmessage = "\nTransaction Successful at " + tollname + ". New balance is ZWL$" + AvailableBalance;
    sendSMS(txtmessage);

    delay(1000);
      
      }

    if(stat ==  "I"){
    digitalWrite(red,HIGH);
    lcd.setCursor(0,0);
    lcd.print("Trans Failed");
    lcd.setCursor(0,1);
    lcd.print("Balance:");
    lcd.print(AvailableBalance); 
    txtmessage = "\nTransaction failed at " + tollname + ". New balance is ZWL$" + AvailableBalance;
    sendSMS(txtmessage);    
    delay(1000);  
      }

      

    
      database = ""; 
 
      }
      
      else{
        
     database += c;   
        }
    
    
    }
 

    
     }
   if(in == '0'){
//digitalWrite(trans,LOW);
lcd.setCursor(0,1);
lcd.print("NOT REGISTERED      ");
digitalWrite(red,HIGH);
    delay(1000);

     }
  
  }

delay(1000);
  lcd.clear();
}

void sendSMS(String message){
  SIM900.println("AT"); //Handshaking with SIM900
  SIM900.println("AT+CMGF=1"); // Configuring TEXT mode
  SIM900.print("AT+CMGS=\"" + phonenumber + "\"");
  //SIM900.println("AT+CMGS=\"+263782141728\"");//change ZZ with country code and xxxxxxxxxxx with phone number to sms
  SIM900.print(message); //text content
  SIM900.write(26);
  delay(5000);
}

int relay_pins[] = {2,3,4,5,6,7,8,9};
#define led 13//onboard
String odebrane ="";
int relay_number;
int blink(){
  digitalWrite(led, HIGH);
  delay(500);
  digitalWrite(led, LOW);
  delay(100);
}
void serialEvent(){
  odebrane = Serial.readString();
  if(odebrane.substring(0,5)=="relay"){

  relay_number = odebrane.substring(6,7).toInt();

  if(odebrane.substring(9,11)=="on"){
    digitalWrite(relay_pins[((relay_number)-1)], LOW);
  }else if(odebrane.substring(9,12)=="off"){
    digitalWrite(relay_pins[((relay_number)-1)], HIGH);
  }
  }
}
void setup() {
  pinMode(led, OUTPUT);
  Serial.begin(9600);
  Serial.setTimeout(15);
  while (!Serial) {
    digitalWrite(led, HIGH);
    delay(50);
    digitalWrite(led, LOW);
    delay(50);// wait for serial port to connect. Needed for native USB port only
  }
  pinMode(2, OUTPUT);
  pinMode(3, OUTPUT);
  pinMode(4, OUTPUT);
  pinMode(5, OUTPUT);
  pinMode(6, OUTPUT);
  pinMode(7, OUTPUT);
  pinMode(8, OUTPUT);
  pinMode(9, OUTPUT);

  digitalWrite(2, HIGH);
  digitalWrite(3, HIGH);
  digitalWrite(4, HIGH);
  digitalWrite(5, HIGH);
  digitalWrite(6, HIGH);
  digitalWrite(7, HIGH);
  digitalWrite(8, HIGH);
  digitalWrite(9, HIGH);

  
}

void loop() {

}

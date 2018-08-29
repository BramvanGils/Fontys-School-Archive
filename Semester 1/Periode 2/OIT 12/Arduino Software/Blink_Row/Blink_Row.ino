int sensorPin = 0;    // The potentiometer is connected to
                      // analog pin 0
                      
int ledPin = 13;      // The LED is connected to digital pin 13

// the setup function runs once when you press reset or power the board
void setup() {
  // initialize digital pin LED_BUILTIN as an output.
  pinMode(13, OUTPUT);
  pinMode(12, OUTPUT);
  pinMode(11, OUTPUT);
  pinMode(10, OUTPUT);
  pinMode(9, OUTPUT);
  pinMode(8, OUTPUT);
  
  
}

// the loop function runs over and over again forever
void loop() {
   AllOn();
   AllOff();
}

void AllOn()
{
  int sensorValue;
  sensorValue = analogRead(sensorPin);
  
  digitalWrite(13, HIGH);
  delay(sensorValue);
  digitalWrite(12, HIGH);
  delay(sensorValue);
  digitalWrite(11, HIGH);
  delay(sensorValue);
  digitalWrite(10, HIGH);
  delay(sensorValue);
  digitalWrite(9, HIGH);
  delay(sensorValue);
  digitalWrite(8, HIGH);
  delay(sensorValue);
}

void AllOff()
{
  int sensorValue;
  sensorValue = analogRead(sensorPin);
  
  digitalWrite(13, LOW);
  delay(sensorValue);
  digitalWrite(12, LOW);
  delay(sensorValue);
  digitalWrite(11, LOW);
  delay(sensorValue);
  digitalWrite(10, LOW);
  delay(sensorValue);
  digitalWrite(9, LOW);
  delay(sensorValue);
  digitalWrite(8, LOW);
  delay(sensorValue);
}

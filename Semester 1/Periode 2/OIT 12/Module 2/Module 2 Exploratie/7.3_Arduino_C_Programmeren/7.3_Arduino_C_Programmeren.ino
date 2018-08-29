int ledPin = 9;    // LED connected to digital pin 9
String Protocol;
int Delay = 30;
bool play = true;

void setup() {
   Serial.begin(9600);     // opens serial port, sets data rate to 9600 bps
}

void loop() 
{
  CheckInput();
  if (Protocol == "PAUSE_FADE")
  {
    play = false;
  }
  else if (Protocol == "RESUME_FADE")
  {
    play = true;
  }
  else if (Protocol.substring(0,10) == "SET_DELAY:")
  {
      Delay = Protocol.substring(10,13).toInt();
  }
  
  if(play)
  {
    Fade();
  }
  
}

void CheckInput()
{
  if (Serial.available() > 0)
  {
    if(Serial.read() == '#')
    {
      Protocol = ReadInput();
      Serial.println(Protocol);
    }
  }
}

String ReadInput()
{
  while(Serial.available() == 0){}
  
    char InputChar = Serial.read();
    String InputString = "";
  
  while(InputChar != '%')
  {
    if(Serial.available() > 0)
    {
      InputString += char(InputChar);
      InputChar = Serial.read();
    }
  }
  return String(InputString);
}

void Fade(){
  // fade in from min to max in increments of 5 points:
  for (int fadeValue = 0 ; fadeValue <= 255; fadeValue += 5) {
    // sets the value (range from 0 to 255):
    analogWrite(ledPin, fadeValue);
    // wait for 30 milliseconds to see the dimming effect
    delay(Delay);
  }

  // fade out from max to min in increments of 5 points:
  for (int fadeValue = 255 ; fadeValue >= 0; fadeValue -= 5) {
    // sets the value (range from 0 to 255):
    analogWrite(ledPin, fadeValue);
    // wait for 30 milliseconds to see the dimming effect
    delay(Delay);
  }
}

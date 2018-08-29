int ledPinRood = 11;
int ledPinGroen = 10;
int ledPinBlauw = 9;

String Protocol;

void setup() 
{
  Serial.begin(9600);     // opens serial port, sets data rate to 9600 bps

  pinMode(ledPinGroen,OUTPUT);
  pinMode(ledPinRood,OUTPUT);
  pinMode(ledPinBlauw,OUTPUT);
}

void loop() 
{
  Protocol = CheckForInput();
  if (Protocol == "LED_ON")
  {
    digitalWrite(ledPinRood,HIGH);
  }

  if (Protocol == "LED_OFF")
  {
    digitalWrite(ledPinRood,LOW);
  }

  while(millis() > 30000)
  {
    digitalWrite(ledPinRood,LOW);
    delay(200);
    digitalWrite(ledPinRood,HIGH);
    delay(200);
  }
}

String CheckForInput()
{
  while (Serial.available() > 0)
  {
    if(Serial.read() == '#')
    {
      return ReadInput();
    }
  }
  return "INVALID_INPUT";
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

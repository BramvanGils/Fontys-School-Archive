
void setup() {
        Serial.begin(9600);     // opens serial port, sets data rate to 9600 bps
}

void loop() 
{
  if (Serial.available() > 0)
  {
    if(Serial.read() == '#')
    {
      String Protocol = ReadInput();
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

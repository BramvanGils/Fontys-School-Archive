String ReadInput()
{
  while (Serial.available() == 0) {}

  char InputChar = Serial.read();
  String InputString = "";

  while (InputChar != '%')
  {
    if (Serial.available() > 0)
    {
      InputString += char(InputChar);
      InputChar = Serial.read();
    }
  }
  return String(InputString);
}

void FindInput()
{
  if (Serial.available() > 0)
  {
    if (Serial.read() == '#')
    {
      Protocol = ReadInput();
      Serial.println(Protocol);
    }
  }
  CompileInput();
}



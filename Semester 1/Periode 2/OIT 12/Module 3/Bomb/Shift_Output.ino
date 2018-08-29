void OutputShift()
{
  byte data = PotData() + RGBData() + LedData();

  shiftOut(datapin, clockpin, MSBFIRST, data);
  digitalWrite(latchpin, HIGH);
  digitalWrite(latchpin, LOW);
}

byte PotData()
{
  byte potvalue = map(analogRead(2), 0, 450, 0, 15);
  potvalue = constrain(potvalue, 0, 15);
  return potvalue * 16;
}

byte RGBData()
{
  if (ButtonAState)
  {
    RGBState++;
  }
  if (RGBState > 7)
  {
    RGBState = 0;
  }
  return RGBState * 2;
}

byte LedData()
{
  return millis() / 1000 % 2;
}

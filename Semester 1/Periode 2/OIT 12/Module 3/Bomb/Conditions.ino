bool Condition(byte Index)
{
  if(Index < 2)
  {
    return LedStatus(Index);
  }
  else if(Index < 18)
  {
    return LedSerieStatus(Index - 2);
  }
  else if(Index < 28)
  {
    return LastNumberStatus(Index - 18);
  }
  else
  {
    return RGBStatus(Index - 28);
  }
}

bool LedStatus(byte Index)
{
  if(millis() / 1000 % 2 == Index)
  {
    return true;
  }
  return false;
}

bool LedSerieStatus(byte Index)
{
  if(PotData() == Index * 16)
  {
    return true;
  }
  return false;
}

bool LastNumberStatus(byte Index)
{
  long TimeLeft = MaxTime - (millis() - ExtraTime);
  if((TimeLeft / 1000) % 10 == Index)
  {
    return true;
  }
  return false;
}

bool RGBStatus(byte Index)
{
  if(RGBData() == Index * 2)
  {
    return true;
  }
  return false;
}

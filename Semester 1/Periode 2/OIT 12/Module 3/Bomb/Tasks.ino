byte CurrentTask = 0;
byte Tasks[4];
byte condition[4];

bool ProcesTasks()
{
  lcd.setCursor(8, 0);
  lcd.print(CurrentTask);
  if (CheckTask(Tasks[CurrentTask]))
  {
    if(Condition(condition[CurrentTask]))
    {
      CurrentTask++;
    }
    else
    {
      Boom();
    }
  }
  
  if (CurrentTask > 3)
  {
    return true;
  }
  else
  {
    return false;
  }
}

bool CheckTask(byte index)
{
  if (index == 0)
  {
    return ButtonBState;
  }
  else
  {
    return CutWire(index);
  }
}

bool CutWire(byte index)
{
  if (digitalRead(16 + index) == HIGH)
  {
    Serial.println("test");
    return true;
  }
  else
  {
    return false;
  }
}

bool CheckMistake()
{
    for (int i = CurrentTask; i < 4; i++)
    {
      if (CutWire(Tasks[i]) && Tasks[i] != 0)
      {
        return true;
      }
    }

    for (int i = 0; i < CurrentTask; i++)
    {
      if (CutWire(Tasks[i]) == false && Tasks[i] != 0)
      {
        return true;
      }
    }
    ButtonCheck();

    if(ButtonBState && Tasks[CurrentTask] != 0)
    {
      return true;
    }
  return false;
}

void CompileInput()
{
  if(Protocol.substring(0,5) == "START")
  {
    for(int i = 0; i < 4; i++)
    {
      Tasks[i] = Protocol.substring(5 + 3 * i, 5 + 3 * i + 1).toInt();
      condition[i] = Protocol.substring(6 + 3 * i, 6 + 3 * i + 2).toInt();
    }
    Start = true;
  }
}

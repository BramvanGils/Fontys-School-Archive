String Protocol;
long MaxTime = 120000;
long ExtraTime;
byte RGBState = 7;
bool ButtonAState;
bool ButtonBState;
bool Start = false;

#include <LiquidCrystal.h>
const int DraadpinRood = 19, DraadpinBlauw = 18, DraadpinGreen = 17 , Potpin = 2, ButtonApin = 15, ButtonBpin = 14, rs = 13, en = 12, latchpin = 8, datapin = 7, clockpin = 6, d4 = 5, d5 = 4, d6 = 3, d7 = 2;
LiquidCrystal lcd(rs, en, d4, d5, d6, d7);

void SetPinmodes()
{
  pinMode(datapin, OUTPUT);
  pinMode(clockpin, OUTPUT);
  pinMode(latchpin, OUTPUT);
}

void SetLCD()
{
  lcd.begin(16, 2);
  lcd.print("TIME");
}

void setup()
{
  SetPinmodes();

  

  // set serial
  Serial.begin(9600);

  while(Start == false)
  {
    FindInput();
  }

  // prepare LCD
  SetLCD();

  // Set the extra time
  ExtraTime = millis();
}

void loop()
{
  if (Protocol != "BOOM" && Protocol != "DEFUSED")
  {
    OutputShift();
    if (PrintTime() || CheckMistake())
    {
      Boom();
    }
    if (ProcesTasks())
    {
      Defused();
    }
  }
}

bool PrintTime()
{
  long TimeLeft = MaxTime - (millis() - ExtraTime);
  if (TimeLeft < 0)
  {
    return true;
  }
  lcd.setCursor(0, 1);
  lcd.print((TimeLeft / 1000) / 60);
  lcd.setCursor(1, 1);
  lcd.print(":");
  int seconds = (TimeLeft / 1000) % 60;
  if (seconds < 10)
  {
    lcd.setCursor(2, 1);
    lcd.print(0);
    lcd.setCursor(3, 1);
    lcd.print(seconds);
  }
  else
  {
    lcd.setCursor(2, 1);
    lcd.print(seconds);
  }
  

  
  return false;
}

bool ButtonCheck()
{
  // Save button states
  bool ButtonStateAA = digitalRead(ButtonApin);
  bool ButtonStateAB = digitalRead(ButtonBpin);
  delay(50);
  bool ButtonStateBA = digitalRead(ButtonApin);
  bool ButtonStateBB = digitalRead(ButtonBpin);

  if(ButtonStateAA && !ButtonStateBA)
  {
    ButtonAState = true;
  }
  else
  {
    ButtonAState = false;
  }

  if(ButtonStateAB && !ButtonStateBB)
  {
    ButtonBState = true;
  }
  else
  {
    ButtonBState = false;
  }
}

void Boom()
{
  Protocol = "BOOM";
  Serial.print('#' + Protocol + '%');
  
  shiftOut(datapin, clockpin, MSBFIRST, 255);
  digitalWrite(latchpin, HIGH);
  digitalWrite(latchpin, LOW);

  lcd.setCursor(8, 0);
  lcd.print("EXPLODED");
}

void Defused()
{
  Protocol = "DEFUSED";
  Serial.print('#' + Protocol + '%');
  
  shiftOut(datapin, clockpin, MSBFIRST, 0);
  digitalWrite(latchpin, HIGH);
  digitalWrite(latchpin, LOW);

  lcd.setCursor(8, 0);
  lcd.print("DEFUSED");
}

int ledPinRood = 11;
int ledPinGroen = 10;
int ledPinBlauw = 9;

int ColorPhase = 0;
int Snap = 0;
int SnapStart;
int SlowDown = 5;
int PinKnop = 2;

// Button values
bool ButtonStateA;
bool ButtonStateB;
bool ButtonStateC;
bool ButtonStateD = true;

void setup() 
{
  Serial.begin(9600);     // opens serial port, sets data rate to 9600 bps

  pinMode(ledPinGroen,OUTPUT);
  pinMode(ledPinRood,OUTPUT);
  pinMode(ledPinBlauw,OUTPUT);

  pinMode(PinKnop,INPUT);

}

void loop() 
{
  if(ButtonState())
  {
    ChangeColor();
  }
}

void ChangeColor()
{
  ColorPhase = (millis() / SlowDown - Snap)% 1535;
  Serial.println(ColorPhase);

  if(ColorPhase < 255)
  {
    analogWrite(ledPinRood,255);
    analogWrite(ledPinBlauw,ColorPhase);
    analogWrite(ledPinGroen,0);
  }
  else if(ColorPhase < 511)
  {
    analogWrite(ledPinRood, 255 - (ColorPhase % 256));
    analogWrite(ledPinBlauw,255);
    analogWrite(ledPinGroen,0);
  }
  else if(ColorPhase < 767)
  {
    analogWrite(ledPinRood,0);
    analogWrite(ledPinBlauw,255);
    analogWrite(ledPinGroen,ColorPhase - 511);
  }
  else if(ColorPhase < 1023)
  {
    analogWrite(ledPinRood,0);
    analogWrite(ledPinBlauw,255 - (ColorPhase % 256));
    analogWrite(ledPinGroen,255);
  }
  else if(ColorPhase < 1279)
  {
    analogWrite(ledPinRood,ColorPhase - 1023);
    analogWrite(ledPinBlauw,0);
    analogWrite(ledPinGroen,255);
  }
  else
  {
    analogWrite(ledPinRood,255);
    analogWrite(ledPinBlauw,0);
    analogWrite(ledPinGroen,255 - (ColorPhase % 256));
  }
}

//Checks if the button has been pressed
bool ButtonPress()
{
  // Save button states
  ButtonStateA = digitalRead(PinKnop);
  delay(50);
  ButtonStateB = digitalRead(PinKnop);

  // Check 
  if(ButtonStateA && !ButtonStateB)
  {
    return true;
  }
  else
  {
    return false;
  }
}

bool ButtonState()
{
  bool ButtonStateC = ButtonPress();
  if(ButtonStateC && ButtonStateD)
  {
    ButtonStateD = false;
    BeginSnap();
  }
  else if(ButtonStateC && !ButtonStateD)
  {
    ButtonStateD = true;
    StopSnap();
  }
  return ButtonStateD;
}

void BeginSnap()
{
  SnapStart = millis() / SlowDown;
}

void StopSnap()
{
  Snap += millis() / SlowDown - SnapStart;
}

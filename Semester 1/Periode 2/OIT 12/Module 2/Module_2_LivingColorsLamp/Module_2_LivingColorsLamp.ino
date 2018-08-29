// Output pins
int ledPinRed = 11;
int ledPinGreen = 10;
int ledPinBlue = 9;
int ledPin = 8;

// Input pins
int PinKnopA = 3;
int PinKnopB = 2;
int PinPot = A0;

// Button values
bool ButtonStateAA;
bool ButtonStateAB;
bool ButtonStateBA;
bool ButtonStateBB;

bool ButtonStateA;
bool ButtonStateB;

// Remote Control on?
bool RemoteControl;
// ModeValues (DEMO, PRESET, MIX-MODE, REMOTE)
String Mode = "DEMO";
// PresetColor (Yellow,Magenta,Cyan)
String PresetColor = "Yellow";
// MixColor (Red,Green,Blue)
String MixColor = "Red";

// Protocol Variables
String Protocol;
bool Switched = false;

//RGB values
int RedValue = 128;
int GreenValue = 128;
int BlueValue = 128;

//---------------------------------------------------------------------------------------------------------------

// Stratup and initialiser
void setup()
{
  // set outputs
  pinMode(ledPinGreen, OUTPUT);
  pinMode(ledPinRed, OUTPUT);
  pinMode(ledPinBlue, OUTPUT);
  pinMode(ledPin, OUTPUT);

  // set inputs
  pinMode(PinKnopA, INPUT);
  pinMode(PinKnopB, INPUT);
  pinMode(PinPot, INPUT);

  // set serial
  Serial.begin(9600);
}

void loop()
{
  ButtonCheck();
  FindInput();

  if (Mode == "DEMO")
  {
    DemoMode();
  }
  else if (Mode == "PRESET")
  {
    PresetMode();
  }
  else if (Mode == "MIX-MODE")
  {
    SetMixColor();
  }

  UpdateColors();

  if (Switched)
  {
    AnnounceSwitch();
    Switched = false;
  }
}

void UpdateColors()
{
  analogWrite(ledPinRed, RedValue);
  analogWrite(ledPinGreen, GreenValue);
  analogWrite(ledPinBlue, BlueValue);
}

void AnnounceSwitch()
{
  if (Protocol == "REMOTE_CONTOL")
  {
    Serial.println(Protocol);
  }
  else
  {
    Serial.println("ARDUINO_CONTROL");
  }
  Serial.print("RED_STATUS:");
  Serial.println(RedValue);
  Serial.print("Green_STATUS:");
  Serial.println(GreenValue);
  Serial.print("Blue_STATUS:");
  Serial.println(BlueValue);
}

//Checks if the A or B button has been pressed
void ButtonCheck()
{
  // Save button states
  ButtonStateAA = digitalRead(PinKnopA);
  ButtonStateBA = digitalRead(PinKnopB);
  delay(50);
  ButtonStateAB = digitalRead(PinKnopA);
  ButtonStateBB = digitalRead(PinKnopB);

  // Check A
  if (ButtonStateAA && !ButtonStateAB)
  {
    ButtonStateA = true;
  }
  else
  {
    ButtonStateA = false;
  }

  // Check B
  if (ButtonStateBA && !ButtonStateBB)
  {
    ButtonStateB = true;
  }
  else
  {
    ButtonStateB = false;
  }

  ImplementButtonChanges();
}

void ImplementButtonChanges()
{
  if (ButtonStateA)
  {
    if (Mode == "PRESET")
    {
      if (PresetColor == "Yellow")
      {
        PresetColor = "Magenta";
      }
      else if (PresetColor == "Magenta")
      {
        PresetColor = "Cyan";
      }
      else if (PresetColor == "Cyan")
      {
        PresetColor = "Yellow";
      }
    }
    else
    {
      Mode = "PRESET";
      Switched = true;
      digitalWrite(ledPin, LOW);
    }
  }
  else if (ButtonStateB)
  {
    if (Mode == "MIX-MODE")
    {
      if (MixColor == "Red")
      {
        MixColor = "Green";
      }
      else if (MixColor == "Green")
      {
        MixColor = "Blue";
      }
      else if (MixColor == "Blue")
      {
        MixColor = "Red";
      }
    }
    else
    {
      Mode = "MIX-MODE";
      Switched = true;
      digitalWrite(ledPin, LOW);
    }
  }
}

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

void CompileInput()
{
  String ValueSnap;
  if (Protocol == "REMOTE_CONTROL")
  {
    Mode = "REMOTE_CONTROL";
    digitalWrite(ledPin, HIGH);
  }
  if (Mode == "REMOTE_CONTROL")
  {
    if (Protocol.substring(0, 8) == "SET_RED:")
    {
      ValueSnap = Protocol.substring(8);
      RedValue = ValueSnap.toInt();
    }
    else if (Protocol.substring(0, 10) == "SET_GREEN:")
    {
      ValueSnap = Protocol.substring(10);
      GreenValue = ValueSnap.toInt();
    }
    else if (Protocol.substring(0, 9) == "SET_BLUE:")
    {
      ValueSnap = Protocol.substring(9);
      BlueValue = ValueSnap.toInt();
    }
  }
}

void DemoMode()
{
  if (millis() % 3000 < 1000)
  {
    RedValue = 255;
    GreenValue = 0;
    BlueValue = 0;
  }
  else if (millis() % 3000 < 2000)
  {
    RedValue = 0;
    GreenValue = 255;
    BlueValue = 0;
  }
  else
  {
    RedValue = 0;
    GreenValue = 0;
    BlueValue = 255;
  }
}

void PresetMode()
{
  if (PresetColor == "Yellow")
  {
    RedValue = 255;
    GreenValue = 255;
    BlueValue = 0;
  }
  else if (PresetColor == "Magenta")
  {
    RedValue = 255;
    GreenValue = 0;
    BlueValue = 255;
  }
  else if (PresetColor == "Cyan")
  {
    RedValue = 0;
    GreenValue = 255;
    BlueValue = 255;
  }
}

void SetMixColor()
{
  int PotValue = analogRead(PinPot);
  PotValue = map(PotValue, 0, 1023, 0, 255);
  PotValue = constrain(PotValue, 0, 255);

  if (MixColor == "Red")
  {
    RedValue = PotValue;
  }
  else if (MixColor == "Green")
  {
    GreenValue = PotValue;
  }
  else if (MixColor == "Blue")
  {
    BlueValue = PotValue;
  }
}

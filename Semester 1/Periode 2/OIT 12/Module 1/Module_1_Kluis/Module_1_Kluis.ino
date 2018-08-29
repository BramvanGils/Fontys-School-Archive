// Output pins
int ledPinRood = 11;
int ledPinGroen = 10;
int ledPinBlauw = 9;

// Input pins
int PinKnop = 2;
int PinPot = A0;

// Calculation values
int Input = 0;
int LastInput = 10;
int Code1 = 1;
int Code2 = 2;
int Code3 = 3;
int Code4 = 4;
int Invoer1;
int Invoer2;
int Invoer3;
int Invoer4;
int CurrentState = 1;

// Button values
bool ButtonStateA;
bool ButtonStateB;

// String values
bool UpdateScreen = true;
bool Correct = false;

//---------------------------------------------------------------------------------------------------------------

// Stratup and initialiser
void setup()
{
  // set outputs
  pinMode(ledPinGroen,OUTPUT);
  pinMode(ledPinRood,OUTPUT);
  pinMode(ledPinBlauw,OUTPUT);

  // set inputs
  pinMode(PinKnop,INPUT);
  pinMode(PinPot,INPUT);
  
  // set serial
  Serial.begin(9600);

  // begin sequence
  Red();
}

void loop()
{ 
  // Checks if the potentiometer got shifted
  InputValueChanged();

  // Triggers whenever the potentiometer gets shifted
  if(UpdateScreen)
  {
    RefreshScreen();
  }

  // Triggers whenever the button gets pressed
  if(ButtonPress())
  {
     // Calculate all values
     SetValue();
     //Move up the process by one step
     CurrentState++;
     //Update the interface
     RefreshScreen();
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

//Checks if the potentio meter has shifted
void InputValueChanged()
{
    Input = analogRead(PinPot);
    Input = map(Input, 0, 512, 0, 25);
    Input = constrain(Input, 0, 25);
    if(LastInput == Input)
    {
      UpdateScreen = false;
    }
    else
    {
      UpdateScreen = true;
      LastInput = Input;
    }
}

// Sets the entered values and determines wether the correct sequence has been given
void SetValue()
{
  switch(CurrentState)
    {
        case 1:
          Invoer1 = Input;
          break;
        case 2:
          Invoer2 = Input;
          break;
        case 3:
          Invoer3 = Input;
          break;
        case 4:
          Invoer4 = Input;

          if(Code1 == Invoer1 && Code2 == Invoer2 && Code3 == Invoer3 && Code4 == Invoer4)
          {
          Correct = true;
          }
          else if(Code1 != Invoer1 || Code2 != Invoer2 || Code3 != Invoer3 || Code4 != Invoer4)
          {
          Correct = false;
          }
          
          break;
        case 6:
          Code1 = Input;
          break;
        case 7:
          Code2 = Input;
          break;
        case 8:
          Code3 = Input;
          break;
        case 9:
          Code4 = Input;
          break;
    }    
}

// Prints out all lines of text into the serial monitor. Also decides when the leds should burn.
void RefreshScreen()
{
  if(CurrentState != 5 && CurrentState != 10)
  {
    // Line 1: Current mode
    if(CurrentState < 5)
    {
      Serial.println("Voer de toegangscode in:");
    }
    else
    {
      Serial.println("Voer nieuwe toegangs code in:");
    }

    // Line 2: Current value
    Serial.print("Waarde: ");
    Serial.println(Input);

    // Line 3: Action performed
    switch(CurrentState)
    {
        case 1:
          Serial.println("Voer eerste nummer in...");
          break;
        case 2:
          Serial.println("Voer tweede nummer in...");
          break;
        case 3:
          Serial.println("Voer derde nummer in...");
          break;
        case 4:
          Serial.println("Voer vierde nummer in...");
          break;
        case 6:
          Serial.println("Voer eerste nummer in...");
          break;
        case 7:
          Serial.println("Voer tweede nummer in...");
          break;
        case 8:
          Serial.println("Voer derde nummer in...");
          break;
        case 9:
          Serial.println("Voer vierde nummer in...");
          break;
    }
    ClearScreen(10);
  }
  else if(CurrentState == 5 && Correct)
  {
    Serial.println("Juiste Toegangscode is ingevoerd");
    ClearScreen(12);
    Green3Sec();
    CurrentState++;
    RefreshScreen();
  }
  else if(CurrentState == 5)
  {
    Serial.println("Verkeerde Toegangscode");
    ClearScreen(12);
    BlinkRed();
    CurrentState = 1;
    RefreshScreen();
  }else
  {
    Serial.println("Toegangs code Gewijzigd");
    ClearScreen(12);
    Blue3Sec();
    CurrentState = 1;
    RefreshScreen();
  }
}

//Clear the screen by adding a certain amount of empty lines
void ClearScreen(int length)
{
    for (int i=0; i < length; i++)
    {
    Serial.println("");
    }
}

// Default colour the led emits
void Red()
{
  digitalWrite(ledPinRood,HIGH);
  digitalWrite(ledPinGroen,LOW);
  digitalWrite(ledPinBlauw,LOW);
}

// Let the led blink red for 3 seconds
void BlinkRed()
{
  Red();
  for (int i=0; i < 3; i++)
  {
      digitalWrite(ledPinRood,LOW);
      delay(500);
      digitalWrite(ledPinRood,HIGH);
      delay(500);
  }
  Red();
}

// Let the led burn green for 3 seconds
void Green3Sec()
{
  digitalWrite(ledPinRood,LOW);
  digitalWrite(ledPinGroen,HIGH);
  delay(3000);
  Red();
}

// Let the led burn blue for 3 seconds
void Blue3Sec()
{
  digitalWrite(ledPinRood,LOW);
  digitalWrite(ledPinBlauw,HIGH);
  delay(3000);
  Red();
}

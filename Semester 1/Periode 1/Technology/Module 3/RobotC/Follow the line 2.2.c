int DarkestValue = getColorReflected(S3);
int LightestValue = getColorReflected(S3);
int StandardLightValue;
int MaxEnginePower = 10;
int Offset;
int HalfRange;

bool ButtonState;
bool PauseState = false;

void CheckPaused()
{
	if(getButtonPress(buttonEnter) && !ButtonState) // check of er een verandering is in de button state
	{
		PauseState = !PauseState;
	}

	ButtonState = getButtonPress(buttonEnter);
}

void CalibrateValues()
{
	if (DarkestValue > getColorReflected(S3)) // stel de donkerste waarde bij
	{DarkestValue = getColorReflected(S3);}

	if (LightestValue < getColorReflected(S3)) // stel de lichtste waarde bij
	{LightestValue = getColorReflected(S3);}

	StandardLightValue = (LightestValue + DarkestValue) / 2; // vind de algemene waarde die gevolgd wordt
	HalfRange = (LightestValue - DarkestValue) / 2; // vind de afwijkings range
	Offset = StandardLightValue - getColorReflected(S3); // vind de mate van afwjking

	displayBigTextLine(8,"Offset = %d", Offset); // debug
}

void PowerMotors()
{
	CalibrateValues();

	if(Offset < 0)
	{
		setMotor(motorC,(1+Offset / HalfRange) * MaxEnginePower); //Stuur naar rechts
		setMotor(motorB,MaxEnginePower);
	}
	else if(Offset > 0)
	{
		setMotor(motorC,MaxEnginePower);
		setMotor(motorB,(1-Offset /HalfRange) * MaxEnginePower); //Stuur naar links
	}
	else
	{
		setMotor(motorB,MaxEnginePower);
		setMotor(motorC,MaxEnginePower); // recht vooruit
	}
}

void MotorStop()
{
	setMotor(motorB, 0);
	setMotor(motorC, 0);
}

void Evade()
{
	setMotorSyncEncoder(motorB, motorC, -100, 180, 20);	// maak kwartslag draai.
	waitUntilMotorStop(motorB);
	setMotorSyncEncoder(motorB, motorC, 0, 540, 20); 	// rijd 50 cm naar voren.
	waitUntilMotorStop(motorB);
	setMotorSyncEncoder(motorB, motorC, 100, 180, 20);	// maak kwartslag draai.
	waitUntilMotorStop(motorB);
	setMotorSyncEncoder(motorB, motorC, 0, 540, 20); 	// rijd 50 cm naar voren.
	waitUntilMotorStop(motorB);
	setMotorSyncEncoder(motorB, motorC, 100, 180, 20);	// maak kwartslag graden draai.
	waitUntilMotorStop(motorB);

	setMotor(motorB,20);
	setMotor(motorC,20);

	while(getColorReflected(S3) >= StandardLightValue) // zoekzwarte lijn
	{}

	setMotorSyncEncoder(motorB, motorC, -100, 180, 20);	// maak kwartslag draai.
	waitUntilMotorStop(motorB);

}


task main()
{
	while (getTouchValue(S1) == 0){}

	while(true)
	{

		CheckPaused();

		if (!PauseState)
		{
			PowerMotors();
		}
		else
		{
			MotorStop();
		}

		if(getUSDistance(S4) < 20)
		{
			Evade();
		}

		delay(10);
	}
}

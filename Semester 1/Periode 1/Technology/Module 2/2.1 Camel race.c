bool waitanswer =false;
bool finished = false;
float time;
bool correctleft = true;
string options;

task main()
{
	//wacht tot de touch sensor wordt ingedrukt
	while(getTouchValue(S1) != 1){};
	clearTimer(T1);

	//rijd naar voren totdat de zwarte lijn gevonden wordt
	while(getColorReflected(S3) >7)
	{
		setMotor(motorB,50);
		setMotor(motorC,50);
	}

	//stop en play Activate
	setMotor(motorB,0);
	setMotor(motorC,0);
	playSoundFile("Activate");

	while(!finished) //herhaal zolang de witte lijn nog niet gevonden is
	{
		//pak random random waardes en bereken antwoord
		int value1 = 1 + random(9);
		int value2 = 1 + random(9);
		int answer = value1 * value2;

		//display vraag
		string question;
		stringFormat(question, "wat is %d X %d?",value1,value2);
		displayBigTextLine(4,question);

		//voeg mutatie toe aan een van de waardes en maak een fout antwoord
		switch(random(3))
		{
		case 0:
			value1++;
			break;

		case 1:
			value1--;
			break;

		case 2:
			value2++;
			break;

		case 3:
			value2--;
			break;
		}
		int notanswer =  value1 * value2;

		//display antwoorden
		switch(random(1))
		{
		case 0:
			stringFormat(options, "  %d      %d  ",answer,notanswer);
			correctleft = true;
			break;

		case 1:
			stringFormat(options, "  %d      %d  ",notanswer,answer);
			correctleft = false;
			break;
		}
		displayBigTextLine(10,options);

		//wacht tot knop wordt ingedrukt
		waitUntil(getButtonPress(buttonLeft) || getButtonPress(buttonRight));
		waitanswer = true;
		while(waitanswer == true)
		{

			//als het antwoord fout is wacht 0,2 seconden play "Uh-oh" en verlaat loop
			if((getButtonPress(buttonLeft) && !correctleft) || (getButtonPress(buttonRight) && (correctleft)))
			{
				playSoundFile("Uh-oh");
				delay(200);
				waitanswer = false;
			}

			//als het antwoord goed is:
			else if((!getButtonPress(buttonLeft) && correctleft) || (getButtonPress(buttonRight) && !correctleft))
			{
				//play good en start motor
				playSoundFile("Good");
				setMotor(motorB,50);
				setMotor(motorC,50);

				//check gedurende 1 seconde of de grond wit is
				clearTimer(T2);
				while(getTimerValue(T2) < 1000)
				{
					//zo ja stop motor en stop vragen stellen
					if(getColorReflected(S3) >40)
					{
						finished = true;

						setMotor(motorB,0);
						setMotor(motorC,0);
					}
				}

				//na 1 sec stop motoren wacht op nieuwe vraag
				setMotor(motorB,0);
				setMotor(motorC,0);
				waitanswer = false;
			}
		}
	}
	//play cheer
	playSoundFile("Cheering");

	//clear display
	displayBigTextLine(10,"                 ");
	displayBigTextLine(4,"                 ");

	//bereken tijd in seconden
	time = getTimerValue(T1) / 1000;

	//display eindtijd
	displayBigTextLine(6,"eind tijd:");
	displayBigTextLine(8,"%d sec", time);

	wait(3000);
}

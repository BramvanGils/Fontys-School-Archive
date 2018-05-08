#include "Subjects.c"

void TitleScreen();
void MainMenuScreen();
void LevelScreen(int subject);
void QuestionScreen(int subject, int level);
void CheckAnswer(string userInput, int subject, int level, int question);

//void ParseString(string incomingString);
//string FormatStringForPC();

string mainMenuList[] = {"ENGELS<", "NEDERLANDS", "REKENEN", "INSTELLINGEN"};
int mainMenuLength = 4;
string title = "";
int buttonSelected = 0;
int rightAnswers = 0;
int wrongAnswers = 0;
bool goBack = false;
bool levelCleared = false;
bool playMode = false;

string levelMenuList[] = {
	"LEVEL EEN<", "LEVEL TWEE", "LEVEL DRIE",
	"LEVEL VIER", "LEVEL VIJF", "LEVEL ZES",
	"LEVEL ZEVEN", "LEVEL ACHT", "LEVEL NEGEN",
	"LEVEL TIEN"
};

int levelMenuLength = 10;

/*enum subjects {ENGELS, NEDERLANDS,REKENEN}; */
enum levels {
	LEVELONE, LEVELTWO, LEVELTHREE,
	LEVELFOUR, LEVELFIVE, LEVELSIX,
	LEVELSEVEN, LEVELEIGHT, LEVELNINE,
	LEVELTEN
};

enum subjects {ENGELS, NEDERLANDS,REKENEN};

//display title screen
void TitleScreen()
{
	eraseDisplay();
	displayCenteredBigTextLine(2, "EduBot");
	displayCenteredTextLine(4, "Learning with enjoyment");

	//sleep for 200ms
	sleep(200);
	MainMenuScreen();
}

//display Main Menu screen
void MainMenuScreen()
{
	eraseDisplay();
	title = "-Main Menu";
	buttonSelected = 0;

	displayString(1, title);

	for(int i = 0; i < mainMenuLength; i++) // loop through MainMenu items
	{
		// added +2 offset for array index starting at zero and occupied space at 1 from title screen
		displayString((i+2), mainMenuList[i]);
	}

	//loop until the user has decided to go back or selec one of the items
	while(true)
	{
		eraseDisplay();
		title = "-Main Menu";
		displayString(1, title);
		for(int i = 0; i < mainMenuLength; i++)
		{
			// added +2 offset for array index starting at zero and occupied space at 1 from title screen
			displayString((i+2), mainMenuList[i]);
		}

		waitForButtonPress();
		if(getButtonPress(buttonUp) == 1)
		{
			//up button select
			if(buttonSelected > 0)
			{
				//delete the < icon from menu
				stringDelete(mainMenuList[buttonSelected], stringFind(mainMenuList[buttonSelected], "<"), 1);

				mainMenuList[buttonSelected -1] += "<";
				buttonSelected--;
			}
		}
		else if(getButtonPress(buttonDown) == 1){
			// down button select

			if(buttonSelected < ((mainMenuLength)-1)) // -1 due to instellingen not being counted
			{
				//delete the < icon from menu
				stringDelete(mainMenuList[buttonSelected], stringFind(mainMenuList[buttonSelected], "<"), 1);

				mainMenuList[buttonSelected +1] += "<";
				buttonSelected++;
			}
		}
		else if(getButtonPress(buttonEnter) == 1)
		{
			LevelScreen(buttonSelected);
			sleep(750);
		}
		else if(getButtonPress(buttonLeft) == 1)
		{
			testMode = false;
			eraseDisplay();
			break;
		}

		sleep(250);
	}
}

//display Level screen
void LevelScreen(int subject)
{
	eraseDisplay();
	title = "-Level Menu";
	displayString(1, title);

	for(int i = 0; i < levelMenuLength; i++)
	{
		// added +2 offset for array index starting at zero and occupied space at 1 from title screen
		displayString((i+2), levelMenuList[i]);
	}

	//loop until the user has decided to go back or selec one of the items
	while(true)
	{
		eraseDisplay();
		title = "-Level Menu";
		displayString(1, title);
		for(int i = 0; i < levelMenuLength; i++)
		{
			// added +2 offset for array index starting at zero and occupied space at 1 from title screen
			displayString((i+2), levelMenuList[i]);
		}

		waitForButtonPress();
		if(getButtonPress(buttonUp))
		{
			//up button select
			if(buttonSelected > 0)
			{
				//delete the < icon from menu
				stringDelete(levelMenuList[buttonSelected], stringFind(levelMenuList[buttonSelected], "<"), 1);

				levelMenuList[buttonSelected -1] += "<";
				buttonSelected--;
			}
		}
		else if(getButtonPress(buttonDown)){
			// down button select

			if(buttonSelected < (levelMenuLength)) // -1 due to instellingen not being counted
			{
				//delete the < icon from menu
				stringDelete(levelMenuList[buttonSelected], stringFind(levelMenuList[buttonSelected], "<"), 1);

				levelMenuList[buttonSelected +1] += "<";
				buttonSelected++;
			}
		}
		else if(getButtonPress(buttonEnter))
		{
			//level doorsturen
			//TODO break free from loop
			QuestionScreen(subject, buttonSelected);
			sleep(750);
		} else if(getButtonPress(buttonLeft))
		{ // break out of the while loop
			goBack = true;
			eraseDisplay();
			break;
		}

		sleep(250);
	}

	/*if(goBack)
	{ // if goback is true load MainMenuScreen
	MainMenuScreen();
	goBack = false;
	}*/
}

//display Question screen
void QuestionScreen(int subject, int level) // receive which subject (enum level)
{
	eraseDisplay();
	title = "-Question";
	displayString(1, title);

	for(int i = 0; i < 10; i++) 	//todo loop through question array
	{
		eraseDisplay();

		title = "-Question ";
		string convertIntToString = i + 1;
		strcat(title, convertIntToString);
		strcat(title, "/10");

		displayString(1, title);
		displayString(2, questions[subject * level + i]);

		for(int j = 0; j < 3; j++) // loop through question answers
		{
			string answer = "";
			switch(j)
			{
			case 0:
				/*
				calculation questionAnswers
				old formula questionsAnswers[subject * level * i][j]
				new formula questionsAnswers[(subject * 100) + (level + 1) * i][j]
				*/

				strcat(answer, "Left: ");
				strcat(answer, questionsAnswers[(subject * 100) + (level + 1) * i][j]);
				break;
			case 1:
				strcat(answer, "Up: ");
				strcat(answer, questionsAnswers[(subject * 100) + (level + 1) * i][j]);
				break;
			case 2:
				strcat(answer, "Right: ");
				strcat(answer, questionsAnswers[(subject * 100) + (level + 1) * i][j]);
				break;
			default:
				break;
			}
			//displayString(j+3, questionsAnswers[subject * level + j]);
			displayString(j+3, answer);
		}

		//wait until user has answered
		waitForButtonPress();
		delay(200);
		// A: Button Left B: Button UP C: Button Right D: Button Down

		if(getButtonPress(buttonLeft))
		{
			CheckAnswer(questionsAnswers[subject * level + i][0], subject, level, i);
		}
		else if (getButtonPress(buttonUp))
		{
			CheckAnswer(questionsAnswers[subject * level + i][1], subject, level, i);
		}
		else if (getButtonPress(buttonRight))
		{
			CheckAnswer(questionsAnswers[subject * level + i][2], subject, level, i);
		}
		else if(getButtonPress(buttonDown))
		{
			//LevelScreen(subject);
			eraseDisplay();
			break;
		}
		else
		{
			displayString(6, "Sorry I don't understand press one of the buttons (LEFT, UP, RIGHT, DOWN, BACK)");
			displayString(7, "Press Down to go Back.");
			waitForButtonPress();
			sleep(200);
		}

		delay(1000);
	}

	int Englvl1 = 4;
	int Nedlvl1 = 0;
	int Reklvl1= 0;
	int Englvl2 = 2;
	int Nedlvl2 = 0;
	int Reklvl2= 0;
	int Englvl3 = 0;
	int Nedlvl3 = 0;
	int Reklvl3 = 0;
	int Englvl4 = 0;
	int Nedlvl4 = 0;
	int Reklvl4 = 0;

	if(rightAnswers >= 7)
	{
		if(subject == 0)
		{
			switch(level)
			{
			case 0:
				Englvl1++;
				break;
			case 1:
				Englvl2++;
				break;
			case 2:
				Englvl3++;
				break;
			default:
				break;
			}
		}
		else if (subject == 1)
		{
			switch(level)
			{
			case 0:
				Nedlvl1++;
				break;
			case 1:
				Nedlvl2++;
				break;
			case 2:
				Nedlvl3++;
				break;
			default:
				break;
			}
		}
		else if (subject == 2)
		{
			switch(level)
			{
			case 0:
				Reklvl1++;
				break;
			case 1:
				Reklvl2++;
				break;
			case 2:
				Reklvl3++;
				break;
			default:
				break;
			}
		}

		levelCleared = true;
	}
}

void CheckAnswer(string userInput, int subject, int level, int question)
{
	if(strcmp(userInput, questionsRightAnswer[subject * level + question]) == 0)
	{
		// up good answer
		rightAnswers++;
	}
	else
	{
		// do nothing or up wrong answers
		wrongAnswers++;
	}
}

////////////////////////////////////////////////////////////////////////////////
// ROBOTC EV3 remote control demonstration program.
// This program receives messages from the host computer: Forward, Backward, Left and Right.
// It sends back the distance in cm measured by the ultrasonic sensor and the angle in degrees
// measured by the gyro sensor.
////////////////////////////////////////////////////////////////////////////////

////////////////////////////////////////////////////////////////////////////////
// Connection scheme:
// motorA: medium motor front lever
// motorB: large motor right wheel
// motorC: large motor left wheel
// motorD: -
// Sensor S1: Touch sensor
// Sensor S2: Gyro sensor
// Sensor S3: Color sensor
// Sensor S4: Ultrasonic sensor
////////////////////////////////////////////////////////////////////////////////


// EV3Mailbox.c is needed to enable sending and receiving mailbox messages.
// It is possible to have ten input mailboxes and one output mailbox.
// However in the below code only EV3_INBOX0 and EV3_OUTBOX0 are used.
// See the comments in EV3Mailbox.c for additional info.
// Unfortunately ROBOTC cannot handle multipe C files so we have to include it.

//include gui

/*int xpEng = 0;
int xpNed = 0;
int xpRek = 0;
int lbCommon = 0;
int lbRare = 0;
int lbEpic = 0;
int lbLegendary = 0;*/

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
string lvlComplete;

string formattedString = "";
bool testMode = false;

//void ParseString(string incomingString);
void Test();
void FormatStringForPC();

#include "GUI.c"
#include "EV3Mailbox.c"

#include "Movement.c"
#include "EduBot.c"
#include "Education.c"

task main()
{
	displayBigTextLine(0, "Started!");

	char msgBufIn[MAX_MSG_LENGTH];  // To contain the incoming message.
	char msgBufOut[MAX_MSG_LENGTH];  // To contain the outgoing message

	openMailboxIn("EV3_INBOX0");
	openMailboxOut("EV3_OUTBOX0");
	bool sent2= false;//prevents multiple sending of a string
	bool sent4= false;

	while (true)
	{
		displayCenteredBigTextLine(0, "Play Mode: ON");
		//string string2 = "A1B2C3D4E5F6G7";
		FormatStringForPC();
		string string2 = formattedString;
		string string4 = "4";
		// Read input message.
		// readMailboxIn() is non-blocking and returns "" if there is no message.
		readMailboxIn("EV3_INBOX0", msgBufIn);
		if (strcmp(msgBufIn, "") != 0)
		{
			string incoming = msgBufIn;
			if(stringFind(incoming, "0")==0)
			{
				sprintf(msgBufOut, "NULL");

				delay(500);
				sent2=false;
				sent4=false;
			}
			if(stringFind(incoming, "1")==0 && sent2== false)
			{
				displayBigTextLine(2, "String ping ontvangen");
				//Create big string
				delay(100);
				sprintf(msgBufOut, string2);
				delay(100);
				sent2=true;
				writeMailboxOut("EV3_OUTBOX0", msgBufOut);
				delay(200);

			}
			if(stringFind(incoming, "A")==0 && sent4==false)
			{
				displayBigTextLine(2, "String XP ontvangen");
				//set all int to 0
				delay(100);
				sprintf(msgBufOut, string4);
				writeMailboxOut("EV3_OUTBOX0", msgBufOut);
				sent4=true;
			}

			if(strcmp(incoming, "1") == 0)
			{
				testMode = false;
			}

			/*if(strlen(incoming) == 14)
			{
				ParseString(incoming);
			}*/

			//Send string4 naar desktop
			// Here fill your incoming message handling.
			// For example when message "Forward" is received, the EV3 should move forward.
		}
		else
		{
			displayCenteredTextLine(6, "Press Enter for TestMode!");
			displayCenteredBigTextLine(8, "empty message!");

			if(testMode)
			{
				Test();
			}

			if(getButtonPress(buttonEnter) == 1)
			{
				testMode = true;
			}
		}

		// Here fill your outgoing message handling.
		// This means sending the distance in cm measured by the ultrasonic sensor
		// and the angle in degrees measured by the gyro sensor.
		// Put both values in msgBufOut.
		// Use the format ?<distance> <angle>" (space between distance and angle) so that it can be read by the host program.

		delay(100);  // Wait 100 ms to give host computer time to react.
	}

	closeMailboxIn("EV3_INBOX0");
	closeMailboxOut("EV3_OUTBOX0");
	return;
}

void Play()
{

}

void Test()
{
	TitleScreen();
}

/*void ParseString(string incomingString)
{
	// format example string string incoming = "A123B345C1003";

	int length = strlen(incomingString);
	int indexA = stringFind(incomingString, "A");
	int indexB = stringFind(incomingString, "B");
	int indexC = stringFind(incomingString, "C");

	string XpstrEng = incomingString;
	string XpstrNed = incomingString;
	string XpstrRek = incomingString;

	int deleteBC = length-indexB;
	int deleteA = indexB-indexA;
	int deleteAB = indexC-indexA;
	int deleteC = length-indexC;

	stringDelete(XpstrEng, indexB, deleteBC);
	delay(10);
	stringDelete(XpstrEng, indexA, 1);
	delay(10);
	stringDelete(XpstrNed, indexC, deleteC);
	delay(10);
	stringDelete(XpstrNed, indexB, 1);
	delay(10);
	stringDelete(XpstrNed, indexA, deleteA);
	delay(10);
	stringDelete(XpstrRek, indexC, 1);
	delay(10);
	stringDelete(XpstrRek, indexA, deleteAB);

	displayBigTextLine(8, XpstrRek);
	displayBigTextLine(5, XpstrNed);
	displayBigTextLine(2, XpstrEng);

	xpEng = atoi(XpstrEng);
	xpNed = atoi(XpstrNed);
	xpRek = atoi(XpstrRek);
}*/

/*void FormatStringForPC()
{

int xpEng = 1; int xpNed = 2; int xpRek = 3;
int lbCommon = 4; int lbRare = 5; int lbEpic = 6;
int lbLegendary = 7;

string XpLb = "";
sprintf(XpLb, ("2A%dB%dC%dD%dE%dF%dG%d"), xpEng, xpNed, xpRek, lbCommon, lbRare, lbEpic, lbLegendary);
displayBigTextLine(4, XpLb);

formattedString = XpLb;
}*/

void FormatStringForPC()
{
/*int Englvl1 = 1;
int Nedlvl1 = 2;
int Reklvl1= 3;
int Englvl2 = 4;
int Nedlvl2 = 5;
int Reklvl2= 6;
int Englvl3 = 7;
int Nedlvl3 = 8;
int Reklvl3 = 9;
int Englvl4 = 10;
int Nedlvl4 = 11;
int Reklvl4 = 12; */

sprintf(lvlComplete, ("A%dB%dC%dD%dE%dF%dG%dH%dI%d"), Englvl1, Nedlvl1, Reklvl1, Englvl2, Nedlvl2, Reklvl2, Englvl3, Nedlvl3, Reklvl3);
displayBigTextLine(4, lvlComplete);
}

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
//deze zijn uitgezet vanwege grote aantal errors
//#include "GUI.c"
#include "EV3Mailbox.c"

//#include "Movement.c"
//#include "EduBot.c"
//#include "Education.c"

task main()
{
	displayBigTextLine(0, "Started!");

	char msgBufIn[MAX_MSG_LENGTH];  // To contain the incoming message.
	char msgBufOut[MAX_MSG_LENGTH];  // To contain the outgoing message

	openMailboxIn("EV3_INBOX0");
	openMailboxOut("EV3_OUTBOX0");
	bool sent2=false;//prevents multiple sending of a string
	bool sent4=false;
	while (true)
	{

		string string2 = "A1B2C3D4E5F6G7";
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
			if(stringFind(incoming, "1")==0 && sent2==false)
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

			//Send string4 naar desktop
			// Here fill your incoming message handling.
			// For example when message "Forward" is received, the EV3 should move forward.
		}
		else
		{
			displayBigTextLine(8, "empty message!");
		}


		// Here fill your outgoing message handling.
		// This means sending the distance in cm measured by the ultrasonic sensor
		// and the angle in degrees measured by the gyro sensor.
		// Put both values in msgBufOut.
		// Use the format ?<distance> <angle>" (space between distance and angle) so that it can be read by the host program.


		delay(5000);

		delay(100);  // Wait 100 ms to give host computer time to react.
	}
	closeMailboxIn("EV3_INBOX0");
	closeMailboxOut("EV3_OUTBOX0");
	return;
}

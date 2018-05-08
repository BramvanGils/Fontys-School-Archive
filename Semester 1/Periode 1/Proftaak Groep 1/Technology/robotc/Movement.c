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

// Maybe insert a free joystick ride mode when finished

int movementSpeed = 20;
int nMotorOne = motorB;
int nMotorTwo = motorC;
enum Direction { FORWARD, RIGHT, LEFT, BACKWARD };

void Move(int distance)
{
	// Check which motor is where

	// Calculate distance in CM
	int distanceInCM = (distance / 17.65);
	setMotorSync(nMotorOne, nMotorTwo, distanceInCM, movementSpeed);
}

void StopMoving()
{
	setMotorSync(nMotorOne, nMotorTwo, 0, 0);
}

void Turn(enum Direction direction) // TODO check which side the robot turns with left and right
{
	resetGyro(S2);

	switch(direction)
	{
	case LEFT:
		setMotorSync(nMotorOne, nMotorTwo, 100, movementSpeed);
		while(getGyroDegrees(S2) < 90 )
		{

		}
		StopMoving();
		break;
	case RIGHT:
		setMotorSync(nMotorOne, nMotorTwo, -100, movementSpeed);
		while(getGyroDegrees(S2) < 90 )
		{

		}
		StopMoving();
		break;
	case BACKWARD:
		setMotorSync(nMotorOne, nMotorTwo, -100, movementSpeed);
		while(getGyroDegrees(S2) < 180 )
		{

		}
		StopMoving();
		break;
	default:
		StopMoving();
		//TODO write to screen sorry I don't know what you mean
		break;
	}
}

// Mode where you can control the EV3 Robot with a controller
/*void JoyRide() // maybe TODO fix joyride
{

	//Infinite Loop
	while(true)
	{
		// Update buttons and joysticks
		getJoystickSettings(joystick);

		//Assigns the value of the Y1 axis to the left motor
		setMotorSpeed(leftMotor, joystick.joy1_y1);
		//Assigns the value of the Y2 axis to the right motor
		setMotorSpeed(rightMotor, joystick.joy1_y2);

		//If button 6 (right bumper) is pressed
		if(joy1Btn(06) == 1)
		{
			//Raise the arm
			motor[armMotor] = 100;
		}

		//Else, if button 8 (right trigger) is pressed
		else if(joy1Btn(08) == 1)
		{
			//Lower the arm
			motor[armMotor] = -100;
		}

		//Else (no button pressed)
		else
		{
			//Turn the arm motor off
			motor[armMotor] = 0;
		}
	}

}*/

task main()
{
		resetGyro(S2); // zet de gyro terug op 0
		while(getTouchValue(S1) != 1){}; // wacht tot touch sensor wordt ingedrukt.

		while(getGyroDegrees(S2) <= 360) // herhaal onderstaande actie totdat een volle draai gemaakt wordt.
			{
			datalogAddValueWithTimeStamp(1,getUSDistance(S4)); // voeg sonische metingen toe aan datalog.
			writeDebugStreamLine("sonische sensor leest: %d", getUSDistance(S4)); // voeg sonische metingen toe aan debugstream.

			motor(motorB) = 5;
			motor(motorC) = -5; // draai met de klok mee
			}
}

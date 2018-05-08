task main()
{
		while(getTouchValue(S1) != 1){}; // wacht tot touch sensor wordt ingedrukt.


		for(byte x = 0; x < 4; ++x) // herhaal onderstaande sequentie 4 maal.
    		{
        setMotorSyncEncoder(motorB, motorC, 0, 1080, 100); // rijd 50 cm naar voren.
        waitUntilMotorStop(motorB);
        setMotorSyncEncoder(motorB, motorC, 100, 180, 100); // maak kwartslag draai.
        waitUntilMotorStop(motorB);
        }

}

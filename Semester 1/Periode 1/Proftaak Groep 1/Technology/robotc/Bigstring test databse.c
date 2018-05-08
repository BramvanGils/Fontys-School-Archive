
task main()
{
int Englvl1 = 1;
int Nedlvl1 = 2;
int Reklvl1= 3;
int Englvl2 = 4;
int Nedlvl2 = 5;
int Reklvl2= 6;
int Englvl3 = 7;
int Nedlvl3 = 8;
int Reklvl3 = 9;
string lvlComplete;
sprintf(lvlComplete, ("A%dB%dC%dD%dE%dF%dG%dH%dI%d"), Englvl1, Nedlvl1, Reklvl1, Englvl2, Nedlvl2, Reklvl2, Englvl3, Nedlvl3, Reklvl3);
displayBigTextLine(4, lvlComplete);
delay(5000);


}

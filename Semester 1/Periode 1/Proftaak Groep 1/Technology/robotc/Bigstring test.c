
task main()
{
int xpEng = 1;
int xpNed = 2;
int xpRek = 3;
int lbCommon = 4;
int lbRare = 5;
int lbEpic = 6;
int lbLegendary = 7;
string XpLb;
sprintf(XpLb, ("A%dB%dC%dD%dE%dF%dG%d"), xpEng, xpNed, xpRek, lbCommon, lbRare, lbEpic, lbLegendary);
displayBigTextLine(4, XpLb);
delay(5000);


}

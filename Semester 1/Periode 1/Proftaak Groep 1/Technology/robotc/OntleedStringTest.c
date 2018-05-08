
task main()
{
string incoming = "A123B345C1003";
int length = strlen(incoming);
int indexA = stringFind(incoming, "A");
int indexB = stringFind(incoming, "B");
int indexC = stringFind(incoming, "C");
string XpstrEng = incoming;
string XpstrNed = incoming;
string XpstrRek = incoming;
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
delay(5000);
}

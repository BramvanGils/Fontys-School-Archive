float frequencymultiplier = 1000;
float frequencybottom = 150;
float intervaltime = 0.1;
float timerslower = 100;


task main()
{
	while(true)
	{
	playTone((((sin(getTimerValue(T1)/timerslower)+1)*frequencymultiplier + frequencybottom) + ((sin(getTimerValue(T1)/timerslower/2)+1)*frequencymultiplier + frequencybottom) + ((sin(getTimerValue(T1)/timerslower/3)+1)*frequencymultiplier + frequencybottom)+ ((sin(getTimerValue(T1)/timerslower/4)+1)*frequencymultiplier + frequencybottom)+ ((sin(getTimerValue(T1)/timerslower/5)+1)*frequencymultiplier + frequencybottom)),intervaltime);
	}

}

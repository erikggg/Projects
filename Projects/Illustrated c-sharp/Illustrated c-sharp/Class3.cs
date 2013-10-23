using System;
using Simple;

public class DateClass
{                   
	public void PrintDateAndTime()
	{
        DateTime dt = DateTime.Now;
        Console.WriteLine("{0}", dt);
	}
    public int GetHour()
    {
        DateTime dt = DateTime.Now;
        int hour = dt.Hour;
        
        return hour;
        
        
    }
    public int GetMinute()
    {
        DateTime dt = DateTime.Now;
        int minute = dt.Minute;

        return minute;
    }
}


//int lng = LosingTeam.NumberOfGoals
//arraypos = winningTeam.[LosingTeam.NumberOfGoals]+1
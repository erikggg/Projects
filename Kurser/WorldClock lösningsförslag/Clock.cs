// ClockV4.cs
// Created by:  Farid Naisan, 2006-09-03
//
//  
// 
using System;

namespace WorldClock
{
    /// <summary>
    /// Class that get the current date and time of the system 
    /// and print it out.	
    /// 
    /// NOTE: No need to have static fields or methods.    
    /// </summary>
    class Clock
    {
        //All fields should be private
        private DateTime time;  //a part of the System namespace

        //This method has to be deklared as "public" in order to
        //be accessa ble by other classes (ex ClockProg)

        public void PrintDateAndTime()
        {
            time = DateTime.Now;                 //Get the time (as an object)
            Console.WriteLine("The time and date in Scandinivian is now: " + time.ToString());  //write the time as text
        }


        //Show time at another location in the world.
        public void PrintDateAndTimeSomeWhereElse(int hourDifference, string location)
        {
            Console.Title = "THE WORLD CLOCK";
            time = DateTime.Now;                 //Get the time (as an object)

            Console.WriteLine("Time in Scandinavian:  " + time.ToShortTimeString());
            time = time.AddHours(hourDifference);  //The object time holds now time for somewhere else

            Console.WriteLine("Time in " + location + ": " + time.ToShortTimeString());  //write the time as text

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

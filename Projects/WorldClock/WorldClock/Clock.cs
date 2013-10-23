//Code Example
//Clock.cs
//By: Erik Grahn 20130923

//System is a namespace in .NET Framwork that hosts a 
//greate number of ready to use classes. This namespace
//includes classes that are needed for common tasks such 
//as input/out actions.
//The keyword "using" says to the compiler that we will
//be using some classes from the namespace (here from
//the System namespace).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//VS has assigned the namespace WorldClock to our project
namespace WorldClock
{
    //Syntax for class definition
    public class Clock
    {
        private string city;
        private int timezone;
        private int result;
        private DateTime time;
        //now we do the following: 1 ask the user for the city name
        //                         2. show the time for the user.
        // all the code we write, except instance variables and comments must be contained within a method
        public void WhatIsTheTime()
        {
            ReadAndSaveCityName();

            OtherLocations();

            ShowDateAndTime();
        }
        private void ReadAndSaveCityName()
        { 
            //Clear the screen
            Console.Clear();
            Console.WriteLine("Hi, what is the name of the city");
            //When the user has entered a text and pressed the Enter key, read the given text
            //and save it in this object
            city = Console.ReadLine();
        }
        public void OtherLocations()
        {

            Console.WriteLine("What is the time difference?");


            if (int.TryParse(Console.ReadLine(), out result))
            {
                timezone = result;
            }
            else
            {
                Console.WriteLine("Please input a valid integer value to denote the timezone offset");
            }
        }
        private void ShowDateAndTime()
        {
            time = DateTime.Now;

            Console.WriteLine("*******ABC - Apu's Big Clock (yes, clock)*********");
            Console.WriteLine("     Local date:" + DateTime.Now.ToLongDateString());
            Console.WriteLine("     Local time:" + DateTime.Now.ToLongTimeString());
            Console.WriteLine("     The date in " + city + ": " + time.AddHours(timezone).ToLongDateString());
            Console.WriteLine("     The time in " + city + ": " + time.AddHours(timezone).ToLongTimeString());
            Console.WriteLine("**************************************************");
        }
    }
}

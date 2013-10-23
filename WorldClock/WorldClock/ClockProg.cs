//Code Example
//Clock.cs
//By: Erik Grahn 20130923


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This class is the start class and its method Main will be the first code
//that will be executed at run time.

//The namespace of our project. All other classes that are defined in the other files bit
//with this namespace declaration willl find and use eachother. Spelling is important (except in comments :))!
namespace WorldClock
{
    //Class name declaration, class name in camelcase.
    //it is important to be consistent here, either use public modifier or none at all (since generally a private class has little use)
    /*public*/ class ClockProg
    {
        static void Main(string[] args)
        {
            //To do:
            //1. Declare and create an object of the class Clock
            Clock clockObj = new Clock();

            //2. Call the clockObj's (of class Clock) public method WhatIsTheTime to show date and time
            clockObj.WhatIsTheTime();

            //The prompt window will disappear fast.
            //We can keep the window by putting the console in input mode (waiting for user input)
            //by using the ReadLine method in the Console class, namespace System
            Console.ReadLine(); //Press enter to close the console window.
        }
    }
}

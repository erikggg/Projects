// ClockV4Prog.cs
// Created by:  Farid Naisan, 2006-09-03
//
// To Do:  Write a console application that shows the current 
// time and date. The application should contain at least two
// classes, one that serves as the entry to the program and one 
// that performs the job.  A good practice, to keep in mind,at
// least one class för every job and one class to start the 
// program.
// 
//

using System;

namespace WorldClock
{
    /// <summary>
    /// 
    /// Console application that prints the current time and date.
    /// This class makes use of another class, the Clock. 
    /// </summary>

    public class ClockProg
    {

        static void Main(string[] args)
        {
            //Create an object (an instance) of the class
            //ClockV4. 

            Clock time = new Clock();  //declare and create an object of Clock
            time.PrintDateAndTime();  //use a public method of the object

            //A couple of blank lines
            Console.WriteLine();
            Console.WriteLine();

            //Pause the program
            time.PrintDateAndTimeSomeWhereElse(-9, "San Diego");
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();  //Let the command window wait!
        }
    }
}
// Menu.cs
// Created:  Farid Naisan, 2008-06-13
// Revised:  Farid Naisan, 2012-06-19 Minor changes
// Purpose: This class demos how a menu can be show on a console window.
//          The menu continues until the user chooses to exit.
//          The menu contains choices for date and time.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuAppCS
{
    class Menu
    {
        /// <summary>
        /// Shows a menu and reads the user's choice of how to show the 
        /// current time, date or both
        /// </summary>
        public void ShowMenu()
	    {
		    bool done = false;  //Flag: if true exit the loop
		
		    while (!done)  //while done = false (done = false at start, from above)
		    {
			    //Show the menu text and retrieve the user's choice
			    int iValue = ReadMenuChoice();
			
			    DateTime now = DateTime.Now;  //get the current date and time (system)
                string strOut = String.Empty; //temporary variable (work variabel)

			    //Determin which message to show
                switch (iValue)
                {
                    case 0:    //User selects to exit the program
                        done = true;
                        break;

                    case 1:
                        strOut = "Current date is: " + now.ToShortDateString();
                        break;

                    case 2:
                        strOut = "Current time is : " + now.ToShortTimeString();
                        break;

                    case 3:
                        strOut = "Current long-date is: " + now.ToLongDateString();
                        break;

                    case 4:
                        strOut = "Current long-time is : " + now.ToLongTimeString();
                        break;

                    default:
                        strOut = "Välj ett heltal från listan";
                        break;
                } //switch

                //if the user has not chosen to exit the program, show results
                if (!done)                
                    WriteOutput(strOut); 
		    }//while
	    }//showMenu

        /// <summary>
        /// Read the user's menu choice
        /// </summary>
        /// <returns>A value representing the user's choice.</returns>
        private int ReadMenuChoice()
	    {
		    bool done = false;
		    int iValue = -1;
    				
		    do
		    {
                WriteMenuText();
                if (int.TryParse(Console.ReadLine(), out iValue))
                {
                    if ((iValue >= 0) && (iValue <= 4))
                        done = true;
                }
                
                if (!done)
                    Console.WriteLine("Invalid choice, try again!\n");
			
		    }while (!done);
		
		    return iValue;
	    }//WriteMenutText

        /// <summary>
        /// Help method showing the menu text
        /// </summary>
        private void WriteMenuText()
        {
            WriteBlankLines(3);
            Console.WriteLine("\n *****************  MENU *********************");
            Console.WriteLine(" ***** 1. Current short date format");
            Console.WriteLine(" ***** 2. Current short time");
            Console.WriteLine(" ***** 3. Current long date format");
            Console.WriteLine(" ***** 4. Current long time format");
            Console.WriteLine(" ***** 0. Exit\n");
            Console.WriteLine(" *********************************************");
            WriteBlankLines(2);

            Console.Write(" ***** May I have your choice please: ");
        }

        /// <summary>
        /// Show the results that is a string containting a date/time information
        /// </summary>
        /// <param name="strOut">String to show.</param>
        private void WriteOutput(string strOut)
        {
            //'\n' is an Escape Sequence character for new line
            Console.WriteLine("\n\n *************  YOUR VIRTUAL CLOCK ************\n");
            Console.WriteLine("  " + strOut);
 
        
        }
        /// <summary>
        /// Method that prints a number of blanklines to the console
        /// window.  The number of lines is determined by the
        /// the caller of the method
        /// </summary>
        /// <param name="count">Number of lines to print.</param>
        private void WriteBlankLines(int count)
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine();
        }

    }//class
} //namespace

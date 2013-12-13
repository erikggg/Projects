using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAHAssignment2
{
    //This class will handle all input actions from the user, 
    //depending on the desired datatype output.
    class Input
    {   
        //This static method returns an integer with the option of inputting a maximum value
        //It will parse user input to int and check that the value is below max int input.
        public static int ReadIntegerConsole(string text, int? maxInput)
        {
            Console.Write("{0} ", text);
            string userValue = Console.ReadLine();
            int returnvalue;

            if (int.TryParse(userValue, out returnvalue) && ((returnvalue <= maxInput) || (!maxInput.HasValue)))
            {
                return returnvalue;
            }
            else
            {
                
                while (!int.TryParse(userValue, out returnvalue))
                {
                    Console.Write("Please choose a valid input for this menu:  ");
                    userValue = Console.ReadLine();
                }
                return returnvalue;
                
            }

            
        }
        //this inputmethod returns the user input parsed to int.
        //until user provides a valid input, the method will ask the user for a valid input.
        public static int ReadIntegerConsole()
        {
            string userValue = Console.ReadLine();
            int returnvalue;

            if (int.TryParse(userValue, out returnvalue))
            {
                return returnvalue;
            }

            else
            {
                while ((!int.TryParse(userValue, out returnvalue)))
                {
                    Console.Write("Please choose a valid (int) input for this menu");
                    userValue = Console.ReadLine();
                }
                return returnvalue;
            }
        }
        //This method returns user input parsed to double
        //if input is valid, we will ask for another, valid, input.
        public static double ReadDoubleConsole()
        {
            string userValue = Console.ReadLine();
         
            double returnvalue;
            //Trying to parse user value to double, allowing both decimalpoint and decimalcomma.
            if ((double.TryParse(userValue, System.Globalization.NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out returnvalue)) &&
                double.TryParse(userValue, System.Globalization.NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out returnvalue))
                
            {
                //if parse was successful, return uservalue
                return returnvalue;
            }
            else
            {
                //if parse is not valid, ask for a valid number until it is supplied, then return it.
                while (!(double.TryParse(userValue, System.Globalization.NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out returnvalue)) &&
                       !(double.TryParse(userValue, System.Globalization.NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out returnvalue)))
                {
                    Console.Write("Please input a floating point (double) value: ");
                    userValue = Console.ReadLine();
                }
                return returnvalue;

            }

        }
        public static decimal ReadDecimalConsole()
        {
            string userValue = Console.ReadLine();
            decimal returnValue;


            if (decimal.TryParse(userValue, out returnValue))
            {
                return returnValue;
            }
            else
            {
                while (!decimal.TryParse(userValue, out returnValue))
                {
                    Console.Write("Please input a valid decimal value: ");
                    userValue = Console.ReadLine();
                }
                return returnValue;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAHAssignment2
{
    class Input
    {   
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
                        Console.Write("Please choose a valid input for this menu");
                        userValue = Console.ReadLine();
                    }
                    return returnvalue;
                }
           }
        public static double ReadDoubleConsole()
        {
            string userValue = Console.ReadLine();
         
            double returnvalue;

            if (double.TryParse(userValue, out returnvalue))
            {
                return returnvalue;
            }
            else
            {

                while (!double.TryParse(userValue, out returnvalue))
                {
                    Console.Write("Please input a floating point number: ");
                    userValue = Console.ReadLine();
                }
                return returnvalue;

            }

        }
    }
}

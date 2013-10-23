using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpressionsStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int c; //declaration statement
            int someValue;
            string z;
            int x = 0;
            int y = 0;
            int a = 0;
            int b = 0;
            string myString;
            string myFirstName;
            string myLastName;


            myString = myFirstName + myLastName; //expression statement
            someValue = (3 * x) / 100; //first expression, then assignment

            if (x > y) z = "Bob";

            //x + y;
            //Assignment operator
            x = 3;

            //Addition operator

            x = 3 + 4;

            //Subtraction operator
            x = 4 - 3;

            //Multiplication operator
            x = 10 * 5;

            //Division operator
            x = 10 / 5;

            //Equality operator
            if (x == y)
            {
            }
            //Greater than operator
            if (x > y)
            { 
            }

            //Less than operator
            if (x < y)
            { 
            }

            //Greater or equal to operator
            if (x >= y)
            { 
            }

            //Less than or equal to operator
            if (x <= y)
            { 
            }

            //Conditional AND operator
            if ((x > y) && (a > b))
            { 
            }

            //Conditional OR operator
            if ((x > y) || (a > b))
            { 
            }
            
            //Conditional 
            string message = (x == 1) ? "Car" : "Boat";

            //Member access and Method invocation
            // access writeline member of Console class
            //and invoking the method with the parenthesis and an input parameter.
            Console.WriteLine("Hi");


        }
    }
}

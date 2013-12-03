using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*This class will add */
namespace MAHAssignment2
{
    class FloatingNumberWhileAdd
    {
        private double summation;

        public void Start()
        {
            WriteProgramInfo();
            summation = ReadValuesAndSumNumbers();
            WriteResult(summation);
        }
        private void WriteProgramInfo()
        {
            Console.WriteLine("********** Summation of real numbers **********  ");
            Console.WriteLine("             Using while-statement               ");
            Console.WriteLine("Write 0 to finish!");
            Console.WriteLine("Make sure to input correct decimal characters");
        }
        private void WriteResult(double result)
        {

            Console.WriteLine("This sum is: {0}", result);
        }
        private double ReadValuesAndSumNumbers()
        {
            bool done = false;
            double result;
            double total = 0;
            
            while (!done)
            {
                Console.Write("Please input a floating point number: ");
                result = Input.ReadDoubleConsole();
                if (result == 0)
                {
                    done = true;
                    //break;
                }
                else 
                    total += result;

            }
            return total;
        }
    }
}

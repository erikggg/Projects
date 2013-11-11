using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAHAssignment2
{
    class WholeNumbersForAdd
    {
        private int numberOfInputs;
        private int summation = 0;
        private int[] ints;
        

        public void Start()
        {
            WriteProgramInfo();
            ReadInput();
            SumNumbers();
        }
        private void SumNumbers()
        {
            
            for (int i = 0; i < ints.Length; i++)
            {
                summation += ints[i];
            }
            
            Console.Write("Total value of chosen ints:  {0}\n", summation);

        }
        private void WriteProgramInfo()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("This menu choice will sum a number of ints");
            Console.WriteLine("*******************************************");
            
        }
        private void ReadInput()
        {
            numberOfInputs = Input.ReadIntegerConsole("Number of values to sum?  ", null);
            //Console.Write(numberOfInputs);

            ints = new int[numberOfInputs];

            int j;

            for (int i = 0; i < ints.Length; i++)
            {

                j = i+1;

                Console.Write("Please input Value number {0}: ", j);
                ints[i] = Input.ReadIntegerConsole();
                //Console.Write(ints[i]);

            }

        }
    }
}

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
            
            Console.Write("Total value of chosen ints:  {0}", summation);

        }
        private void WriteProgramInfo()
        {
            Console.WriteLine("This menu choice will sum a number of ints");
            
        }
        private void ReadInput()
        {
            Input numbers = new Input();
            numberOfInputs = numbers.input("Number of values to sum?  ", null);
            //Console.Write(numberOfInputs);

            ints = new int[numberOfInputs];

            int j;

            for (int i = 0; i < ints.Length; i++)
            {

                j = i+1;

                Console.Write("Please input Value number {0}: ", j);
                ints[i] = numbers.input();
                //Console.Write(ints[i]);

            }

        }
    }
}

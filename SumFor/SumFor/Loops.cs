using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFor
{
    public class Loops
    {
        //public void RunLoops()
        //{
        //    SumUpNumbersFor();
        //    SumUpNumberWhile();
        //}
        public int SumUpNumbersFor()
        {
            int end = 5000;
            int sum = 0;

            for (int i = 0; i < end; i++)
            {
                sum += i;
            }
            return sum;
        }


        public int SumUpNumberWhile()
        {
            int end = 5000;
            int sum = 0;
            int i = 0;
            while (i < end)
            {
                sum += i;
                i++;

            }
            return sum;
        }

    }
}

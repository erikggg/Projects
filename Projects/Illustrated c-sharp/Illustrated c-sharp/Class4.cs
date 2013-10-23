using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simple;

    public class PrintValues
    {
        public int EInt = 20;

        public void PrintSum (int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("Newsflash: {0} + {1} is {2}", x, y, sum);
        }
        public int Sum(int x, int y)
        {
            return x + y;
        }
        
        public float Avg (float input1, float input2)
        {
            return (input1+input2)/2.0F;
        }
        
   }

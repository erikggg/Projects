using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Loops run = new Loops();

            Console.WriteLine(run.SumUpNumberWhile());
            Console.WriteLine(run.SumUpNumbersFor());

            Console.ReadLine();

            int sum = 1;

            //for (int i = 1; i < 5000; i++)
            //{
                

            //    sum = sum + i;
            //    Console.WriteLine(sum);
                
            //}
            int i = 1;

            while (i < 5000)
            {
                sum = sum + i;
                i++;
                Console.WriteLine(sum);
            }
            Console.ReadLine();

        }
    }
}

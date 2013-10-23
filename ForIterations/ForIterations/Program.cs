using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10/*as long as this is true, execute the code*/; i++ /*do this after every invocation of the code*/)
            //{
            //    //Console.WriteLine(i.ToString());
            //    if (i == 7)
            //    {
            //        Console.WriteLine("Found se7en!");
            //        break;
            //    }
            //}
           
            for (int myX = 0; myX < 10; myX++)
            {
                Console.WriteLine(myX);
                
            }
            Console.ReadLine();
        }
    }
}

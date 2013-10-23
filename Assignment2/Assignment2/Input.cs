using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAHAssignment2
{
    class Input
    {
        int i;
        
        public int input()
        {
            Console.WriteLine("Please type in your menu choice");
            string userValue = Console.ReadLine();
            return int.Parse(userValue);
        }
    }
}

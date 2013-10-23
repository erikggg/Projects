using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionÖvning
{
    class Addition
    {
        private int maxNo;
        public int GetMaxNo()
        { 
            int result;

            Console.WriteLine("Input Max number you want to add");
            if (int.TryParse(Console.ReadLine(), out result) == true)
            //if (double.TryParse(Console.ReadLine(), out result) == true)
            {
                maxNo = result;
            }
            else
            {
                Console.WriteLine("Please input a valid int");
            }
            Console.WriteLine("you chose {0}", maxNo);
            return maxNo;
        }
        public void Iterate(int count)
        { 
            int i = 1;
            int sum = i;
            while (i < count)
            {
                sum = sum + i;
                Console.WriteLine("Sum:{0}", sum);                
                i++;
            }
            Console.ReadLine();
        }
    }
}

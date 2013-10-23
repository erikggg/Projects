using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAHAssignment1
{
    class GroceryStore
    {
        static void Main(string[] args)
        {
            Console.Title = "Eriks Supermarket";

            Product product = new Product();

            product.Start();

            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
    }
}

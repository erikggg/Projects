using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price
{
    class Program
    {
        static void Main(string[] args)
        {
            //To do:
            //1. Declare and create an object of the class Clock
            Product product = new Product();

            
           
            double pris = product.inputPrice();
            double antal = product.inputQuantity();

            double price = product.calcPrice(pris, antal);
            double moms = product.calcMoms(price);

            

            product.output(price, moms);
           

            
           
            //The prompt window will disappear fast.
            //We can keep the window by putting the console in input mode (waiting for user input)
            //by using the ReadLine method in the Console class, namespace System
        //    Console.ReadLine(); //Press enter to close the console window.
        }
    }
}

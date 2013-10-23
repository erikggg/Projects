using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Price;

namespace Price
{
    public class Product
    {
        //input
        private const double moms = 12; //moms i procent

        //output
        //private double totalPris; //uträknat pris
        //private double totalMoms; //uträknad moms för mängden.
        
        
        public double inputPrice()
        {
            Console.WriteLine("What is the inprice?");
            string str1 = Console.ReadLine();
            double aPris = 0;
            try
            {
                aPris = double.Parse(str1);
            }
            catch (Exception e)
            {
                Console.WriteLine("not a valid number!");
            }
            return aPris;

            
            
        }
        public double inputQuantity()
        {
            Console.WriteLine("What is the quantity?");
            string str2 = Console.ReadLine();
            double antKilo = 0;

            try
            {
                antKilo = double.Parse(str2);
            }
            catch(Exception f)
            {
                Console.WriteLine("Not a valid amount!");
            }
            return antKilo;
        }
        public double calcPrice(double pris, double antal)
        {
            
            return antal * pris;
            
        }
        public double calcMoms(double price)
        {
            return price * (moms / 100);
        }


        public void output(double totalpriset, double momsen)
        {

            Console.WriteLine("The total price for the quantity specified is: {0}kr and the VAT is: {1}kr ({2}%)", totalpriset, momsen, moms);
            Console.ReadLine();
        }
    }
    
}

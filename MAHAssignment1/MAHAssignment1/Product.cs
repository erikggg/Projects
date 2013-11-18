using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAHAssignment1
{
    class Product
    {
        private const double foodVATRate = 12, otherVATRate = 25;
        

        public string name;
        public int count;
        public double unitPrice;
        public bool foodItem;

        private double VATRateUsed;
        private double totalVAT;
        private double totalNetValue;
        private double totalValue;


        public void Start()
        {
            ReadInput();

            CalculateValues();

            PrintReciept();
        }
        private void ReadInput()
        {
            ReadName();

            ReadNetUnitPrice();

            ReadIfFoodItem();

            ReadCount();

        }

        private void ReadName()
        {
            Console.WriteLine("Please enter productname: ");
            name = Console.ReadLine();
        }
        private void ReadNetUnitPrice()
        {
            double result;

            Console.WriteLine("Net Unit Price: ");
            if (double.TryParse(Console.ReadLine(), out result) == true)
            {
                unitPrice = result;
            }
            else
            {
                Console.WriteLine("Input is not valid.");
            }

        }
        private void ReadIfFoodItem()
        { 
            Console.WriteLine("Is this a food item(y/n): ");
            char response = char.Parse(Console.ReadLine());

            if ((response == 'y') || (response == 'Y'))
                foodItem = true;
            else
                foodItem = false;

        }
        private void ReadCount()
        {
            Console.WriteLine("Count/Amount: ");
            count = int.Parse(Console.ReadLine());
        }
        private void CalculateValues()
        {
            
            
            totalNetValue = count * unitPrice;

            if (foodItem == true)
            {
                
                VATRateUsed = foodVATRate;
            }
            else
            {
                VATRateUsed = otherVATRate;
            }
            totalVAT = totalNetValue * (VATRateUsed / 100);
            totalValue = totalVAT + totalNetValue;
        }
        private void PrintReciept()
        {
            Console.WriteLine("***Total amount to pay: {0}***", totalValue);
            Console.WriteLine("***Including VAT at {0}%: {1} ***", VATRateUsed, totalVAT);
            Console.WriteLine("***This program has been developed by Erik Grahn***");

        }
    }
}

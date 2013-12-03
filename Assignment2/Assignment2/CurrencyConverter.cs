using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*This class will convert an amount of SEK to any named currency given the currency name and conversionrate (amount of sek/currency). 
 * Amount to convert is added up before calculations are made, using a do-while loop*/
namespace MAHAssignment2
{
    class CurrencyConverter
    {
        public void Start()
        {
            //calling info method
            WriteProgramInfo();
            //calling calculate method with amount, currency and rate as parameters
            CalculateAndDisplay(InputSum(), InputCurrency(), ExchangeRate());
        }
        private void WriteProgramInfo()
        {
            //displaying information on currency converter
            Console.WriteLine("********** The CurrencyConverter **********");
            Console.WriteLine("Write 0 to finish input!");
            Console.WriteLine("Make sure to use correct decimal characters");
            Console.WriteLine("*******************************************");
        }
        private decimal InputSum()
        {   
            decimal result;
            //setting total to 0 before calculations start
            decimal total = 0;

            //until user inputs a 0, keep adding the amounts together using the ReadDoubleConsole method
                do
                {
                    Console.Write("Please input an amount in kr, or zero to exit calculations: ");
                    result = Input.ReadDecimalConsole();
                    total += result;
                }
                while (result != 0);
            //return the sum total
            return total;
        }
        private string InputCurrency()
        {
            //asking the user for Currency name
            Console.Write("Please input the name of the currency you wish to convert to:  ");
            string userValue = Console.ReadLine();
            return userValue;
        }
        private decimal ExchangeRate()
        {
            decimal userValue;
            //requesting currency rate from user, not sure if sek/currency could be explained better
            Console.Write("Please input currency rate (amount of SEK per target currency):  ");
            userValue = Input.ReadDecimalConsole();
            return userValue;
        }
        private void CalculateAndDisplay(decimal amount, string toCurrency, decimal rate)
        {
            //calculating amount in target Currency
            decimal toCurrencyAmount = amount / rate;
            Console.WriteLine("*******************************************");
            Console.WriteLine("{0} kr is converted to {1} {2} at the rate of {3}kr/{2}", amount, toCurrencyAmount, toCurrency, rate, toCurrency);
            Console.WriteLine("*******************************************");
        }
    }
}
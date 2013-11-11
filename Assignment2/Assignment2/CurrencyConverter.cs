using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAHAssignment2
{
    class CurrencyConverter
    {
        Input amount = new Input();
        public void Start()
        {
            WriteProgramInfo();
            //InputSum();
            CalculateAndDisplay(InputSum(), InputCurrency(), ExchangeRate());
        }
        private void WriteProgramInfo()
        {
            Console.WriteLine("********** The CurrencyConverter **********");
            Console.WriteLine("Write 0 to finish input!");
            Console.WriteLine("Make sure to use correct decimal characters");
            Console.WriteLine("*******************************************");
        }
        private double InputSum()
        {   
            double result;
            double total = 0;

            
                do
                {
                    Console.Write("Please input an amount in kr, or zero to exit calculations: ");
                    Input userValue = new Input();
                    result = Input.ReadDoubleConsole();
                    total += result;
                }
                while (result != 0);
            return total;
        }
        private double ExchangeRate()
        {
            double userValue;
            Console.Write("Please input currency rate:  ");
            userValue = Input.ReadDoubleConsole();
            return userValue;
        }
        private string InputCurrency()
        {
            Console.Write("Please input the name of the currency you wish to convert to:  ");
            string userValue = Console.ReadLine();
            return userValue;
        }
        private void CalculateAndDisplay(double amount, string toCurrency, double rate)
        {
            double toCurrencyAmount = amount / rate;
            Console.WriteLine("*******************************************");
            Console.WriteLine("{0} kr is converted to {1} {2} at the rate of {3}kr/{2}", amount, toCurrencyAmount, toCurrency, rate, toCurrency);
            Console.WriteLine("*******************************************");
        }
    }
}
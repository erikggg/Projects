using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAHAssignment2
{
    class CelciusToFahrenheit
    {
        //double toCelsius;
        double toFahrenheit;

        public void Start()
        {
            DisplayInfo();
            DisplayStuff(100);
        }
        private void DisplayInfo()
        {
            Console.WriteLine("Temperature Table");
            Console.WriteLine("Showing Celsius (C) to Fahrenheit (F) conversion");
        }
        private void DisplayStuff(int maxCelsius)
        {
            Console.SetWindowSize(Console.WindowWidth, (maxCelsius/4)+4);
            int valueToConvert;
            for (int i = 0; i <= maxCelsius; i++)
            {
                valueToConvert = i;
                //toCelsius = (5.0 / 9.0 * (valueToConvert - 32));
                toFahrenheit = (9.0 / 5.0 * valueToConvert + 32.0);
                if (i % 4 == 0)
                Console.WriteLine("{0, 25} F = {1,8} C", toFahrenheit.ToString("F2"), valueToConvert.ToString("F2"));
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
        }
    }
}

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
        int max;
        int min; 

        public void Start()
        {
            DisplayInfo();
            GetInput();
            //saving old height to temporarily set window hight to display a large amount of values.
            int oldHeight = Console.WindowHeight;
            DisplayStuff(max, min);
            Console.SetWindowSize(Console.WindowWidth, oldHeight);
        }
        private void GetInput()
        {
            //only showing integers divisible by 4
            max = Input.ReadIntegerConsole("Please input the max celsius value", null);
            min = Input.ReadIntegerConsole("Please input the minimum celsius value", null);
            
        }
        private void DisplayInfo()
        {
            
            Console.WriteLine("Temperature Table");
            Console.WriteLine("Showing Celsius (C) to Fahrenheit (F) conversion");
        }
        //taking max and min values to display
        private void DisplayStuff(int maxCelsius, int minCelsius)
        {
            //for larger amounts, set window size to amount of lines displayed + 6
            
            if ((maxCelsius/4)+6 > Console.WindowHeight && (maxCelsius/4)+4 <= 58)
            {
                Console.SetWindowSize(Console.WindowWidth, (maxCelsius/4)+6);
            }
            for (int i = minCelsius; i <= maxCelsius; i++)
            {
                
                //toCelsius = (5.0 / 9.0 * (valueToConvert - 32));
                toFahrenheit = (9.0 / 5.0 * i + 32.0);
                //only writing every 4 calculations to allow all calculations to show in the window
                if (i % 4 == 0)
                Console.WriteLine("{0, 25} F = {1,8} C", toFahrenheit.ToString("F2"), i.ToString("F2"));
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
        }
    }
}

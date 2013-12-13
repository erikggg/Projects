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
        //displaying Fahrenheit as a double since conversion will result in fractions of a degree.
        double toFahrenheit;
        //choosing int for celsius values
        int maxCelsius;
        int minCelsius; 

        public void Start()
        {
            DisplayInfo();
            GetInput();
            //saving old height to temporarily set window hight to display a large amount of values.
            int oldHeight = Console.WindowHeight;
            //calling display method with min and max values.
            DisplayStuff(maxCelsius, minCelsius);
            //reset window size to old value
            Console.SetWindowSize(Console.WindowWidth, oldHeight);
        }
        private void GetInput()
        {
            //Get celsius interval to display, using min and max values
            maxCelsius = Input.ReadIntegerConsole("Please input the max celsius value", null);
            minCelsius = Input.ReadIntegerConsole("Please input the minimum celsius value", null);
            
        }
        private void DisplayInfo()
        {
            
            Console.WriteLine("Temperature Table");
            Console.WriteLine("Showing Celsius (C) to Fahrenheit (F) conversion");
        }
        //taking max and min values to display
        private void DisplayStuff(int maxCelsius, int minCelsius)
        {
            //If rows + 6 is larger than current window height and smaller 
            //than max window height set window size to 
            //amount of lines displayed + 6 to display chosen values in same console window.
            //values divided by 4 since we only print every 4th value.
            //for larger amounts, set window size to amount of lines displayed + 6
            if ((maxCelsius / 4) + 6 > Console.WindowHeight && (maxCelsius / 4) + 6 <= Console.LargestWindowHeight)
            {
                //setting window size if result set is larger than window hight but smaller than max window height.
                Console.SetWindowSize(Console.WindowWidth, (maxCelsius/4)+6);         
            }
            //print values between given min and max
            for (int i = minCelsius; i <= maxCelsius; i++)
            {
                
                //toCelsius = (5.0 / 9.0 * (valueToConvert - 32));
                toFahrenheit = (9.0 / 5.0 * i + 32.0);
                //only writing every 4 calculations to allow all calculations to show in the window
                if (i % 4 == 0)
                Console.WriteLine("{0, 25} F = {1,8} C", toFahrenheit.ToString("F2"), i.ToString("F2"));
            }

            //waiting for command before exiting conversion and returning to menu..
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAHAssignment2
{
    class Menu
    {
        
        public void Start()
        {
            bool done = false;
            int menuchoice;

            while (!done)
            {
                Console.Title = "MAIN MENU";
                Console.WriteLine("*******************************************");
                Console.WriteLine("Whole Numbers with For                   :1");
                Console.WriteLine("Floating Point Numbers with While        :2");
                Console.WriteLine("Currency Converter with Do While loop    :3");
                Console.WriteLine("Work Schedule                            :4");
                Console.WriteLine("Celsius to Fahrenheit                    :5");
                Console.WriteLine("Exit the Program                         :0");
                Console.WriteLine("*******************************************");
                menuchoice = Input.ReadIntegerConsole("Please input your menu choice", null);
                
                Console.WriteLine("Your choice: {0}", menuchoice);
                switch (menuchoice)
                {
                    case 0:
                        done = true;
                        break;
                    
                    case 1:

                        WholeNumbersForAdd choice1 = new WholeNumbersForAdd();
                        choice1.Start();
                        break;
                    case 2:
                        FloatingNumberWhileAdd choice2 = new FloatingNumberWhileAdd();
                        choice2.Start();
                        break;
                    case 3:
                        CurrencyConverter choice3 = new CurrencyConverter();
                        choice3.Start();
                        break;

                    case 4:
                        WorkingSchedule choice4 = new WorkingSchedule();
                        choice4.Start();
                        break;
                    case 5:
                        CelciusToFahrenheit choice5 = new CelciusToFahrenheit();
                        choice5.Start();
                        break;
                    default:
                        Console.WriteLine("Your choice: {0} has not yet been implemented. Please select another menu option", menuchoice);
                        break;
                    
                }

                

            }
        }
        
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAHAssignment2
{ 
    class Menu
    {
        //Start method kicks off the Menu class.
        public void Start()
        {
            
            bool done = false;
            
            //while not done, display the menu options.
            while (!done)
            {
                //save choice 
                int menuchoice;

                Console.Title = "MAIN MENU";
                Console.WriteLine("*******************************************");
                Console.WriteLine("Whole Numbers with For                   :1");
                Console.WriteLine("Floating Point Numbers with While        :2");
                Console.WriteLine("Currency Converter with Do While loop    :3");
                Console.WriteLine("Work Schedule                            :4");
                Console.WriteLine("Celsius to Fahrenheit                    :5");
                Console.WriteLine("Exit the Program                         :0");
                Console.WriteLine("*******************************************");
                //ask for menu choice from displayed menu options
                menuchoice = Input.ReadIntegerConsole("Please input your menu choice", null);
                
                //display chosen options
                Console.WriteLine("Your choice: {0}", menuchoice);
                //create an instance of chosen class with the switch being the previously chosen menu option
                //return to calling code until user exits
                switch (menuchoice)
                {
                        //if choice is 0, set done variable to true and break
                    case 0:
                        done = true;
                        break;
                    
                    case 1:
                        //creating an instance of WholeNumbersForAdd
                        WholeNumbersForAdd choice1 = new WholeNumbersForAdd();

                        //call start method of WholeNumbersForAdd
                        choice1.Start();
                        
                        break;
                    case 2:
                        //creating an instance of FloatingNumberWhileAdd
                        FloatingNumberWhileAdd choice2 = new FloatingNumberWhileAdd();
                        //call start method of FloatingNumberWhileAdd
                        choice2.Start();
                        break;
                    case 3:
                        //create instance
                        CurrencyConverter choice3 = new CurrencyConverter();
                        //call start method
                        choice3.Start();
                        break;

                    case 4:
                        //create instance
                        WorkingSchedule choice4 = new WorkingSchedule();
                        //call start method
                        choice4.Start();
                        break;
                    case 5:
                        //create instance
                        CelciusToFahrenheit choice5 = new CelciusToFahrenheit();
                        //call start method
                        choice5.Start();
                        break;
                    default:
                        //if the choice made is not valid, display we are not done so we ask the user to choose another option
                        Console.WriteLine("Your choice: {0} has not yet been implemented. Please select another menu option", menuchoice);
                        break;
                    
                }

                

            }
        }
        
        
    }
}

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
            Input choice = new Input();
            int menuchoice;

            while (!done)
            {
                Console.Title = "MAIN MENU";

                Console.WriteLine("Whole Numbers with For                   :1");
                Console.WriteLine("Floating Point Numbers with While        :2");
                Console.WriteLine("Currency Converter with Do While loop    :3");
                Console.WriteLine("Work Schedule                            :4");
                Console.WriteLine("Exit the Program                         :0");
                menuchoice = choice.input();

                switch (menuchoice)
                {
                    case 0:
                        done = true;
                        break;
                    
                    case 1:
                        WholeNumbersForAdd
                }

                //WholeNumbersWithfor()

                Console.ReadLine();
            }
        }
        
        
    }
}

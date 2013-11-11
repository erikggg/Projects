using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAHAssignment2
{
    class WorkingSchedule
    {
        public int choice;
        public void Start()
        {
            ListChoices();
            ShowSchedule();
        }
        public void ListChoices()
        { 
            Console.WriteLine("1: Show a list of weekends to work");
            Console.WriteLine("2: Show a list of nights to work");
            Console.WriteLine("0: Return to main menu");

            choice = Input.ReadIntegerConsole();
        }
        private void ShowSchedule()
        { 
            while (choice != 0)
            if (choice == 1)
                ShowWeekendSchedule();

            if (choice == 2)
                ShowNightsSchedule();
            else
                Console.WriteLine("Invalid menu option");
        }
        private void ShowWeekendSchedule()
        {

        }
        private void ShowNightsSchedule()
        { 

        }
    }
 
}
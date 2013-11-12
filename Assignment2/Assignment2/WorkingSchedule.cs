using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAHAssignment2
{
    class WorkingSchedule
    {
        public bool done = false;
        public int choice;
        public void Start()
        {
            ListChoices();
            while (!done)
            {

                ShowSchedule();
            }
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
            switch (choice)
            {
                case 0:
                    done = true;
                    break;
                case 1:
                    ShowWeekendSchedule();
                    break;

                case 2:
                    ShowNightsSchedule();
                    break;
                    
                default:
                    Console.WriteLine("Invalid menu option");
                    break;
            }
        } 
        private void ShowWeekendSchedule()
        {
            int week;
            int maxweek = 52;
            for (int i = 0; i < maxweek; i += 3)
            {
                week = i;
                if (i == 0)
                {
                    week = 6;
                    i = week;
                }
                Console.WriteLine("Week {0}", week);
            }
            done = true;
            return;
        }
        private void ShowNightsSchedule()
        {

        }
    }

}
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

            while (!done)
            {
                ListChoices();
                DisplaySchedule();
            }
        }
        public void ListChoices()
        {
            Console.WriteLine("");
            Console.WriteLine("1: Show a list of weekends to work");
            Console.WriteLine("2: Show a list of nights to work");
            Console.WriteLine("0: Return to main menu");

            choice = Input.ReadIntegerConsole();
            Console.WriteLine("Your choice: {0}", choice);
        }
        private void DisplaySchedule()
        {
            switch (choice)
            {
                case 0:
                    done = true;
                    break;
                case 1:
                    //Weekends
                    ShowSchedule(6, 3, 52);
                    break;

                case 2:
                    //Nights
                    ShowSchedule(1, 5, 52);
                    break;

                default:
                    Console.WriteLine("Invalid menu option");
                    break;
            }
        }
        private void ShowSchedule(int startweek, int interval, int maxweek)
        {
            int week = startweek;
            int i = 0;

            while (week < maxweek)
            {
                
                if (i % 3 == 0)
                {
                    Console.Write("\n");
                }

                Console.Write("{0, -3} {1,3}\t", "Week", week.ToString());

                week += interval;
                i++;
            }
            return;
        }
    }

}
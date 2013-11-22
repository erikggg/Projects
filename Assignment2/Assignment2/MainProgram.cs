using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//main method starts the menu
namespace MAHAssignment2
{
    class MainProgram
    {
        static void Main(string[] args)
        {
           //create new instance ArgumentOutOfRangeException menu class.
            Menu menu = new Menu();
   
            //call Start method in menu class
            menu.Start();
        }

    }
}

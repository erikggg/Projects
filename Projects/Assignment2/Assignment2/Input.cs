using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Input
    {
        int i;
        
        private int input(int i)
        { 
            
            if (int.TryParse(i), out result) == true)
            {
                return result;
            }
            
        }
    }
}

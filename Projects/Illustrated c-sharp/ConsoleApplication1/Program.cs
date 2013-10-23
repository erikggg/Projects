using System;

namespace MyProgram
{
    class MyProgram
    {
        static void Main()
        {
            int? myI1, myI2, myI3;
            
            myI1 = null;
            myI2 = myI1;
            myI3 = 3;
            int regInt = (int)myI3;

            
            if (myI1 != null && myI2 != null && myI3 != null)
            {
                Console.WriteLine("none of the values are null");
                Console.WriteLine("myI1:{0}, myI2:{1}, myI3:{2}", myI1, myI2, myI3);
            }
            else if (myI1 != null || myI2 != null || myI3 != null)
            {
                Console.WriteLine("One or more of the values are null");
                Console.WriteLine("myI1:{0}, myI2:{1}, myI3:{2}", myI1, myI2, myI3);
            }
            
        }
    }
}
using System;
using Simple;

public class ForLoop
{
    public void PrintAndLoop()
    {

        int intVal = 3;

        if (intVal == 3)
            Console.WriteLine("Value is 3");
        for (int i = 0; i < 5; i++)
            Console.WriteLine("Value of i: {0}", i);
    }

}

using System;

namespace MyInterActiveApplication
{
    class GoodDayPerson
    {
        static void Main(string[] args)
        {
            Console.Write("Please state your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello {0} and welcome to C# & Visual Studio", name);
        }
    }
}
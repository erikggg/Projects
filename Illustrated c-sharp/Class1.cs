using System;
using Simple;


public class Class1
{

        public void DisplayRadii()
    {
        const double PI = 3.1416; // Declare local constant
        for (int radius = 1; radius <= 5; radius++)
        {
        double area = radius * radius * PI; // Read from local constant
        Console.WriteLine ("Radius: {0}, Area: {1}", radius, area);
        Console.ReadLine();
        }
    }
  
}


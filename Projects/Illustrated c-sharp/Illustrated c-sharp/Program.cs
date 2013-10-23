using System;
using Simple;

namespace Simple
{
    //public class DateClass
    //{
    //    public void PrintDateAndTime()
    //    {
    //        DateTime dt = DateTime.Now;
    //        Console.WriteLine("{0}", dt);
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there!");

            //string var1 = "5";
            //Console.WriteLine("the string value of var1 is {0}", var1);

            //Console.Write("Please input your chosen string value to replace 5: ");

            //var1 = Console.ReadLine();
            //Console.WriteLine("You wrote '{0}', which is now the value of var1", var1);


            //Radius rad = new Radius();
            //rad.DisplayRadii();

            //ForLoop loop = new ForLoop();
            //loop.PrintAndLoop();

            DateClass dc = new DateClass();
            dc.PrintDateAndTime();



            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                Console.WriteLine("Another case of the mondays");
            }
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                Console.WriteLine("TGIF!");
            }
            else
            {
                Console.WriteLine("it's not monday!");
            }
            string noon = "unknown";

            if (dc.GetHour() > 12)
                noon = "afternoon";
            else noon = "morning!";

            Console.WriteLine("The Hour is:{0} and the minute is {1}. It is currently {2}", dc.GetHour(), dc.GetMinute(), noon);

            int int1;
            int int2;
            int x;
            int y;
            
            Random randprint = new Random();

            Console.WriteLine("Input first number");


            //Console.WriteLine("random number: {0}", randprint.Next(25));

            //number = Console.ReadLine();
            int count = 0;

            while (!Int32.TryParse(Console.ReadLine(), out int1))
            {
            
                    int ten = randprint.Next(5);
                    //create random text print class
                    if (count <= 10)
                    {

                        if (ten == 0 && count <= 10)
                        {
                            Console.WriteLine("Please input a valid number");
                            Console.WriteLine("Randomint is {0}", ten);
                            count++;
                        }
                        if (ten == 1 && count <= 10)
                        {
                            Console.WriteLine("Please input a valid integer");
                            Console.WriteLine("Randomint is {0}", ten);
                            count++;
                        }
                        if (ten == 2 && count <= 10)
                        {
                            Console.WriteLine("Only Integers are considered valid input");
                            Console.WriteLine("Randomint is {0}", ten);
                            count++;
                        }
                        if (ten == 3 && count <= 10)
                        {
                            Console.WriteLine("A valid number please");
                            Console.WriteLine("Randomint is {0}", ten);
                            count++;
                        }
                        if (ten == 4 && count <= 10)
                        {
                            Console.WriteLine("Valid number needed for calculations!");
                            Console.WriteLine("Randomint is {0}", ten);
                            count++;
                        }
                    }
                    if (count > 10 && count <= 15)
                    {
                        if (ten == 0 || ten == 1 || ten == 2 || ten == 3 || ten == 4)
                        {
                            Console.WriteLine("For the love of god, input a valid number");
                            count++;
                        }
                        if (count == 15)
                        {
                            if (ten == 0 || ten == 1 || ten == 2 || ten == 3 || ten == 4)
                            {
                                Console.WriteLine("That's it, no more attempts for you! First number set to 0.");
                                break;
                            }
                        }
                    }
                    
            }
            
                    x = int1;
                    Console.WriteLine("Input {0} is a valid integer", x);

            Console.WriteLine("Input second number");
            if (Int32.TryParse((Console.ReadLine()), out int2))
            {
                y = int2;

                Console.WriteLine("Input {0} is a valid integer", y);
            }
            else
            {
                Console.WriteLine("Please input a valid second number");
                while (!Int32.TryParse((Console.ReadLine()), out int2))
                    Console.WriteLine("Please input a valid second number");
                y = int2;
            }

            PrintValues pv = new PrintValues();

            int sum = pv.Sum(x, y);

            Console.WriteLine("Average is {2} and Sum is {3} of values {0} and {1}", x, y, pv.Avg(x, y), sum);

            // Random rand = new Random();
            //   Console.WriteLine("random number: {0}", rand.Next());



            Console.ReadLine();
        }
    }
}

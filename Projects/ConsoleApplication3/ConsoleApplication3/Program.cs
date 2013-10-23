using System;

class DaysTemp
{
    public int High, Low;
    public int Average()
    {
        return (High + Low) / 2;
    }
    public void MyMethod()
    {
        Console.WriteLine("First");
        Console.WriteLine("Last");
    }
}
class Program
{
    static void Main()
    {
        int myInt = 3;

        DaysTemp t1 = new DaysTemp();
        DaysTemp t2 = new DaysTemp();

        t1.High = 76; t1.Low = 57;
        t2.High = 75; t2.Low = 53;

        while (myInt > 0)
        {
            --myInt;
            Console.WriteLine("t1: {0},{1},{2}, MyInt:{3}",
                        t1.High, t1.Low, t1.Average(), myInt);

            Console.WriteLine("t2: {0},{1},{2}, MyInt{3}",
                        t2.High, t2.Low, t2.Average(), myInt);
            t1.MyMethod();
            Console.ReadLine();
        }
    }
}
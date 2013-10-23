using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
class MyClass
{
void PrintDateAndTime( ) // Declare the method.
{
DateTime dt = DateTime.Now; // Get the current date and time.
Console.WriteLine("{0}", dt); // Write it out.
}
static void Main() // Declare the method.
{
MyClass mc = new MyClass();
mc.PrintDateAndTime( ); // Invoke the method.
Console.ReadLine();
}
}}

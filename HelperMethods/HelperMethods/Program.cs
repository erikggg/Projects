using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myValue = superSecretFormula();
            string myValue = superSecretFormula("Bob");
            Console.WriteLine(myValue);

            //myValue = superSecretFormula("Steve");
            Console.WriteLine(superSecretFormula());


            Console.ReadLine();
        }
        private static string superSecretFormula()
        {
            return "Hello World";
        }
        private static string superSecretFormula(string name)
        {
            return String.Format("Hello world, {0}", name);
        }
    }
}

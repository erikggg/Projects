using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionÖvning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Addition.GetMaxNo();
            Addition addition = new Addition();

            int maxNo = addition.GetMaxNo();
            
            addition.Iterate(maxNo);
        }
    }
}

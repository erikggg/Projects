//FordonProgram.cs  (startklassen)
//Denna rad är en kommentar och kompileras inte
//Kodexempel - Konsol applikation
//Skapad:  Farid Naisan, juni 2012


//'using System' säger till kompilatorn att den ska leta i System-gruppen efter klassen Console
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FordonApplikation
{
    /// <summary>
    /// 
    /// </summary>
    public class FordonProgram
    {
        public static void Main(string[] args)
        {
            //1. Deklarera en variable av klassen Bil
            Bil bilObj;  //skall hålla koll på var datan finns i minnet
            
            //2. Skapa objektet i minnet (allokera minne)
            bilObj = new Bil();  //new anropar konstruktorn (se bil.cs)

            //3. Använd tjänster av detta objekt
            bilObj.LäsInputOchSkrivInfo();

            //program utför sina instruktioner och avslutar här
            //Detta går så fort att kommandofönstret försvinner innan du fått 
            //en chans att se resultatet.  Om vi sätter programmet i ett läsläge
            //stannar du exekvering tills man matar in något (t ex trycker på Enter)

            Console.WriteLine("Tryck på enter för att avsluta progrmmet!");
            Console.ReadLine();  //läs något

        }
    }
}

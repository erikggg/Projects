//Bil.cs
//Denna rad är en kommentar och kompileras inte
//Kodexempel - Konsol applikation
//Skapad:  Farid Naisan, juni 2012


//'using System' säger till kompilatorn att den ska leta i System-gruppen efter klassen Console
using System;  
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Gruppnamn för denna applikation (jmf System)
namespace FordonApplikation
{
    /// <summary>   //XML kompatibla kommentarer
    /// Denna klass hanterar allt om en Bil som en typ Fordon.
    /// Klassen är publik  och hetter Bil. Vill du ändra namnet tryck F2 på ditt tangentbord
    /// Delar av klassen är numrerade.
    /// </summary>
    public class Bil
    {
        //Del 1: instansvariabler - var sparsam!
        //instansvariabler (attribut) som beskriver en bil (vilken som helst)
        //beskriver objektets tillsåntd, objekt är en instans av denna klass
        private string modell;
        private int antalDörrar;
        private double pris;
        private bool besiktad;

        //Del 2: Konstruktor
        //1.  Konstruktor är en speciell metod som heter samma som klassen och 
        //har ingen retur type (void, inte osv). En konstruktor används bl. a. för att 
        //initiera instansvariabler. Varje gång ett objekt (instans) av denna klass skapas 
        //med nyckelordet new, exekveras konstruktorn aumatiskt just innan objektet skapas.
        public Bil()
        {
            Console.WriteLine("Inne i konstruktorn, en ny bil kommer snart till världen!\n");
            modell = "Ej känd.";  //modell ej angivet
            antalDörrar = 4;  //standard
            pris = 0.0;   //priset ej känt fr början
            besiktad = false;  //anta att  bilen inte är besiktad (initiering)
        }

        //Del 3: metoder som utför instruktioner
        //------------------------------------------------------------------------------------------

        //Läs indata och printa ut allt om bilen
        public void LäsInputOchSkrivInfo()
        { 
            //1. Fråga användaren om bilen är besiktad och spara svaret
            LäsInfoOmBesiktning();

            //2. Skriv all info som är sparad för bilen än så länge
            VisaBilInfo();        
        
        }
 
        //------------------------------------------------------------------------------------------
        private void LäsInfoOmBesiktning()
        {
            Console.WriteLine("Är bilen besikted (j/n)?");
            //Läs ett tecken från användaren och spara det i en temporär variabel (svar)

		    char svar = char.Parse(Console.ReadLine());

            //Om användaren skriver j eller J är bilen besiktad; annars inte
            //== är likhets symbol (om vänstra del är lika med högra del)
		    if ( (svar == 'j') || (svar == 'J') )
			    besiktad = true;
		    else
			    besiktad = false;
	    }

        //------------------------------------------------------------------------------------------
 
        //  \n skapar en ny rad.
        public void VisaBilInfo()
        {
            Console.WriteLine("Följande info finns om bilen:\n\n");

            //Det värde som sparat i variabeln besikta är antingen true eller false.
            //Om besiktad = true är bilen besiktad - hur skriver vi ut det? Så här:
            
            string strBesiktad = "Bilen är inte besiktad.";

            if (besiktad)  //det samma som att skriva if (besiktad == true)
                strBesiktad = "Bilen är besiktad.";  //denan text används om bilen är besiktad
            
            //Formatera en string för att skriva ut
            //I satsen nedan {0} kommer att ersättas av aktuella värdet från variabeln
            //modell, {1} av värdet sparat i antalDörrar, osv
            //Vänstra delen mellan " och " är formatsatsen och högra delen är list av 
            //variabler från vilka värden skall tas. \n gör att besiktnings info skrivs ut 
            //på en ny rad.
            string strUt = string.Format("Modell: {0} Dörrar:{1} Pris: {2} \nBesiktning: {3}\n", 
                      modell, antalDörrar, pris, strBesiktad);

            Console.WriteLine(strUt);
        }
        /// <summary>
        ///  Property för att ge både läs- och skrivaccess till
        ///  värdet av den privata variabeln antalDörar.
        ///  value är ett reserverat ord som automatiskt får samma 
        ///  typ som Propertyn, här blir den int.
        ///  value innehåller ett nytt värde för antalDörrar.
        /// </summary>
        public int AntalDörrar
        {
            get 
            { 
                return antalDörrar; 
            }
            set
            {
                antalDörrar = value;
            }
        
        }

        public void Test()
        {
            //Hämta info om besiktning på sv
       
            string info = GeBesiktningsInfo(true); 
            
            //Nu hämta info om beskiktning på en
            //obs. återanvända info-variabeln
            info = GeBesiktningsInfo(false);

        }

        //Metoden använder sig av nästlade if-satser
        public string GeBesiktningsInfo(bool svenska)
        {
            string textUt = String.Empty; //tom sträng

            //info om beskiktning, "beskiktad" är instansvariabel
            if (besiktad) //samma som:  if (besiktad == true)
            {
                if (svenska)
                    textUt = "Bilen är besiktad!";
                else
                    textUt = "The car is inspected!";
            }
            else
            {
                if (svenska)
                    textUt = "Bilen är inte besiktad!";
                else
                    textUt = "The car is not inspected!";
            }
            return textUt;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPTE_CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Création des objets Compte bancaire.....
            Compte Gage;
            Gage = new Compte("12345",3800,"Gage Pascal",-200);

            Compte Benitez;
            Benitez = new Compte("54721", 1200, "Benitez Charles", -700);

            Compte Anguenot;
            Anguenot = new Compte("68751", 1000, "Anguenot Guillaume", -100);

            //les fonctionnalités...
            
            Console.WriteLine(Gage.ToString());
            Console.WriteLine(Benitez);
            Console.WriteLine(Anguenot);

            Gage.Transferer(1300, Benitez);
            Console.WriteLine(Gage.ToString());
            Console.WriteLine(Benitez);
            if (Gage.Superieur(Benitez)==1)
            {
                Console.WriteLine("Solde supérieur");
            }
            else if (Gage.Superieur(Benitez) == 0)
            {
                Console.WriteLine("Même solde");
            }
            else
            {
                Console.WriteLine("Solde inférieur");

            }

           

            Console.ReadKey();
        }
    }
}

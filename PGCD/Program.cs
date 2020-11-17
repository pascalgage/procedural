using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            string redo = "o";
            do
            {
                //Tableau des diviseurs possibles
                List<int> TAB = new List<int>();

                //Entrez le premier entier positif
                int A;
                Console.WriteLine("Entrez un nombre entier A:");
                A = int.Parse(Console.ReadLine());

                //Entrez le deuxième entier positif
                int B;
                Console.WriteLine("Entrez un nombre entier B:");
                B = int.Parse(Console.ReadLine());

                int D = 0;//Diviseur initial


                do
                {

                    D++;

                    if (A % D == 0 && B % D == 0)
                    {
                        TAB.Add(D);
                    }

                } while (D < A && D < B);


                //Expression du résultat
                Console.WriteLine("Le PGCD de " + A + " et de " + B + " est: " + TAB.Last());

                //Option de redémarrage du programme do...while par redo="o"...
                Console.WriteLine("Voulez-vous recommencer ? O/N");
                redo = Console.ReadLine().ToLower();

                if (redo != "o") { Console.WriteLine("Operation terminée !"); }

            } while (redo == "o");
            Console.ReadLine();


        }
    }
}

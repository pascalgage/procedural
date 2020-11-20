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
                Console.WriteLine("Entrez un nombre entier A positif non nul:");
                A = int.Parse(Console.ReadLine());

                bool test;
                test = calcul.nombrepremier(A);


                //Entrez le deuxième entier positif
                int B;
                Console.WriteLine("Entrez un nombre entier B positif non nul:");
                B = int.Parse(Console.ReadLine());

                bool test2;
                test2 = calcul.nombrepremier(B);


                int D = 0;//Diviseur initial

                if (test == true)
                {
                    Console.WriteLine("le nombre saisie par l'utilisateur {0:#,###} est premier", A);
                }
                if (test2 == true)
                {
                    Console.WriteLine("le nombre saisie par l'utilisateur {0:#,###} est premier", B);
                }

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
            
            Console.ReadKey();


        }
        class calcul
        {
            public static bool nombrepremier(double _Nbutilisateur)

            {
                double reste;
                int Diviseur = 2;
                bool Premier = true;
                double Limite = Math.Sqrt(_Nbutilisateur);

                do
                {
                    reste = _Nbutilisateur % Diviseur;
                    if (reste == 0)
                    {
                        Premier = false;
                        break;
                    }
                    Diviseur++;
                } while (Diviseur <= Limite);

                return Premier;
            }
        }
    }
}

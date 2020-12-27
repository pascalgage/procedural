using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEU3
{
    class Program
    {
        static void Main(string[] args)
        {
            string redo;
            string Utilisateur;

            int TOTALJOUEUR = 0;
            int TOTALCOMPUTER = 0;
        do { 
            Console.WriteLine("Veuillez entrer votre nom :");
            Utilisateur = Console.ReadLine();

            do
            {
                Random nombre = new Random();
                int mystery = nombre.Next(0, 3);

                int nbrJ;
                Console.WriteLine("Veuillez entrer un chiffre entre 0 et 2:");
                nbrJ = int.Parse(Console.ReadLine());


                if (nbrJ == mystery)
                {
                    Console.WriteLine("PERSONNE NE MARQUE !");

                }
                //JOUEUR GAGNE QUAND :

                if (nbrJ > mystery && nbrJ - mystery == 2)
                {

                    TOTALJOUEUR++;
                    Console.WriteLine(Utilisateur + " marque 1 point");


                }
                if (nbrJ < mystery && mystery - nbrJ == 1)
                {
                    TOTALJOUEUR++;
                    Console.WriteLine(Utilisateur + " marque 1 point");
                }

                // COMPUTER GAGNE QUAND :
                if (mystery > nbrJ && mystery - nbrJ == 2)
                {

                    TOTALCOMPUTER++;
                    Console.WriteLine("COMPUTER marque 1 point");
                }
                if (mystery < nbrJ && nbrJ - mystery == 1)
                {
                    TOTALCOMPUTER++;
                    Console.WriteLine("COMPUTER marque 1 point");
                }

                //FIN DU JEU QUAND ARRIVE à 10 points
                if (TOTALJOUEUR >= 10)
                {
                    Console.WriteLine(Utilisateur + " a GAGNé !!!");
                    break;
                }
                if (TOTALCOMPUTER >= 10)
                {
                    Console.WriteLine("COMPUTER a gagné, allez courage!  " + Utilisateur);
                    break;
                }

                //FIN DE PARTIE à l'initiative du JOUEUR

                if (nbrJ < 0) { Console.WriteLine("BAD COMMAND:GAME OVER!"); break; }
                if (nbrJ > 2) { Console.WriteLine("BAD COMMAND:GAME OVER!"); break; }

                Console.WriteLine("SCORE JOUEUR: " + TOTALJOUEUR + " " + "SCORE COMPUTER: " + TOTALCOMPUTER + "");

            } while (TOTALJOUEUR <= 10 && TOTALCOMPUTER <= 10);

                Console.WriteLine("Une autre partie ? O/N  " + Utilisateur);
                redo = Console.ReadLine().ToUpper();

                if (redo != "O") { Console.WriteLine("Bye Bye"); }

        }while(redo=="O");

            Console.ReadKey();
        }
    }
}

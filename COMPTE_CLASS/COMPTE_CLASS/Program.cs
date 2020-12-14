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
            //Outils de transfert (une variable)...
            double _montant = 0;
            

            //Création des objets Compte bancaire.....
            Compte unCompte;
            unCompte = new Compte("12345",3800,"Gage Pascal",-200);

            Compte deuxCompte;
            deuxCompte = new Compte("54721", 1200, "Benitez Charles", -700);

            //OPERATION DE TRANSFERT....

            //Console.WriteLine("Combien voulez-vous transférer ?");
            //_montant = double.Parse(Console.ReadLine());


            //unCompte.Debiter(_montant);
            //deuxCompte.Crediter(_montant);

            unCompte.Transferer(2500, deuxCompte);
            unCompte.Comparer(unCompte, deuxCompte);

            
           
            

            Console.WriteLine(unCompte.Infocompte());
            Console.WriteLine(deuxCompte.Infocompte());

            Console.ReadKey();
        }
    }
}

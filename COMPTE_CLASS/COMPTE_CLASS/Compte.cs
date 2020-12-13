using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPTE_CLASS
{
    public class Compte
    {

        //attributs....
        private int numeroCompte;
        private double soldeCompte;
        private string nomTitulaire;
        private int decouvert;
        
        //propriétés....
        public int UNnumeroCompte { get => numeroCompte; }
        public double UNsoldeCompte { get => soldeCompte; set => soldeCompte=value; }
        public string UNnomTitulaire { get => nomTitulaire; }
        public int UNdecouvert { get => decouvert; }

        //constructeur....
        public Compte(int UNnumeroCompte, double UNsoldeCompte, string UNnomTitulaire, int UNdecouvert)
        {
            numeroCompte = UNnumeroCompte;
            soldeCompte = UNsoldeCompte;
            nomTitulaire = UNnomTitulaire;
            decouvert = UNdecouvert;
        }
        
        //méthodes....
        public void Crediter(double _montant)
        {
            soldeCompte = soldeCompte + _montant;
            
        }

        public void Debiter(double _montant)
        {
            soldeCompte = soldeCompte - _montant;
            if (soldeCompte<decouvert) {Console.WriteLine("Pas autorisé"); } else { Console.WriteLine("OK"); }
        }

        public void Transferer(double _montant,int UNnumeroCompte)
        {
            Console.WriteLine("Quel compte à créditer ?");
            UNnumeroCompte = int.Parse(Console.ReadLine());

            

        }
        public void Comparer()
        {

        }


        public string Infocompte()
        {
            return "N°:"+numeroCompte + " "+"Solde:" + soldeCompte + " "+"Nom:" + nomTitulaire + " " + decouvert+" euros";
        }


    }
}

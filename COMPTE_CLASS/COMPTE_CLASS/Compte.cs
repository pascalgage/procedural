using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPTE_CLASS
{
    public class Compte
    {
        private int numeroCompte;
        private int soldeCompte;
        private string nomTitulaire;
        private int decouvert;

        public Compte(int UNnumeroCompte, int UNsoldeCompte, string UNnomTitulaire, int UNdecouvert)
        {
            numeroCompte = UNnumeroCompte;
            soldeCompte = UNsoldeCompte;
            nomTitulaire = UNnomTitulaire;
            decouvert = UNdecouvert;
        }
        public void SetNum(int value)
        {
            numeroCompte = value;
        }

        public string Infocompte()
        {
            return "N°:"+numeroCompte + " "+"Solde:" + soldeCompte + " "+"Nom:" + nomTitulaire + " " + decouvert+" euros";
        }
    }
}

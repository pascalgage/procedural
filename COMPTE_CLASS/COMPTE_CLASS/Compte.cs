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
        private string numeroCompte;
        private double soldeCompte;
        private string nomTitulaire;
        private double decouvert;
        
        //propriétés....
        public string UNnumeroCompte { get => numeroCompte; }
        public double UNsoldeCompte { get => soldeCompte; set => soldeCompte=value; }
        public string UNnomTitulaire { get => nomTitulaire; }
        public double UNdecouvert { get => decouvert; }

        //constructeur....
        public Compte(string UNnumeroCompte, double UNsoldeCompte, string UNnomTitulaire, double UNdecouvert)
        {
            this.numeroCompte = UNnumeroCompte; 
            this.soldeCompte = UNsoldeCompte;
            this.nomTitulaire = UNnomTitulaire;
            this.decouvert = UNdecouvert;
        }
        
        //méthodes....
        public void Crediter(double _montant)
        {
            this.soldeCompte += _montant;
            
        }

        public bool Debiter(double _montant)
        {
       

            if (( this.soldeCompte-_montant) < decouvert)
            {
                return false;
            }
            else
            {
                this.soldeCompte -= _montant;
                return true;
            }
        }

        public void Transferer(double _montant,Compte _beneficiaire)
        {
          //  bool transfertPossible;

            if (_montant > 0)
            {
                if (this.Debiter(_montant) == true)
                {
                    _beneficiaire.Crediter(_montant);

                }

            }
            

        }
        public int Superieur(Compte _B)
        {
          return  this.soldeCompte.CompareTo(_B.soldeCompte);
        }
       

        

        //L'affichage des comptes.....
        public override string ToString()
        {
            return "compte N°:"+numeroCompte + " "+"Solde:" + soldeCompte + " "+"Nom:" + nomTitulaire + " " + decouvert+" euros";
        }


    }
}

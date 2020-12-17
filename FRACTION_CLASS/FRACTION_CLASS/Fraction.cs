using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRACTION_CLASS
{
    public class Fraction
    {
        //Attributs....
        private int numerateur;
        private int denominateur;

        //propriétés....
        public int UNnumerateur { get => numerateur; set => numerateur = value; }
        public int UNdenominateur { get=> denominateur; set=> denominateur =value; }
        
        //constructeur....
        public Fraction(int UNnumerateur, int UNdenominateur)
        {
            this.numerateur = UNnumerateur;
            this.denominateur = UNdenominateur;
            
        }
        //constructeur à vide....
        public Fraction()
        {
            this.numerateur = 0;
            this.denominateur = 0;

           
        }
        //méthodes....
        public int Infos()
        {
            int resultat;
            return resultat= numerateur/denominateur; 
        }
        public override string ToString()
        {
            return +numerateur+"/"+denominateur;
        }
        public void Oppose(int numerateur,int denominateur)
        {
            this.numerateur = -(numerateur);
        }
        public void Inverse(int numerateur, int denominateur)
        {
            this.numerateur = denominateur;
            this.denominateur = numerateur;
        }
        public bool Superieur( Fraction _F)
        {
            if ((this.numerateur/this.denominateur) > (_F.numerateur / _F.denominateur))
            {
                return false;
            }
            else
            {
                Console.WriteLine("est supérieur !!!");
                return true;
            }
        }




    }
}

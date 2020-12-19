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
            if ((this.numerateur/this.denominateur) < (_F.numerateur / _F.denominateur))
            {
                return false;
            }
            else
            {
                Console.WriteLine(this+ " est supérieur à "+_F);
                return true;
            }
        }
        public bool Egal(Fraction _F)
        {
            if ((this.numerateur / this.denominateur) == (_F.numerateur / _F.denominateur))
            {
                Console.WriteLine(this + " est égal à " + _F);
                return true;
            }
            else
            {
                return false;
            }

        }
        private int Reduire()
        {
            List<int> TAB = new List<int>();

            
            int numerateur=this.numerateur;
            int denominateur=this.denominateur;
            int D = 0;

            if (numerateur < 0) { numerateur=-numerateur; }
            if (denominateur < 0) {denominateur=-denominateur; }
            

            do
            {

                D++;

                if (numerateur % D == 0 && denominateur % D == 0)
                {
                    TAB.Add(D);
                }

            } while (D < numerateur && D < denominateur);

            return TAB.Last();
            

        }
        public void ToDisplay(Fraction _F)
        {
            
           Console.WriteLine(this.numerateur/ _F.Reduire()+"/"+this.denominateur/_F.Reduire());

        }
    }
}

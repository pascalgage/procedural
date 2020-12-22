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
        public int UNnumerateur
        {
            get { return numerateur; }

            set { numerateur = value; }
        }
        
        public int UNdenominateur
        {
            get { return denominateur; }

            set { denominateur = value; }
        }
        //constructeur....
        public Fraction(int UNnumerateur, int UNdenominateur)
        {
            this.numerateur = UNnumerateur;
            this.denominateur = UNdenominateur;
            
        }
        //Constructeur à vide...
        public Fraction()
        {
            this.numerateur = 0;
            this.denominateur = 1;
        }
        
        //méthodes....
        public double Infos(double N,double O)
        {
            double resultN;
            resultN= N / O;
            Console.WriteLine(Math.Round(resultN,2));
            return resultN;  
        }

        public override string ToString()
        {
            return +this.numerateur+"/"+this.denominateur;
        }

        public string Oppose()
        {
            string fractionOppose;
            fractionOppose=-(this.numerateur)+"/"+this.denominateur;
            Console.WriteLine(fractionOppose);
            return fractionOppose;
        }

        public void Inverse()
        {
            
           
        }

        public bool Superieur(Fraction _F)
        {
            if ((this.numerateur/this.denominateur) <= (_F.numerateur / _F.denominateur))
            {
                return false;
            }
            else
            {
                Console.WriteLine(this+ " est supérieur à "+_F);
                return true;
            }
        }

        public bool Inferieur(Fraction _F)
        {
            if ((this.numerateur / this.denominateur) >= (_F.numerateur / _F.denominateur))
            {
                return false;
            }
            else
            {
                Console.WriteLine(this + " est inférieur à " + _F);
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

        private int GetPgcd()
        {
            List<int> TAB = new List<int>();

            
            int numerateur=this.numerateur;
            int denominateur=this.denominateur;

            int D = 0;

            if (numerateur < 0) 
            { 
                numerateur = -numerateur;
            }

            if (denominateur < 0)
            { 
                denominateur = -denominateur;
            }

            if (numerateur < 0 && denominateur < 0)
            {
                numerateur = -(numerateur);
                denominateur = -(denominateur);
            }

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

        private void Reduire(Fraction _F)
        {
           
           Console.WriteLine(this.numerateur/ _F.GetPgcd()+"/"+this.denominateur/_F.GetPgcd());

        }

        public void Plus(Fraction _F)
        {
            int NUM;
            int DEN;

            NUM = (this.numerateur * _F.denominateur) + (_F.numerateur * this.denominateur);
            DEN = (this.denominateur * _F.denominateur);

            if (NUM == 0)
            {
                DEN = 0;
            }
            
            if (NUM < 0 && DEN < 0)
            {
                NUM = -(NUM);
                DEN = -(DEN);
            }

            Fraction G;
            G = new Fraction(NUM, DEN);

            G.Reduire(G);
            
            
        }

        public void Moins(Fraction _F)
        {
            int NUM;
            int DEN;

            NUM = (this.numerateur * _F.denominateur) - (_F.numerateur * this.denominateur);
            DEN = (this.denominateur * _F.denominateur);

            if (NUM == 0)
            {
                DEN = 0;
            }

            if (NUM < 0 && DEN < 0)
            {
                NUM = -(NUM);
                DEN = -(DEN);
            }

            Fraction H;
            H = new Fraction(NUM,DEN);

            H.Reduire(H);
        }

        public void Multiplie(Fraction _F)
        {
            int NUM;
            int DEN;

            NUM = (this.numerateur * _F.numerateur);
            DEN = (this.denominateur * _F.denominateur);

            if (NUM == 0)
            {
                DEN = 0;
            }

            if (NUM < 0 && DEN < 0)
            {
                NUM = -(NUM);
                DEN = -(DEN);
            }

            Fraction I;
            I = new Fraction(NUM, DEN);

            I.Reduire(I);
        }

        public void Divise(Fraction _F)
        {
            int NUM;
            int DEN;

            NUM = (this.numerateur * _F.denominateur);
            DEN = (this.denominateur * _F.numerateur);

            if (NUM==0)
            {
                DEN = 0;
            }

            if (NUM < 0 && DEN < 0)
            {
                NUM = -(NUM);
                DEN = -(DEN);
            }

            Fraction J;
            J = new Fraction(NUM, DEN);

            J.Reduire(J);
        }
        
    }
}

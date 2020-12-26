using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FRACTION_APP;
namespace FRACTION_CLASS
{
    public class Fraction
    {
        //Attributs....
        private int numerateur;
        private int denominateur;

        //propriétés....
        public int Numerateur
        {
            get { return numerateur; }

            set { numerateur = value; }
        }
        
        public int Denominateur
        {
            get { return denominateur; }

            set { denominateur = value; }
        }
        //constructeur....
        public Fraction(int _numerateur, int _denominateur)
        {
            try
            {
                this.numerateur = _numerateur;
                this.denominateur = _denominateur;

                double uneFraction = (double)this.numerateur / this.Denominateur;
            }
            catch(ArithmeticException e)
            {
                Console.WriteLine("Nous ne pouvons diviser par zéro" + e.Message);
            }
            catch(Exception er)
            {
                Console.WriteLine(er.Message);
            }
            
            
        }
        
        public Fraction(int _numerateur)
        {
            this.numerateur = _numerateur;
            this.denominateur = 1;
        }
        //Constructeur à vide

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
            resultN=(Math.Round(resultN,2));
            return resultN;  
        }

        public double InfoW(double N,double O)
        {
            double resultN;
            resultN= N / O;
            Console.WriteLine(Math.Round(resultN,2));
            return resultN;  
        }

        public override string ToString()
        {
            string chaineFraction = "";

            if (this.denominateur == 1)
            {
                chaineFraction += this.numerateur;
            }
            else
            {

             if (this.denominateur < 0)
                {
                    if (this.numerateur > 0)
                    {
                        chaineFraction += (-this.numerateur) + "/" + (-this.denominateur);
                    }
                    else
                    {
                        chaineFraction += (-this.numerateur) + "/" + (-this.denominateur);

                    }
                }
                else
                    {
                   chaineFraction += this.numerateur + "/" + this.denominateur;
                    }
            }
            
            return chaineFraction;
        }

        public string Oppose()
        {
            string fractionOppose;

            if(this.numerateur <0 && this.denominateur < 0)
            {
                fractionOppose = (this.numerateur) + "/" + -(this.denominateur);
            }
            else
            {
                fractionOppose = -(this.numerateur) + "/" + (this.denominateur);
            }
            if (this.numerateur >= 0 && this.denominateur > 0)
            {
                fractionOppose = (this.numerateur) + "/" + -(this.denominateur);
            }
            
            Console.WriteLine(fractionOppose);
            return fractionOppose;
        }

        public void Inverse()
        {
                int temp = this.numerateur;
                this.numerateur = this.denominateur;
                this.denominateur = temp;
        }

        public bool Superieur(Fraction _F)
        {
            double A= this.Infos(this.numerateur,this.denominateur);
            double B= _F.Infos(_F.numerateur,_F.denominateur);
            bool test;

            if ((A) <= (B))
            {
                test= false;
            }
            else
            {
                Console.WriteLine(this+ " est supérieur à "+_F);
                test= true;
            }
            return test;
        }

        public bool Inferieur(Fraction _F)
        {
            double A= this.Infos(this.numerateur,this.denominateur);
            double B= _F.Infos(_F.numerateur,_F.denominateur);
            bool test;

            if ((A) >= (B))
            {
                test= false;
            }
            else
            {
                Console.WriteLine(this + " est inférieur à " + _F);
                test= true;
            }
            return test;
        }

        public bool Egal(Fraction _F)
        {
            double A= this.Infos(this.numerateur,this.denominateur);
            double B= _F.Infos(_F.numerateur,_F.denominateur);
            bool test;

            if ((A) == (B))
            {
                Console.WriteLine(this + " est égal à " + _F);
                test= true;
            }
            else
            {
                test=false;
            }
            return test;
        }

        private int GetPgcd()
        {
         //Méthode "Last" recherche PGCD.
            List<int> TAB = new List<int>();

            
            int numerateur = this.numerateur;
            int denominateur = this.denominateur;

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

        private void Reduire()

        {
            if(this.denominateur / this.GetPgcd() == 1 || this.denominateur / this.GetPgcd() == -1 || this.numerateur==0)
            {
                Console.WriteLine(this.numerateur / this.GetPgcd());
            }
            else
            {
                if(this.denominateur / this.GetPgcd() < 0)
                {
                    if(this.numerateur / this.GetPgcd() > 0)
                    {
                        Console.WriteLine(-this.numerateur / this.GetPgcd() + "/" + -this.denominateur / this.GetPgcd());
                    }
                    else
                    {
                        Console.WriteLine(-this.numerateur / this.GetPgcd() + "/" + -this.denominateur / this.GetPgcd());
                    }
                }
                else
                {
                    Console.WriteLine(this.numerateur / this.GetPgcd() + "/" + this.denominateur / this.GetPgcd());
                }
            }
        }
        
        public Fraction Plus(Fraction _F)
        {
            int NUM;
            int DEN;

            NUM = (this.numerateur * _F.denominateur) + (_F.numerateur * this.denominateur);
            DEN = (this.denominateur * _F.denominateur);

            if (NUM < 0 && DEN < 0)
            {
                NUM = -(NUM);
                DEN = -(DEN);
            }

            Fraction G;
            G = new Fraction(NUM, DEN);

            G.Reduire();
            
            return G;
           
        }

        public Fraction Moins(Fraction _F)
        {
            int NUM;
            int DEN;

            NUM = (this.numerateur * _F.denominateur) - (_F.numerateur * this.denominateur);
            DEN = (this.denominateur * _F.denominateur);

            if (NUM < 0 && DEN < 0)
            {
                NUM = -(NUM);
                DEN = -(DEN);
            }

            Fraction H;
            H = new Fraction(NUM,DEN);

            H.Reduire();
            return H;
            
        }

        public Fraction Multiplie(Fraction _F)
        {
            int NUM;
            int DEN;

            NUM = (this.numerateur * _F.numerateur);
            DEN = (this.denominateur * _F.denominateur);

            if (NUM < 0 && DEN < 0)
            {
                NUM = -(NUM);
                DEN = -(DEN);
            }

            Fraction I;
            I = new Fraction(NUM, DEN);

            I.Reduire();
            return I;
            
        }

        public Fraction Divise(Fraction _F)
        {
            int NUM;
            int DEN;

            NUM = (this.numerateur * _F.denominateur);
            DEN = (this.denominateur * _F.numerateur);

            if (NUM < 0 && DEN < 0)
            {
                NUM = -(NUM);
                DEN = -(DEN);
            }

            Fraction J;
            J = new Fraction(NUM, DEN);

            J.Reduire();
            return J;
            
        }
        
    }
}

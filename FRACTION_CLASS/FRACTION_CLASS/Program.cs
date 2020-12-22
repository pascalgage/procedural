using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRACTION_CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int N;
            int D;

            int M;
            int E;
              
                Console.WriteLine("Entrez le numérateur de la fraction 1: " );
                N = int.Parse(Console.ReadLine());
                Console.WriteLine("Entrez le dénominateur de la fraction 1: " );
                D = int.Parse(Console.ReadLine());
                Console.WriteLine("Entrez le numérateur de la fraction 2: ");
                M = int.Parse(Console.ReadLine());
                Console.WriteLine("Entrez le dénominateur de la fraction 2: ");
                E = int.Parse(Console.ReadLine());

            Console.Clear();

            Fraction F1;
            F1 = new Fraction(N, D);
            Fraction F2;
            F2 = new Fraction(M, E);

            Console.WriteLine("L'addition de "+F1.ToString()+" et de "+F2.ToString()+" est  égale à: "); F1.Plus(F2);
            Console.WriteLine("La soustraction des deux fractions est égale à: "); F1.Moins(F2);
            Console.WriteLine("La multiplication des deux fractions est égale à: "); F1.Multiplie(F2);
            Console.WriteLine("La division des deux fractions est égale à: "); F1.Divise(F2);
            
            F1.Superieur(F2);
            F1.Inferieur(F2);
            F1.Egal(F2);

            Console.WriteLine("La fraction " + F1.ToString() + " est égale à:");
            F1.Infos(N,D);
            Console.WriteLine("La fraction " + F2.ToString() + " est égale à:");
            F2.Infos(M,E);
            Console.WriteLine("L'opposé de la fraction " + F1.ToString() + " est:");
            F1.Oppose();
            Console.WriteLine("L'opposé de la fraction " + F2.ToString() + " est:");
            F2.Oppose();

            


            Console.ReadLine();
        }
    }
}

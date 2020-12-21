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
            


            int N = 0;
            int D = 0;

            int M = 0;
            int E = 0;
            
               
                Console.WriteLine("Entrez le numérateur de la fraction 1 " );
                N = int.Parse(Console.ReadLine());
                Console.WriteLine("Entrez le dénominateur de la fraction 1 " );
                D = int.Parse(Console.ReadLine());
                Console.WriteLine("Entrez le numérateur de la fraction 2 ");
                M = int.Parse(Console.ReadLine());
                Console.WriteLine("Entrez le dénominateur de la fraction 2 ");
                E = int.Parse(Console.ReadLine());




            Fraction F1;
            F1 = new Fraction(N, D);
            Fraction F2;
            F2 = new Fraction(M, E);


            Console.WriteLine("L'addition de "+F1.ToString()+" et de "+F2.ToString()+" est  égale à: "); F1.Plus(F2);
            Console.WriteLine("La soustraction des deux fractions est égale à: "); F1.Moins(F2);
            Console.WriteLine("La multiplication des deux fractions est égale à: "); F1.Multiplie(F2);
            Console.WriteLine("La division des deux fractions est égale à: "); F1.Divise(F2);

            




            Console.ReadLine();
        }
    }
}

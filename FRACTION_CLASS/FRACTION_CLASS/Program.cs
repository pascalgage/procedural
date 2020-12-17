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
            Fraction F1;
            F1 = new Fraction(5, 2);

            Fraction F2;
            F2 = new Fraction(10, 7);

            Fraction F3;
            F3 = new Fraction(0, 1);

            
            

            F1.Superieur(F2);

            Console.WriteLine(F2.Infos());
            Console.WriteLine(F3.Infos());


            Console.WriteLine(F1);
            Console.WriteLine(F2);


            Console.ReadLine();
        }
    }
}

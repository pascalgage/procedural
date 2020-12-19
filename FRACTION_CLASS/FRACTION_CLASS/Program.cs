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
            F1 = new Fraction(12, 6);

            Fraction F2;
            F2 = new Fraction(44,12);

            Fraction F3;
            F3 = new Fraction(408, 72);

            F2.ToDisplay(F2);
            F3.ToDisplay(F3);
            F1.Plus(F2);
            
            Console.WriteLine(F2);
            Console.WriteLine(F2.Infos(44,12));

            Console.ReadLine();
        }
    }
}

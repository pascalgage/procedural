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
            F1 = new Fraction(63,98);

            Fraction F2;
            F2 = new Fraction(1, 14);

            Fraction F3;
            F3 = new Fraction(4, 7);


            F1.ToDisplay(F1);

            F2.Plus(F3);

            Console.ReadLine();
        }
    }
}

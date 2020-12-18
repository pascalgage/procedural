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
            F1 = new Fraction(120,-150);

            Fraction F2;
            F2 = new Fraction(25, 5);

            Fraction F3;
            F3 = new Fraction(0, 1);


            F1.ToDisplay(F1);

            
            

            Console.WriteLine(F1);
           


            Console.ReadLine();
        }
    }
}

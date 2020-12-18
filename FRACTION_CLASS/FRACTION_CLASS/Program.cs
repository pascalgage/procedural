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
<<<<<<< HEAD
            F1 = new Fraction(120,-150);

            Fraction F2;
            F2 = new Fraction(25, 5);
=======
            F1 = new Fraction(5, 2);

            Fraction F2;
            F2 = new Fraction(10, 7);
>>>>>>> e7e68b39d7e85ed3fecba387415032f397df99a9

            Fraction F3;
            F3 = new Fraction(0, 1);

<<<<<<< HEAD

            F1.ToDisplay(F1);

            
            

            Console.WriteLine(F1);
           
=======
            
            

            F1.Superieur(F2);

            Console.WriteLine(F2.Infos());
            Console.WriteLine(F3.Infos());


            Console.WriteLine(F1);
            Console.WriteLine(F2);
>>>>>>> e7e68b39d7e85ed3fecba387415032f397df99a9


            Console.ReadLine();
        }
    }
}

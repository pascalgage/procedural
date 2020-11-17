using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diviseur
{
    class Program
    {
        static void Main(string[] args)
        {
            string redo = "O";
            do
            {

                int A;
                Console.WriteLine("Entrez un nombre entier:");
                A = int.Parse(Console.ReadLine());
               
                int D = 2;
               
                
                    do
                    {
                        if (A % D == 0)
                        {
                            Console.WriteLine(D);
                        }
                        D++;


                    } while (D < A);
                
                Console.WriteLine("Souhaitez-vous effectuer un autre calcul ? O/N");
                redo = (Console.ReadLine()).ToUpper();
                if (redo != "O") { Console.WriteLine("Opération terminée !"); }
            } while (redo == "O");
            Console.ReadKey();
        }
    }
}

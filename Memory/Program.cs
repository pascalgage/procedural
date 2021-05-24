using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int nbr;
            double r=4;

            Console.WriteLine("Combien de mémoire voulez-vous ?");
            nbr = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nbr; i++)
            {
                
                r = (r*2);
                Console.WriteLine(r);

                
                
            }

            Console.ReadKey();
        }
    }
}

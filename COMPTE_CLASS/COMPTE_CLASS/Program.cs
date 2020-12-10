using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPTE_CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte unCompte;
            unCompte = new Compte(12345,3800,"gage",200);

            Console.WriteLine(unCompte.Infocompte());

            Console.ReadKey();
        }
    }
}

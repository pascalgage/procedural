using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POINT_CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pointA;
            pointA = new Point(0, 0);

            Point pointB;
            pointB = new Point(1, 1);

            pointA.Deplacer(3, 4);
            pointB.Deplacer(7, 4);

            

            Console.WriteLine(pointA.ToString());
            Console.WriteLine(pointB.ToString());


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POINT_CLASS
{
    public class Point
    {
        //attributs...
        private float axeAbscisseX;
        private float axeOrdonneeY;
        //propriétés...
        public float UNaxeAbscisseX { get => axeAbscisseX; set => axeAbscisseX = value; }
        public float UNaxeOrdonneeY { get => axeOrdonneeY; set => axeOrdonneeY = value; }
        //constructeur...
        public Point(float UNaxeAbscisseX,float UNaxeOrdonneeY)
        {
            this.axeAbscisseX = UNaxeAbscisseX;
            this.axeOrdonneeY = UNaxeOrdonneeY;
        }
        public Point()
        {
            this.axeAbscisseX = 0;
            this.axeOrdonneeY = 0;

        }
        //méthodes...
        public void Deplacer(float _X,float _Y)
        {
            this.axeAbscisseX = _X;
            this.axeOrdonneeY = _Y;
        }
        public override string ToString()
        {
            return "Abscisse est: " + axeAbscisseX + " Ordonnee est: " + axeOrdonneeY;
        }
        public void ConstruireSymOrd(float _X,float _Y)
        {
            this.axeAbscisseX =  (_X);
            this.axeOrdonneeY = -(_Y);
        }
        public void ConstruireSymAbs(float _X,float _Y)
        {
            this.axeAbscisseX = -(_X);
            this.axeOrdonneeY =  (_Y);
        }
        public void ConstruireSymOr(float _X,float _Y)
        {
            this.axeAbscisseX = -(_X);
            this.axeOrdonneeY = -(_Y);
        }

        
        

        
    }
}

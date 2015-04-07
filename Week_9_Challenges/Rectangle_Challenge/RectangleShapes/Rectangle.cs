using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangularShapes
{
    public class Rectangle
    {
        private int _sideA; //properties
        private int _sideB;
        public bool rectangle;
        public bool square;

        public Rectangle(int sideA, int sideB) //class constructor
        {
            _sideA = sideA; 
            _sideB = sideB;
        }

        public int Area()
        {

            int area = _sideA * _sideB;
            return area;
        }

        public int Perimeter()
        {

            int perimeter = 2 * (_sideA + _sideB);
            return perimeter;
        }

        public double Diagonal()
        {
            double a = Math.Pow(_sideA, 2);
            double b = Math.Pow(_sideB, 2);
            return Math.Round(Math.Sqrt(a + b), 2);
        }

        public bool IsSquare()
        {

            return _sideA == _sideB;
       
        }


    }
}
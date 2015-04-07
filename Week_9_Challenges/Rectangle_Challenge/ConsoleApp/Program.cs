using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RectangularShapes;

// add a using statement for the RectangleShapes namespace. ie "using RectangleShapes;"

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(90, 40);
            Console.WriteLine(rectangle.IsSquare());
            Console.WriteLine(rectangle.Perimeter());
            Console.WriteLine(rectangle.Diagonal());
            Console.WriteLine(rectangle.Area());

            Rectangle Square = new Rectangle(80,80);
            Console.WriteLine(Square.IsSquare());
            Console.WriteLine(Square.Perimeter());
            Console.WriteLine(Square.Diagonal());
            Console.WriteLine(Square.Area());
        }


           

           
            // Release 3 Only!!! Add driver test code that uses the Rectangle class you have created in the RectangleShapes namespace/project. See above to add a using
        }
    }

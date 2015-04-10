using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using ReverseWords;

// add a using statement for the ReverseWords namespace.

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Reverser ReverseIt = new Reverser();
            Console.WriteLine(ReverseIt.Reverse("would you like a warming cup of tea?"));
            Console.WriteLine(ReverseIt.Reverse("I'm running at them with an axe"));
            Console.WriteLine(ReverseIt.Reverse("ouch"));
            Console.WriteLine(ReverseIt.Reverse("cup of sugar"));
            
            // Release 3 Only!!! Add driver test code that uses the Reverser class you have created.
        }
    }
}
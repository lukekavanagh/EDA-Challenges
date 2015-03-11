// Pseudo-code
// create a method 'seperate comma', it has to take an integer as input
// it must return a comma seperated integer so something like 1,000,000
// define the integer to be converted to string
// consider using int.parse method? research this
// will definately have to use {0} formatting? so research this too
// Console.WriteLine Method to print result to console.



// Pseudo-Driver-Code
// Console.WriteLine(seperateComma)


// Initial solution
     public static String SeparateComma(int number)
        {
            int toBeConverted = 100000000;
            string a = toBeConverted.ToString();
            string formatted = String.Format("{0:#,###,###.##}", a);

            
        }


// Refactored solution

        public static String SeparateComma(int number)
        {
            string formatted =  String.Format("{0:n0}", number);
            return formatted;
            Console.WriteLine(formatted);
        }
      
        }
    }
        


/*******Look at Solution*******/
// Second Refactored solution

        public static String SeparateComma(int number)
        {
            string formatted =  String.Format("{0:n0}", number);
            return formatted;
        }
      
        }
    }
        
/*Code not used 
 int toBeConverted = 1000000000;
 string a = toBeConverted.ToString();
 char[] inputarray = a.ToCharArray();
Array.Reverse(inputarray);
string output = new string(inputarray);
string spattern = "^([0-9]+,)*[0-9]+$";
foreach (char s in output)
{
Console.WriteLine("{0 -14})", s);
}
if (System.Text.RegularExpressions.Regex.IsMatch(s, spattern))
{
Console.WriteLine("valid");
}
else 
{
Console.WriteLine("Invalid");
}
 */


// Reflection
// The learning from this challenge - if what you come up with at first seems logical, don't then go and ditch what
// is logical and work on something more complex! I actually had the whiff of the solution in this one, only to ditch the whiff,
// and begin work on an idea I had cribbed from a ruby solution to the idea. This idea was similar to solution #1, wherein you have to reverse a string. I spent ages
// on finding how to reverse a string as unlike ruby, there is not a string.reverse() method in C# to do it, and so I ended up passing the string to a char array so I could reverse it..
//Needless to say, to convert the Ruby Logic to C# became a convoluted idea, espescially considering the solution was so simple. 
//Upon looking upon the solution, it was frustrating to realise I had the answer to #solution2 and had begun working on something else.
// Sometimes it is best to go with your gut feeling. Hence why I have posted all my workings as a warning to other devs. If what you are working on is a simple challenge, and it seems convoluted THATS BECAUSE IT IS!!!
// That said though, I did learn about Regular expressions and how to use regex patterns as a string,
// and more about the idiosyncracies of the C# language as a whole. 
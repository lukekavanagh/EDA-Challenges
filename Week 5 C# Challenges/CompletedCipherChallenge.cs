using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CipherChallenge
{
    internal class Program
    {
        // The static void main is the starting point of any Console App. ie we have to have one.
        private static void Main(string[] args)
        {
            // Here an instance of the cipher class is created (right of the =) and assigned to a variable of the same type that is called cipher.
            var cipher = new CipherChallenge();

            Console.WriteLine(cipher.MartianCipher("ger^wsqifshc*nywx^kix^qi&10000*fekw@sj$gssp%vergl@hsvmxsw?"));
            Console.WriteLine("yes I can, but only for $12,000 NZ");

            Console.WriteLine("Click [Enter] to exit");

            Console.ReadLine();
        }
    }

    public class CipherChallenge
    {
        // RUN THE CODE BEFORE YOU MAKE ANY CHANGES.
        // What if the code doesn't even work? (It does, but you should still always run it before making changes)!
        // HINTS:
        //   If you do not understand what a line of code is doing. Go into the console and try to figure out how it works.
        //   Use Console.WriteLine statements to track what your program is doing at each step. See line 62 for an example.

        public String MartianCipher(String codedMessage)
        {
            // - Check out this method in the console to see how it works! Also refer to the documentation.
            var input = codedMessage.ToLower().ToCharArray(); // - LK setting a variable called input, which is taking the string
            // input of the martianCipher method, this string input being named codedMessage, it changes codedMessage to Lowercase, and sends the string to a character array.
            var decodedLetters = new List<Char>(); // LK - setting a variable decoded letters which is a new list of characters

            var cipher = new Dictionary<Char, Char>//  // LK -  The general pro of a normal dictionary collection is that it is fast look up,
                // LK - As Dictionaries use hashtables under the covers, they are unordered, and you cannot traverse a dictionary all that easily.
            // The dictionary takes a key/value pair of two Chars.
                
                // This is technically a shift of four letters...Can you think of a way to automate this? Is a Dictionary
                // the best data structure for this problem? What are the pros and cons of Dictionaries?
                {
                {'e', 'a'}, //LK - key, value /
                {'f', 'b'},
                {'g', 'c'},
                {'h', 'd'},
                {'i', 'e'},
                {'j', 'f'},
                {'k', 'g'},
                {'l', 'h'},
                {'m', 'i'},
                {'n', 'j'},
                {'o', 'k'},
                {'p', 'l'},
                {'q', 'm'},
                {'r', 'n'},
                {'s', 'o'},
                {'t', 'p'},
                {'u', 'q'},
                {'v', 'r'},
                {'w', 's'},
                {'x', 't'},
                {'y', 'u'},
                {'z', 'v'},
                {'a', 'w'},
                {'b', 'x'},
                {'c', 'y'},
                {'d', 'z'}
            };

            foreach (var x in input) // What is foreach doing here? //LK - foreach element named x in the coded message,
                // (which was convered to a Char Array) do the following....
                
            {
                var foundMatch = false; ; // for each var x in the foreach loop, variable foundmatch = false;
                // Why would this be assigned to false from the outset? What happens when it's true?
                //LK - it would be assigned to false upon start of the foreach loop because we haven't
                //found any matches yet.
                foreach (var pair in cipher) //LK for each var pair in the cipher instance;
                {
                    var y = pair.Key; //LK - var y = the key of the pair element
                    if (x == y)  // LK - it is comparing if the element x from the char array is equal to Y,
                        // Y being the key of the pair element in the Cipher instance.
                        // What is this comparing? Where is it getting x? Where is it getting y? What are those variables really?
                    {
                        Console.WriteLine("I am comparing x and y. X is " + x + " and Y is " + y + ".\n");
                        // print "I am comparing x and y. X is " + the x variable + "and Y is" + the Y variable
                        // and  full stop, then a line break
                        decodedLetters.Add(pair.Value); // How else could cipher[y] be expressed?
                        // / LK you could also express it as decodedLetters.Add(pair.Value)m as shown.....
                        // as pair.Key is var y, you could also use .Add(pair.Key)
                        // Though if you do, the code will pass but will scramble the decoded message.
                        foundMatch = true;
                        break; // LK - It is breaking to terminate the foreach loop that begins
                        // the process of printing out the cipher.
                    }
                    if (x == '@' || x == '#' || x == '$' || x == '%' || x == '^' || x == '&' || x == '*')
                        //What the heck is this doing? // LK - it's saying if x(x being the element in the char array), is equal to any of these
                        // characters above
                        // LK - Add an empty character, specifically a SPACE to the decoded letters char <list>, and the state of found match is then true,
                        // then break  the loop process again
                    {
                        decodedLetters.Add(' ');
                        foundMatch = true;
                        break;
                    }
                    if (Char.IsDigit(x)) // here we want to see if any part of the decoded letters char list (using var x) is a digit
                        
                      
                    {
                        decodedLetters.Add(x); //, if it is a digit, add x to the decoded letters char list,
                        foundMatch = true; // found match state then changes to true,
                        break;    // break to begin the loop process again.
                    }
                }
                if (!foundMatch) // What is this looking for? // LK If no match is found
                    decodedLetters.Add(x); //add x to decoded letters char list.
            }

            var decodedSentence = String.Concat(decodedLetters); // What does the .Concat() method do?
            //concat methods concatenates (adds) two strings together. 

            var regex = new Regex(@"\d+"); //What is this matching? Look at the regex documentation for help.
            // LK - The regex is setting up a variable to look for particular verbatim patterns (@) that match english digits (\d)
            // that also match the previous element one or more times(+)


            if (regex.IsMatch(decodedSentence)) // if this pattern @"\d+") is found in the decoded sentence
            {
                var match = regex.Match(decodedSentence); // create var match which stores the regex match in decoded sentence
                var number = Convert.ToInt32(match.Value);
                Console.WriteLine(number);// create a variable number which converts the digit match to Int32 and assigns this
                // to match's.value. I found out by doing a console.writeline that match's value is 10000 as shown in the encoded message at the top
                var newNumber = number/100; // create a variable newNumber that divides number by 100
                decodedSentence = regex.Replace(decodedSentence, newNumber.ToString()); // replace what was found in regex
                // with the decoded sentence and the result of new number converted to a string

            }
            return decodedSentence; // What is this returning? 
            // This returns the results of the regex pattern search, providing a decoded sentence which has gone through the control flow
            // of the program it specifically returns can somebody get me 100 bags of cool ranch doritos?

            
        }
    }
}

// Reflections
// This challenge was a nice change, and it was cool to be able to "tamper" with the code
// to see what the outcome would be. I realised I had learnt a fair bit about Regex expressions additionally,
// and it was good to see how they can be used in a different sort of program to the ones listed on the MSDN pages.
// Some of the methods we had learnt previously had also sunk in, and this challenge definately made me feel 
// code literate.

// The Cipher is structured initally around the key/value pairings, e.g.... g stands for the c of 'can'.
// 1.first the coded message was changed to a char array...
// 2. then a char list was created called coded letters, to store coded letters
// 3. A foreach loop was used to traverse through the encoded message(input)
//4. Within that foreach another foreach loop which iterated through an instance of the cipherchallenge using a var pair.
// 5. Within this foreach, a var y was set, which was assigned to the key of the var pair.
// 6. Then an if statement assessed if element x from the char array was equal to the y element iterating through the class instance.
// 7. Then on the basis of this, corresponding letters began to get added to the encoded letters char list, with allowances for spaces between the words.
// 8. An if statement also checked if the char was a digit, if it was, add it to the decoded letters char list.
//9. a new var decoded sentence was created and concatenated with decoded letters.
// 10. A regular expression was then setup and used on decoded sentence to check for digits
// 11. Once digits were found, a variable was created to store the result of the regex search, and this value was convert to Int32 and stored as var number
// 12. Var number was then divided by 100.
// 13. Decoded sentence was then assigned to a regex replace method and decoded sentence and number were converted to a string.
// 14. The full decoded sentence was then returned.

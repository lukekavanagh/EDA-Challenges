using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords
{
    public class Reverser
    {
        public string Reverse(string words) // create a method reverse which takes an put of a string words and returns a string value. A list to hold the reversed words
        {
            List<string> reversedWords = new List<string>(); //create a list that be used to store reversed words
            string[] splitWords = words.Split(' '); //create string array splitwords in which the words input is split using the split method to split the words into spaces via a character delimiter(boundary denoting a space)

            foreach (var word in splitWords) //foreach goes through the splitwords array and at each word
            {
               //add a new string to the reversed words list that reverses each element and returns the result to array
                reversedWords.Add(new string(word.Reverse().ToArray()));
            }
            return String.Join(" ", reversedWords); //return reversed words with the string joined back together as an element in the array
        }
    }// 1. Split the words 2. Add the reversed words to a character array 3. Return the joined reversed words 
}
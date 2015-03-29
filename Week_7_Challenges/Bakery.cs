/******************** Summary *************************
Exercise: Bakery Refactor

Extend the test suit as directed in the test file ("ctrl + ," will bring up a quick file change menu - otherwise navigate to it via the solution explorer).

Having a set of tests passing allows for a developer to refactor/change the existing code base and know the code still functions as before/expected.

Refactor the class below while maintaining all tests passing
*******************************************************/

using System;
using System.Collections.Generic;

namespace EdaBakery
{
    public class Bakery //creation of public class bakery
    {   // creation of public method Calculate quantities which takes an integer num ofpeople and string favorite food as input
        public string CalculateQuantities(int numOfPeople, String favoriteFood)
        { //create Dictionary List with key value pair of a string and an integer called list
            Dictionary<string,int> list = new Dictionary<string, int>();
            list.Add("pie", 8); // add key pie and integer 
            list.Add("cake", 6); // add cake and integer
            list.Add("cookie", 1); // add cookie and integer
            //these are the wrong way around in respect to the inputs of the method

            bool hasFave = false; // boolean value is hasfave equals false
            int faveFoodQuantity = 0; // integer faveFoodQuantity set to false
            foreach (KeyValuePair<string,int> entry in list) 
             //foreach loop states for each Keyvalue pair, assign a value entry to it in list and..
            {   //if the string favorite food equals the key of the key value pair,
                if (favoriteFood.Equals(entry.Key))
                {
                    faveFoodQuantity = (int) entry.Value; //set favefood quantity to the key's value (casted to an integer)
                    hasFave = true; //then hasfave boolean value is set to true
                }
            }

            if (!hasFave) throw new Exception("You can't make that food");
            // if hasfave is false throw new exception with message
            if (numOfPeople%faveFoodQuantity == 0) // using modulo if the number of people and the fave food quanity are equal to zero
            {
                int x = numOfPeople/faveFoodQuantity; //set integer x to the number of people divided by the fave good quantity
                return "You need to make " + x + " " + favoriteFood + "(s)."; //and return message comprised of "you need to make" + the value of x + the favorite food string + (s)"
            }
            else if (numOfPeople%faveFoodQuantity != 0) // else if using modulo the numofpeople and fave food quanity is not equal to zero
            {
                int numPies = 0; //create new integers set to zero.
                int numCakes = 0;
                int numCookies = 0;
                while (numOfPeople > 0) //while num of people is greater than zero
                {
                    if (numOfPeople/(int) (list["pie"]) > 0) //if number of people (casted to integer) divided by the value of key pie in the list is greater than zero
                    {
                        numPies = numOfPeople/(int) (list["pie"]); //num pies = num of people divided by value of pie
                        numOfPeople = numOfPeople%(int) (list["pie"]); // num of people modulo'd by the value of pie
                    }
                    else if (numOfPeople/(int) (list["cake"]) > 0) //else if the number of people divded by the value of cake is the list is greater than zero
                    {
                        numCakes = numOfPeople/(int) (list["cake"]); // num of cakes = the number of people divided by the value of cake in the list
                        numOfPeople = numOfPeople%(int) (list["cake"]); // num of people modulo'd by the value of cake in the Dictionary list
                    }
                    else
                    {
                        numCookies = numOfPeople; //num of Cookies = num of people
                        numOfPeople = 0; // number of people = 0;
                    }
                }
                return "You need to make " + numPies + " pie(s), " + numCakes + " cake(s), and " + numCookies +
                       " cookie(s).";//return message using strings and integers which hold the result of each variable..
            }
            return "No-op"; //return no -op
        }
    }
}

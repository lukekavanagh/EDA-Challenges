/******************** Summary *************************
Exercise: Validating a Credit Card

Write methods that use the Luhn Algorithm to validate whether a credit card has a valid credit card number.

Start by running the tests. There are some build errors where the tests are expecting there to be code that doesn't yet exist.
Stub the constructor and CheckCard method out so the test suit may compile and run.

You should also check the length of the parameter of the of the constructor.

Remember constructors are methods with no return (not even void) and have the same name as the class
*******************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateCreditCard
{
    public class CreditCard //create public class called creditcard, which is initialised with a long varialble named card, signifying the creditcard
    {
        long card;


        public CreditCard(long CardNumber) // create class constructor which takens one long variable cardNumber as an input
        {
            //CardNumber = 4563952022212888;

            if (CardNumber.ToString().Length == 16) // as we are unable to test long length, we've got to convert the long cardnumber to a string, and then assess it's length.
            {                                       //if length of cardnumber once converted to string = 16;
                card = CardNumber; // assign the card variable to point at cardNumber
            }
            else //otherwise throw an exception which prints a string to the user please enter a 16 digit credit card number
            {
                throw new ArgumentException("Please enter a 16 digit credit card number");
            }

        }


        public bool CheckCard()
        {

            //long[] cardArray = new long[15];
            List<long> luhnList = new List<long>(); // create a new luhnList to enable us to perform Luhn's algorithm
            long total = 0; // create a variable for the total

            for (int i = 0; i < 16; i++) // if i is less than the 16 elements, keep incrementing
            {
                long digit = card; //assign a variable digit to card

                if (i % 2 != 0) // creating a state within  the for loop - where if at any time i can't be divided by two...
                {
                    if (digit * 2 < 9) // if digit multiplied by 2 is less in value than 9
                    {
                        luhnList.Add(digit * 2); // add the product of digit multiplied by two, to the to luhnlist list of longs
                    }
                    else
                    {
                        long sum = 0; // set long named sum to 0 for use later
                        long x = digit; // set a reference to digit with the value x (which also refers to card)

                        while (x != 0) // while x is not equal to zero remains true
                        {
                            sum += x % 10; // add x modulo 10 to sum, giving a sum a value
                            x /= 10; // and add the value of x divided by 10 after this.
                        }
                        luhnList.Add(sum); // add the value of sum to luhnList.
                    }
                }
                else //otherwise if x is equal to zero
                {
                    luhnList.Add(digit); // add digit to luhnlist
                }
                total += luhnList[i]; // add each stage of luhnlist to total
            }
            if (luhnList[15] % 2 == 0) // if the 15 elements in luhnlist can all be divided by 2
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}




                    









 
            


             
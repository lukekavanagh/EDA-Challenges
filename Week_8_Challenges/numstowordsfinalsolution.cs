/********************************* This File is not compiled or tested ********************************/
// Pseudo-code



// Initial solution
public class NumbersToWords
    {
        string[] upToTwenty = new string[] {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
         "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
        string[] tens = new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        string[] hundred = new string[] { "hundred" };

        public String ConvertNumberToWord(int num)
        {
            for (int i = 0; i < upToTwenty.Length; i++)
			{
			if (num >= 0 && num <= 19)
                return upToTwenty[num];
			}
            if (num < 100)
            {
                return tens[num / 10 - 2];
            }
            if (num < 1000)
            {
                return hundred[num / 1000];
            }
            return num.ToString();

        }
    }


// Refactored solution
namespace NumsToWords
{
    public class NumbersToWords
    {
        string[] upToNineteen = new string[] {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
         "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
        string[] tens = new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety", "One Hundred" };

        public String ConvertNumberToWord(int num)
        {
            if (num >= 0 && num <= 19)
            {
                return upToNineteen[num];
            }
            if (num > 19)
            {
                return tens[num / 10 - 2];
            }
            return num.ToString();

        }
    }
}



/*******Look at Solution*******/
// Second Refactored solution
namespace NumsToWords // this is the example solution
{
    public class NumbersToWords // creation of public class NumbersToWords
    {
        public String ConvertNumberToWord(int num) // creation of method which returns a string and accepts an integer as input; 
        {
            if (num > 19) // if number is greater than 19
            { // the ConvertToWords method is broken into two private methods, sort of helper methods?
                return BigNum(num) + LittleNum(num); // return the results of the bignum method and the results of the little num method
            }
            else
            {
                return LittleNum(num); //else return the results of the LittleNum method
            }
        }

        private string BigNum(int num) //creation of big num which returns a string and takes an integer as input
        {
            num = num / 10; // num is set to number divided by 10 so that num can relate to the relevant case in the switch statement
            switch (num) //creation of switch statement which takes num as input
            { //the cases denote the tens and the one hundred, with the default return is "number not in range"
                case 2:
                    return "Twenty";
                case 3:
                    return "Thirty";
                case 4:
                    return "Fourty";
                case 5:
                    return "Fifty";
                case 6:
                    return "Sixty";
                case 7:
                    return "Seventy";
                case 8:
                    return "Eighty";
                case 9:
                    return "Ninety";
                case 10:
                    return "One Hundred";
                default:
                    return "Number not in range";
            }
        }

        private string LittleNum(int num)
        {
            // This is a little narly but it gets rid of the second didget
            if (num > 19)
            {
                num = Convert.ToInt32(num.ToString().Remove(0, 1));
                // if num entered is greater than 19, num is converted to int32, then num is converted to string to remove the second digit?
            }

            switch (num) //creation of switch statement which takes num as input
            {//these are the single digits and from 10 to 19. Default returns an empty string.
                case 1:
                    return "One";
                case 2:
                    return "Two";
                case 3:
                    return "Three";
                case 4:
                    return "Four";
                case 5:
                    return "Five";
                case 6:
                    return "Six";
                case 7:
                    return "Seven";
                case 8:
                    return "Eight";
                case 9:
                    return "Nine";
                case 10:
                    return "Ten";
                case 11:
                    return "Eleven";
                case 12:
                    return "Twelve";
                case 13:
                    return "Thirteen";
                case 14:
                    return "Fourteen";
                case 15:
                    return "Fifteen";
                case 16:
                    return "Sixteen";
                case 17:
                    return "Seventeen";
                case 18:
                    return "Eighteen";
                case 19:
                    return "Nineteen";
                default:
                    return "";
            }
        }
    }
}




// Reflections
// I had a fun time on this challenge and it was good to reaquaint myself with C# after dabbling with javascrip this week
// I am still a little foggy around test code however - I will brush up on this
// My code passed, but i couldn't get the console to print 47.
/********************************* This File is not compiled or tested ********************************/
// Pseudo-code



// Initial solution
namespace Phase0_Exercise30_Simple_Guessing_Game
{
    public class GuessingGame
    {
        int answer; // the Guessing game class will initialise the class member when an instance of the class is created in static void main()

        public int Guess(int guess)
        {
            if (guess > answer)
                return "high";

            else if (guess == answer)
                return "correct";

            else if (guess < answer)
                return "low";
        }

        public bool IsSolved()
        {
            if (lastGuess && lastResult == "correct")
                return true;

            else
                return false;
        }



// Refactored solution
namespace GuessingGame
{
    public class GuessGame
    {

        public int answer;
        public int guess;


        public GuessGame(int answer)
        {
            answer = 0;
            guess = 0;
        }

        public int Guess(int guess)
        {
            if (guess > answer)
                Console.WriteLine("high");

            else if (guess == answer)
                Console.WriteLine("correct");

            else if (guess < answer)
                Console.WriteLine("low");

            return answer; // provides a return path if the code does not enter the if statement.

        }

        public bool IsSolved()
        {
            if (guess == answer)

                return true;

            else
                return false;
        }
    }
}


/*******Look at Solution*******/
// Second Refactored solution



// Reflections
//This challenge was an insightful challenge for me because it did taught me an important thing; there is a thin line
// between bloody minded perserverance and knowing when you are stuck and have to ask for help.  It turns out there
// was a small error with the tests, so additionally, sometimes it is better to go away, and 
// come back the next day, as you actually do get insights when your mind is fresh and not worn down. 
//
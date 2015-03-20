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
}}



// Second Refactored solution
namespace GuessingGame
{
    public class GuessGame
    {

        public int answer { get; set; }
        public bool Solved { get; set; }
        
       

        public GuessGame(int answer)
        {
            this.answer = answer;
            this.Solved = Solved;
            
            
           
        }
        public string Guess(int guess)
        {
            if (guess > answer)
            {
                Solved = false;
                return "high";
            }

            else if (guess == answer)
            {
                Solved = true;
                return "correct";
            }

            else if (guess < answer)
            {
                Solved = false;
                return "low";
            }
            else
            {
                return "Try again";
            } 
        }

        public bool IsSolved()
        {
         
            if (Solved == true)
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


// Reflections
//This challenge was an insightful challenge for me because it did taught me an important thing; there is a thin line
// between bloody minded perserverance and knowing when you are stuck and have to ask for help. I had
// been stuck on the IsSolved Method In the end, i liased with Tom
// on my cohort, and Rich, and Rich made a few suggestions as to adding a "solved" boolean property in my class constructor, so that I 
// could change the state of the game after each guess was made in my Guess method.
// I could then use the boolean property to control the state of the game in the IsSolved property
// I also learnt that to come back the next day, you actually do get insights when your mind is fresh and not worn down. 
//
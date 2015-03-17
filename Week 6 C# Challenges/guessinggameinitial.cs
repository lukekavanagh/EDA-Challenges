// Pseudo-code

// Initial solution
using System;

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


    }
    // your code here!
}

// Refactored solution
public class GuessingGame
  public class GuessingGame
  {
    public int answer;
    public int guess;
   
  
  public GuessingGame(int answer)
  {
    answer = 0;
    guess = 0;
  }
    
  public int Guess (int guess)
    
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
   

// Reflections
// This challenge was an insightful challenge for me because it did taught me an important thing; there is a thin line
// between bloody minded perserverance and knowing when you are stuck and have to ask for help. Additionally, sometimes it is better to go and away, and 
// come back the next day, as you actually do get insights when your mind is fresh and not worn down. I could get to the test suite stage,
// but my tests are not all passing. I have been in contact with Tom on the Kotare cohort, who has had a similar problem to me, and as
// the week progresses we are going to keep trying to solve this challenge, as there other challenges to do this week and its important
// to ration your time with respect to them. 
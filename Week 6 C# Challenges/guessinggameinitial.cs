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
  {
    public int answer = 0;
    public int guess = 0;
    
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

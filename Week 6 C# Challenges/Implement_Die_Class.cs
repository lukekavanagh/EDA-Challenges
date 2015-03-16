// Pseudo-code
// will need to create a public class Die
// will need to instantiate the public class, creating a new object
// will need to create a of method
// give an a die object some characteristics - such as sides,
// to return the number of sides of the dice
// the other method will be die roll to physically roll the die
// think about acting random random = new random to return a random number with a range
// when the die is rolled?
// if number thrown is less than one, throw new argument exception, perhaps 
// do a console.writeLine("you can't throw less than one, please throw again"

/*
// Initial solution
    
    public class Die
    {
    public int sides
        
    public Die ()
        {
        sides = 6;
        }
 
// method  to roll dice
    public int diceRoll (int throwDice)
    {
    Random Roll = new Random();
    int throwDice = Roll.Next(1, 7);
    }
 
//exception
 if (sides <= 0)

 throwNewException("number of sides must be greater than zero!")


//test die

public class testDie
 {
DieDie1 = new Die()
 * 
Console.WriteLine(Die.diceRoll())
*/

// Refactored solution
{
  public class Die //declare public class Die
  {
    int sides; // set integer value type for die sides

    public Die(int s) // set constructor which took one argument called s
    {
      if (s < 1) // if s < 1, throw a new Argument exception with a string message
          // number of sides must be greater than one. otherwise, sides remains pointing to s
        throw new ArgumentException("Number of sides must be greater than one", "sides");
      else
        sides = s;
    }

    public int Sides() // creation of sides field - Sides (caps) returns sides (lower)..the method Sides
        // returns the integer sides;
    {
      return sides;
    }

    public int Roll() // set up method for rolling die
    {
      var random = new Random(); // set a instance of the random class, to allow us to roll random values
      int roll = random.Next(0, sides); // create integer roll, which uses the random method passes 0 as a minium value and sides as a maximum value
      return roll+1; // return an increment of the roll value type + 1.

// Reflections
// Whilst I did not solve this solution, I found that the way I worked out how to do things was not incorrect.
// I went through what the solution asked me to do, and figured out how to implement a class
// by creation of a method (to roll the dice), and setting of the fields/characteristics of the die class
// It is frustrating to know what I want to do and have the logical side of things sussed out but fall down 
// on the code, but I am trying to pare back the amount of time I spend on challenges, purely because I think
// its pointless to spend hours "staying stuck"...much better to come to the realisation that you have
// taken things as far as you can and/or can come back to it.
// What I do try to do with every solution is comment through the code so that I usually have
// a general understanding of the logic of the solution and how it has been arrived at.

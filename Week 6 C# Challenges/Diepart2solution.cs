/********************************* This File is not compiled or tested ********************************/
// Pseudo-code
// use the first exercise as a base and amend the Die class so that it takes a list of strings as input
// give String list a name
// create a method which takes the a string list denoted the arbitary labels as an input
// use an if statement to declare if the total items in the string list are less than one
// "number of sides must be greater than one or suchlike"
// else, sides = labels;
// the sides method, should return the count of sides string list
// the roll method should be amended so that the maximum value it can return is sides.Count
// 


// Initial solution
public class Die //declare public class Die that takes a list of strings as input
{
    List<String> sides;

    public Die(List<string> labels) // create method which takes string list labels as input
    {
        if (labels.Count < 1)
            throw new ArgumentException("Number of sides must be greater than one", "sides");
        else
            sides = labels; //assign sides to labels
    }

    public int Sides() // creation of sides method - The method returns
    // the count of the sides list.
    {
        return sides.Count;
    }

    public int Roll() // set up method for rolling die
    {
        var random = new Random(); // set a instance of the random class, to allow us to roll random values
        int roll = random.Next(0, sides.Count); // create integer roll, which uses the random method passes 0 as a minium value and sides.count as a maximum value
        return roll + 1; // return an increment of the roll value type + 1.
    }
}


// Refactored solution



/*******Look at Solution*******/
// Second Refactored solution
namespace DiePartTwo
{
    public class Die
    {
        List<String> sides;

        public Die(List<String> listarray)
        {
            if (listarray.Count < 1)
                throw new ArgumentException("Number of sides must be greater than one", "sides");
            else
                sides = listarray;
        }

        public int Sides()
        {
            return sides.Count;
        }

        public String Roll()
        {
            var random = new Random();
            int roll = random.Next(0, sides.Count);
            return sides[roll];
        }
    }
}


// Reflections
//In this challenge I gained some insights into how integers and string collections(lists) can be used.
// I also learnt how the instance methods can interact with the inputs assigned to a class, and how these
// values can be used together irrespective of string or integer value.
// I also learnt the naming conventions are important. Sometimes I also faced feeling a bit lost.

/********************************* This File is not compiled or tested ********************************/
// Pseudo-code



// Initial solution
namespace FizzBuzz
{
    public class Program
    {

        public static object SuperFizzBuzz(object[] numbers)
        {
            foreach (object number in numbers)
            {
                int i = Convert.ToInt32(number);// set an integer to hold the value of converting the numbers array to a number
                if (i % 3 == 0)
                {
                    string fizz = i.ToString("Fizz");
                    Console.WriteLine(fizz);
                }
                else if (i % 5 == 0)
                {
                    string buzz = i.ToString("Buzz");
                    Console.WriteLine(buzz);
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    string fizzbuzz = i.ToString("FizzBuzz");
                    Console.WriteLine(fizzbuzz);
                }

                return number;


            }
        }

        static void Main(string[] args)
        {

        }
    }
}


// Refactored solution

public class Program
    {
         static void Main(string[] args)
         {
             Console.WriteLine(SuperFizzBuzz(new object[] { 3, 6, 9 }).SequenceEqual(new object[] { "Fizz", "Fizz", "Fizz" }));
             Console.WriteLine(SuperFizzBuzz(new object[] { 5, 10, 20 }).SequenceEqual(new object[] { "Buzz", "Buzz", "Buzz" }));
             Console.WriteLine(SuperFizzBuzz(new object[] { 15, 30, 45 }).SequenceEqual(new object[] { "FizzBuzz", "FizzBuzz", "FizzBuzz" }));
             Console.WriteLine(SuperFizzBuzz(new object [] {15, 1, 5, 3}).SequenceEqual(new object[]{ "FizzBuzz", 1, "Buzz", "Fizz"}));
         } // in this driver code I am testing the SuperFizzBuzz method by testing one objects sequence against another, the console gives me true each time as the sequences
           // compare the expected and actual results.

public class Program
    {
    public static object[] SuperFizzBuzz(object[] numbers)
    {
        object[] toBeReturned = new object[numbers.Length];
        //create new object with the value of the input arrays length
        for (int i = 0; i < numbers.Length; i++)
        {
            //if the object converted to an integer at position I in the loop can be divided by 3
            if (Convert.ToInt32(numbers[i]) % 3 == 0)
            {
                toBeReturned[i] = "fizz"; // position i in to be returned equals string "fizz"
            }

            else if (Convert.ToInt32(numbers[i]) % 5 == 0) // if object at position i converted to an integer at position i can be divided by 5
            {
                toBeReturned[i] = "buzz"; // position i in to be returned equals string "buzz"
            }
            else if (Convert.ToInt32(numbers[i]) % 3 == 0 && Convert.ToInt32(numbers[i]) % 5 == 0)
            { // if it can be divided by 3 and 5 return string fizzbuzz
                toBeReturned[i] = "fizzbuzz";
            }
            else
            {
                toBeReturned[i] = numbers[i];
            }
            return toBeReturned;
        }
    }


/*******Look at Solution*******/
// Second Refactored solution
              static void Main(string[] args)
         {
             Console.WriteLine(SuperFizzBuzz(new object[] { 3, 6, 9 }).SequenceEqual(new object[] { "Fizz", "Fizz", "Fizz" }));
             Console.WriteLine(SuperFizzBuzz(new object[] { 5, 10, 20 }).SequenceEqual(new object[] { "Buzz", "Buzz", "Buzz" }));
             Console.WriteLine(SuperFizzBuzz(new object[] { 15, 30, 45 }).SequenceEqual(new object[] { "FizzBuzz", "FizzBuzz", "FizzBuzz" }));
             Console.WriteLine(SuperFizzBuzz(new object [] {15, 1, 5, 3}).SequenceEqual(new object[]{ "FizzBuzz", 1, "Buzz", "Fizz"}));
         } // in this driver code I am testing the SuperFizzBuzz method by testing one objects sequence against another, the console gives me true each time as the sequences
           // compare the expected and actual results.


         public static object[] SuperFizzBuzz(object[] numbers)
              {//create new object with the value of the input arrays length
             object[] toBeReturned = new object[numbers.Length];
             for (int i = 0; i < numbers.Length; i++)
             { // if the object at position i in each iteration converted to an int 32 can be divided by three and 5
                 if (Convert.ToInt32(numbers[i]) % 3 == 0 && Convert.ToInt32(numbers[i]) % 5 == 0)
                 {
                     toBeReturned[i] = "FizzBuzz"; //to be returned at position i equals fizzbuzz
                 }
                 else if (Convert.ToInt32(numbers[i]) % 5 == 0) // if the object at position i in each iteration can be divided by 5
                 {
                     toBeReturned[i] = "Buzz"; // position i in to be returned equal string "buzz"
                 }
                 else if (Convert.ToInt32(numbers[i]) % 3 == 0)
                 {
                     toBeReturned[i] = "Fizz"; // position i in to be returned[i];
                 }
                 else
                 {
                     toBeReturned[i] = numbers[i]; //otherwise the position of to be returned at each iteration is equal to each iteration in the numbers array
                 }
             }
             return toBeReturned; //return to be returned array, also gives the code an exit path.
         }
    }
}



// Reflections
// I took a slightly different turn at the beginning, using a foreach loop instead of a for loop, which was just slightly down the wrong road. I kept getting the error "not all code paths return a value". So had to reassess.
// It was interesting to write driver code to make test two sequences belonging to two different objects. This aided my
// understanding as I was unable to run Tests in week 7 due to a problem with my Nunit framework
// Considering this is reputedly a interview question at some tech interviews this was great practice 
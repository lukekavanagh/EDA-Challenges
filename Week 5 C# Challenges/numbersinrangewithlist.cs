// Pseudo-code



// Initial solution
 public static int CountBetween(List<int> numbers, int lowerBound, int upperBound)
        {

            var numbersInRange = new List<int>();
            foreach (var number in numbers)
            {
                if (number >= lowerBound && number <= upperBound)
                {
                    numbers.Add(number);
                }
            }

                return numbersinrange;
            }
        }
    }



// Refactored solution
 public static int CountBetween(List<int> numbers, int lowerBound, int upperBound)
        {

            var numbersInRange = new List<int>(); //create new list variable called numbers in range
            foreach (var number in numbers) //iterate through the elements in the numbersusing an element (var) called number
            {
                if (number >= lowerBound && number <= upperBound) // if the var number is greater than or 
                //equal to lowerBound integer and the var number is less than or equal to the upperbound integer...
                {
                    numbersInRange.Add(number); // add the var number to the numbersInrange list.
                }
            }

                return numbersinrange.Count; //return a cached field of the numbers in range list.
            }
        }
    }



/*******Look at Solution*******/
// Second Refactored solution
 public static int CountBetween(List<int> numbers, int lowerBound, int upperBound)
        {

            var numbersInRange = new List<int>(); //create new list variable called numbers in range
            foreach (var number in numbers) //iterate through the elements in the numbersusing an element (var) called number
            {
                if (number >= lowerBound && number <= upperBound) // if the var number is greater than or 
                //equal to lowerBound integer and the var number is less than or equal to the upperbound integer...
                {
                    numbersInRange.Add(number); // add the var number to the numbersInrange list.
                }
            }

                return numbersinrange.Count; //return a cached field of the numbers in range list.
            }
        }
    }



// Reflections
//Whilst I had paired on this challenge in week 4, it was good to see how to solve the problem using lists instead of arraylists.
// I had initially tried to use a for loop to iterate through the index of numbers, but decided to try use a foreach loop as 
// to try use a query on the list elements instead of the list index. Whilsyt I got a little stuck on what variable to .Add numbers to,
// the general crux of the solution was the same. Whether it is forloop or foreach loop, they both are using an if statement
// to determine if a variable is between the bounds of the list, and then if if it is, add it to the list, and return a cached
// field (count) of the list.
// This challenge taught me that even if you may have solved the challenge previously, it is good to come back to the challenge as
// there are more than one way to skin a cat when it comes to coding, and it broadens you're understanding when you review code.

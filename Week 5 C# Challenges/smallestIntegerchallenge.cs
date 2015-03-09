/******************************************************
Exercise: Find the smallest integer in an array
Write a method SmallestInteger which takes as its input a List of integers and returns the smallest integer in the List.
integer in the list            
For example:
            
SmallestInteger for the List [-10, 0, 10] should return [-10]
SmallestInteger for the List [-10, -20, -30] should return [-30]
SmallestInteger for the List [] should return 0
*******************************************************/

// Pseudo-code
//create a method smallestinteger takes takes input of two integers and returns smallest
// add if statement to return nothing if list is empty
// use a for loop to iterate through the array
// index into thr array at position I and  add list.count method to get hold of what is in array
// then return smallest integer




// Initial solution

        public class Exercise25SmallestIntegerInList
        {
        public int SmallestInteger (List<int> numbers) 
        {
        if (numbers.Count == 0)
        {
        return 0;
        }
        for (int i=0; i<numbers.Count; i++)
        {
            numbers.Sort();
            numbers.Reverse();
        }

        return numbers[numbers.Count-1];

        }
        }
}


// Refactored solution
 public class Exercise25SmallestIntegerInList
        {
        public int SmallestInteger (List<int> numbers) 
        {
        if (numbers.Count == 0)
        {
        return 0;
        }
        for (int i=0; i<numbers.Count; i++)
        {
            numbers.Sort();
            numbers.Reverse();
        }

        return numbers[numbers.Count-1];

        }
        }
}


/*******Look at Solution*******/
// Second Refactored solution
 public int SmallestInteger (List<int> numbers)
{
    if (numbers.Count () ==0)
    {
        return 0;
    }
    for (int i=0; i<numbers.Count; i++)
    {
        numbers.Sort();
    }
    return numbers[0];
    }
}
// Reflections
// Whilst I passed the challenge, I fell into a trap of referring closely to the challenge
// wherein you had to return the LARGEST integer in an array, and basically I  got a bit
// creative and just used the sort and reverse method in my for loop to reverse the output, which returned the smallest integer.
// I learnt that the count method does not count the integers in the array per se, more returns 
// a cached field of integers, which can then be sorted and things can be done with them from there.
// I also learnt that again, sometimes It can be less code that does a better job and not necessarily
// to reach for a for loop when I want to "do something" with an array.
// Again I am getting better at finding methods that I can use creaively though.

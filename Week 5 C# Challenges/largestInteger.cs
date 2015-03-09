// Pseudo-code
//create a method largest integer
// ensure method takes a list of inputs
// enusre that if list is empty, return 0
// set local variable max value to the [0] element position in the list
// use for loop to cycle through list with .count and select position i in numbers list
// if the maxValue variable is greater than the
// position i in the numbers list, sort the list, and return the numbers list,
// with with the list being counted 
// 



// Initial solution
public int LargestInteger (List<int>numbers)
	{
	int maxValue = numbers[0];

	for (int i = 0; i < numbers.Count; i++)
		if (maxValue> numbers[i])
			maxValue = numbers[i];
			return maxValue;

		}


// Refactored solution
 public int LargestInteger(List<int> numbers)
    {
     if (numbers.Count == 0)
     {
       return 0;
     }

int maxValue = numbers[0];

	for (int i = 0; i<numbers.Count; i++)
    {
		if (maxValue>numbers[i])
        {
		numbers.Sort();
        }
	}
      return maxValue;
		}// your code here!
    }
}

/*******Look at Solution*******/
// Second Refactored solution
 public int LargestInteger(List<int> numbers)
    {
     if (numbers.Count == 0)
     {
       return 0;
     }

int maxValue = numbers[0];

	for (int i = 0; i<numbers.Count; i++)
    {
		if (maxValue>numbers[i])
        {
		numbers.Sort();
        }
	}
      return numbers[numbers.Count-1];
		}
    }
}
	


// Reflections
// I decided to do this challenge as a solo challenge. The annoying thing about this challenge was that 
// I almost had it, but kept failing 3 of the 8 tests because I couldn't figure out to 
// return numbers[numbers.Count-1]; So i learnt that the last element of an array is count-1.
// I learnt that you get list lengths by using .Count and not .Length.
// I also learnt that sometimes, the amount of code you write does not necessarily 
// equate to the best solution.
// I am getting better at deciding how to solve problems logically though //
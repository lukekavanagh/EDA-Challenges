// Pseudo-code (paired With Rich Churcher)
// Create Method CountBetween with an arraylist and two integers as arguments
// Need to include if statement to make arraylist return at start
// Use .Count property on ArrayList to check if empty
//      if so, return 0
// Set local count variable to 0
// Add for loop to iterate through ArrayList
//      If integer at position i is greater than or equal to lowerBound,
//          and less than or equal to upperBound,
//          increment count by one
// Return count


public int CountBetween (ArrayList numbers, int lowerBound, int upperBound)
{
	if (numbers.Count == 0)
	{
		return 0;
	}
	
	int count = 0;
	for (int i=0;i<numbers.Count;i++)
	{
	    if ((int)numbers[i] >= lowerBound && (int)numbers[i] <= upperBound)
	    {
	        count++;
	    }
	    
	}
	
	return count;
}
// Refactored solution


/*******Look at Solution*******/
// Second Refactored solution
public int CountBetween (ArrayList numbers, int lowerBound, int upperBound)
{
	if (numbers.Count == 0)
	{
		return 0;
	}
	
	int count = 0;
    foreach (int n in numbers)
    {
        if (n >= lowerBound && n <= upperBound)
        {
            count++;
        }
    }
}


// Reflections
//
// I had no idea ArrayList required a cast from Object to int!
// Searching for methods/tools can be avoided by stepping through the problem

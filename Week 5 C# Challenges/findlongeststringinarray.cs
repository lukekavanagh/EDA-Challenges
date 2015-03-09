/******************************************************
Write a method LongestString that takes as its input a List of Strings and returns the longest String in the List

Example:
LongestString for the List ["hello", "zzzzzzzzzz", "pizza"] should return "zzzzzzzzzz"            
For example:
LongestString for the List ["hello", "zzzzzzzzzz", "pizza"] should return "zzzzzzzzzz"
*/
// Pseudo-code
//create an array of strings
//add if statement to state if length is longest, return?
//need to sort the array by .length property
//need to return the longest string at end of program

// Initial solution
public string LongestString (string [] array)
{
	if (array.Count == 0)
		{
			return "";
		}
	foreach (string n in array)
			{
		orderby n.Length descending
			}
	return n;


// Refactored solution






/*******Look at Solution*******/
// Second Refactored solution

if (array.Count() == 0) {
	return null;
}

// Check if array only has one element, in which case just return that string
if (array.Count () == 1) {
	return array [0];
					}

			var lengths = from element in array
    		      			orderby element.Length descending
    		      			select element;
			return lengths.ToArray () [0];

		}


// Reflections
// With this challenge I went through alot of refactoring before settling on the code i wanted.
// When I unhid the solution, I was really suprised as I had parts of the solution figured out, but just
// in the wrong area of the program. I also had not considered to check if the array only had one element in it and return
// it at the position [0].
// I did consult google during this challege, but think I went down the wrong route slightly, as I had not stumbled across
// the from keyword before. 
// The key learnings from this one is to not stumble on blindly if completely stuck, and ask for help. And take your my time
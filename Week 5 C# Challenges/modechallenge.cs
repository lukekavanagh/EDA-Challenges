// Pseudo-code
// create a method that takes list of integers called Mode
// returns a mode value
// what is mode? the mode is the most frequent value in a set of numbers
// have to sort array numerically?
// use dictionary list.


// Pseudo-Driver-Code



// Initial solution
 public static List<int> Mode(List<int> array)
        {
            modeList = new List<int>();

            if (array != null && array.Count() > 0) // Test for a null reference or empty list //
            {
                var counts = new Dictionary<int, int>(); //store the number of occurences of a number in a new Dictionary //
             foreach (int element in array) // using foreach loop add one to the count for each occurence of an element
             {
                 if (counts.ContainsKey(element)) // when iterating through the dictionary called counts,
                                                    // if any element contains key
                     counts[element]++;      //add element to counts
                 else
                     counts.Add(element, 1);  // else add key value pair to counts
             }
             int max = 0; //create an integer to hold max
                           
             foreach (var count in counts)  //using a foreach loop, loop through the counts of each element and find the elements
                            //that occured most often
             {
                 if (count.Value <= max) continue; //you're looking in the 'counts' dictionary values with count and stating if the element count's values are less than or equal to max..
                 max = count.Value; // assign max to count value;
             }

             foreach (var count in counts)
             {
                 if (count.Value == max)
                     modeList.Add(count.Key); // add count's key to the modeList variable.
             }
            }
            return modeList;

             {


// Refactored solution



/*******Look at Solution*******/
// Second Refactored solution
public static List<int> Mode(List<int> array)
 public static List<int> Mode(List<int> array)
        {
            modeList = new List<int>();

            if (array != null && array.Count() > 0) //test for a null reference or empty list
            {
                var counts = new Dictionary<int, int>();
             foreach (int element in array)
             {
                 if (counts.ContainsKey(element))
                     counts[element]++;
                 else
                     counts.Add(element, 1);
             }
             int max = 0;
             foreach (var count in counts)
             {
                 if (count.Value <= max) continue;
                 max = count.Value;
             }
             var values = new List<int>(counts.Values); // added values variable which is a list of integers takes the variable for the count frequency's values as an input
             values.Sort();                             // sort the values numerically //
             var maxFrequency = values[values.Count - 1]; // created variable max frequency that establishes the last indexed element in the values list //

             foreach (var count in counts) 
             {
                 if (count.Value == maxFrequency) // if an element's value in the counts dictionary is equal to the max frequency
                     modeList.Add(count.Key); // add the count element's key to modelist.
             }
            }
            return modeList;
// Reflections
// To be honest with this challenge I cribbed heavily from the internet. Sometimes I still don't feel I am at a stage
// where I feel the code will flow from my fingertips
// I need to brush up on how lists and dictionarys are formed.
// It is also easy to forget naming conventions. The wrong name assigned to a key variable or list can really trip you up,
// and this is what happened in my challenge when I named the list wherein the frequency that the number appears as "counts".
//  Aside from that, what I did do was pretty close to the example solution, so that is one good thing. 
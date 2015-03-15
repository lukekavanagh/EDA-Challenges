// Pseudo-code
// Pseudo-code
//create two methods one called PadOriginal and PadNew // both methods are a lists 
// Pad Original method accepts three parameters...1. a list of objects called array, an "minimum size" value which takes non-negative integers, and an padding value declared as an object
// PadNew Method also accepts three parameters 1. A list of objects called array, an integer "minimum size" and object value set to null

// Pseudo-Driver-Code
// public List<object> PadOriginal(List<object> array, int minSize, Object padding = null)
//     
//            public int minSize = 0;
//            if (array.Length <= minSize)

 //           return List <int> = new List <int> PadValue(minSize);

// public List<object> PadNew(List<object> array, int minSize, Object value = null)
        // if minSize <= array.Length
        // return List <int> = new List <int> ();

// if (padding == null)
      //padding = 0; 




// Pseudo-Driver-Code



// Initial solution



// Refactored solution



/*******Look at Solution*******/
// Second Refactored solution
 
        public List<object> PadOriginal(List<object> array, int minSize, Object padding = null)
        {
            int spacesToAdd = minSize - array.Count; // set up an integer value type spacestoadd which is
            // the minimum size minus the cached field of the array - the size of the array(count).
            if (padding == null) // if the padding variable is equal to null
                padding = 0; // pad the list with zero

            for (int index = 0; index < spacesToAdd; index++) // if integer index is less than the spaces to add value type
                // increment through list and use the add method at each increment, passing in a reference to the padding
                //parameter, then return the array. 
            {
                array.Add(padding);
            }
            return array;
        }

        public List<object> PadNew(List<object> array, int minSize, Object padding = null)
        {
            int spacesToAdd = minSize - array.Count; // again sets a spacestoadd value type which is minsize - array.Count

            if (padding == null) // if statement to ensure if padding is null, set padding to zero
                padding = 0;

            List<object> newArray = (List<object>)array.Clone(); // here a new array has been set up in which the clone method is
            //used to create a shallow copy of the array - copies just the elements, and keeps the references to the objects
            // in the original array.
            for (int index = 0; index < spacesToAdd; index++) // for loop sets an integer index, where if index is less than the spaces to
             // add value type, then index increments through the newArray list, and adds padding to the newArray, before finally returning it.
            {
                newArray.Add(padding);
            }
            return newArray;


// Reflections
// I was very sick during this challenge and didn't follow the instructions to the challenge all that well as you can probably
// tell from my pseudocode. That said, I was on the right track with a couple of the concepts.
// It was good to see that arrays are fairly malleable if the size of them is not declared at the outset
// and if they are not made immutable by specifying an array size.
// and it was good to see the array.Clone method in action to make a shallow copy of the array, as I had not seen this done as of yet
// Again at the moment I feel my development is similar to a person who can read french but not speak it,
// I find I can read code and make sense of what Is occuring, but forming programs straight of the bat becomes a challenge.
// This of course, will come with practice.

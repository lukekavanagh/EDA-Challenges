// Pseudo-code
// create list called 'median' which takes as its input a list of numbers
// The median is caLculated by placing numbers in the order of their value, and then finding the middle number
// To this end, I would imagine a sorting method will have to be used on the list.
// Median is a form of average - the list will have to be divided by 2


// Initial solution
public static Median (list <int>)
{
    list.Sort();
    foreach (int value in list)
{
    list.Average();
}
    return median;




// Refactored solution

 public static int Median(List<int> list)
        {
    
        public static int Median(List<int> list)
        {
            list.Sort();//sort the list
            if (list.Count % 2 == 0)// the count method uses modulo to check if the field returned from the list can be divided by two...
            {
               
                int a = list[(list.Count / 2) - 1]; //if count is even, average the two elements, integer a and b
                int b = list[(list.Count / 2)];
                return (a + b) / 2;
            }
            else
            {
                
                return list.Count / 2; // if count is odd, return the middle element.
               
            }
          



        }
    }
}
/*******Look at Solution*******/
// Second Refactored solution



// Reflections
// To be honest, I had the idea of how to calculate the median and how to sort the list, but got bogged down when googling for help.
// I spent way too long on this challenge, in some ways, not giving up is one of my good traits but is also one of my bad ones,
// because I become a real beligerent sod. I think I will give this one another go later in the week as there is a problem with the example solution,
// I understood what I have to do to pass the tests and managed to pass a couple, but its a case of being able to express what I want to do which is holding me back at the minute.
// I am getting better at being able to think about lists/  arrays creatively though.

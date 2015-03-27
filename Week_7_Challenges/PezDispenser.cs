/*********************** This file is not compiled **************************/
//PsuedoCode
//What methods are needed? What will they do? What fields do you need to make it work?





//PezDispenser
    public class PezDispenser
    {
        public List <string>flavors = new List<string>(); //create new List called flavors that acts as a list to hold the pez's
    
        public string PezCount() //create pez count method
        {
          return flavors.Count.ToString(); //  return the count of the flavors list to string to show how many pez are there
        }

        public string SeeAllPez() // create SeeAllPez method
        {
           foreach (var flavor in flavors) //foreach loop goes through flavors list and for every element;
           {
               Console.WriteLine(flavors); //prints the flavors list to the console to the user can see what is in the list
           }
        return flavors.ToString(); // provide return path for method - list is returned to a string
        }

        public string AddPez() //create addPez method
        {
        for (int i = 0; i < flavors.Count; i++) //create for loop that iterates through flavors.Count
		{

            flavors.Add("Adding Pez To Dispenser"); //adds pez to dispenser
        }
        return flavors.ToString(); //provide return path to string
        }

        public string GetPez() //create getpez method
        {
            for (int i = 0; i < flavors.Count; i++) //create for loop that iterates through flavors list
            {
                flavors.Remove("Getting Pez");  //..remove pez so the user can eat it.
            }
        return flavors.ToString(); //once again return path provides what is in flavors.
        }   
        }

    }



//Reflections
// I actually had to do this as quick as I can as I can running out of time to complete the challenges for this week
// I have a build with the PezDispenser class, it is intensely simple, but I figure that is no bad thing built on the basis of adding and removing from a list.
//if anything this challenge has taught me I am getting better at knowing what tools I have in my "toolbox" such as for loops, foreach loops etc
// Again I have a problem with the Nunit framework which I have asked about but have yet to hear unfortunately (28/03/15) so am just going to keep cruising on through.. I will address this problem myself if I have time this weekend, but have to keep going.

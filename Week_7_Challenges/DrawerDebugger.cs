/********************************* This File is not compiled or tested ********************************/
//When your done copy paste Silverware, Drawer and Tests here
// Drawer
using System.Collections.Generic;

namespace DrawerDebugger
{
    public class Drawer // create public class drawer
    {
        // Are there any more methods needed in this class?************
        public List<Silverware> contents; // initialise public list called contents which references the silverware class as it's type

        private bool open; // set private boolean property open

        public Drawer() //creation of class Constructor which initialises two members
        {
            contents = new List<Silverware>();  //create and assign new List object called contents which references the silverware class
            open = true; //assign private boolean open to the state true.
        }

        public void OpenDrawer() //create method with empty constructor opens the drawer, which assigns the open property to a true state
        {
            open = true; //set boolean property open to true when this method is invoked
        }

        public void Close() //create method with empty constructor which closes the drawer
        {
            open = false; // set boolean property open to false when this method is invoked.
        }

        public List<Silverware> AddItem(Silverware item) //create method Add Item which takes a public list of type silverware class as a type
        {
            for (int i = 0; i < contents.Count; i++)
            {
                item = contents[i];

                if (item != null) break;
            }
            contents.Add(item);
            return contents;
            //return the contents list, with the addition of an item to this contents list.

        }

        public Silverware RemoveItem(Silverware item = null) //create Remove Item method, which references the silverware class, and sets a value called item to null as input
        {
            if (item == null) //if item == null
            {
                for (int i = 0; i < contents.Count; i++) //create for loop which returns a cached field of the contents.Count
                {
                    item = contents[i]; // what is this doing? // at each iteration, the value item  is assigned to the contents list at each iteration.
                    // i is position at each iteration within contents list.
                    if (item != null) break; //if item is not equal to null, break the for loop.
                }
            }

            contents.Remove(item); //and remove an item from the contents list
            return item; //return item, which is assigned to the contents list, so should return to the contents list?
        }


        public void Dump() // what should this method return? it's void it can't return anything? 
        {
            Console.WriteLine("Your drawer is now empty");//print message to the console
        }

        public void ViewContents() //create method ViewContents... 
        {
            Console.WriteLine("The drawer contains:"); //which prints this message to console
            foreach (Silverware silverware in contents) //creates foreach which uses a reference to the silverware class and goes through the contents list..
            {
                Console.WriteLine("- " + silverware.type); //for each silverware reference print message to console
            }                                              //and the silverware type, the reference to silverware is accessing the public property string called type in the silverware class
        }
    }
}

// Silverware

namespace DrawerDebugger
{
    public class Silverware //create public class Silverware
    {
        public String type; // set two properties, one a public string type denoting type of silverware
        public bool clean;  // set other property which is a public boolean to denote if the silverware is clean or not via true/false

        public Silverware(String silverware_type, bool is_clean = true)
        // create method silverware which takes a string silverware_type as input and a boolean which sets state to true, to denote that the silverware is clean
        {
            type = silverware_type; //assigns the type property to silverware_type so we can use it here and elsewhere
            clean = is_clean; // assigns the property clean to is_clean
        }

        public void Eat() //creation of a method which returns void called Eat
        {
            Console.WriteLine("eating with the " + type); //print "eating with the" + the type property to console
            clean = false; // clean is false when this method is called.
        }

        public void CleanSilverware()
        {
            Console.WriteLine("Cleaning SilverWare");
            clean = true;
        }


    }
}


// Tests
//Problem with Nunit - am speaking to Dan about it


// Reflections
// Enjoyed this challenge despite experiencing technical problems with the tests.
// I have been timeboxing my challenges to two hours so I don't spend more time than what  I need to
// ensuring I take what I can from the challenges and move on
// I seem to have got around my head around how classes, properties and methods interact between each other so that is good.
// Was a fun challenge to do and I enjoyed commenting on what each part of the code does, i tend to make this a habit in my challenges in phase zero
// which means the challenges can take a bit of time
// The Nunit framework  not working is disapointing, but I have to try to learn some more about the writing of tests.
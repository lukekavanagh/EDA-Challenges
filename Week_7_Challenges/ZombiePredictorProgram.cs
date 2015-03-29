using System;
using System.Collections;
using System.Collections.Generic;
using ZombiePredictor;

namespace ZombiePredictor
{
    public class Program
    {
        public static void Main()
        {
            State_Data Data = new State_Data();//creation of instance of state data class which creates the state data dictionary, which the Predictor instances then use to pull the data from the public dictionary key value pairs defined in state data.
            Predictor Alabama = new Predictor("Alabama", Data.Set["Alabama"][0], Data.Set["Alabama"][1], Data.Set["Alabama"][2], Data.Set["Alabama"][3]); 
            Alabama.VirusEffects();//above a new instance of the predictor class is being created and the we are "keying" into the public dictionary using the key name, which is a string
            // and specifiying the postion of the value in the list value of the public dictionary using the data.set which pulls the key, and the position from the data collection(the dictionary).
            //THEN the virus effects method is called on the predictor instance, which returns predicted deaths and speed of spread. This format stays the same for the 4 instances called
            Predictor Jersey = new Predictor("New Jersey", Data.Set["New Jersey"][0], Data.Set["New Jersey"][1], Data.Set["New Jersey"][2], Data.Set["New Jersey"][3]);
            Jersey.VirusEffects();
            Predictor California = new Predictor("California", Data.Set["California"][0], Data.Set["California"][1], Data.Set["California"][2], Data.Set["California"][3]);
            California.VirusEffects();
            Predictor Alaska = new Predictor("Alaska", Data.Set["Alaska"][0], Data.Set["Alaska"][1], Data.Set["Alaska"][2], Data.Set["Alaska"][3]);
            Alaska.VirusEffects();
            foreach (string state in Data.Set.Keys) //here a foreach loop is created which creates a string state in the instance of the state data class called data
                                                       // it then accesses the Dictionary Set as a property and then uses the Keys property to access the keys
            {   //then a new instance  of the Predictor class called FiddyStates is created which uses the string state as a variable to unlock the values and the index of the values is shown by [0], [1] etc
                Predictor FiddyStates = new Predictor(state, Data.Set[state][0], Data.Set[state][1], Data.Set[state][2], Data.Set[state][3]);
                FiddyStates.VirusEffects(); // The virus effects method is called on FiddyStates

            }
            
            Console.WriteLine("Hit [Enter] to end the program");// print "hit enter to end program to console"
            Console.ReadLine(); //display the line on screen
            
        
            
            

          
{
    // do something with entry.Value or entry.Key
}
            {
                
            }
        }
    }
}



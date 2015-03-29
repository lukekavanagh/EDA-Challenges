using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombiePredictor
{
    public class Predictor // creation of public class Predictor
    { // setting properties..all of these are private, which means they are unaccessible client side.
        private string _state; // private property string state
        private string _populationDensity; // private property string _populationDensity
        private string _population; // private property string _population
        private string _region; // private string _region
        private string _regionalSpread; // private property string _regionalSpread

        public Predictor(string state_of_origin, string population_density, string population, string region, string regional_spread)
        {//create public predictor method which takes a range of inputs, all private strings
            _state = state_of_origin; //set private property state to the state of origin input
            _populationDensity = population_density; //set the private property state to the population density input
            _population = population; //set the private property state to the population input
            _region = region; // set the region property state to the region input
            _regionalSpread = regional_spread; // set the regional spread private property to regional_spread input
        }

        public void VirusEffects()
        {//create Virus Effects method which consists of two methods, a method within a method as such.
            // 1. Predicted deaths which takes populationDensity, population, and _state properties as inputs and spits them back out when called
            // 2. Speed Of Spread which measures the speed of virus spread by taking population Density and State as inputs
            PreditcedDeaths(_populationDensity, _population, _state);
            SpeedOfSpread(_populationDensity, _state);
        }

        private void PreditcedDeaths(string popDens, string pop, string state)
        {//creation of method which doesn't return anythng. Takes three string inputs
            decimal _numberOfDeaths; //creation of decimal to measure number of deaths.
            string[] popDensWords = popDens.Split(' ');//creation of string array popdenswords to split the popdens input into spaces
            string[] popWords = popDens.Split(' '); //creation of string array popwords which also splits pop dens  input into spaces
            if (decimal.Parse(popDensWords[1]) >= 200)//if you can convert popdenwords into a decimal at position 2 of the array and this is greater than or equal to 200..
            { //then decimal numberOfDeaths = the multiplication of a decimal by the value you got by converting pop words into a decimal at positin 2 and casting a (decimal) of a double 0.4
                _numberOfDeaths = decimal.Multiply(decimal.Parse(popWords[1]), (decimal)0.4);
            }
            else if (decimal.Parse(popDensWords[1]) >= 150)
            {// else if the result of parsing popdenwords into a decimal at array position 1 is greater than or equal to 150 
                _numberOfDeaths = decimal.Multiply(decimal.Parse(popWords[1]), (decimal)0.3);
            }//then decimal numberOfDeaths = the result of multiplying  the value you got by converting pop words into a decimal at position 2 and casting a (decimal) of the value 0.3
            else if (decimal.Parse(popDensWords[1]) >= 100)
                // else if the value you get by parsing popdenwords array position into a decimal at position 2 is greater than or equal to 100..
            {
                _numberOfDeaths = decimal.Multiply(decimal.Parse(popWords[1]), (decimal)0.2);
            }//then decimal numberOfDeaths = the result of multiplying  the value you got by converting pop words into a decimal at position 2 and casting a (decimal) of the value 0.2
            else if (decimal.Parse(popDensWords[1]) >= 50)
                // else if the result of parsing popdenwords to a decimal at position 2 of the array is greater than or equal to 50...
            {
                _numberOfDeaths = decimal.Multiply(decimal.Parse(popWords[1]), (decimal)0.1);
            }//then decimal numberOfDeaths = the result of multiplying  the value you got by converting pop words into a decimal at position 2 and casting a (decimal) of the value 0.1
            else
            {// number of deaths is the result of multiplying the result of multiplying  the value you got by converting pop words into a decimal at position 2 and casting a (decimal) of the value 0.05
                _numberOfDeaths = decimal.Multiply(decimal.Parse(popWords[1]), (decimal)0.05);
            }
            Console.WriteLine("{0} will lose {1} people in this outbreak", state, _numberOfDeaths);
           
        }   //print the name of state..."will lose"....numberOfDeaths...people in this outbreak" using placeholder formatting replacement

        private void SpeedOfSpread(string popDens, string state)
        {//create SpeedOfSpread method which takes two string inputs.
            double speed = 0; //creation of double type speed is set to zero
            string[] popDensWords = popDens.Split(' '); // set an string array popDensWords which splits the array into spaces by ' '
            if (decimal.Parse(popDensWords[1]) >= 200)
            {// if the result of parsing popDenwords[1] is greater than or equal to >=200
                speed += 0.5; // add double 0.5 to speed. basically increase speed by this figure
            }
            else if (decimal.Parse(popDensWords[1]) >= 150)
            {//else if the result of parsing popDenwords[1] is greater than or equal to 150
                speed += 1; // add integer 1 to speed.
            }
            else if (decimal.Parse(popDensWords[1]) >= 100)
            {//else if the result of parsing popDenwords[1] is greater than or equal to 100
                speed += 1.5; //add 1.5 to speed
            }
            else if (decimal.Parse(popDensWords[1]) >= 50)
            {//if the result of parsing popDenwords[1] is greater than or equal to 50
                speed += 2; //add integer 2 to speed
            }
            else
            {//else just increase speed by a double - 2.5
                speed += 2.5;
            }
            Console.WriteLine(" and will spread across the state in {0} months.\n\n", speed);
        }// print second line to console. "and will spread across the state in (value of speed) months. then line break.
    }


    public class State_Data //creation of second public class to hold state data, which is 
        // which is a public dictionary, which has a key value pair where a string is the key, and a list is the value. it's name is set.
    {
        public Dictionary<string, List<string>> Set = new Dictionary<string, List<string>>
        { //so in the first line Alabama is the key, and the value is a list of strings, population density, population, region, and regional spread
            //naturally the list follows this format as it has been defined at the beginning.
            {"Alabama", new List<string>{"population_density: 94.65", "population: 4822023", "region: 5", "regional_spread: 3"}},
            {"Alaska", new List<string>{"population_density: 1.1111"," population: 731449", "region: 10", "regional_spread: 9"}},
            {"Arizona", new List<string>{"population_density: 57.05", "population: 6553255", "region: 8", "regional_spread: 8"}},
            {"Arkansas", new List<string>{"population_density: 56.43", "population: 2949131", "region: 7", "regional_spread: 5"}},
            {"California", new List<string>{"population_density: 244.2", "population: 38041430"," region: 9", "regional_spread: 8"}},
            {"Colorado", new List<string>{"population_density: 49.33", "population: 5187582", "region: 8", "regional_spread: 6"}},
            {"Connecticut", new List<string>{"population_density: 741.4", "population: 3590347", "region: 1", "regional_spread: 2"}},
            {"Delaware", new List<string>{"population_density: 470.7", "population: 917092,", "region: 3", "regional_spread: 2"}},
            {"Florida", new List<string>{"population_density: 360.2", "population: 19317568"," region: 3", "regional_spread: 5"}},
            {"Georgia", new List<string>{"population_density: 172.5", "population: 9919945", "region: 3", "regional_spread: 5"}},
            {"Hawaii", new List<string>{"population_density: 216.8", "population: 1392313", "region: 11", "regional_spread: 9"}},
            {"Idaho", new List<string>{"population_density: 19.15", "population: 1595728", "region: 8", "regional_spread: 9"}},
            {"Illinois", new List<string>{"population_density: 231.9", "population: 12875255", "region: 4", "regional_spread: 6"}},
            {"Indiana", new List<string>{"population_density: 182.5", "population: 6537334", "region: 4", "regional_spread: 5"}},
            {"Iowa", new List<string>{"population_density: 54.81", "population: 3074186", "region: 6", "regional_spread: 4"}},
            {"Kansas", new List<string>{"population_density: 35.09", "population: 2885905", "region: 6", "regional_spread: 7"}},
            {"Kentucky", new List<string>{"population_density: 110.0", "population: 4380415", "region: 5", "regional_spread: 4"}},
            {"Louisiana", new List<string>{"population_density: 105.0", "population: 4601893", "region: 7", "regional_spread: 5"}},
            {"Maine", new List<string>{"population_density: 43.04", "population: 1329192", "region: 1", "regional_spread: 2"}},
            {"Maryland", new List<string>{"population_density: 606.2", "population: 5884563", "region: 3", "regional_spread: 2"}},
            {"Massachusetts", new List<string>{"population_density: 852.1", "population: 6646144", "region: 1", "regional_spread: 2"}},
            {"Michigan", new List<string>{"population_density: 174.8", "population: 9883360", "region: 4", "regional_spread: 2"}},
            {"Minnesota", new List<string>{"population_density: 67.14", "population: 5379139", "region: 6", "regional_spread: 4"}},
            {"Mississippi", new List<string>{"population_density: 63.50", "population: 2984926", "region: 5", "regional_spread: 7"}},
            {"Missouri", new List<string>{"population_density: 87.26", "population: 6021988", "region: 6", "regional_spread: 4"}},
            {"Montana", new List<string>{"population_density: 6.86", "population: 1005141", "region: 8", "regional_spread: 9"}},
            {"Nebraska", new List<string>{"population_density: 23.97", "population: 1855525", "region: 6", "regional_spread: 8"}},
            {"Nevada", new List<string>{"population_density: 24.8", "population: 2758931", "region: 8", "regional_spread: 9"}},
            {"New Hampshire", new List<string>{"population_density: 147.0", "population: 1320718", "region: 1, region: 1", "regional_spread: 2"}},
            {"New Jersey", new List<string>{"population_density: 1205", "population: 8864590", "region: 2", "regional_spread: 3"}},
            {"New Mexico", new List<string>{"population_density: 17.16", "population: 2085538", "region: 8", "regional_spread: 7"}},
            {"New York", new List<string>{"population_density: 415.3", "population: 19570261","region: 2", "regional_spread: 1"}},
            {"North Carolina", new List<string>{"population_density: 200.6", "population: 9752073", "region: 3", "regional_spread: 5"}},
            {"North Dakota", new List<string>{"population_density: 9.92", "population: 699628", "region: 6", "regional_spread: 8"}},
            {"Ohio", new List<string>{"population_density: 282.5", "population: 11544225"," region: 4", "regional_spread: 2"}},
            {"Oklahoma", new List<string>{"population_density: 55.22", "population: 3814820", "region: 7", "regional_spread: 6"}},
            {"Oregon", new List<string>{"population_density: 40.33", "population: 3899353", "region: 9", "regional_spread: 8"}},
            {"Pennsylvania", new List<string>{"population_density: 285.3", "population: 12763536"," region: 2", "regional_spread: 3"}},
            {"Rhode Island", new List<string>{"population_density: 1016", "population: 1050292", "region: 1", "regional_spread: 2"}},
            {"South Carolina", new List<string>{"population_density: 157.1", "population: 4723723", "region: 3", "regional_spread: 5"}},
            {"South Dakota", new List<string>{"population_density: 10.86", "population: 833354", "region: 6", "regional_spread: 8"}},
            {"Tennessee", new List<string>{"population_density: 156.6", "population: 6456243", "region: 5", "regional_spread: 3"}},
            {"Texas", new List<string>{"population_density: 98.07", "population: 26059203"," region: 7", "regional_spread: 3"}},
            {"Utah", new List<string>{"population_density: 34.3", "population: 2855287", "region: 8", "regional_spread: 9"}},
            {"Vermont", new List<string>{"population_density: 67.73", "population: 626011", "region: 1", "regional_spread: 2"}},
            {"Virginia", new List<string>{"population_density: 207.3", "population: 8185867", "region: 3", "regional_spread: 2"}},
            {"Washington", new List<string>{"population_density: 102.6", "population: 6724540", "region: 9", "regional_spread: 8"}},
            {"Washington,D.C.", new List<string>{"population_density: 10357", "population: 632323", "region: 3", "regional_spread: 2"}},
            {"West Virginia", new List<string>{"population_density: 77.06", "population: 1855413", "region: 3", "regional_spread: 4"}},
            {"Wisconsin", new List<string>{"population_density: 105.2", "population: 5726398", "region: 4", "regional_spread: 6"}},
            {"Wyoming", new List<string>{"population_density: 5.851", "population: 576412", "region: 8", "regional_spread: 6"}}
          
        };

        
        
            }
        }

       
   

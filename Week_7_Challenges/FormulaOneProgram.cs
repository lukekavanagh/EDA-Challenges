using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormulaOneGame;

namespace CarConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Dodge = new Car();
            Dodge.Model = "Dodge"; // car model property is set to Dodge
            Dodge.Type = "Viper"; //Car type is set to viper
            Dodge.StartCar();// car is started Console.writeline ("car starts)
            Dodge.Accelerate(25); // now following the guide in the readme, the car accelerates to 25 m.p.h, console.writeline prints out message confirming this action
            Dodge.TimeTakenToDestination(0.25, 25); // the time taken to destination is returned - distance divided by speed
            Dodge.DeCelerate(25); // We declerated to stop and turn right
            Dodge.StopCar(); // car is stopped, console.writeLine "
            Dodge.TurnRight(); // The car now turns right, console writeline "Car turns right"
            Dodge.Accelerate(35); // Car accelerated to 35, console writeline prints "dec
            Dodge.DeCelerate(15); // Car decelerates to 15 as it enters school zone
            Dodge.StopCar(); // Car stops to turn left as instructed in the readme. "Car stops".
            Dodge.TurnLeft(); // Car Turns left
            Dodge.Accelerate(35); // Accelerate to 35 mph, console writeline message
            Dodge.CheckSpeed(); // check speed near the school
            Dodge.DeCelerate(35);// Decelerate
            Dodge.StopCar();// stop car
            Dodge.TotalDistanceTravelled(110, 0.31); // pass Total speed x Total time to method to get the distance
            Dodge.TimeTakenToDestination(3.4, 110); // pass Distance / Speed to get the total time taken.
            
        }
       

     
    }
}

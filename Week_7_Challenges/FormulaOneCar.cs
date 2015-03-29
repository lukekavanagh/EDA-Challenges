using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneGame
{
    public class Car
    {
        public string Model { get; set; }
        public string Type { get; set; }
        public int Speed { get; set; }
        public int MilesTravelled { get; set; }
        public int TimeTravelled { get; set; }

        public int CheckSpeed() // define method to help us check speed.
        {
          return Speed; //return the speed
        }

        public int Accelerate(int Speed) //create accelerate method takes speed as input
        {
            Speed += Speed; //increase speed by the input specified
            Console.WriteLine("Increasing Speed.....drive safely");
            MilesTravelled += Speed; //add Speed integer to miles travelled
            return Speed;
        }
        public int DeCelerate(int Speed)
        {
            Speed -= Speed; //Decrease Speed by the input specfied
            Console.WriteLine("Decreasing Speed....");
            MilesTravelled += Speed; //add Speed integer to miles travelled
            return Speed;
        }
        public int DriveLikeAManiac(int Speed)
        {
            Speed = Speed += 50;
            Console.WriteLine("Jesus man you almost hit an old lady");
            MilesTravelled += Speed; //add Speed integer to miles travelled
            return Speed;
        }
        public int DriveLikeANana(int Speed)
        {
            Speed = Speed -= 50;
            Console.WriteLine("braking...that's some safe driving");
            MilesTravelled += Speed; //add Speed integer to miles travelled
            return Speed;
        }
        public void TurnLeft() // turn left method
        {
            Console.WriteLine("Turning Left");
        }
        public void TurnRight() // turn right method
        {
            Console.WriteLine("Turning Right");
        }
        public void StartCar()
        {
            Console.WriteLine("Key's put in the ignition and started");
        }
        public void StopCar()
        {
            Console.WriteLine("Car stopped");
        }
        public int TimeTakenToDestination(double Distance, int TotalSpeed)
        {
            return (int)Distance / TotalSpeed;
        }
        public double TotalDistanceTravelled(int Speed, double Time)
        {
            return Speed / (int)Time;
        }
        MeatLoversPizza MeatLovers = new MeatLoversPizza();

        }
    }

    



			 
			

        //distance divded by speed = time

        
        

   

    


    

            
    


/******************** Summary *************************
Exercise: OO Basics

Get all the tests passing.
Then comment out the tests at the bottom of the StudentTest file.
Make those tests pass.
Extend the app by adding more tests and functionality.
*******************************************************/
using System;
using System.Collections.Generic;

namespace LoveOOForTheWin
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> Students = new List <Student>(); // The students list is a new list of type Student, type student being the Student class
            // Instantiate a list of Student
            
            // create a new student in the list using the .add method, which takes an string input for the name
            // and an array as the other input, as specified in the class constructor of Student.cs
            Students.Add(new Student("Alex", new[] { 100, 100, 100, 0, 100 }));
            Students.Add(new Student("Rod", new[] { 100, 100, 100, 0, 100 }));
            Students.Add(new Student("Jane", new[] { 100, 80, 70, 60, 50 }));
            Students.Add(new Student("Freddy", new[] { 100, 90, 80, 70, 60 }));
            Students.Add(new Student("Jamal", new[] { 90, 80, 60, 40, 90 }));
           
            // Driver Code ^^^
            // Instantiate and add 5 students to the list above using the .Add() method of the list class. (google: msdn list add).
            // This should look something like this: Though the arguments passed in are wrong ;).
            // StudentList.Add(new Student("Bret", "McKenzie", 45, "Funny Dude").


            // Write a foreach loop that loops over the StudentList and Console.WriteLines each of the Student Names.
            foreach (var student in Students) //for each element in students
            {
                Console.WriteLine(student.Name); //print out element (name property)
            }

            // Add a Console.ReadLine to pause the app.
            Console.ReadLine();

        }
    }
}

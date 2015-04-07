using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveOOForTheWin
{
    public class Student
    {
        public string Name { get; set; }
        public int [] Score { get; set; }


        public Student(string name, int [] score)
        {
            this.Name = name;
            this.Score = score;
         }

        public string LetterGrade()
        {
            int average = Average();

            if (average < 60)
            {
                return "F";
            }
            if (average < 70)
            {
                return "D";
            }
            if (average < 80)
            {
                return "C";
            }
            if (average < 90)
            {
                return "B";
            }
            return "A";
        }

        



        public int Average()
        {
            return (int)Math.Floor(Score.Average());
        }
        //returns the average of the Score  as a double...so it has to be casted to an integer.
        // Math.floor rounds down an to the lowest integer - 1.5 becomes 1.00
        public int MethodThatReturnsASix()
        {
            throw new NotImplementedException();
        } 
        }

        }

    
       
        // Add properties to make the tests pass. Once the you have all the tests passing. Uncomment the tests at the bottom of StudentTest.cs











    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;

namespace LoveOOForTheWin
{
    public  class searcher
    {
        public int LinearSearcher(List <Student> students, string name)
        {// create method which returns an integer and takes a List of type student and string name as inputs
            int search = 0; //set search counter as zero
            foreach (var student in students) // for each student in students
            {
                if (student.Name == name) // if student.Name property is equal to the inputs name property
                {
                    return search; //return the search integer.
                }
                search++; // and increment search by 1
            }
            return -1; //otherwise return the end of the array.
        }
               
            }


        }
    

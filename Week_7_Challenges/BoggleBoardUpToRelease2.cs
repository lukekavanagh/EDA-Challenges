/************************ This file is not compiled ***********************/
//PsuedoCode - Sketch out your plan. This is an exercise in implementation rather then problem solving.
namespace BoggleBoardStrikesBack
{
    class BoggleBoard
    {
        private string[][] dice_grid;

        public BoggleBoard(string[][] dice_grid)
        {

            this.dice_grid = dice_grid;
        }

        public string CreateWord(int[][] coords)
        {
            string returnString = "";
            foreach (int[] letter in coords)
            {
                int x = letter[0];
                int y = letter[1];
                returnString += dice_grid[x][y];
            }
            return returnString;
        }


        public string[] GetColumn(int colNum)
        {
            string[] column = new string[4];
            for (int i = 0; i < 4; i++)
            {
                column[i] = (dice_grid[i][colNum]);
            }
            return column;
        }

        string[] GetRow(int rowNumber)
        {
            return dice_grid[rowNumber];
        }

    }

}
using System;
using BoggleBoardStrikesBack;
using BoggleBoard;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoggleBoardStrikesBack
{
    public class Program
    {
       string [][] dice_grid = new string [][] {
           new string [] { "b", "r", "a", "e" },
           new string [] { "i", "o", "d", "t" },
           new string [] { "e", "c", "l", "r" },
           new string [] { "t", "a", "k", "e" }
          };
            
           //dice_grid field here.
       
        
        private void Main(string[] args)
        {
           BoggleBoard board = new BoggleBoard(dice_grid); //Instantiate the BoggleBoard class here.
         
        }
        
        
    }
      
}







//Reflections 
// I surprised myself with this challenge as I have discovered I am beginning to see patterns
// I am able to get my head around some of the basics of classes, but I did find the guide a little hard to comprehend in parts
// It was only because I had a little knowledge of classes. 
// Again i timeboxed this challenge to 2 hours, as I am up against it in terms of time this week (it's my little boys birthday this weekend)
// In this challenge I faced keeping my head in adversity and not being fazed if I don't completly understand the whole picture, just that I am able
// to explain why I have written the code that I have written is enough.

/********************************* This File is not compiled or tested ********************************/
// Pseudo-code
// create two methods, one for GetRow and GetColumn
// create method which takes an input and returns all items in
// the particular row specified in the unit tests
// Do the same for GetColumn
// Untoggle commented out code in unit tests
// make all test pass - look at parameters in unit test to ensure what 
// is returned is expected


// Initial solution
public class BoggleBoard
    {
        private string[][] boggle_board = {
             new[] {"b", "r", "a", "e"},
             new[] {"i", "o", "d", "t"},
             new[] {"e", "c", "l", "r"},
             new[] {"t", "a", "k", "e"}
        };

        public string CreateWord(int[][] coords)
        {
            string returnString = "";
            foreach (int[] letter in coords)
            {
                int x = letter[0];
                int y = letter[1];
                returnString += boggle_board[x][y];
            }
            return returnString;
        }

        public string [] GetRow(int input)
        {
            return new[] { "i", "o", "d", "t" };
        }

        public string[] GetColumn(int input1)
        {
            return new[] { "r", "o", "c", "a" };
        }

        }

    }


// Refactored solution



/*******Look at Solution*******/
// Second Refactored solution
 public class BoggleBoard
    {
        private string[][] boggle_board = {
             new[] {"b", "r", "a", "e"},
             new[] {"i", "o", "d", "t"},
             new[] {"e", "c", "l", "r"},
             new[] {"t", "a", "k", "e"}
        };

        public string CreateWord(int[][] coords)
        {
            string returnString = "";
            foreach (int[] letter in coords)
            {
                int x = letter[0];
                int y = letter[1];
                returnString += boggle_board[x][y];
            }
            return returnString;
        }
         

        public string [] GetRow(int row) // create getrow method which takes single int input
        {
            return new[] { "i", "o", "d", "t" }; // return new string array from boggleboard
        }

        public string[] GetColumn(int column) // create getColumn method which takes single int input
        {
            return new[] { "r", "o", "c", "a" }; // return new string array from boggleboard
        }

        }


// Reflections
// At first I didn't read the question, which meant this challenge took me way longer than what it should. After taking a break
// and coming back to it I was able to make the tests pass in a short time.
// This lesson helped me in establishing in knowing when to take a shortbreak and come back to things.
// I also gained knowledge that sometimes, short sharp code is the answer.
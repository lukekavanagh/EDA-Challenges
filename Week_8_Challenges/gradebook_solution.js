/*
Gradebook from Names and Scores

You will work with the following two variables.  The first, students, holds the names of four students.
The second, scores, holds groups of test scores.  The relative positions of elements within the two
variables match (i.e., 'Joseph' is the first element in students; his scores are the first value in scores.).

Do not alter the students and scores code.

*/

var students = ["Joseph", "Susan", "William", "Elizabeth"]

var scores = [ [80, 70, 70, 100],
               [85, 80, 90, 90],
               [75, 70, 80, 75],
               [100, 90, 95, 85] ]

// __________________________________________
// Write your code below.
var gradebook = {}; // create new gradebook which is an empty object - release #0

for (var i = 0; i < students.length; i++) // create for loop that loops through students array and at each iteration, assigns to gradebook 
{                                        // a new object. which is a property of the student's names in students array - release #1
  gradebook[students[i]] = new Object ();
}

for (var i = 0; i < students.length; i++) { //create for loop that loops through students array and at each iteration,assigns to gradebook
  gradebook[students[i]].testScores = scores[i]; // a new property testscores, this property is an iteration through the scores array.
};                                               // release #2


gradebook.addScore = function (name, score)  // create function addscore which is a property of gradebook, which takes a name and score as input
  
{  
    gradebook[name].testScores.push(score)   // where the name value matches the gradebook property, push the score to Testscores - release #3
}

gradebook.getAverage = function (name) // create get average function which is a property of gradebook which takes a name as input

{
    var averagescore = average(gradebook[name].testScores) // creare var average score which uses the average function to index into the name 
    return averagescore;
}

var average = function (array) // create function that takes an array as input, sets a integer called sum to zero to use to store results
{                             // use for loop to iterate through the array's length and at each iteration, add the value of the array to the sum..
  sum = 0;                    // and then returns sum divided by the array.length. When this function is called, it will action all the above.
  for (var i = 0; i < array.length; i++) 
  {
  sum += array[i];
  }
  return sum/array.length;

}

/* Reflections
This challenge was a good learning as it made me look at my code and refactor - originally I had repeated the code when setting up the
properties in release 1 and 2, but realised I could iterate through the students array and assign a property to grade book and assign a value 
to that property.
I did this challenge entirely on my own so it was a good javascript refresher and I have begun to see familiarities with javascript and C#, particularly
in the way that methods and functions are created (the inputs in particular)
*/

// __________________________________________
// Driver Code:  Do not alter code below this line.


function assert(test, message, test_number) {
  if (!test) {
    console.log(test_number + "false");
    throw "ERROR: " + message;
  }
  console.log(test_number + "true");
  return true;
}



assert(
  (gradebook instanceof Object),
  "The value of gradebook should be an Object.\n",
  "1. "
)

assert(
  (gradebook["Elizabeth"] instanceof Object),
  "gradebook's Elizabeth property should be an object.",
  "2. "
)

assert(
  (gradebook.William.testScores === scores[2]),
  "William's testScores should equal the third element in scores.",
  "3. "
)

assert(
  (gradebook.addScore instanceof Function),
  "The value of gradebook's addScore property should be a Function.",
  "4. "
)

gradebook.addScore("Susan", 80)

assert(
  (gradebook.Susan.testScores.length === 5
   && gradebook.Susan.testScores[4] === 80),
  "Susan's testScores should have a new score of 80 added to the end.",
  "5. "
)

assert(
  (gradebook.getAverage instanceof Function),
  "The value of gradebook's getAverage property should be a Function.",
  "6. "
)

assert(
  (average instanceof Function),
  "The value of average should be a Function.\n",
  "7. "
)
assert(
  average([1, 2, 3]) === 2,
  "average should return the average of the elements in the array argument.\n",
  "8. "
)

assert(
  (gradebook.getAverage("Joseph") === 80),
  "gradebook's getAverage should return 80 if passed 'Joseph'.",
  "9. "
)

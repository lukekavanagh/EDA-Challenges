# OO Basics - Student

## Learning Competencies
- Use if/else statements, string methods, while loops, List and List Methods
- Use strings, integers, arrays, Lists and Dictionary
- Automate repetitive tasks using loops
- Make a Console App.

## Summary:
In this challenge you will work with a collection of simple `Student` [objects](https://msdn.microsoft.com/en-us/library/ms173110.aspx). An object is an abstract idea that 

Your program will create arrays of student data, and compute the average scores for each student.

## Release 0: Create a List of Students

Create an array `students` with 5 Student objects (HINT: You'll need to create the student objects first). Each student should be assigned a `Name`, and 5 test scores (scores are between 0 and 100) when it is created. The Student should be named `"Alex"` with an int array Scores `[100,100,100,0,100]`. Once you've done this properly, the Release 0 tests should pass.
We have stubbed an empty Student class as a starting point.

Note to make all the tests pass you need only define the tests. This is called stubbing, in C# we also need to add an exemption else the code wont compile. e.g.

```
public int MethodThatReturnsASix ()  
{  
    throw new NotImplementedException();  
}  
```

## Release 1: Average Scores & GetLetterGrade
Uncomment the tests at the bottom of the StudentTest.cs file. Run the tests again and see what fails.


Compute and assign a score average and a letter grade to each student. Letter grades are based on the average (A for >=90%, B for >=80%, C for >= 70%, D for >= 60% and F for < 60%).
Once done all the tests should pass.

## Release 2: Linear Search
Create a new Class Searcher. Ctrl + Shift + A to bring up the add new item menu. Then just Select class and name it "Searcher".
Write a [linear_search](http://en.wikipedia.org/wiki/Linear_search) method that searches the student array for a student's `Name` and returns the position of that student if they are in the array. If the student is not in the array then the method should return -1.

## Release 3: Write your Tests
Add a class to your test project called SearcherTest
Add some NUnit Tests for the logic you have created (Testing methods makes sure they return what we expect).

## Release 4: Binary Search (Optional)
Write a [binary_search](http://en.wikipedia.org/wiki/Binary_search_algorithm) method that searches the student array for a student's first_name and returns the position of that student if they are in the array. If the student is not in the array then the method should return -1.  You can write a iterative (or recursive, if you are comfortable with that) version of `binary_search`.

## Release 4: [Refactor](https://github.com/dev-academy-phase0/phase-0-handbook/blob/master/coding-references/refactoring.md)

## Release 5: Push!
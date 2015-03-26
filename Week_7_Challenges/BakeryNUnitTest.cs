/******************** Summary *************************
Test multiple permutations of the use of the CalculateQuantities method.

These tests are to determine the edge cases of the use of the method.

There are five variations of a test for the CalculateQuantities method to write.

All follow the pattern of 

 * Arrange
 * 
 * Act
 * 
 * Assert
 
Do not be tempted to copy paste the first one - this is an exercise to help build muscle memory.
*******************************************************/

using EdaBakery;
using NUnit.Framework;
using REPLTestSupport;

namespace UnitTestProject
{
    //This is called an attribute - it provides information about the BakeryTest class.
    //Here it says that the class is a Test Class using the NUnit test framework.
    [TestFixture]
    public class BakeryTest
    {
        //This is a class variable/field.
        private Bakery bakery;

        //The SetUp attribute tells NUnit to run this method before every test. It is responsible for setting up any requirements that all tests need.
        //In this case as we are testing the Bakery class we want to create a new instance/version of it each time. This silos the tests.
        //If we didn't a later test may give a false return if it is based on something a previous test had done. 
        [SetUp]
        public void init()
        {
            bakery = new Bakery();
        }

        //The Test Attribute tells NUnit that the method is a test.
        [Test]
        public void TestCalculateQuantitiesExists()
        {
            //Here we use a var for the type as we are not sure what type it is.
            var actual = HelperMethods.getMethod(bakery.GetType(), "CalculateQuantities");

            //Assert is a static class we use for asserting/testing the results of tests. Google "msdn assert" and look at the methods section.
            Assert.NotNull(actual);
        }
        

        //Each of the comments below will guide you through writing the test. Fill in the code under each of the comments.
        //Start by creating a Test attribute.
        [Test]
        public void CalculateQuantities();
        


        //Now define a public method that returns void called TestResultOfCalculateQuantities1. 
        //We have added the body tags ({} on line 50 and 65) for the method to make organising the comments easier. uncomment them when you have named the method.
        [TestMethod]
        public void TestResultofCalculateQuantities1();
        {
        //Arrange
        public string expected = "You need to make 4 cakes";
        //Define a string field/variable called expected and assign it (=) the value "You need to make 4 cake(s).". This is what we are expecting as a result of the method.

        //Define a string field/variable called actual. this has no value at the moment. we will add one as an action below.
        public string actual = "";

        //Act
        //Assign the result of using the CalculateQuantities with the arguments (24, "cake") to the field actual. Remember assignments go from right to left. example below.
        //actual = methodThingee(9, "words of wonder");
        var actual =  TestResultofCalculateQuantities1(24, "cake");
        

        //Assert
        //Use the Assert class with the method AreEqual. Then pass the fields expected and actual in separated by a comma.
        Assert.AreEqual(expected, actual);
        }

        //Once you have finished the test you should be able to run it and see it passing.

        //Now write four more tests for these combinations:
        /*
		actual - CalculateQuantities(41, "pie") and expected - "You need to make 5 pie(s), 0 cake(s), and 1 cookie(s)."
        */
        [Test]
        public void CalculateQuantities2();

        [TestMethod]
        public void TestResultofCalculateQuantities2();
        {
        public string expected = "You need to make 5 pie(s), 0 cake(s), and 1 cookie(s)."; //Arrange
        
        public string actual = ""; //Arrange

        var actual = TestResultOfCalculateQuantities2(41, "pie"); // Act

        Assert.AreEqual(expected, actual); //Assert

	//	actual - CalculateQuantities(24, "cookie") and expected - "You need to make 24 cookie(s)."
        [Test]
        public void CalculateQuantities3();
        
        [TestMethod]
        public void ResultOfCalculateQuantities3();
        {
        public string expected = "You need to make 24 cookie(s)."//Arrange

        public string actual = ""; // Arrange

        var actual = ResultOfCalculateQuantities3(24, "cookie"); //Act

        Assert.AreEqual(expected, actual);

        }
        
        // actual - CalculateQuantities(4, "pie") and expected - "You need to make 0 pie(s), 0 cake(s), and 4 cookie(s)."
        [test]		
        public void CalculateQuantities4();

        [TestMethod]
        public void ResultOfCalculatingQuantities4();
        {
        
        public string expected = "You need to make 0 pie(s), 0 cake(s), and 4 cookie(s).";

        public string actual = "";

        var actual = ResultOfCalculatingQuantities4(4, "pie");

        Assert.AreEqual(expected, actual);
        }

        //actual - CalculateQuantities(130, "pie") and expected - "You need to make 16 pie(s), 0 cake(s), and 2 cookie(s)."
       
        [Test]
        public void CalculatingQuantities5();
            
        public void ResultOfCalculatingQuantities5();
        {
        public string expected = "You need to make 16 pie(s), 0 cake(s), and 2 cookie(s).";

        public string actual = "";

        var actual = ResultOfCalculatingQuantities5(130, "pie");

        AssertAreEqual(expected, actual);
        }
        

        









         
        When finished go back to the Bakery class and start refactoring! Remember to run your tests with each change.
        */
    }
}
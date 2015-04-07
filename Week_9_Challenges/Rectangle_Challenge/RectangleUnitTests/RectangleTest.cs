using NUnit.Framework;
using RectangularShapes;
using System;
using System.Reflection;

namespace RectangleUnitTests
{
    [TestFixture]
    public class RectangleTest
    {
        private Rectangle _rectangle;
        private Rectangle _square;

        [SetUp]
        public void Init()
        {
            _rectangle = new Rectangle(10, 20);
            _square = new Rectangle(20, 20);
        }

        [Test]
        public void Has_Area_Method()
        {
            // Act
            MethodInfo actual = typeof(Rectangle).GetMethod("Area");

            // Assert
            Assert.IsNotNull(actual, "\"Area\" method is not defined");
            Assert.AreEqual(typeof(int), actual.ReturnType, "Return must be of type int");
        }

        [Test]
        public void Has_Perimiter_Method()
        {
            // Act
            MethodInfo actual = typeof(Rectangle).GetMethod("Perimeter");

            // Assert
            Assert.IsNotNull(actual, "\"Perimeter\" method is not defined");
            Assert.AreEqual(typeof(int), actual.ReturnType, "Return must be of type int");
        }

        [Test]
        public void Has_Diagnal_Method()
        {
            // Act
            MethodInfo actual = typeof(Rectangle).GetMethod("Diagonal");

            // Assert
            Assert.IsNotNull(actual, "\"Diagonal\" method is not defined");
            Assert.AreEqual(typeof(Double), actual.ReturnType, "Return must be of type Double");
        }

        [Test]
        public void Has_IsSquare_Method()
        {
            // Act
            MethodInfo actual = typeof(Rectangle).GetMethod("IsSquare");

            // Assert
            Assert.IsNotNull(actual, "\"IsSquare\" method is not defined");
            Assert.AreEqual(typeof(bool), actual.ReturnType, "Return must be of type bool");
        }

        [Test]
        public void Area_Returns_Correct_Area_For_A_Rectangle()
        {
        //    // Arrange
            int expected = 200;

        //    // Act
            int actual = _rectangle.Area();

        //    // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Area_Returns_Correct_Area_For_A_Square()
        {
        //    // Arrange
            int expected = 400;

        //    // Act
            int actual = _square.Area();

        //    // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Perimiter_Returns_Correct_Length_For_Rectangle()
        {
        //    // Arrange
            int expected = 60;

        //    // Act
            int actual = _rectangle.Perimeter();

        //    // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Perimiter_Returns_Correct_Length_For_Square()
        {
        //    // Arrange
            int expected = 80;

        //    // Act
            int actual = _square.Perimeter();

        //    // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Diagnal_Returns_Correct_Length_For_Rectangle()
        {
        //    // Arrange
            double expected = 22.36;

        //    // Act
            double actual = _rectangle.Diagonal();

        //    // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Diagnal_Returns_Correct_Length_For_Square()
        {
        //    // Arrange
            double expected = 28.28;

        //    // Act
            double actual = _square.Diagonal();

        //    // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsSquare_Returns_True_For_Square()
        {
            // Act
            bool actual = _square.IsSquare();

        //    // Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void issquare_returns_false_for_rectangle()
        {
        //    // Act
            bool actual = _rectangle.IsSquare();

        //    // Assert
            Assert.IsFalse(actual);
        }
    }
}
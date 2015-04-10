using NUnit.Framework;
using ReverseWords;
using System;
using System.Linq;
using System.Reflection;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest1
    {
        private Reverser _reverser;

        [SetUp]
        public void Init()
        {
            _reverser = new Reverser();
        }

        [Test]
        public void Has_Reverse_Method_With_Words_Parameter()
        {
            // Act
            MethodInfo actual = typeof(Reverser).GetMethod("Reverse");

            // Assert
            Assert.IsNotNull(actual, "\"Reverse\" method is not defined");
            Assert.AreEqual(typeof(string), actual.ReturnType, "Return must be of type string");

            Assert.IsNotNull(actual.GetParameters().Select(s => s).FirstOrDefault(s => s.Name == "words"),
                "Parameter \"words\" not defined");
            Assert.AreEqual(typeof(string), actual.GetParameters().Select(s => s).First(w => w.Name == "words").ParameterType,
                "Parameter \"words\" must be of type \"string\"");
        }

        [Test]
        public void Reverse_A_Single_Word(
            [Values("Macintosh", "Windows", "Ubuntu")] string word)
        {
            string expected = new string(word.Reverse().ToArray());
            string actual = _reverser.Reverse(word);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Reverse_Multiple_Words(
            [Values("Orcs Must Die", "Settlers of Catan", "Eggs or Toast")] string words)
        {
            string expected = String.Join(" ", words.Split(' ').Select(s =>
            {
                s = new string(s.Reverse().ToArray());
                return s;
            }).ToArray());
            string actual = _reverser.Reverse(words);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Reverse_A_Sentance()
        {
            string words = "If debugging is the process of removing software bugs, then programming must be the process of putting them in. Edsger Dijkstra (Dutch computer scientist, winner of the 1972 Turing Award)";
            string expected = String.Join(" ", words.Split(' ').Select(s =>
            {
                s = new string(s.Reverse().ToArray());
                return s;
            }).ToArray());
            string actual = _reverser.Reverse(words);
            Assert.AreEqual(expected, actual);
        }
    }
}
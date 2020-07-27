using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class AddMethodTests
    {
        [TestMethod]
        public void AddMethod_AddOneInt_ListCountIsOne()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            int expected = 1;
            int actual;

            //Act

            list.Add(5);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void AddMethod_AddOneInt_Index0Equals5()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            int expected = 5;
            int actual;

            //Act
            list.Add(5);
            actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void AddMethod_AddOneString_ListCountIsOne()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();

            int expected = 1;
            int actual;

            //Act
            list.Add("Hello");
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void AddMethod_AddOneString_Index0EqualsHello()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();

            string expected = "Hello";
            string actual;

            //Act
            list.Add("Hello");
            actual = list[0];

            //Assert 
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void AddMethod_AddTwoStrings_ListCountIsTwo()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();

            int expected = 2;
            int actual;

            //Act
            list.Add("Hello");
            list.Add("World");
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]

        public void AddMethod_AddTwoStrings_Index1IsWorld()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();

            string expected = "World";
            string actual;

            //Act
            list.Add("Hello");
            list.Add("World");
            actual = list[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void RemoveMethod_RemoveOneInt_ListCountIsOne()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 5, 2 };

            int expected = 1;
            int actual;

            //Act
            list.Remove(5);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void RemoveMethod_RemoveOneString_Index0EqualsWorld()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>() { "Hello", "World" };

            string expected = "World";
            string actual;

            //Act
            list.Remove("Hello");
            actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

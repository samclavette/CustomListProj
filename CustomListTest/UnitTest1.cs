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

        public void AddMethod_AddOneInt_IndexZeroEqualsFive()
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

        public void AddMethod_AddOneString_IndexZeroEqualsHello()
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

        public void AddMethod_AddTwoStrings_IndexOneIsWorld()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string hello = "Hello";
            string expected = "World";
            string actual;

            //Act
            list.Add("Hello");
            list.Add("World");
            actual = list[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void AddMethod_AddThreeInts_CapacityIsFour()
        {
            CustomList<int> list = new CustomList<int>();

            int value1 = 5;
            int value2 = 2;
            int value3 = 7;
            int expected = 4;
            int actual;

            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            actual = list.Capacity;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void AddMethod_AddThreeInts_CapacityIsEight()
        {
            CustomList<int> list = new CustomList<int>();

            int value1 = 5;
            int value2 = 2;
            int value3 = 7;
            int value4 = 12;
            int value5 = 2;
            int expected = 8;
            int actual;

            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);

            actual = list.Capacity;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveMethod_RemoveOneInt_ListCountIsOne()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            int int1 = 5;
            int int2 = 2;
            int expected = 1;
            int actual;

            //Act
            list.Add(int1);
            list.Add(int2);
            list.Remove(int2);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void RemoveMethod_RemoveOneString_Index0EqualsWorld()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();

            string value1 = "Hello";
            string value2 = "World";
            string expected = "World";
            string actual;

            //Act
            list.Add(value1);
            list.Add(value2);
            list.Remove(value1);
            actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void RemoveMethod_RemoveTwoInts_CountIsZero()
        {
            //Arange
            CustomList<int> list = new CustomList<int>();

            int value1 = 5;
            int value2 = 2;
            int expected = 0;
            int actual;

            //Act
            list.Add(value1);
            list.Add(value2);
            list.Remove(value1);
            list.Remove(value2);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);


        }
        //3, 5, 6, 5, 3
        //when called, the remove method will take out the first occurence
        //3, 6, 5, 3 would be the result

    }
}

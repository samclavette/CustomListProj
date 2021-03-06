﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

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
            string world = "World";
            string expected = "World";
            string actual;

            //Act
            list.Add(hello);
            list.Add(world);
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

        public void AddMethod_AddFiveInts_CapacityIsEight()
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

        [TestMethod]

        public void RemoveMethod_RemoveMiddleValue_IndexOneEqualsEight()
        {
            CustomList<int> list = new CustomList<int>();

            int value1 = 5;
            int value2 = 2;
            int value3 = 8;
            int expected = 8;
            int actual;

            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Remove(value2);
            actual = list[1];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void RemoveMethod_RemoveFirstOccurence_IndexTwoEqualsFive()
        {
            CustomList<int> list = new CustomList<int>();

            int value1 = 3;
            int value2 = 5;
            int value3 = 6;
            int value4 = 5;
            int value5 = 3;
            int expected = 5;
            int actual;

            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);
            list.Remove(5);

            actual = list[2];

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]

        public void ToStringMethod_AddValueOneValueTwoValueThree_EqualsOneTwoThree()
        {
            CustomList<int> list = new CustomList<int>();

            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            string expected = "123";
            string actual;

            actual = list.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringMethod_AddValuesOneThroughFive_EqualsOneTwoThreeFourFive()
        {
            CustomList<int> list = new CustomList<int>();

            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);
            string expected = "12345";
            string actual;

            actual = list.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringMethod_AddFiveValues_LengthEqualsFive()
        {
            CustomList<int> list = new CustomList<int>();

            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);
            int expected = 5;
            int actual;

            string newString = list.ToString();
            actual = newString.Length;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringMethod_AddFourRemoveTwo_LengthEqualsTwo()
        {
            CustomList<int> list = new CustomList<int>();

            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Remove(value2);
            list.Remove(value4);
            int expected = 2;
            int actual;

            string newString = list.ToString();
            actual = newString.Length;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringMethod_AddFourRemoveTwo_StringEqualsOneThree()
        {
            CustomList<int> list = new CustomList<int>();

            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Remove(value2);
            list.Remove(value4);
            string expected = "13";
            string actual;

            actual = list.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void PlusOperatorMethod_AddTwoIntLists_ListEqualsFirstThenSecond()
        {
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> listTwo = new CustomList<int>() { 4, 5, 6 };

            CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
            CustomList<int> actual;

            actual = listOne + listTwo;

            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [TestMethod]
        public void PlusOperatorMethod_AddTwoIntLists_ListEqualsFirstThenSecondWRegularLists()
        {
            List<int> expected = new List<int>() { 1, 2, 3 };
            List<int> actual = new List<int>() { 1, 2, 3 };

            //List<int> expected = new List<int>() { 1, 2, 3, 4, 5, 6 };
            //List<int> actual;

            //actual = listOne + listTwo;

            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [TestMethod]

        public void PlusOperatorMethod_AddTwoIntLists_CountEqualsSix()
        {
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> listTwo = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> listThree = new CustomList<int>();

            int expected = 6;
            int actual;

            listThree = listOne + listTwo;
            actual = listThree.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void PlusOperatorMethod_AddTwoIntLists_CountEqualsThree()
        {
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listThree = new CustomList<int>();

            int expected = 3;
            int actual;

            listThree = listOne + listTwo;
            actual = listThree.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void PlusOperatorMethod_AddTwoIntLists_ListAtIndexThreeEqualsFour()
        {
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> listTwo = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> listThree = new CustomList<int>();

            int expected = 4;
            int actual;

            listThree = listOne + listTwo;
            actual = listThree[3];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void PlusOperatorMethod_AddTwoStringLists_ListCountEqualsSix()
        {
            CustomList<string> listOne = new CustomList<string>() { "my", "name", "is" };
            CustomList<string> listTwo = new CustomList<string>() { "Sam", "got", "it?" };
            CustomList<string> listThree = new CustomList<string>();

            int expected = 6;
            int actual;

            listThree = listOne + listTwo;
            actual = listThree.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void MinusOperatorMethod_SubtractTwoIntLists_ListEqualsFirstThenSecond()
        {
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> listTwo = new CustomList<int>() { 4, 3, 6 };

            CustomList<int> expected = new CustomList<int>() { 1, 2 };
            CustomList<int> actual;

            actual = listOne - listTwo;

            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod]

        public void MinusOperatorMethod_SubtractTwoIntLists_CountEqualsTwo()
        {
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> listTwo = new CustomList<int>() { 4, 3, 6 };
            CustomList<int> listThree = new CustomList<int>();

            int expected = 2;
            int actual;

            listThree = listOne - listTwo;
            actual = listThree.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void MinusOperatorMethod_SubtractTwoIntLists_ListAtIndexOneEqualsTwo()
        {
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> listTwo = new CustomList<int>() { 4, 3, 6 };
            CustomList<int> listThree = new CustomList<int>();


            int expected = 2;
            int actual;

            listThree = listOne - listTwo;
            actual = listThree[1];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void MinusOperatorMethod_SubtractTwoStringLists_ListCountEqualsOne()
        {
            CustomList<string> listOne = new CustomList<string>() { "my", "name", "is" };
            CustomList<string> listTwo = new CustomList<string>() { "Sam", "name", "is" };
            CustomList<string> listThree = new CustomList<string>();

            int expected = 1;
            int actual;

            listThree = listOne - listTwo;
            actual = listThree.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void MinusOperatorMethod_SubtractTwoStringLists_ListCountEqualsThree()
        {
            CustomList<string> listOne = new CustomList<string>() { "my", "name", "is" };
            CustomList<string> listTwo = new CustomList<string>();
            CustomList<string> listThree = new CustomList<string>();

            int expected = 3;
            int actual;

            listThree = listOne - listTwo;
            actual = listThree.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void MinusOperatorMethod_SubtractTwoStringLists_ListCountEqualsZero()
        {
            CustomList<string> listOne = new CustomList<string>();
            CustomList<string> listTwo = new CustomList<string>() { "my", "name", "is" };
            CustomList<string> listThree = new CustomList<string>();

            int expected = 0;
            int actual;

            listThree = listOne - listTwo;
            actual = listThree.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void ZipListsMethod_ZipTwoLists_ListCountIsSix()
        {
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> listTwo = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> listThree = new CustomList<int>();

            int expected = 6;
            int actual;

            listThree = listOne.ZipList(listTwo);
            actual = listThree.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void ZipListsMethod_ZipTwoLists_IndexTwoEqualsTwo()
        {
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> listTwo = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> listThree = new CustomList<int>();

            int expected = 2;
            int actual;

            listThree = listOne.ZipList(listTwo);
            actual = listThree[2];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void ZipListsMethod_ZipTwoLists_CountEqualsFive()
        {
            CustomList<int> listOne = new CustomList<int>() { 1, 2};
            CustomList<int> listTwo = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> listThree = new CustomList<int>();

            int expected = 5;
            int actual;

            listThree = listOne.ZipList(listTwo);
            actual = listThree.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void ZipListsMethod_ZipTwoLists_IndexFourEqualsSix()
        {
            CustomList<int> listOne = new CustomList<int>() { 1, 2};
            CustomList<int> listTwo = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> listThree = new CustomList<int>();

            int expected = 6;
            int actual;

            listThree = listOne.ZipList(listTwo);
            actual = listThree[4];

            Assert.AreEqual(expected, actual);
        }

    }                                                 
}

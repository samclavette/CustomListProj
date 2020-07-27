﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class AddMethodsTest
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
        public void AddMethod_AddOneString_ListCountIsOne()
        {

        }
    }
}

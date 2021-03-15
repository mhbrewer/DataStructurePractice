using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;

namespace DataStructuresTest
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void LinkedList_NewListEmpty_Returns_Exception()
        {
            // Arrange
            LinkedList list = new LinkedList();

            // Assert Exception
            int expected = list.valueAtIndex(0);
            
        }
        
        [TestMethod]
        public void LinkedList_NewList0_Returns_0()
        {
            // Arrange
            LinkedList list = new LinkedList(0);

            // Act
            int expected = list.valueAtIndex(0);
            int actual = 0;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void LinkedList_NewList1_Returns_1()
        {
            // Arrange
            LinkedList list = new LinkedList(1);

            // Act
            int expected = list.valueAtIndex(0);
            int actual = 1;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void LinkedList_IndexOutOfBounds_Returns_Exception()
        {
            // Arrange
            LinkedList list = new LinkedList(1);

            // Act
            int expected = list.valueAtIndex(1);
            int actual = 1;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void LinkedList_1_2_ValueAt1_Returns_2()
        {
            // Arrange
            LinkedList list = new LinkedList(1);
            list.add(2);

            // Act
            int expected = list.valueAtIndex(1);
            int actual = 2;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void LinkedListEmpty_add5_ValueAt0_Returns_5()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.add(5);

            // Act
            int expected = list.valueAtIndex(0);
            int actual = 5;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

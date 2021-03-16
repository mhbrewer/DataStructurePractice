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
        public void LinkedListEmpty_Add5_ValueAt0_Returns_5()
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
        
        [TestMethod]
        public void LinkedListEmpty_ToString_Returns_EmptyList()
        {
            // Arrange
            LinkedList list = new LinkedList();

            // Act
            string expected = list.ToString();
            string actual = "{}";

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void LinkedList_1_2_ToString_Returns_FullList()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.add(1);
            list.add(2);

            // Act
            string expected = list.ToString();
            string actual = "{1,2}";

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void LinkedList_1_2_Add3InMiddle_ToString_Returns_1_3_2()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.add(1);
            list.add(2);
            list.addAtIndex(1, 3);

            // Act
            string expected = list.ToString();
            string actual = "{1,3,2}";

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void LinkedList_AddAtIndex_1_3_ToString_Returns_1_3()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.addAtIndex(0, 1);
            list.addAtIndex(1, 3);

            // Act
            string expected = list.ToString();
            string actual = "{1,3}";

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void LinkedList123_ToString_Returns_1_2_3()
        {
            // Arrange
            LinkedList list = new LinkedList(new int[] {1, 2, 3});

            // Act
            string expected = list.ToString();
            string actual = "{1,2,3}";

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void LinkedList1_ToString_Returns_1()
        {
            // Arrange
            LinkedList list = new LinkedList(new int[] {1});

            // Act
            string expected = list.ToString();
            string actual = "{1}";

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void LinkedListEmpty_ToString_Returns_Empty()
        {
            // Arrange
            LinkedList list = new LinkedList(new int[] {});

            // Act
            string expected = list.ToString();
            string actual = "{}";

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void LinkedList123_RemoveAt1_ToString_Returns_1_3()
        {
            // Arrange
            LinkedList list = new LinkedList(new int[] {1,2,3});
            list.removeAtIndex(1);

            // Act
            string expected = list.ToString();
            string actual = "{1,3}";

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void LinkedList123_RemoveAt2_ToString_Returns_1_2()
        {
            // Arrange
            LinkedList list = new LinkedList(new int[] {1,2,3});
            list.removeAtIndex(2);

            // Act
            string expected = list.ToString();
            string actual = "{1,2}";

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

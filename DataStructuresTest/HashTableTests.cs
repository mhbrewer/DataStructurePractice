using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;

namespace DataStructuresTest
{
    [TestClass]
    public class HashTableTests
    {
        [TestMethod]
        public void Binary_NewHashTableEmpty_Size_Returns_0()
        {
            // Arrange
            HashTable hash = new HashTable();

            // Assert Exception
            int expected = hash.size;
            int actual = 0;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Binary_NewHashTableKey1Value1_Size_Returns_1()
        {
            // Arrange
            HashTable hash = new HashTable(1, 1);

            // Assert Exception
            int expected = hash.size;
            int actual = 1;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Binary_NewHashTableKey1Value1_getValue1_Returns_1()
        {
            // Arrange
            HashTable hash = new HashTable(1, 1);

            // Assert Exception
            int expected = hash.getValue(1);
            int actual = 1;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Binary_NewHashTableKey200Value5_getValue200_Returns_5()
        {
            // Arrange
            HashTable hash = new HashTable(200, 5);

            // Assert Exception
            int expected = hash.getValue(200);
            int actual = 5;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Binary_EmptyHashTable_AddKey0Value1_getValue0_Returns_1()
        {
            // Arrange
            HashTable hash = new HashTable();
            hash.add(0, 1);

            // Assert Exception
            int expected = hash.getValue(0);
            int actual = 1;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
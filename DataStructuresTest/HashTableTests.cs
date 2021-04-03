using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;
using System.Collections.Generic;

namespace DataStructuresTest
{
    [TestClass]
    public class HashTableTests
    {
        [TestMethod]
        public void Binary_NewHashTableEmpty_getSize_Returns_0()
        {
            // Arrange
            HashTable hash = new HashTable();

            // Act
            int actual = hash.getSize();
            int expected = 0;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Binary_NewHashTableKey1Value1_getSize_Returns_1()
        {
            // Arrange
            HashTable hash = new HashTable(1, 1);

            // Act
            int actual = hash.getSize();
            int expected = 1;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Binary_NewHashTableKey1Value1_getValue1_Returns_1()
        {
            // Arrange
            HashTable hash = new HashTable(1, 1);

            // Act
            int actual = hash.getValue(1);
            int expected = 1;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Binary_NewHashTableKey200Value5_getValue200_Returns_5()
        {
            // Arrange
            HashTable hash = new HashTable(200, 5);

            // Act
            int actual = hash.getValue(200);
            int expected = 5;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Binary_EmptyHashTable_AddKey0Value1_getValue0_Returns_1()
        {
            // Arrange
            HashTable hash = new HashTable();
            hash.add(0, 1);

            // Act
            int actual = hash.getValue(0);
            int expected = 1;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Binary_EmptyHashTable_AddKey200Value1_getValue200_Returns_1()
        {
            // Arrange
            HashTable hash = new HashTable();
            hash.add(200, 1);

            // Act
            int actual = hash.getValue(200);
            int expected = 1;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Binary_EmptyHashTable_AddKey200Value1_getSize_Returns_1()
        {
            // Arrange
            HashTable hash = new HashTable();
            hash.add(200, 1);

            // Act
            int actual = hash.getSize();
            int expected = 1;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Binary_EmptyHashTable_AddKey2KeysSameModulo_getFirstValue_Returns_CorrectValue()
        {
            // Arrange
            HashTable hash = new HashTable();
            hash.add(0, 1);
            hash.add(19, 2);

            // Act
            int actual = hash.getValue(0);
            int expected = 1;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Binary_EmptyHashTable_AddKey2KeysSameModulo_getSecondValue_Returns_CorrectValue()
        {
            // Arrange
            HashTable hash = new HashTable();
            hash.add(0, 1);
            hash.add(19, 2);

            // Act
            int actual = hash.getValue(19);
            int expected = 2;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Binary_EmptyHashTable_AddSameKeyTwice_getSize_Returns_1()
        {
            // Arrange
            HashTable hash = new HashTable();
            hash.add(0, 1);
            hash.add(0, 2);

            // Act
            int actual = hash.getSize();
            int expected = 1;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Binary_EmptyHashTable_AddSameKeyThreeTimes_getValue_Returns_3()
        {
            // Arrange
            HashTable hash = new HashTable();
            hash.add(0, 1);
            hash.add(0, 2);
            hash.add(0, 3);

            // Act
            int actual = hash.getValue(0);
            int expected = 3;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Binary_HashTable_Add200KeyValues_getValue12_Returns_12()
        {
            // Arrange
            HashTable hash = new HashTable();
            for(int i = 0; i < 200; i++) {
                hash.add(i, i);
            }

            // Act
            int actual = hash.getValue(12);
            int expected = 12;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
        
    }

    [TestClass]
    public class HashTableExceptionTests
    {
        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void Binary_EmptyHashTable_getValue0_Exception()
        {
            // Arrange
            HashTable hash = new HashTable();

            // Assert Exception
            int actual = hash.getValue(0);
        }
        
        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void Binary_HashTable_AddKey19Value1_getValue0_Exception()
        {
            // Arrange
            HashTable hash = new HashTable();
            hash.add(19, 1);

            // Assert Exception
            int actual = hash.getValue(0);
        }
    }
}
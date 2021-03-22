using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;

namespace DataStructuresTest
{
    [TestClass]
    public class BinaryTreeTests
    {
        [TestMethod]
        public void Binary_NewTreeEmpty_Size_Returns_0()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();

            // Assert Exception
            int expected = tree.size();
            int actual = 0;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Binary_NewTreeOneInput_Size_Returns_1()
        {
            // Arrange
            BinaryTree tree = new BinaryTree(1);

            // Assert Exception
            int expected = tree.size();
            int actual = 1;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Binary_TwoNodeTree_Size_Returns_2()
        {
            // Arrange
            BinaryTree tree = new BinaryTree(1);
            tree.add(2);

            // Assert Exception
            int expected = tree.size();
            int actual = 2;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
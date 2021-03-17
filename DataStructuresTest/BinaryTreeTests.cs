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
    }
}
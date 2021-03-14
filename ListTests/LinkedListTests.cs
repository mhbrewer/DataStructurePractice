using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lists;

namespace ListTests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void LinkedList_NewListEmpty_Returns_0()
        {
            // Arrange
            LinkedList list = new LinkedList();
            // Act
            var expected = list.head.value;

            // Assert

        }
    }
}

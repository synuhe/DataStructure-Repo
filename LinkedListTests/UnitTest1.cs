using System;
using Xunit;
using LinkedLists;

namespace LinkedListTests
{
    public class Node
    {
        [Fact]
        public void BasicAddToTail()
        {
            DoublyLinkedList list = new DoublyLinkedList();
            list.addToTail(5);
            Assert.Equal(5, list.Tail.Value);
        }
    }
}

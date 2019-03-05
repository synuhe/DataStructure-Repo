using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists 
{
    public class DoublyLinkedList
    {

       public DoublyLinkedList()
        {
            Head = Tail = null; 
        }
        public void AddToTail(int value)
        {
            if (Head == null & Tail == null)
            {
                Node node = new Node(value);
                Head = Tail = node;

            }
        }

        public Node Tail
        {
            private set; get;
        }

        public Node Head
        {
            private set; get;
        }
    }
}

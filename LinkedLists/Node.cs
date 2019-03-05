using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    public class Node 
    {
        public Node next { get; set;}
        public Node prev { get; set;}
        public int Value { get; set;}
        /// <summary>
        /// Node Constructor 
        /// </summary>
        /// <param name="next">Node next</param>
        /// <param name="prev"> Node prev</param>
        /// <param name="value"> Node value</param>
        public Node(int value)
        {
            Value = value;
            next = prev = null;
        }
    }
}

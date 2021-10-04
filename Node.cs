using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class Node<T>
    {
        public Node<T> next;
        public T data;
        public Node(T data)
        {
            this.data = data;
            this.next = null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class CustomLinkedList<T>
    {
        Node<T> head;
        //Method to insert element at First
        public void InsertAtFront(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (this.head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }

        //Method to Display all Linked List elements
        public void Display()
        {
            int count = 1;
            Node<T> temp = head;
            while (temp != null)
            {
                Console.WriteLine("Element {0} of Linked List is: {1}", count, temp.data);
                temp = temp.next;
                count++;
            }
        }

        //Method to Search a particular word
        public bool Search(T data)
        {
            Node<T> temp = head;
            while (temp != null)
            {
                if (temp.data.Equals(data))
                {
                    return true;
                }
                else
                {
                    temp = temp.next;
                }
            }
            return false;
        }

        //Method to delete a particular word
        public void DeleteElement(T data)
        {
            Node<T> temp = head;
            while (temp.next != null)
            {
                if (temp.next.data.Equals(data))
                {
                    Console.WriteLine("\nDelete data: {0}", temp.next.data);
                    temp.next = temp.next.next;
                    break;
                }
                else
                {
                    temp = temp.next;
                }
            }
        }

        //Method to Convert linked list elements to string
        public string ReturnToString()
        {
            string StringValues = "";
            Node<T> node = head;
            StringValues += head.data;
            node = node.next;
            while (node != null)
            {
                StringValues += " " + node.data;
                node = node.next;
            }
            return StringValues;
        }

        //Method for sorted Insertion
        public void SortedInsertion(T data)
        {
            Node<T> newNode = new Node<T>(data);
            Node<T> temp = head;
            if (head == null || newNode.idata <= head.idata)
            {
                newNode.next = head;
                head = newNode;
            }
            else if (head.next == null && head.idata < newNode.idata)
            {
                head.next = newNode;
            }
            else
            {
                if (temp.next.idata > newNode.idata)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
                else
                {
                    while (temp.next != null && temp.next.idata < newNode.idata)
                    {
                        temp = temp.next;
                    }
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
            }
        }
    }
}

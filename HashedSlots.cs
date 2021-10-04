using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class HashedSlots<T>
    {
        //Linked List to store values of say index
        private readonly int size;
        private LinkedList<T>[] item;
        public HashedSlots(int size)
        {
            this.size = size;
            this.item = new LinkedList<T>[size];
        }


        //Add Node: Get Array Position ->Get linked list
        public void AddNode(T value)
        {
            int position = GetArrayPosition(value);
            LinkedList<T> linkedList = GetLinkedList(position);
            linkedList.AddLast(value);
        }
        //Step 1: Get slot number by %size
        public int GetArrayPosition(T key)
        {
            int position = Convert.ToInt32(key) % size;
            return (Math.Abs(position));

        }
        //Step 2: Get Linked List
        protected LinkedList<T> GetLinkedList(int position)
        {
            LinkedList<T> linkedList = item[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<T>();
                item[position] = linkedList;
            }
            return linkedList;
        }
        //method to display element in each slot
        public string Display()
        {
            string result = "";

            for (int i = 0; i < size; i++)
            {
                LinkedList<T> linkedList = item[i];
                if (linkedList == null)
                {
                    continue;
                }
                int count = 1;
                foreach (T value in linkedList)
                {
                    Console.WriteLine("Element {0} of index {1} in Hash Table is: {2}", count, i, value);
                    result = value.ToString() + " " + result;
                    count++;
                }

            }
            return result;
        }
        public int Search(T value)
        {
            int position = GetArrayPosition(value);
            LinkedList<T> linkedList = GetLinkedList(position);
            if (linkedList == null)
            {
                return -1;
            }
            else
            {
                int found = -1;
                foreach (T i in linkedList)
                {
                    if (i.Equals(value))
                    {
                        found = 1;
                    }
                }
                return found;
            }
        }
    }
}

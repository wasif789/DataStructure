using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructure
{
    class OrderedList<T>
    {
        static string[] myFile;
        public void GetInput()
        {
            //Read input from Text File
            myFile = File.ReadAllText(@"C:\Users\wsffa\c#_projects\DataStructure\NumberList.txt").Split(" ");

            //Create object for LinkedList Class
            CustomLinkedList<int> linkedList = new CustomLinkedList<int>();

            //Insert all file data to Linked List
            foreach (string element in myFile)
            {
                int number = Convert.ToInt32(element);
                linkedList.SortedInsertion(number);
            }
            linkedList.Display();

            //Enter element to be Searched
            Console.WriteLine("\nEnter the Element to be Searched");
            int searchElement = Convert.ToInt32(Console.ReadLine());
            if (linkedList.Search(searchElement))
            {
                linkedList.DeleteElement(searchElement);
                linkedList.Display();
            }
            else
            {
                linkedList.SortedInsertion(searchElement);
                linkedList.Display();
            }
            //Write back to File
            string StringValues = linkedList.ReturnToString();
            File.WriteAllText(@"C:\Users\wsffa\c#_projects\DataStructure\NumberList.txt", StringValues);
        }
    }
}

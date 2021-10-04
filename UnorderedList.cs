using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructure
{
    class UnorderedList<T>
    {
        static string[] myFile;
        public void GetInput()
        {
            //Read input from Text File
            myFile = File.ReadAllText(@"C:\Users\wsffa\c#_projects\DataStructure\WordFile.txt").Split(" ");

            //Create object for LinkedList Class
            CustomLinkedList<string> linkedList = new CustomLinkedList<string>();

            //Insert all file data to Linked List
            foreach (var element in myFile)
            {
                linkedList.InsertAtFront(element);
            }
            linkedList.Display();

            //Enter element to be Searched
            Console.WriteLine("\nEnter the Element to be Searched");
            string searchElement = Console.ReadLine();
            if (linkedList.Search(searchElement))
            {
                linkedList.Search(searchElement);
                linkedList.Display();
            }
            else
            {
                linkedList.InsertAtFront(searchElement);
                linkedList.Display();
            }

            //Write back to File
            string StringValues = linkedList.ReturnToString();
            File.WriteAllText(@"C:\Users\wsffa\c#_projects\DataStructure\WordFile.txt", StringValues);
        }
    }
}

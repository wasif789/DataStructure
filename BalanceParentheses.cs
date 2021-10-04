using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class BalanceParentheses<T>
    {
        Node<T> head;
        public void GetInput()
        {
            //Create object for LinkedList Class
            CustomLinkedList<char> customLinkedList = new CustomLinkedList<char>();

            //Get expression from user
            Console.WriteLine("Enter Arithmetic Expression");
            string expression = Console.ReadLine();

            //Push open parenthesis
            foreach (var element in expression)
            {
                if (element == '(')
                {
                    customLinkedList.InsertAtFront(element);
                }
                if (element == ')')
                {
                    customLinkedList.Pop();
                }
            }
            customLinkedList.Display();

            //Check whether stack is Empty
            if (customLinkedList.IsEmpty() == 0)
            {
                Console.WriteLine("Parentheses is Balanced!");
            }
            else
            {
                Console.WriteLine("Parentheses is not Balanced!");

            }
        }

    }
}

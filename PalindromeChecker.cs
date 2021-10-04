using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class PalindromeChecker<T>
    {
        public string palindrome;
        public void CheckPalindrome()
        {
            //Create object for Linked List Class
            CustomLinkedList<char> customLinkedList = new CustomLinkedList<char>();
            //Enter the Element to be Checked as Palindrome
            Console.WriteLine("Enter the string to be checked!");
            palindrome = Console.ReadLine();
            //Enqueue elements of string
            for (int i = 0; i < palindrome.Length; i++)
            {
                customLinkedList.Enqueue(palindrome[i]);
            }
            customLinkedList.Display();
            //Dequeue elements and store in a String
            string reverseWord = customLinkedList.DequeuePalindrome();
            if (palindrome == reverseWord)
            {
                Console.WriteLine("\n{0} is a Palindrome!", palindrome);
            }
            else
            {
                Console.WriteLine("\n{0} is not a Palindrome!", palindrome);

            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class PrimeNumbers<T>
    {

        public static int[,] AnagramNumbers = new int[10, 100];
        public static int[,] NotAnagramNumbers = new int[10, 100];
        public static List<int> PalindromeNumbers = new List<int>();
        public static int range = 0, index = 0, change = 0;
        public static int[,] primeNumbers = new int[10, 100];
        public static CustomLinkedList<int> customStack = new CustomLinkedList<int>();
        public static CustomLinkedList<int> customQueue = new CustomLinkedList<int>();

        //Check prime number from start-End range
        public static void PrimeChecker(int start, int end)
        {

            Console.WriteLine("\n---------------- Printing Prime Number in Range ({0} - {1}) ----------------", start, end);
            for (int i = start + 1; i <= end; i++)
            {
                if (i > 100)
                {
                    string temp = Convert.ToString(i);
                    char ind = temp[0];
                    range = Convert.ToInt32(ind) - 48;

                }
                //Change index to 0 for every range 0-100,101-200,201-300...
                if (change != range)
                {
                    index = 0;
                    change = range;
                }
                int flag = 0;
                for (int j = start; j < i; j++)
                {
                    if (i != 0 && i != 1 && j != 0 && j != 1 && (i % 2 == 0 || i % j == 0))
                    {
                        flag = 1;
                        break;
                    }
                }
                if (i != 1 && (flag != 1 || i == 2))
                {
                    primeNumbers[range, index] = i;
                    index++;
                }
            }
            //Extending Program to Store anagrams
            //Print prime numbers in range 0-100
            change = 0;
            for (int k = 0; k < 10; k++)
            {
                for (int l = 0; l < 100; l++)
                {
                    if (primeNumbers[k, l] != 0)
                    {
                        Console.WriteLine(primeNumbers[k, l]);

                        if (primeNumbers[k, l] > 100)
                        {
                            string tempVal = Convert.ToString(primeNumbers[k, l]);
                            char ind = tempVal[0];
                            range = Convert.ToInt32(ind) - 48;

                        }
                        //Change index to 0 for every range 0-100,101-200,201-300...
                        if (change != range)
                        {
                            index = 0;
                            change = range;
                        }
                        char[] temp = primeNumbers[k, l].ToString().ToCharArray();
                        Array.Sort(temp);
                        int SecondString = 0;
                        int firstString = Convert.ToInt32(String.Join("", temp));
                        int q;
                        for (q = l + 1; q < 100; q++)
                        {
                            char[] secondtemp = primeNumbers[k, q].ToString().ToCharArray();
                            Array.Sort(secondtemp);
                            SecondString = Convert.ToInt32(String.Join("", secondtemp));
                            if (firstString == SecondString)
                            {
                                break;
                            }
                        }
                        if (SecondString == firstString)
                        {
                            AnagramNumbers[range, index] = primeNumbers[k, l];
                            customStack.InsertAtFront(primeNumbers[k, l]);
                            customQueue.Enqueue(primeNumbers[k, l]);
                            index++;
                            AnagramNumbers[range, index] = primeNumbers[k, q];
                            index++;
                            customStack.InsertAtFront(primeNumbers[k, q]);
                            customQueue.Enqueue(primeNumbers[k, q]);

                        }
                    }
                }
            }


            Console.WriteLine("\n*************************************************************************************************");
            Console.WriteLine("                  DISPLAYING ANAGRAM STACK IN REVERSE ORDER in Range ({0} - {1})                   ", start, end);
            Console.WriteLine("*************************************************************************************************");
            //Program 10: Display Anagrams in reverse order using stack
            customStack.Display();


            Console.WriteLine("\n*************************************************************************************************");
            Console.WriteLine("                  DISPLAYING ANAGRAM USING QUEUE in Range ({0} - {1})                   ", start, end);
            Console.WriteLine("*************************************************************************************************");
            //Program 11: Display Anagrams in Queue
            customQueue.Display();



            Console.WriteLine("\n---------------- Printing Anagram Array in Range ({0} - {1}) ----------------", start, end);
            //Print Array having anagram
            for (int k = 0; k < 10; k++)
            {
                for (int l = 0; l < 100; l++)
                {
                    if (AnagramNumbers[k, l] != 0)
                    {
                        Console.WriteLine(AnagramNumbers[k, l]);
                    }

                }
            }
            Console.WriteLine("\n---------------- Printing Non-Anagram Array in Range ({0} - {1}) ----------------", start, end);
            //Print Array having anagram
            int check = 0; ;
            for (int k = 0; k < 10; k++)
            {
                for (int l = 0; l < 100; l++)
                {
                    check = 0;
                    if (primeNumbers[k, l] != 0)
                    {
                        for (int p = 0; p < 10; p++)
                        {
                            for (int m = 0; m < 100; m++)
                            {

                                if (primeNumbers[k, l] == AnagramNumbers[p, m])
                                {
                                    check = 1;
                                    break;
                                }
                            }
                            if (check == 1)
                            {
                                break;
                            }
                        }
                        if (check == 0)
                        {
                            NotAnagramNumbers[k, l] = primeNumbers[k, l];
                            Console.WriteLine(NotAnagramNumbers[k, l]);
                        }

                    }
                }
            }
        }

    }
}

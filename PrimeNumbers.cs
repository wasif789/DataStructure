using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class PrimeNumbers
    {

        public static List<int> AnagramNumbers = new List<int>();
        public static List<int> PalindromeNumbers = new List<int>();
        public static int range = 0, index = 0, change = 0;

        //Check prime number from start-End range
        public static void PrimeChecker(int start, int end)
        {
            int[,] primeNumbers = new int[10, 100];
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

            //Print prime numbers in range 0-100
            for (int k = 0; k < 10; k++)
            {
                for (int l = 0; l < 100; l++)
                {
                    if (primeNumbers[k, l] != 0)
                    {
                        Console.WriteLine(primeNumbers[k, l]);
                    }
                }
            }

        }
    }
}

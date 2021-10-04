using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class NumberOfBST
    {
        //Formula: t(n) = \sum_{i=1}^{n} t(i-1) t(n-i)  
        //t(0) = 1 and t(1) = 1
        //t(2) = t(0)t(1) + t(1)t(0) = 2  
        public int NumberOfTree(int n)
        {
            if (n <= 1) return 1;

            int sum = 0;
            int left = 0, right = 0;

            for (int i = 1; i <= n; i++)
            {
                left = NumberOfTree(i - 1);
                right = NumberOfTree(n - i);
                sum += (left * right);
            }
            return sum;
        }
    }
}

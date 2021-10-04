using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace DataStructure
{
    class NumberOfBST
    {
        //Formula: t(n) = \sum_{i=1}^{n} t(i-1) t(n-i)  
        //t(0) = 1 and t(1) = 1
        //t(2) = t(0)t(1) + t(1)t(0) = 2  

        public BigInteger NumberOfTree(BigInteger n)
        {
            if (n <= 1) return 1;
            BigInteger sum = 0;

            for (int i = 1; i <= n; i++)
            {
                BigInteger left = NumberOfTree(i - 1) % 100000007;
                BigInteger right = NumberOfTree(n - i) % 100000007;
                sum = (sum + (left * right)) % 100000007;
            }
            return sum;
        }
    }
}

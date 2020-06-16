using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二章算法分析
{
    public static class 时间复杂度为logN的三个例子_对分查找_最大公约数欧几里得_幂运算_
    {

        //对分查找：给定一个整数X和整数A0，A1...AN-1,后者已经预先排序并在内存中，求X在A中的下标i，如果X不在序列内，返回-1
        public static int BinarySearch(int[] A, int x, int n)
        {
            int left, right, mid;
            left = 0; right = n - 1;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (x > A[mid])
                {
                    left = mid + 1;
                }
                else if (x < A[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
        //求最大公约数，欧几里得算法，辗转相处
        public static int Gcd(int m, int n)
        {
            int rem = 0;
            while (n > 0)
            {
                rem = m % n;
                m = n;
                n = rem;
            }
            return rem;

        }
        //幂运算
        public static long Pow(long x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n == 1)
            {
                return x;
            }
            if (x % 2 == 0)
            {
                return Pow(x * x, n / 2);
            }
            else
            {
                return Pow(x * x, n / 2) * x;
            }
        }
    }
}

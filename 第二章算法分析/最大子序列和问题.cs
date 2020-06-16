using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二章算法分析
{
    //
    public static class 最大子序列和问题
    {
        public static int funn1(int[] A, int n)
        {
            int MaxNum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    int max = 0;
                    for (int l = i; l <= j; l++)
                    {
                        max += A[l];
                    }
                    if (max > MaxNum)
                    {
                        MaxNum = max;
                    }
                }
            }
            return MaxNum;
        }
        public static int func2(int[] A, int n)
        {
            return func2_MaxSubSum(A, 0, A.Length - 1);
        }

        private static int func2_MaxSubSum(int[] a, int left, int right)
        {
            int leftMax = 0;
            int rightMax = 0;
            int leftBorderMax = 0;
            int rightBorderMax = 0;
            int leftBorderSum = 0;
            int rightBorderSum = 0;
            if (left == right)
            {
                if (left > 0)
                    return left;
                else
                    return 0;
            }
            int center = (left + right) / 2;
            leftMax = func2_MaxSubSum(a, left, center);
            rightMax = func2_MaxSubSum(a, center + 1, right);


            for (int i = center; i >= left; i--)
            {
                leftBorderSum += a[i];
                if (leftBorderSum > leftBorderMax)
                {
                    leftBorderMax = leftBorderSum;
                }
            }

            for (int i = center + 1; i <= right; i++)
            {
                rightBorderSum += a[i];
                if (rightBorderSum > rightBorderMax)
                    rightBorderMax = rightBorderSum;
            }
            return func2_max3(leftMax, rightMax, leftBorderMax + rightBorderMax);
        }
        private static int func2_max3(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c)
                {
                    return a;
                }
                else
                {
                    return c;
                }
            }
            else
            {
                if (b > c)
                    return b;
                else
                    return c;
            }
        }

        public static int func3(int[] A, int n)
        {
            int maxSum = 0;
            int timeSum = 0;
            for (int i = 0; i < n; i++)
            {
                timeSum += A[i];
                if (timeSum > maxSum)
                {
                    maxSum = timeSum;
                }
                else if (timeSum < 0)
                {
                    timeSum = 0;
                }
            }
            return maxSum;
        }
    }
}

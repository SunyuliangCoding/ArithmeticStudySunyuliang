using System;

namespace 二分查找
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new int[] { 8, 11, 23, 45, 52, 223, 445, 674, 2211 };


            var newNumbers = new int[] { 1, 3, 4, 5, 6, 8, 8, 8, 23, 567 };
            //  Console.WriteLine(Search(numbers, 52));
            Console.WriteLine(SearchMax(newNumbers, 21));
            Console.ReadKey();

        }
        //求平方根，6位小数
        public static double Getsquare(double x)
        {
            double start = 0; double end = x;
            double mid = 0;
            int index = 0;
            while (index < 6)
            {
                mid = (start + end) / 2;
                if (mid * mid == x)
                {
                    return mid;
                }
                else if (mid * mid > x)
                {
                    end = mid;
                }
                else
                {
                    start = mid;
                }

                index = mid.ToString().IndexOf('.');
                index = mid.ToString().Length - 1 - index;
            }
            return mid;
        }
        //普通二分查找
        public static int Search(int[] numbers, int find)
        {
            int start = 0;
            int end = numbers.Length - 1;
            int mid = 0;
            while (start <= end)
            {
                mid = (start + end) / 2;
                if (numbers[mid] == find)
                {
                    return mid;
                }
                if (mid > find)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return mid;
        }

        //二分查找的变形体

        //查找第一个8的位置
        public static int SearchFirstEqual(int[] numbers, int x)
        {
            int start = 0;
            int end = numbers.Length - 1;
            int mid = -1;
            while (start <= end)
            {
                mid = (start + end) / 2;
                if (numbers[mid] > x)
                {
                    end = mid - 1;
                }
                else if (numbers[mid] < x)
                {
                    start = mid + 1;
                }
                else
                {
                    if (mid == 0 || numbers[mid - 1] == x)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        return mid;
                    }
                }
            }
            return -1;

        }
        //查找最后一个8的位置
        public static int SearchEndEqual(int[] numbers, int x)
        {
            int start = 0;
            int end = numbers.Length - 1;
            int mid = -1;
            while (start <= end)
            {
                mid = (start + end) / 2;
                if (numbers[mid] > x)
                {
                    end = mid;
                }
                else if (numbers[mid] < x)
                {
                    start = mid;
                }
                else
                {
                    if (mid == numbers.Length - 1 || numbers[mid + 1] != x)
                    {
                        return mid;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
            }
            return -1;
        }

        //查找第一个大于等于给定值
        public static int SearchMax(int[] numbers, int x)
        {
            int start = 0;
            int end = numbers.Length - 1;

            int mid = -1;
            while (start<=end)
            {
                mid = (start + end) / 2;

                if (numbers[mid]<x)
                {
                    start = mid + 1;
                }
                else
                {
                    if (mid==0||numbers[mid-1]<x)
                    {
                        return mid;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
            }
            return -1;
        }
    }
}

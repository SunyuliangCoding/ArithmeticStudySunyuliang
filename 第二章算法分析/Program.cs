using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二章算法分析
{
    class Program
    {
        static void Main(string[] args)
        {
            //func1();
            //func2();
            //func3();
            //func4();
            基数排序.Run_Radix_Sort();

            Console.ReadKey();
        }
        static void func2()
        {
            int[] a = { -4,-3,-2,0,3,4,5,6,7};
            Console.WriteLine(时间复杂度为logN的三个例子_对分查找_最大公约数欧几里得_幂运算_.BinarySearch(a,5,a.Length));
        }
        static void func3()
        {
            Console.WriteLine(时间复杂度为logN的三个例子_对分查找_最大公约数欧几里得_幂运算_.Gcd(50,15));
        }
        static void func4() {
            Console.WriteLine(时间复杂度为logN的三个例子_对分查找_最大公约数欧几里得_幂运算_.Pow(2, 16));
        }
        //最大自序和问题
        static void func1()
        {
            Stopwatch myWatch = new Stopwatch();
            myWatch.Start();
            int[] A = { 4, -3, 5, -2, -1, 2, 6, -2 };
            int result = 0;


            //result = 最大子序列和问题.funn1(A, A.Length);
            result = 最大子序列和问题.func3(A, A.Length);


            Console.WriteLine("结果为" + result.ToString());
            myWatch.Stop();
            long myUseTime = myWatch.ElapsedMilliseconds;
            Console.WriteLine("方法一執行時間: " + myUseTime.ToString() + " ms");
         
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一章引论
{
    class Program
    {
        static void Main(string[] args)
        {
            ChooseQuestion();
            Console.ReadKey();
        }
        //说明:编写一个程序解决选择问题，令K=N/2。画出表格显示你的程序对于n为不同值的运行时间
        //选择问题:从一个未排序的整数数组中选取第i大的整数出来。
        public static void ChooseQuestion()
        {
            Stopwatch myWatch = new Stopwatch();
         
            int[] n = { 10,100,1000,10000,100000};
            for (int i = 0; i < n.Length; i++)
            {
                int[] nums = new int[n[i]];
                Random r = new Random();
                for (int j = 0; j < n[i]; j++)
                {
                    nums[j] = r.Next(-10000, 10000);
                }
                myWatch.Start();
                func1(nums);
                myWatch.Stop();
                long myUseTime = myWatch.ElapsedMilliseconds;
                Console.WriteLine("方法一執行時間: " + myUseTime.ToString() + " ms");
                myWatch.Restart();
                func2(nums);
                myWatch.Stop();
                myUseTime = myWatch.ElapsedMilliseconds;
                Console.WriteLine("方法二執行時間: " + myUseTime.ToString() + " ms");
            }
        }
        public static int func2(int[] nums)
        {
            int k = nums.Length / 2;
            int[] newNums = new int[k];
            for (int i = 0; i < k; i++)
            {
                newNums[i] = nums[i];
            }
            for (int i = 0; i < k; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (newNums[j] > newNums[j - 1])
                    {
                        int x = newNums[j - 1];
                        newNums[j - 1] = newNums[j];
                        newNums[j] = x;
                    }
                }
            }
            for (int i = k; i < nums.Length; i++)
            {
                if (nums[i] < newNums[k - 1])
                {
                    continue;
                }
                else
                {
                    for (int j = 0; j < newNums.Length ; j++)
                    {
                        if (nums[i] > newNums[j])
                        {
                            for (int l = newNums.Length - 1; l > j; l--)
                            {
                                newNums[l] = newNums[l- 1];
                            }
                            newNums[j] = nums[i];
                            break;
                        }
                    }
                }
            }
            return newNums[k - 1];
        }
        public static int func1(int[] nums)
        {
            int k = nums.Length / 2;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (nums[j] > nums[j - 1])
                    {
                        int x = nums[j - 1];
                        nums[j - 1] = nums[j];
                        nums[j] = x;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return nums[k - 1];
        }
    }
}

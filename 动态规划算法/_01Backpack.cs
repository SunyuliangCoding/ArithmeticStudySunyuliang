/**************************************************************************      
项    目:        动态规划算法
作    者:        SYL syl
创建时间:        2019/1/3 11:15:30
Copyright (c)    北京迪威特科技有限公司

描    述：
***************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace 动态规划算法
{
    public class _01Backpack
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="weight">物品重量列表</param>
        /// <param name="n">物品个数</param>
        /// <param name="w">背包能承担的最大重量</param>
        /// <returns></returns>
        public int SortPackage(int[] weight, int n, int w)
        {
            bool[,] c = new bool[n, w + 1];

            //第一个要单独处理，因为后面要和前一个物品的结果做比较
            c[0, 0] = true;
            c[0, weight[0]] = true;

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < w + 1; j++)
                {
                    //不放入背包
                    if (c[i - 1, j])
                    {
                        c[i, j] = c[i - 1, j];
                    }
                }
                for (int j = 0; j <= w - weight[i]; j++)
                {
                    //放入背包
                    if (c[i - 1, j])
                    {
                        c[i, j + weight[i]] = c[i - 1, j];
                    }
                }
            }
            var max = 0;
            //找出最大值
            for (int i = 0; i < w + 1; i++)
            {
                if (c[n - 1, i])
                {
                    max = i;
                }
            }

            return max;
        }

        //使用一维布尔数组 存储动态规划中的状态
        public int SortPackage_1(int[] weight, int n, int w)
        {
            bool[] c = new bool[w + 1];
            c[0] = true;
            c[weight[0]] = true;

            for (int i = 1; i < n; i++)
            {
                for (int j = w - weight[i]; j >= 0; j--)
                {
                    if (c[j])
                    {
                        c[j + weight[i]] = true;
                    }
                }
            }
            var max = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i])
                {
                    max = i;
                }
            }
            return max;

        }


        /// <summary>
        /// 有价值的0-1背包,要求在最大重量中找出最大价值
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="values"></param>
        /// <param name="n"></param>
        /// <param name="w"></param>
        public void SortPackageValue(int[] weight, int[] values, int n, int w)
        {
            int[,] states = new int[n, w + 1];
            //初始化状态数组
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < w + 1; j++)
                {
                    states[i, j] = -1;
                }
            }
            //初始化第0件物品
            states[0, 0] = 0;
            states[0, weight[0]] = values[0];

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < w + 1; j++)
                {
                    if (states[i - 1, j] >= 0)
                    {
                        states[i, j] = states[i - 1, j];//不放入此物品
                    }
                }

                for (int j = 0; j <= w - weight[i]; j++)
                {
                    if (states[i - 1, j] >= 0)
                    {
                        var value = states[i - 1, j] + weight[i];
                        if (value> states[i, j + weight[i]])
                        {
                            states[i, j + weight[i]]= value; //放入此物品
                        }
                        
                    }
                }
                for (int p = 0; p < n; p++)
                {
                    for (int j = 0; j < w + 1; j++)
                    {
                        Console.Write(states[p, j] + " ");
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine("===================");

            }

            //筛选最大结果
            var maxValue = 0;
            var maxWeight = 0;
            for (int i = 0; i < w + 1; i++)
            {
                if (i > maxWeight && states[n - 1, i] > 0)
                {
                    maxWeight = i;
                    maxValue = states[n - 1, i];
                }
                else if (i == maxWeight && states[n - 1, i] > maxWeight)
                {
                    maxValue = states[n - 1, i];
                }

            }

            Console.WriteLine($"最大重量为：{maxWeight}==最大价值为：{maxValue}");
        }
    }
}

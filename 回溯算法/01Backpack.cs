using System;
using System.Collections.Generic;
using System.Text;

namespace 回溯算法
{
    //01背包问题
    public class _01Backpack
    {
        public int maxW { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i">当前物品索引</param>
        /// <param name="cw">currentWeight 当前重量</param>
        /// <param name="items">物品列表</param>
        /// <param name="n">物品列表长度</param>
        /// <param name="w">背包可以接受的最大重量</param>
        public void f(int i, int cw, int[] items, int n, int w)
        {
            if (cw == w || i == n)
            {
                if (cw > maxW)
                {
                    maxW = cw;
                }
                return;
            }
            f(i + 1, cw, items, n, w);
            if (cw + items[i] <= w)
            {
                f(i + 1, cw + items[i], items, n, w);
            }

        }

        //回溯算法，带价值的01背包问题
        
    }
}

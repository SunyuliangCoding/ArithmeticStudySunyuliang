/**************************************************************************      
项    目:        动态规划算法
作    者:        SYL syl
创建时间:        2019/1/8 11:07:52
Copyright (c)    北京迪威特科技有限公司

描    述：
***************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace 动态规划算法
{
    public class LevenshteinDistance
    {
        //莱文斯坦距离
        //编辑距离指的就是，将一个字符串转化成另一个字符串，需要的最少编辑操作次数（比如增加一个字符、删除一个字符、替换一个字符）。编辑距离越大，说明两个字符串的相似程度越小；相反，编辑距离就越小，说明两个字符串的相似程度越大。对于两个完全相同的字符串来说，编辑距离就是 0。

        //莱文斯坦距离允许-》增加、删除、替换 这三个操作


        public char[] a = "mitcmu".ToCharArray();
        public char[] b = "mtacnu".ToCharArray();

        public int MinDis = int.MaxValue;
        //递归算法
        public void GetLevenshtein(int i, int j, int cDis)
        {
            if (i == a.Length || j == b.Length)
            {
                if (i < a.Length)
                {
                    cDis += a.Length - i;
                }
                if (j < b.Length)
                {
                    cDis += b.Length - j;
                }
                if (cDis < MinDis)
                {
                    MinDis = cDis;
                }
                //递归一定要有返回
                return;
            }

            if (a[i] == b[j])
            {
                GetLevenshtein(i + 1, j + 1, cDis);
            }
            else
            {
                GetLevenshtein(i + 1, j, cDis + 1);
                GetLevenshtein(i, j + 1, cDis + 1);
                GetLevenshtein(i + 1, j + 1, cDis + 1);
            }
        }
        //动态规划版本
        /* 状态转移方程为：
         * if(a[i]==b[j]) 
         * {
         *      min(GetLevenshtein(i-1,j,minDis)+1,GetLevenshtein(i,j-1,minDis)+1,GetLevenshetein(i-1,j-1,minDis))
         * }
         * else if(a[i]!=b[i])
         * {
         *      min(GetLevenshtein(i-1,j,minDis+1,GetLevenshtein(i,j-1,minDis)+1,GetLevenshetein(i-1,j-1,minDis)+1)
         * }
         */
        public int GetLevenshtein(char[] a, char[] b)
        {
            int[,] minDist = new int[a.Length, b.Length];

            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == a[0])
                {
                    minDist[0, i] = i;
                }
                else if (i != 0)
                {
                    minDist[0, i] = minDist[0, i - 1] + 1;
                }
                else
                {
                    minDist[0, 0] = 1;
                }
            }

            for (int j = 0; j < a.Length; j++)
            {
                if (a[j] == b[0])
                {
                    minDist[j, 0] = j;
                }
                else if (j != 0)
                {
                    minDist[j, 0] = minDist[j - 1, 0] + 1;
                }
                else
                {
                    minDist[0, 0] = 1;
                }
            }

            for (int i = 1; i < a.Length; i++)
            {
                for (int j = 1; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        minDist[i, j] = Min(minDist[i - 1, j] + 1, minDist[i, j - 1] + 1, minDist[i - 1, j - 1]);
                    }
                    else
                    {
                        minDist[i, j] = Min(minDist[i - 1, j] + 1, minDist[i, j - 1] + 1, minDist[i - 1, j - 1] + 1);
                    }
                }
            }
            return minDist[a.Length - 1, b.Length - 1];
        }
        private int Min(int a, int b, int c)
        {
            var min = int.MaxValue;
            if (a < min)
            {
                min = a;
            }
            if (b < min) min = b;
            if (c < min) min = c;
            return min;
        }
    }
}

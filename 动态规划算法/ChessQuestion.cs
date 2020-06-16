/**************************************************************************      
项    目:        动态规划算法
作    者:        SYL syl
创建时间:        2019/1/4 16:01:00
Copyright (c)    北京迪威特科技有限公司

描    述：
***************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace 动态规划算法
{
    //棋盘最短路径问题
    // min_dist(i, j) = w[i][j] + min(min_dist(i, j-1), min_dist(i-1, j))

   //状态转移表法的实现，如果有了递推公式，也叫迭代递推实现方式
    public class ChessQuestion
    {

        public int MinDist(int[,] board, int n)
        {
            int[,] states = new int[n, n];
            states[0, 0] = board[0, 0];

            for (int i = 1; i < n; i++)
            {
                states[0, i] = states[0, i - 1] + board[0, i];
                states[i, 0] = states[i - 1, 0] + board[i, 0];
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    states[i, j] = Math.Min(states[i - 1, j], states[i, j - 1]) + board[i, j];

                }
            }


            return states[n - 1, n - 1];
        }
    }
}

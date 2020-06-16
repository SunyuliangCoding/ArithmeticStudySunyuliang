/**************************************************************************      
项    目:        回溯算法
作    者:        SYL syl
创建时间:        2019/1/4 10:40:15
Copyright (c)    北京迪威特科技有限公司

描    述：
***************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace 回溯算法
{
    //走棋问题

    public class ChessQuestion
    {


        public int Dist = 0;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="board"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public void MinDist(int a, int b, int[,] board, int n, int cDist)
        {

            if (a == n - 1 && b == n - 1)
            {
                if (cDist + board[a, b] < Dist || Dist == 0)
                {
                    Dist = cDist + board[a, b];
                }


                return;
            }
            else
            {
                cDist += board[a, b];
            }
            //向右            
            if (a < n - 1)
            {
                MinDist(a + 1, b, board, n, cDist);
            }
            //向下
            if (b < n - 1)
            {
                MinDist(a, b + 1, board, n, cDist);
            }

        }

    }
}

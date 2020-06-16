using System;
using System.Collections.Generic;
using System.Text;

namespace 回溯算法
{
    //八皇后问题
    /*
     我们有一个 8x8 的棋盘，希望往里放 8 个棋子（皇后），每个棋子所在的行、列、对角线都不能有另一个棋子。你可以看我画的图，第一幅图是满足条件的一种方法，第二幅图是不满足条件的。八皇后问题就是期望找到所有满足这种要求的放棋子方式。
         */
    public class EightQueens
    {
        //当前皇后的排列
        public int[] queesSquence = new int[8];
        public int length = 0;

        public void PrintQuees()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (queesSquence.Length > i && queesSquence[i] == j)
                    {
                        Console.Write("q ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine("");
            }

        }

        public bool CheckQuees(int row, int column)
        {
            if (row == 0)
            {
                return true;
            }
            for (int i = 0; i < row; i++)
            {
                //行列判断
                if (row == i || column == queesSquence[i])
                {
                    return false;
                }
                if ((row - i) == (column - queesSquence[i]) || (row + column) == i + queesSquence[i])
                {
                    return false;
                }
            }
            return true;
        }

        public void EightQueensSort(int row)
        {
            if (row == 8)
            {
                PrintQuees();
                Console.WriteLine("=============================");
                return;
            }
            for (int i = 0; i < 8; i++)
            {
                if (CheckQuees(row, i))
                {
                    queesSquence[row] = i;
                    EightQueensSort(row + 1);
                }
            }
        }
    }
}

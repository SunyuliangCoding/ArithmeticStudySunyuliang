using System;

namespace 回溯算法
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 01背包问题
            //var items = new int[] { 2,4,6,8,12};

            //_01Backpack back = new _01Backpack();
            //back.f(0, 0, items, items.Length, 19);
            //Console.WriteLine(back.maxW);
            #endregion

            #region 八皇后问题
            //var testQueen = new int[] { 0,4,7,5};

            //EightQueens eightQueens = new EightQueens();

            //eightQueens.EightQueensSort(0);
            ////eightQueens.PrintQuees();
            //Console.WriteLine("ok");



            #endregion

            #region  棋盘最短路径
            int[,] checkerboard = new int[4, 4] { { 1, 3, 5, 7 }, { 2, 1, 3, 4 }, { 5, 2, 6, 7 }, { 6, 8, 4, 3 } };
            ChessQuestion chessQuestion = new ChessQuestion();
            chessQuestion.MinDist(0, 0, checkerboard, 4, 0);
            Console.WriteLine(chessQuestion.Dist);
            #endregion
            Console.ReadKey();
        }
    }
}

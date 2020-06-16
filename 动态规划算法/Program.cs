using System;

namespace 动态规划算法
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 两个背包问题
            //var item = new int[] { 2, 4, 6, 8, 12 };
            //var values = new int[] { 1, 2, 3, 9, 5 };
            //_01Backpack backpack = new _01Backpack();
            ////   var result = backpack.SortPackage_1(item, 5, 11);

            //backpack.SortPackageValue(item, values, item.Length, 12);
            #endregion

            #region 棋盘最短路径问题
            //ChessQuestion chessQuestion = new ChessQuestion();
            //int[,] checkerboard = new int[4, 4] { { 1, 3, 5, 7 }, { 2, 1, 3, 4 }, { 5, 2, 6, 7 }, { 6, 8, 4, 3 } };
            //var result=chessQuestion.MinDist(checkerboard, 4);
            //Console.WriteLine(result);
            #endregion

            #region 硬币找零问题
            //CoinQuestion coinQuestion = new CoinQuestion();
            //var coins =new int[] { 1,3,5};
            //Console.WriteLine(coinQuestion.CoinChange(coins,3,9));
            #endregion

            LevenshteinDistance distance = new LevenshteinDistance();
            //distance.GetLevenshtein(0, 0, 0);
            //Console.WriteLine(distance.MinDis);
            char[] a = "mitcmu".ToCharArray();
            char[] b = "mtacnu".ToCharArray();

            Console.WriteLine(distance.GetLevenshtein(a, b));

            Console.ReadKey();
        }
    }
}

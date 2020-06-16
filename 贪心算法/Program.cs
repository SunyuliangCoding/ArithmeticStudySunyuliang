using System;

namespace 贪心算法
{
    class Program
    {
        static void Main(string[] args)
        {
            var ratings = new int[]{1,2,2,3,2,3,4,3 };
            Console.WriteLine(candy(ratings));
            Console.ReadKey();
        }

        //        有 N 个小孩站成一列。每个小孩有一个评级。

        //按照以下要求，给小孩分糖果：

        //    每个小孩至少得到一颗糖果。

        //    评级越高的小孩可以比他相邻的两个小孩得到更多的糖果。

        //需最少准备多少糖果？
        //样例

        //给定评级 = [1, 2], 返回 3.

        //给定评级 = [1, 1, 1], 返回 3.

        //给定评级 = [1, 2, 2], 返回 4. ([1, 2, 1]).

        public static int candy(int[] ratings)
        {
            var candies = new int[ratings.Length];
            for (int i = 0; i < candies.Length; i++)
            {
                candies[i] = 1;
            }
            for (int i = 0; i < ratings.Length-1; i++)
            {
                if (ratings[i + 1] > ratings[i])
                {
                    candies[i + 1] = candies[i] + 1;
                }
            }
            for (int i = ratings.Length-1; i > 0; i--)
            {
                if (ratings[i - 1] > ratings[i])
                {
                    ratings[i - 1] = candies[i] + 1;
                }
            }
            var sum = 0;
            foreach (var item in candies)
            {
                sum = sum + item;
                Console.Write(item + ",");
            }
            return sum;
        }

    }
}

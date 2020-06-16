using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace 第二章算法分析
{
    public static class 基数排序
    {
        public static void Run_Radix_Sort()
        {
            var list = new List<int>() { 0, 1, 512, 343, 64, 125, 216, 27, 8, 729 };
            var result = Radix_Sort(list);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }

        public static List<int> Radix_Sort(List<int> numbers)
        {
            List<List<int>> buckets = new List<List<int>>();
            var n = 0;
            while (n < 10)
            {
                buckets.Add(new List<int>());
                n++;
            }
            var max = 0;
            foreach (var item in numbers)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            for (int i = 1; i <= max.ToString().Length; i++)
            {
                Radic(buckets, i);
            }
            var list = new List<int>();
            foreach (var item in buckets)
            {
                list.AddRange(item);
            }
            return list;
        }
        public static List<List<int>> Radic(List<List<int>> buckets, int n)
        {
            var num = (int)Math.Pow(10, (double)n-1);
            for (int i = 0; i < buckets.Count; i++)
            {
                var x = new int[buckets[i].Count];
                buckets[i].CopyTo(x);
                buckets[i].Clear();
                foreach (var item in x)
                {
                    var len = n.ToString().Length;
                    // 获取第n位数字
                    var number = n;
                    buckets[number].Add(item);
                }
            }
            return buckets;

        }

    }
}

using System;
using System.Collections.Generic;
using 基本数据结构;

namespace 排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 0, 2, 5, 3, 4, 7, 1, 9, 6 };

            // SelectSort(numbers);
            //QuickSort(numbers, 0, numbers.Length - 1);
            HeapSort(numbers);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadKey();
        }
        //堆排序
        private static void HeapSort(int[] numbers)
        {
            Heap p = new Heap(numbers, true);
            var newNumbers = new List<int>();
            while (true)
            {
                if (p.GetCount() == 0)
                {
                    break;
                }
                //    var data = p.Delete();
                var data = p.NewDelete();
                newNumbers.Add(data);
            }
            foreach (var item in newNumbers)
            {
                Console.WriteLine(item);
            }

        }
        private static void insertSort(int[] numbers)
        {
            if (numbers.Length <= 1)
            {
                return;
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                int value = numbers[i];
                var j = i - 1;
                for (; j >= 0; j--)
                {
                    if (numbers[j] > value)
                    {
                        numbers[j + 1] = numbers[j];
                    }
                    else
                    {
                        break;
                    }
                }
                numbers[j + 1] = value;

            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }


        private static void SelectSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int min = numbers[i];
                int j = i;
                int index = -1;
                for (; j < numbers.Length; j++)
                {
                    if (min > numbers[j])
                    {
                        min = numbers[j];
                        index = j;
                    }
                }
                if (index > -1)
                {
                    int value = numbers[i];
                    numbers[i] = numbers[index];
                    numbers[index] = value;
                }


            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        //冒泡排序
        private static void bubbleSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                var sign = true;
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        var a = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = a;
                        sign = false;
                    }
                }
                if (sign)
                {
                    break;
                }
            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        //归并排序
        private static void MergeSort(int[] numbers, int p, int r)
        {
            if (p >= r)
            {
                return;
            }
            var q = (p + r) / 2;
            MergeSort(numbers, p, q);
            MergeSort(numbers, q + 1, r);

            Sort(new Index() { StartIndex = p, EndIndex = q }, new Index { StartIndex = q + 1, EndIndex = r }, numbers);
        }

        private static void Sort(Index pq, Index qAdd1r, int[] numbers)
        {
            //临时数组
            int[] tmp = new int[qAdd1r.EndIndex - pq.StartIndex];

            var i = pq.StartIndex;
            var j = qAdd1r.StartIndex;
            var k = 0;
            while (i <= pq.EndIndex && j <= qAdd1r.EndIndex)
            {
                if (numbers[i] < numbers[j])
                {
                    tmp[k] = numbers[i];
                    k++;
                    i++;
                }
                else
                {
                    tmp[k] = numbers[j];
                    k++;
                    j++;
                }
            }
            if (j <= i)
            {
                var start = j;
                var end = i;
                while (start <= end)
                {
                    tmp[k] = numbers[start];
                    k++; start++;
                }
            }
            for (int x = 0; x < qAdd1r.EndIndex - pq.StartIndex; x++)
            {
                numbers[pq.StartIndex + x] = tmp[x];
            }
        }


        private static void QuickSort(int[] numbers, int p, int r)
        {
            if (p >= r)
            {
                return;
            }
            var q = partition(numbers, p, r);
            QuickSort(numbers, p, q - 1);
            QuickSort(numbers, q + 1, r);
        }
        //获取分区点，并且把小的转移到左边，大的转移到右边
        private static int partition(int[] numbers, int p, int r)
        {
            var pivot = numbers[r];
            int i = p, j = p;
            for (; j < r; j++)
            {
                if (numbers[j] < pivot)
                {
                    var smp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = smp;
                    i++;
                }
            }
            numbers[r] = numbers[i];
            numbers[i] = pivot;



            return i;
        }
    }
    public struct Index
    {
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
    }
}

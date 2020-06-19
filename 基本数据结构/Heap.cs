using System;
using System.Collections.Generic;
using System.Text;

namespace 基本数据结构
{
    public class Heap
    {

        private int[] a;
        private int count;

        public Heap(int capacity)
        {
            this.a = new int[capacity + 1];
            this.count = 0;
        }
        public Heap(int[] data)
        {
            this.a = data;
            this.count = data.Length;
        }
        public void insert(int data)
        {
            //扩容
            if (count==a.Length-1)
            {
                expansion(this.a);
            }
            var index = count +1;
            var currentData = 0;
            while (index%2>0)
            {
                index = index % 2;
                if (true)
                {

                }
            }
        }
        private void expansion(int[] source)
        {
            var newIntList =new int[ source.Length * 2];
            for (int i = 0; i < source.Length; i++)
            {
                newIntList[i] = source[i];
            }
        }
        public void print(int index = 1, int layerCount = 0)
        {
            if (a.Length <= 1)
            {
                Console.WriteLine("heap is empty");
                return;
            }
            var currentLayerCount = Math.Pow(2, layerCount);
            var str = string.Empty;
            for (int i = 0; i < currentLayerCount; i++)
            {
                if (index + i > a.Length - 1)
                {
                    break;
                }
                str += a[index + i] + " ";
            }
            Console.WriteLine(str);
            if (a.Length - 1 > index - 1 + currentLayerCount)
            {
                Console.WriteLine();
                layerCount++;
                print((int)(index + currentLayerCount), layerCount);
            }
        }
    }
}

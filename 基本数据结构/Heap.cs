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
        public int GetCount()
        {
            return this.count-1;
        }
        //堆初始化
        //遗留一个问题，这个堆化算法有问题，子节点不一定比页大，虽然堆顶是最大的
        public Heap(int[] data, bool needInit)
        {
            this.a = data;
            this.count = data.Length;
            for (int i = count / 2; i >= 1; i--)
            {
                percolateDown(i);
                this.print();
            }
            this.print();
        }
        //下滤，递归
        private void percolateDown(int index)
        {
            //判断是否有子节点
            var maxIndex = index * 2;
            if (index * 2 + 1 <= count - 1 && a[index * 2 + 1] > a[index * 2])
            {
                maxIndex = index * 2 + 1;
            }
            if (a[maxIndex] > a[index])
            {
                var min = a[index];
                a[index] = a[maxIndex];
                a[maxIndex] = min;
            }
            if (maxIndex * 2 <= count - 1)
            {
                percolateDown(maxIndex);
            }
        }


        //插入
        public void insert(int data)
        {
            //扩容
            if (count == a.Length)
            {
                expansion(this.a);
            }
            var index = count;
            while (index / 2 > 0)
            {
                //   index = index % 2;
                if (data > a[index / 2])
                {
                    a[index] = a[index / 2];
                    index = index / 2;
                }
                else
                {
                    break;
                }
            }
            //没有必要一直交换，空位置最后到哪，数据就放在哪
            a[index] = data;
            this.print();
        }
        //删除堆顶的元素
        public int Delete()
        {
            var indexData = a[1];
            var lastData = a[count - 1];
            a[count - 1] = 0;
            count--;
            var index = 1;

            while (index * 2 <= count - 1)
            {
                var biggerIndex = a[index * 2] > a[index * 2 + 1] ? index * 2 : index * 2 + 1;
                a[index] = a[biggerIndex];
                index = biggerIndex;
            }
            a[index] = lastData;
            this.print();
            return indexData;

        }
        public int NewDelete()
        {
            var indexData = a[1];
            var lastData = a[count - 1];
            a[1] = lastData;
            a[count - 1] = 0;
            count--;
            percolateDown(1);
            return indexData;
        }
        private void expansion(int[] source)
        {
            var newIntList = new int[source.Length * 2];
            for (int i = 0; i < source.Length; i++)
            {
                newIntList[i] = source[i];
            }
            a = newIntList;
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
                if (index + i >= count)
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

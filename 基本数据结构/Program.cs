using System;
using System.Collections.Generic;

namespace 基本数据结构
{
    class Program
    {
        static void Main(string[] args)
        {
            //SingleLinkedList<int> list = new SingleLinkedList<int>();


            //for (int i = 0; i < 10; i++)
            //{
            //    list.Insert(i);
            //}
            //list.Insert(555, 0);

            //list.Print();
            //LinkListCache cache = new LinkListCache();


            //var newList = list.reverse();
            //list.reverse2();
            //var head = new LinkedListNode<int>();
            //head = list.Head.Next;
            //list.Head = list.reverse3(head);
            //Console.WriteLine("反转后");
            //list.delete(8);
            //list.Print();
            //LinkListCache cache = new LinkListCache();
            //for (int i = 0; i < 10; i++)
            //{
            //    CacheData data = new CacheData();
            //    data.Key = i.ToString();
            //    data.Value = i.ToString();
            //    cache.Add(data);
            //}
            //cache.Print();
            //cache.Add(new CacheData() { Key="3",Value="3" });
            //cache.Print();

            //cache.Get("8");
            //cache.Print();

            //cache.Add(new CacheData() { Key = "33", Value = "33" });
            //cache.Print();


            //var intList = new int[] { 0, 33,25,17,19,8,6,4,9,7 };
            //var heap = new Heap(intList);            
            //heap.print();
            //heap.insert(26);
            //heap.Delete();
            var intList = new int[] { 0, 2, 5, 3, 4, 7, 1, 9, 6 };
            new Heap(intList, true);


            Console.ReadKey();
        }

    }
    public class person { }
}

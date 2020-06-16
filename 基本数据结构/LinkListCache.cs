using System;
using System.Collections.Generic;
using System.Text;

namespace 基本数据结构
{
    //LRU缓存   最近最少使用策略
    public class LinkListCache
    {
        private SingleLinkedList<CacheData> DataList { get; set; }
        const int Max = 10;
        private int DataListLength { get; set; }
        public LinkListCache()
        {
            DataList = new SingleLinkedList<CacheData>();


            DataListLength = 0;
        }

        public void Add(CacheData cacheData)
        {
            LinkedListNode<CacheData> node = new LinkedListNode<CacheData>();
            node.data = cacheData;
            if (DataListLength >= Max)
            {
                var prevoidsNode = new LinkedListNode<CacheData>();
                var currentNode = DataList.Head.Next;
                while (currentNode.Next != null && !currentNode.data.Equals(cacheData))
                {
                    prevoidsNode = currentNode;
                    currentNode = currentNode.Next;
                }
                prevoidsNode.Next = currentNode.Next;

            }
            if (DataList.Head.Next == null)
            {
                DataList.Head.Next = node;
            }
            else
            {
                node.Next = DataList.Head.Next;
                DataList.Head.Next = node;
            }


            DataListLength++;
        }
        public void Print()
        {
            Console.WriteLine("");
            var firstNode = DataList.Head;
            while (firstNode.Next != null)
            {
                firstNode = firstNode.Next;
                Console.WriteLine($"key={firstNode.data.Key}===value={firstNode.data.Value}");
            }
        }
        public void Delete()
        {

        }


        public CacheData Get(string getKek)
        {
            if (DataList.Head.Next == null)
            {
                return null;
            }
            var node = DataList.Head.Next;
            var previousNode = new LinkedListNode<CacheData>();
            while (node.Next != null && node.data.Key != getKek)
            {
                previousNode = node;
                node = node.Next;
            }
            if (node.data.Key == getKek)
            {
                previousNode.Next = node.Next;
                node.Next = DataList.Head.Next;
                DataList.Head.Next = node;
                return node.data;
            }
            else
            {
                return null;
            }
        }
    }
    public class CacheData
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is CacheData)
            {
                var data = obj as CacheData;
                return data.Key == this.Key && data.Value == this.Value;
            }
            else
            {
                return false;
            }
        }
    }
}

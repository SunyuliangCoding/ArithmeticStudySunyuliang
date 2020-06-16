using System;
using System.Collections.Generic;
using System.Text;

namespace 基本数据结构
{
    public class LinkedListNode<T>
    {
        public T data { get; set; }
        public LinkedListNode<T> Next { get; set; }

        //构造表头(或者叫哑节点)
        public LinkedListNode()
        {
            data = default(T);
            Next = null;
        }
        //构造尾节点
        public LinkedListNode(T item)
        {
            this.data = item;
            Next = null;
        }
        //构造普通节点:
        public LinkedListNode(T item, LinkedListNode<T> next)
        {
            this.data = item;
            this.Next = next;
        }
    }
}

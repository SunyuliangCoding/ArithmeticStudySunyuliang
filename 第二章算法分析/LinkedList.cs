using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二章算法分析
{
    // 自己开发的链表
    public class LinkedList<T>
    {
        public LinkedListNode<T> head { get; set; }
        //链表类的基本操作：
        public void MakeEmpty()
        {
            head = null;
        }
        public bool IsEmpty()
        {
            return head == null ? true : false;
        }
        public int Find(LinkedListNode<T> node)
        {
            if (IsEmpty())
            {
                return -1;
            }
            var i = 0;
            while (true)
            {

            }
        }

    }
    public class LinkedListNode<T>
    {
        public T data { get; set; }
        public LinkedListNode<T> next { get; set; }

        public LinkedListNode(T item)
        {
            data = item;
        }
        public LinkedListNode(T item, LinkedListNode<T> node)
        {
            data = item;
            next = node;
        }
        public LinkedListNode()
        {
            data = default(T);
            next = null;
        }

    }
}

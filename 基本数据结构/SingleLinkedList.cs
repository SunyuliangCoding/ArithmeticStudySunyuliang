using System;
using System.Collections.Generic;
using System.Text;

namespace 基本数据结构
{
    public class SingleLinkedList<T>
    {
        public LinkedListNode<T> Head { get; set; }

        public SingleLinkedList()
        {
            Head = new LinkedListNode<T>();
        }
        #region 基本操作
        public bool isEmpty()
        {
            return Head.Next == null;
        }
        public void Add(T item)
        {
            FindLastNode().Next = new LinkedListNode<T>() { data = item };
        }
        public LinkedListNode<T> FindLastNode()
        {
            if (isEmpty())
            {
                return Head;
            }
            LinkedListNode<T> node = new LinkedListNode<T>();
            node = Head;
            while (node.Next != null)
            {
                node = node.Next;
            }
            return node;
        }
        public LinkedListNode<T> Find(T item)
        {

            if (isEmpty())
            {
                return null;
            }
            LinkedListNode<T> node = new LinkedListNode<T>();
            node = Head;
            while (node.Next != null && !node.data.Equals(item))
            {
                node = node.Next;
            }
            return node;

        }

        public void Insert(T item, int index)
        {
            if (isEmpty())
            {
                Head.Next = new LinkedListNode<T>() { data = item };
            }
            var i = 0;
            LinkedListNode<T> itemNode = new LinkedListNode<T>();
            itemNode.data = item;
            LinkedListNode<T> node = new LinkedListNode<T>();
            node = Head;
            while (node.Next != null && i != index)
            {
                node = node.Next;
                i++;
            }
            itemNode.Next = node.Next;
            node.Next = itemNode;

        }
        public void Insert(T item)
        {
            var itemNode = new LinkedListNode<T>() { data = item };
            if (isEmpty())
            {
                Head.Next = itemNode;
                return;
            }
            var node = new LinkedListNode<T>();
            node = Head;
            while (node.Next != null)
            {
                node = node.Next;
            }
            node.Next = itemNode;

        }
        public void delete(T item)
        {
            if (isEmpty())
            {
                return;
            }
            LinkedListNode<T> node = new LinkedListNode<T>();
            LinkedListNode<T> previousNode = new LinkedListNode<T>();
            node = Head;
            while (node.Next != null && !node.data.Equals(item))
            {
                previousNode = node;
                node = node.Next;
            }
            if (node.data.Equals(item))
            {
                previousNode.Next = node.Next;
            }

        }
        public void Print()
        {
            if (isEmpty() || Head.Next == null)
            {
                Console.WriteLine("链表为空");
            }
            LinkedListNode<T> node = new LinkedListNode<T>();
            node = Head;
            while (node.Next != null)
            {
                node = node.Next;
                Console.WriteLine(node.data);

            }
        }
        public static bool isLast(LinkedListNode<T> item)
        {
            return item.Next == null;
        }
        #endregion

        //单链表反转
        public SingleLinkedList<T> reverse()
        {
            if (isEmpty() || Head.Next.Next == null)
            {
                return this;
            }
            SingleLinkedList<T> newList = new SingleLinkedList<T>();
            var node = new LinkedListNode<T>();
            newList.Head.Next = new LinkedListNode<T>();
            newList.Head.Next.data = Head.Next.data;


            node = Head.Next;
            while (node.Next != null)
            {
                node = node.Next;
                LinkedListNode<T> listNode = new LinkedListNode<T>() { data = node.data };
                listNode.Next = newList.Head.Next;
                newList.Head.Next = listNode;

            }
            return newList;

        }

        //不创建新链表，使用迭代的方式反转
        public void reverse1()
        {
            var NewHead = new LinkedListNode<T>();
            while (this.Head != null && this.Head.Next != null)
            {
                var nextNode = new LinkedListNode<T>();
                nextNode = Head.Next.Next;

                Head.Next.Next = NewHead.Next;
                NewHead.Next = Head.Next;
                Head.Next = nextNode;

            }
            //如果是简单链表结构，这里直接返回头结点
            Head = NewHead;

        }

        //迭代方式练习
        public void reverse2()
        {
            var newHead = new LinkedListNode<T>();

            while (Head != null && Head.Next != null)
            {
                var newNode = Head.Next.Next;
                Head.Next.Next = newHead.Next;
                newHead.Next = Head.Next;
                Head.Next = newNode;
            }
            Head = newHead;

        }
        //无头结点链表递归算法
        public LinkedListNode<T> reverse3(LinkedListNode<T> head)
        {
            if ( head.Next == null)
            {
                return head;
            }
            var newHead = reverse3(head.Next);
            head.Next.Next = head;
            head.Next = null;
            return newHead;

        }
        //有头结点链表递归算法
        


    }
}

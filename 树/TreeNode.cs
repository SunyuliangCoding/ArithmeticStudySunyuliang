using System;
using System.Collections.Generic;
using System.Text;

namespace 树
{
    public class TreeNode<T>
    {
        public T Data { get; set; }
        public TreeNode<T> lChild { get; set; }
        public TreeNode<T> rChild { get; set; }

        public TreeNode(TreeNode<T> lp, TreeNode<T> rp)
        {
            Data = default(T);
            lChild = lp;
            rChild = rp;
        }
        public TreeNode(T val, TreeNode<T> lp, TreeNode<T> rp)
        {
            Data = val;
            lChild = lp;
            rChild = rp;
        }
        public TreeNode(T val)
        {
            Data = val;
        }


    }
}

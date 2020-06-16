using System;

namespace 树
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode<int> node1 = new TreeNode<int>(1);
            TreeNode<int> node2 = new TreeNode<int>(2); ;
            var node3 = new TreeNode<int>(3);

            var node4 = new TreeNode<int>(4);
            var node5 = new TreeNode<int>(5);
            var node6 = new TreeNode<int>(6);
            var node7 = new TreeNode<int>(7);

            node1.lChild = node2;
            node1.rChild = node3;

            node2.lChild = node4;
            node2.rChild = node5;
            node3.lChild = node6;
            node3.rChild = node7;


            PreOrder(node1);
            Console.WriteLine("=====================");
            InOrder(node1);
            Console.WriteLine("=====================");
            PostOrder(node1);
            Console.ReadKey();
        }

        //先序遍历，递推公式   preorder(x)=print(x)+preorder(x-left)+preorder(x-right)
        static void PreOrder(TreeNode<int> node)
        {
            if (node == null)
            {
                return;
            }
            Console.WriteLine(node.Data);
            PreOrder(node.lChild);
            PreOrder(node.rChild);
        }
        //中序遍历、递推公式  inOrder(x)=inorder(x--left)+print(x)+inorder(x--right)
        static void InOrder(TreeNode<int> node)
        {
            if (node == null)
            {
                return;
            }
            InOrder(node.lChild);
            Console.WriteLine(node.Data);
            InOrder(node.rChild);

        }

        //后序遍历、 递推公式   postorder(x)=postOrder(x--left)+post(x--right)+print(x)
        static void PostOrder(TreeNode<int> node)
        {
            if (node == null)
            {
                return;
            }
            PostOrder(node.lChild);
            PostOrder(node.rChild);
            Console.WriteLine(node.Data);
        }

    }
}

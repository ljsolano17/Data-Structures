using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure
{
    public class BinaryTree
    {
        public TreeNode root;
        public BinaryTree()
        {
            root = null;
        }

        //insert => recurive
        public void Insert(int value)
        {
            root = InsertRec(root, value);
        }

        public TreeNode InsertRec(TreeNode root, int value)
        {
            if (root == null)
            {
                root = new TreeNode(value);
                return root;
            }
            if(value < root.value)
            {
                root.left = InsertRec(root.left, value);
            }else if (value > root.value)
            {
                root.right = InsertRec(root.right, value);
            }
            return root;
        }

        public void InOrderTraversal(TreeNode node) 
        {
            if (node != null)
            {
                InOrderTraversal(node.left);
                Console.WriteLine(node.value + " ");
                InOrderTraversal(node.right);
            }
        }

        public void PreOrderTraversal(TreeNode node)
        {
            if(node != null)
            {
                Console.WriteLine(node.value + " ");
                PreOrderTraversal(node.left);
                PreOrderTraversal(node.right);
            }
        }
        public void PostOrderTraversal(TreeNode node)
        {
            if(node != null)
            {
                PostOrderTraversal(node.left);
                PostOrderTraversal (node.right);
                Console.WriteLine(node.value + " ");
            }
        }

    }
}

using System;
using TreeStructure;

class Program
{
    public static void Main(string[] args)
    {
        BinaryTree tree = new BinaryTree();
         tree.Insert(1);
         tree.Insert(5);
         tree.Insert(3);
         tree.Insert(10);
         tree.Insert(100);
         tree.Insert(60);
         tree.Insert(2);
         
       
         Console.WriteLine("Inorder Traversal");
         tree.InOrderTraversal(tree.root);
         Console.WriteLine("Preorder Traversal");
         tree.PreOrderTraversal(tree.root);
         Console.WriteLine("Postorder Traversal");
         tree.PostOrderTraversal(tree.root);

        Console.WriteLine("-----------------------------------");
        BinaryTree tree2 = new BinaryTree();
        tree2.root = new TreeNode(1);
        tree2.root.left = new TreeNode(2);
        tree2.root.right = new TreeNode(3);
        tree2.root.left.left = new TreeNode(4);
        tree2.root.left.right = new TreeNode(5);


        Console.WriteLine("Inorder Traversal");
        tree.InOrderTraversal(tree2.root);
        Console.WriteLine("Preorder Traversal");
        tree.PreOrderTraversal(tree2.root);
        Console.WriteLine("Postorder2 Traversal");
        tree.PostOrderTraversal(tree2.root);


    }
}
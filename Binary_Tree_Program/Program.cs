using System;

namespace Binary_Tree_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Binary Search Tree Program");
            Binary_Tree<int> binarySearchTree = new Binary_Tree<int>();
            binarySearchTree.InsertData(56);
            binarySearchTree.InsertData(30);
            binarySearchTree.InsertData(70);
            binarySearchTree.Display(binarySearchTree.GetRoot());
        }
    }
}

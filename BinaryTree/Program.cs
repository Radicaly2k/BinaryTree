using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree");

            BinaryTree bTreeTest = new BinaryTree();

            bTreeTest.Insert(1);
            bTreeTest.Insert(3);
            bTreeTest.Insert(30);
            bTreeTest.Insert(14);
            bTreeTest.Insert(70);
            bTreeTest.Insert(90);
            bTreeTest.Insert(45);
            bTreeTest.Insert(4);
            bTreeTest.Insert(8);
            bTreeTest.Insert(99);
        }
    }
}

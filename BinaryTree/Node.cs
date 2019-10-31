using System;

namespace BinaryTree
{
    public class Node
    {
        public Node m_left;
        public Node m_right;
        public int m_data;

        public void DisplayNode()
        {
            Console.Out.WriteLine($"Node Data: {m_data}");
        }
    }
}

namespace BinaryTree
{
    public class BinaryTree
    {
        public Node root;
        public Node Insert(int data)
        {
            Node newNode = new Node();
            newNode.m_data = data;

            if(root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;

                    if(data < current.m_data)
                    {
                        current = current.m_left;

                        if(current == null)
                        {
                            parent.m_left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.m_right;

                        if(current == null)
                        {
                            parent.m_right = newNode;
                            break;
                        }
                    }
                }
            }

            return newNode;
        }
    }
}

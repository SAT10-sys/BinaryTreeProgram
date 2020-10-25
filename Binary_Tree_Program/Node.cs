using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree_Program
{
    public class Node<T> where T:IComparable
    {
        public T NodeValue;
        public Node<T> LeftNode;
        public Node<T> RightNode;
        public Node(T NodeValue)
        {
            this.NodeValue = NodeValue;
        }

    }
}

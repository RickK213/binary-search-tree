using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public int data; //this is public because we're being lazy
        public Node left;
        public Node right;

        public Node()
        {

        }

        public Node(int item)
        {
            data = item;
        }

    }
}

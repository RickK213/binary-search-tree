using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BST
    {
        //member variables
        Node head = null;

        //constructor
        public BST()
        {

        }

        //member methods
        public void Add(int item)
        {
            Node node = new Node(item);
            if (head == null)
            {
                head = node;
                return;
            }
            Node current = head;
            while (current.left != null)
            {
                if (  )
                {

                }
                current = current.left; //keep traversing until the the next node is null
            }
            current.left = node;
        }

    }
}

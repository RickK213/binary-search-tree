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
            if ( item<current.data )
            {
                while (current.left != null)
                {
                    current = current.left;
                }
                current.left = node;
                return;
            }
            else if ( item>current.data )
            {
                while (current.right != null)
                {
                    current = current.right;
                }
                current.right = node;
                return;
            }
        }

        public string Search(int searchItem)
        {
            string searchPath = "Head ";
            Node current = head;
            if (searchItem < current.data)
            {
                searchPath += "Left ";
                while (current.left != null)
                {
                    if ( searchItem.Equals(current.left) )
                    {
                        return searchPath;
                    }
                    current = current.left;
                }
            }
            else if (searchItem > current.data)
            {
                searchPath += "Right ";
                while (current.right != null)
                {
                    if (searchItem.Equals(current.right))
                    {
                        return searchPath;
                    }
                    current = current.right;
                }
                return searchPath;
            }
            return searchPath;
        }

    }
}

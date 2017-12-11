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
                Console.WriteLine("{0} Node added to head", item);
                Console.ReadKey();
                return;
            }
            Node current = head;
            if ( item<current.data )
            {
                while (current.left != null)
                {
                    current = current.left; //keep traversing left until the the next node is null
                }
                current.left = node;
                Console.WriteLine("{0} Node added to left", item);
                Console.ReadKey();
                return;
            }
            else if ( item>current.data )
            {
                while (current.right != null)
                {
                    current = current.right; //keep traversing right until the the next node is null
                }
                current.right = node;
                Console.WriteLine("{0} Node added to right", item);
                Console.ReadKey();
                return;
            }
        }

        public string Search()
        {
            string searchPath = "";

            return searchPath;
        }

    }
}
